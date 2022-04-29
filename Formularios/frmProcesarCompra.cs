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
        public static List<clArticulo> list = new List<clArticulo>();
        public ccArticuloServicio mCola = frmAgregarCarrito._cola;
        public frmProcesarCompra()
        {
            InitializeComponent();

            dgv_listaProductos.ColumnCount = 3;
            dgv_listaProductos.Columns[0].Name = "Marca";
            dgv_listaProductos.Columns[1].Name = "Descripcion";
            dgv_listaProductos.Columns[2].Name = "Precio";

            dgv_listaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgv_listaProductosCola.ColumnCount = 3;
            dgv_listaProductosCola.Columns[0].Name = "Marca";
            dgv_listaProductosCola.Columns[1].Name = "Descripcion";
            dgv_listaProductosCola.Columns[2].Name = "Precio";

            dgv_listaProductosCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            clArticulo p = new clArticulo();
            p = clArticuloServicio.primerNodo;
            while (p != null)
            {
                dgv_listaProductos.Rows.Add(p.Marca, p.Descripcion, p.Precio.ToString());
                list.Add(p);
                p = p.Siguiente;
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
                clArticulo puntero;
                puntero = mCola.primero;
                do
                {
                    dgv_listaProductosCola.Rows.Add(puntero.Marca, puntero.Descripcion, puntero.Precio.ToString());
                    puntero = puntero.Siguiente;
                }
                while (puntero != null);
            }
        }



        private void dgv_listaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
