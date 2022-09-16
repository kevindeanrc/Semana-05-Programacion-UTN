using PilasYColas.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas.Clases
{
    internal class Pila : ListaColeccion
    {


        private object[] array;
        private int contador;

        public Pila(int cantidad)
        {
            contador = -1;
            array = new object[cantidad];
        }

        public bool Aniadir(object Pila)
        {
            bool añadido = false;
            if (contador < array.Length)
            {
                array[++contador] = Pila;
                añadido = true;
            }
            return añadido;
        }

        public bool Vacia()
        {
            return contador == -1;

        }

        public object Extraer()
        {
            object P = null;

            if (!Vacia())
            {
                P = array[contador];
                array[contador] = null;
                contador--;
            }
            return P;
        }

        public object Primero()
        {
            object p = null;
            if (!Vacia())
            {
                p = array[0];
            }
            return p;
        }
    }
}
