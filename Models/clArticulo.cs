namespace PP.Models
{
    public class clArticulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }

        public int Total { get; set; }

        public clArticulo Siguiente { get; set; }
        public clArticulo Anterior { get; set; }



        public clArticulo()
        {
            this.Codigo = 0;
            this.Descripcion = "";
            this.Marca = "";
            this.Precio = 0;
            this.Cantidad = 0;
            this.Total = 0;
            this.Siguiente = null;
            this.Anterior = null;
        }



        public clArticulo(int Codigo, string Descripcion, string Marca, int Precio, int Cantidad, int Total)
        {
            this.Codigo = Codigo;
            this.Descripcion = Descripcion;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Total = Total;
            this.Siguiente = null;
            this.Anterior = null;
        }

    }
}
