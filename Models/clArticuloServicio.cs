using System;

namespace PP.Models
{
    public class clArticuloServicio
    {
        public static clArticulo primerNodo { get; set; } = null;
        public int Contador { get; set; } = 0;

        public int Size()
        {
            return Contador;
        }

        public void Add(clArticulo Nodo)
        {
            clArticulo Aux = primerNodo;
            if (Aux == null)
            {
                primerNodo = Nodo;
                primerNodo.Siguiente = null; // no hay elementos adelante
                primerNodo.Anterior = null;  // no hay elementos por atras
                Contador++;
            }
            else
            {

                for (Aux = primerNodo; Aux.Siguiente != null; Aux = Aux.Siguiente)
                {

                }

                Nodo.Anterior = Aux;
                Aux.Siguiente = Nodo;

                Nodo.Siguiente = null;
                Contador++;
            }
        }
        public void Imprimir()
        {
            clArticulo p = new clArticulo();
            p = primerNodo;
            while (p != null)
            {
                Console.WriteLine(p.Marca + " " + p.Total);
                p = p.Siguiente;
            }
        }
    }
}

