using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalBrindis_Morales_Flores
{
    public class NodoArbol
    {
        public int valor;
        public NodoArbol izq;
        public NodoArbol der;

        public NodoArbol(int valor)
        {
            this.valor = valor;
            this.izq = null;
            this.der = null;
        }
    }
}
