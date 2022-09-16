using PilasYColas.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas.Clases
{
    internal class Cola : ListaColeccion
    {
        //Tengo un bug a la hora de añadir la cola, no supe como solucionarlo. El interfaz en Pilas anda bien.

        private object[] array;
        private List<Cola> colaLista;
        private int contador;
        public Cola(int cantidad)
        {
            contador = -1;
            colaLista = new List<Cola>(cantidad);
        }
        public bool Aniadir(object Cola)
        {
            bool añadido = false;
            if (contador < array.Length)
            {
                array[++contador] = Cola;
                añadido = true;
            }
            return añadido;
        }

        public object Extraer()
        {
            object P = null;
            for (int i = 0; i < colaLista.Count; i++)
            {
                if (colaLista[i] != null && !Vacia())
                {
                    P = colaLista[i];
                    colaLista[i] = null;
                    contador--;
                    break;
                }

            }
            return P;
        }
        public bool Vacia()
        {
            return contador == -1;
        }

        public object Primero()
        {
            object pri = null;
            if (!Vacia())
            {
                pri = colaLista[0];
            }
            return pri;

        }
    }
}
