using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP.Models;
namespace PP.Formularios
{
    public partial class frmProcesarEmpaque : Form
    {
        public ccArticuloServicio mCola2 = new ccArticuloServicio();
        public static List<clArticulo> mList = new List<clArticulo>();
        public ccArticuloServicio mCola = frmAgregarCarrito._cola;
        Stack<clArticulo> mPila = new Stack<clArticulo>();

        public frmProcesarEmpaque()
        {
            InitializeComponent();

            dgv_Lista.ColumnCount = 6;
            dgv_Lista.Columns[0].Name = "Marca";
            dgv_Lista.Columns[1].Name = "Descripción";
            dgv_Lista.Columns[2].Name = "Cantidad";
            dgv_Lista.Columns[3].Name = "Precio";
            dgv_Lista.Columns[4].Name = "Total";
            dgv_Lista.Columns[5].Name = "Código";
            dgv_Lista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgv_PilaLista.ColumnCount = 6;
            dgv_PilaLista.Columns[0].Name = "Marca";
            dgv_PilaLista.Columns[1].Name = "Descripción";
            dgv_PilaLista.Columns[2].Name = "Cantidad";
            dgv_PilaLista.Columns[3].Name = "Precio";
            dgv_PilaLista.Columns[4].Name = "Total";
            dgv_PilaLista.Columns[5].Name = "Código";
            dgv_PilaLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dgv_Apilado.ColumnCount = 6;
            dgv_Apilado.Columns[0].Name = "Marca";
            dgv_Apilado.Columns[1].Name = "Descripción";
            dgv_Apilado.Columns[2].Name = "Cantidad";
            dgv_Apilado.Columns[3].Name = "Precio";
            dgv_Apilado.Columns[4].Name = "Total";
            dgv_Apilado.Columns[5].Name = "Código";
            dgv_Apilado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;



            clArticulo p = new clArticulo();
            p = clArticuloServicio.primerNodo;
            while (p != null)
            {

                dgv_Lista.Rows.Add(p.Marca, p.Descripcion, p.Cantidad,p.Precio.ToString(),p.Total,p.Codigo);
                p = p.Siguiente;
            }


            if (mCola.primero == null) Console.WriteLine("Cola vacia");
            else
            {
                clArticulo puntero;
                puntero = mCola.primero;
                do
                {
                    dgv_PilaLista.Rows.Add(puntero.Marca, puntero.Descripcion,puntero.Cantidad, puntero.Precio.ToString(),puntero.Total,puntero.Codigo);
                    puntero = puntero.Siguiente;
                }
                while (puntero != null);
            }

        }

        private void btnEmpacar_Click(object sender, EventArgs e)
        {

           
        }

        private void btnEmpacar_Click_1(object sender, EventArgs e)
        {
            clArticulo _p = new clArticulo();

            _p = mCola.primero;
            while (_p != null)
            {
                cpArticulo mPila = new cpArticulo();
                try
                {
                    mPila.Codigo = _p.Codigo;
                    mPila.Descripcion = _p.Descripcion;
                    mPila.Marca = _p.Marca;
                    mPila.Precio = _p.Precio;
                    mPila.Cantidad = _p.Cantidad;
                    mPila.Total = _p.Total;

                    cGlobal.mPilaArticuloServicio.push(mPila);
                    _p = _p.Siguiente;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            for (int x = cGlobal.mPilaArticuloServicio.Cantidad; x > 0; x--) {
                cpArticulo _temp = new cpArticulo();
                _temp = cGlobal.mPilaArticuloServicio.pop();
                dgv_Apilado.Rows.Add(_temp.Marca, _temp.Descripcion, _temp.Cantidad, _temp.Precio, _temp.Total, _temp.Codigo);
                
            }
        }
    }
}
