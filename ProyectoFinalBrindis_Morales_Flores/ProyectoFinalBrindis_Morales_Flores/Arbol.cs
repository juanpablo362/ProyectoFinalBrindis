using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class Arbol
    {
        public NodoArbol raiz;
        private NodoArbol obs;

        public void Recorrido(NodoArbol q)
        {
            if (q != null)
            {
                Console.Write($"{q.valor},");
                Recorrido(q.izq);
                Console.Write($"{q.valor},");
                Recorrido(q.der);
                Console.Write($"{q.valor},");
            }
        }

        private bool FindKey(int v)
        {
            bool Found = false;
            NodoArbol q;
            q = raiz;
            while (!Found && q != null)
            {
                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }
                else
                {
                    if (v < q.valor)
                    {
                        if (q.izq == null)
                            obs = q;
                        q = q.izq;

                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }

                }

            }
            return Found;
        }

        public void LRP()
        {
            int sumatoria = 0;
            int tamano = Tamano(raiz);
            CalcularSumatoria(raiz, 1, ref sumatoria);

            if (tamano == 0)
            {
                Console.WriteLine("El árbol está vacío, LRP no es aplicable.");
                return;
            }

            double lrp = (double)sumatoria / tamano;
            Console.WriteLine($"El LRP del árbol es: {lrp:F2}");
        }

        private void CalcularSumatoria(NodoArbol nodo, int profundidad, ref int sumatoria)
        {
            if (nodo != null)
            {
                sumatoria += profundidad;
                CalcularSumatoria(nodo.izq, profundidad + 1, ref sumatoria);
                CalcularSumatoria(nodo.der, profundidad + 1, ref sumatoria);
            }
        }

        public void Insertar(int v)
        {
            NodoArbol nuevo, psave;
            bool Found = false;
            psave = obs;
            Found = FindKey(v);
            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
            }
            else
            {
                nuevo = new NodoArbol(v);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }
                else
                {
                    if (v < obs.valor)
                    {
                        obs.izq = nuevo;
                    }
                    else
                    {
                        obs.der = nuevo;
                    }
                    obs = nuevo;
                }
            }
        }

        public int Altura(NodoArbol q)
        {
            if (q == null) return 0;
            int alturaIzq = Altura(q.izq);
            int alturaDer = Altura(q.der);
            return 1 + Math.Max(alturaIzq, alturaDer);
        }

        public int Tamano(NodoArbol q)
        {
            if (q == null) return 0;
            return 1 + Tamano(q.izq) + Tamano(q.der);
        }
    }
}
