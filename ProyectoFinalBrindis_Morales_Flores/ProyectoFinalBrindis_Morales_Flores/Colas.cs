using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class Colas
    {
        private int Max;
        private int count = 0;
        private Nodo inicio;
        public Colas(int max)
        {
            Max = max;
            inicio = null;
        }
        private bool underflow()
        {
            if (inicio == null)
            {
                return true;
            }
            return false;
        }
        private bool overflow()
        {
            if (Max == count)
            {
                return true;
            }
            return false;
        }
        public bool Insert(int num)
        {
            if (overflow())
            {
                return false;
            }
            Nodo nuevoNodo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                Nodo act = inicio;
                while (act.siguiente != null)
                {
                    act = act.siguiente;
                }

                act.siguiente = nuevoNodo;
            }
            count++;
            return true;
        }
        public int Extract()
        {
            if (underflow())
            {
                return -1;
            }
            int Extraer = inicio.valor;
            inicio = inicio.siguiente;
            count--;
            return Extraer;
        }
        public int Count()
        {
            return count;
        }
        public void Print()
        {
            if (underflow())
            {
                Console.WriteLine("Cola vacía.");
                return;
            }
            Nodo act = inicio;
            Console.Write("Elementos en la cola: ");
            while (act != null)
            {
                Console.Write($">-< {act.valor} >-<");
                act = act.siguiente;
            }
            Console.WriteLine();
        }
    }
}
