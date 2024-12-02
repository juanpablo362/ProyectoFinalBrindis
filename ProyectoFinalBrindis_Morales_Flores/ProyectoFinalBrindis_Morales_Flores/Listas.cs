using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class Listas
    {
        Nodo inicio;
        public Listas()
        {
            inicio = null;
        }
        //Agregar nodo
        public void Add(int num)
        {
            Nodo nuevo = new Nodo(num);
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Nodo act = inicio;
                while (act.siguiente != null)
                {
                    act = act.siguiente;
                }
                act.siguiente = nuevo;
            }
        }
        // imprimir l lista
        public void print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía");
            }
            else
            {
                Nodo act = inicio;
                // Mientras act tenga un valor imprime el mismo
                while (act != null)
                {

                    Console.WriteLine($"<{act.valor}>");
                    act = act.siguiente;
                }
            }
        }
        public int Find(int pos)
        {
            // Si el primer nodo es vacio o la posicion metida es menor a cero
            if (inicio == null || pos < 0)
            {
                Console.WriteLine("Nodo no encontrado -1");
            }
            Nodo act = inicio;
            int contador = 0;
            // Se reccore la lista
            while (act != null)
            {
                if (contador == pos)
                {
                    return act.valor;
                }
                act = act.siguiente;
                contador++;
            }
            return -1; // Si no es valido
        }
        // Contar nodos
        public int Count()
        {
            if (inicio == null)
            {
                return 0;
            }
            Nodo act = inicio;
            int contador = 0;
            while (act != null)
            {
                contador++;
                act = act.siguiente;
            }

            return contador;
        }
        // Buscar un valor
        public int FindValue(int num)
        {
            if (inicio == null)
            {
                return -1;
            }
            Nodo act = inicio;
            int posicion = 0;
            while (act != null)
            {
                if (act.valor == num)
                    return posicion;
                act = act.siguiente;
                posicion++;
            }
            return -1;
        }
        // Cambiar un valor
        public bool Change(int pos, int num)
        {
            if (inicio == null || pos < 0)
            {
                return false;
            }
            Nodo act = inicio;
            int contador = 0;
            while (act != null)
            {
                if (contador == pos)
                {
                    act.valor = num; // Si encontramos la posición, cambiamos el valor del nodo.
                    return true;
                }
                act = act.siguiente;
                contador++;
            }

            return false; // Si no se encuentra
        }

        // Método para eliminar un nodo
        public bool Delete(int pos)
        {
            if (inicio == null || pos < 0)
                return false; // Si la lista está vacía
            if (pos == 0)
            {
                // Si se elimina el primer nodo, simplemente movemos 'inicio' al siguiente nodo.
                inicio = inicio.siguiente;
                return true;
            }
            Nodo act = inicio;
            Nodo ant = null;
            int contador = 0;
            while (act != null)
            {
                if (contador == pos)
                {
                    ant.siguiente = act.siguiente;
                    return true;
                }
                ant = act;
                act = act.siguiente;
                contador++;
            }
            return false; // Si no se encuentra la posición
        }
    }
}
