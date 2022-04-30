using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Models
{
    public class cpArticuloServicio
    {
        //commit
        public static cpArticulo PrimerArticulo { get; set; }
        public int Cantidad = 0;


        public void push(cpArticulo NuevoArticulo)
        {
            if (PrimerArticulo == null)
            {
                PrimerArticulo = NuevoArticulo;
                NuevoArticulo.ArticuloAbajo = null;
                NuevoArticulo.ArticuloArriba = null;
                Cantidad++;
            }
            else
            {
                NuevoArticulo.ArticuloAbajo = PrimerArticulo;
                PrimerArticulo.ArticuloArriba = NuevoArticulo;
                PrimerArticulo = NuevoArticulo;
                PrimerArticulo.ArticuloArriba = null;
                Cantidad++;
            }
        }

        public cpArticulo pop()
        {
            cpArticulo temp = new cpArticulo();
            if (Cantidad > 0)
            {
                if (PrimerArticulo.ArticuloArriba == null)
                {
                    PrimerArticulo = PrimerArticulo;
                    PrimerArticulo.ArticuloArriba = temp;
                    Cantidad--;
                    return PrimerArticulo;
                }
                else
                {
                    PrimerArticulo = PrimerArticulo.ArticuloAbajo;
                    PrimerArticulo.ArticuloArriba = temp;
                    Cantidad--;
                    return PrimerArticulo;
                }

            }
            else
            {
                return PrimerArticulo;
            }
        }

        public cpArticulo peek()
        {
            return PrimerArticulo;
        }

    }
}
