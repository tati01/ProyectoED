using PP.Models;
using System;
using System.Windows.Forms;

namespace PP.Formularios
{
    public partial class frmAgregarCarrito : Form
    {
        public static clArticuloServicio mLista = new clArticuloServicio();
        public static ccArticuloServicio _cola = new ccArticuloServicio();
        public frmAgregarCarrito()
        {
            InitializeComponent();

            for (int i = 0; i <= 10; i++)
            {
                cmb_Cant_Arroz.Items.Add(i);
                cmb_Cant_Cereal.Items.Add(i);
                cmb_Cant_CocaCola.Items.Add(i);
                cmb_Cant_Gomitas.Items.Add(i);
                cmb_Cant_iceCubes.Items.Add(i);
                cmb_Cant_IceDrink.Items.Add(i);
                cmb_Cant_Manzanas.Items.Add(i);
                cmb_Cant_Shampoo.Items.Add(i);

            }
        }

        private void btn_Agregar_Arroz_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 45983;
            mArticulo.Descripcion = "Arroz";
            mArticulo.Marca = "Tio Pelon";
            mArticulo.Precio = 1750;
            mArticulo.Cantidad = cmb_Cant_Arroz.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();

        }

        private void btn_Agregar_Manzana_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 89765;
            mArticulo.Descripcion = "Manzanas";
            mArticulo.Marca = "Manzana Verde";
            mArticulo.Precio = 650;
            mArticulo.Cantidad = cmb_Cant_Manzanas.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_Agregar_IceDrink_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 45309;
            mArticulo.Descripcion = "Bebida energetica";
            mArticulo.Marca = "Ice Sparkling";
            mArticulo.Precio = 1470;
            mArticulo.Cantidad = cmb_Cant_IceDrink.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_Agregar_IceCubes_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 09879;
            mArticulo.Descripcion = "Chicles de menta";
            mArticulo.Marca = "Ice Cubes";
            mArticulo.Precio = 3400;
            mArticulo.Cantidad = cmb_Cant_iceCubes.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_Agregar_CocaCola_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 12345;
            mArticulo.Descripcion = "Bebida de 2500 ml";
            mArticulo.Marca = "Coca Cola Light";
            mArticulo.Precio = 1350;
            mArticulo.Cantidad = cmb_Cant_CocaCola.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_Agregar_Cereal_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 56097;
            mArticulo.Descripcion = "Cereal con pedazos de chocolate";
            mArticulo.Marca = "Cereal Kellogg's Komplete";
            mArticulo.Precio = 2580;
            mArticulo.Cantidad = cmb_Cant_Cereal.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_gomitas_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 89479;
            mArticulo.Descripcion = "Gomitas";
            mArticulo.Marca = "Trululu";
            mArticulo.Precio = 620;
            mArticulo.Cantidad = cmb_Cant_Gomitas.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();
        }
        private void btn_Agregar_Shampoo_Click(object sender, EventArgs e)
        {
            clArticulo mArticulo = new clArticulo();
            mArticulo.Codigo = 70876;
            mArticulo.Descripcion = "Shampoo";
            mArticulo.Marca = "Herbal Essences";
            mArticulo.Precio = 4950;
            mArticulo.Cantidad = cmb_Cant_Shampoo.SelectedIndex;
            mArticulo.Total = mArticulo.Precio * mArticulo.Cantidad;
            mLista.Add(mArticulo);
            _cola.encolar(mArticulo);
            //mLista.Imprimir();

        }

        private void frmAgregarCarrito_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
