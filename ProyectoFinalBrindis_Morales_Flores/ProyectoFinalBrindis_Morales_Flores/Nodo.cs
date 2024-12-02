using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class Nodo
    {
        public int valor;
        public Nodo siguiente;

        public Nodo(int valor)
        {
            this.valor = valor;
            this.siguiente = null;
        }
    }
}
