using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Models
{
    public class ccArticulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public string Marca { get; set; }

        public int Precio { get; set; }

        public int Cantidad { get; set; }

        public int Total { get; set; }

        public ccArticulo Siguiente { get; set; }
        public ccArticulo Anterior { get; set; }
    }
}
