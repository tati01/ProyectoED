using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Models
{
    public class ccArticuloServicio
    {
        public clArticulo primero;
        public clArticulo ultimo;


        public ccArticuloServicio() 
        {
            primero = ultimo = null;
        }

        public void encolar(clArticulo NuevoArticulo) 
        {
            clArticulo aux = new clArticulo();
            aux = NuevoArticulo;
            if(primero == null)
            {
                primero = ultimo = aux;
                aux.Siguiente = null;
            }
            else
            {
                ultimo.Siguiente = aux;
                aux.Siguiente = null;
                ultimo = aux;

            }


        }

        public void Mostrar() 
        {
            if (primero == null) Console.WriteLine("Cola vacia");
            else 
            {
                clArticulo puntero;
                puntero = primero;

                do
                {
                    Console.WriteLine(puntero.Marca);
                    puntero = puntero.Siguiente;
                }
                while (puntero != null);
            }
        }

    }
}
