using PP.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PP.Formularios
{

    public partial class frmProcesarCompra : Form
    {
        public clArticuloServicio mlista_carrito = frmAgregarCarrito.mLista;
        public ccArticuloServicio mCola2 = new ccArticuloServicio();
        public static List<clArticulo> _list = new List<clArticulo>();
        public ccArticuloServicio mCola = frmAgregarCarrito._cola;
        public frmProcesarCompra()
        {
            InitializeComponent();

            dgv_listaProductos.ColumnCount = 6;
            dgv_listaProductos.Columns[0].Name = "Marca";
            dgv_listaProductos.Columns[1].Name = "Descripcion";
            dgv_listaProductos.Columns[2].Name = "Cantidad";
            dgv_listaProductos.Columns[3].Name = "Precio";
            dgv_listaProductos.Columns[4].Name = "Total";
            dgv_listaProductos.Columns[5].Name = "Codigo";

            dgv_listaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgv_listaProductosCola.ColumnCount = 6;
            dgv_listaProductosCola.Columns[0].Name = "Marca";
            dgv_listaProductosCola.Columns[1].Name = "Descripcion";
            dgv_listaProductosCola.Columns[2].Name = "Cantidad";
            dgv_listaProductosCola.Columns[3].Name = "Precio";
            dgv_listaProductosCola.Columns[4].Name = "Total";
            dgv_listaProductosCola.Columns[5].Name = "Codigo";

            dgv_listaProductosCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            clArticulo _p = new clArticulo();
            _p = clArticuloServicio.primerNodo;
            while (_p != null)
            {
                dgv_listaProductos.Rows.Add(_p.Marca, _p.Descripcion, _p.Cantidad, _p.Precio.ToString(),_p.Total,_p.Codigo);
                _list.Add(_p);
                _p = _p.Siguiente;
            }


        }
        private void btn_procesarProductos_Click(object sender, EventArgs e)
        {
            _procesarCompra();
            mCola.Mostrar();
        }

        public void _procesarCompra()
        {
            if (mCola.primero == null) Console.WriteLine("Cola vacia");
            else
            {
                clArticulo _puntero;
                _puntero = mCola.primero;
                do
                {
                    dgv_listaProductosCola.Rows.Add(_puntero.Marca, _puntero.Descripcion, _puntero.Cantidad, _puntero.Precio.ToString(), _puntero.Codigo);
                    _puntero = _puntero.Siguiente;
                }
                while (_puntero != null);
            }
        }



        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
