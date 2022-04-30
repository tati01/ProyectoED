using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.Models
{
    public class cGlobal
    {

        public static clArticuloServicio mListaArticuloServicio = new clArticuloServicio();

        public static ccArticuloServicio mColaArticuloServicio = new ccArticuloServicio();

        public static cpArticuloServicio mPilaArticuloServicio = new cpArticuloServicio();

        public static List<clArticulo> mList = new List<clArticulo>();
    }
}
