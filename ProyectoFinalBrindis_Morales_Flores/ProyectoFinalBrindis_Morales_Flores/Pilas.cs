using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class Pilas
    {
        private int MAX;
        private int tope = 0;
        private Nodo inicio;

        public Pilas(int max)
        {
            MAX = max;
            inicio = null;
        }
        private bool Empty()
        {
            if (inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MostrarMax()
        {
            Console.WriteLine(MAX);
        }

        private bool Full()
        {
            if (MAX == tope)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            //Imprimir pila
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia");
            }
            else
            {
                Nodo act = inicio;
                while (act != null)
                {
                    Console.Write($"<{act.valor}>");
                    act = act.siguiente;
                }
                Console.WriteLine();
            }
        }
        public bool Push(int num)
        {
            //Regresa true si se inserto el elemento
            //De forma exitosa
            //Regresa false si no se pudo inserta o porque la pila esta em full
            if (Full())
            {

                Console.WriteLine("No se puede insertar por que la pila esta llena");
                return false;
            }
            Nodo act = new Nodo(num);
            act.siguiente = inicio;
            inicio = act;
            tope++;
            return true;
        }
        public int Pop()
        {
            //Regresa el valor sacado pero si no se pudo sacar
            // Regresa -1
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia");
                return -1;
            }
            int valor = inicio.valor;
            inicio = inicio.siguiente;
            tope--;
            return valor;
        }
    }
}
