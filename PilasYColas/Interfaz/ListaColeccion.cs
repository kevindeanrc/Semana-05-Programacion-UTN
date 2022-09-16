using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilasYColas.Interfaz
{
    interface ListaColeccion
    {
        bool Vacia();
        object Extraer();
        object Primero();
        bool Aniadir(object Pila);
    }
}
