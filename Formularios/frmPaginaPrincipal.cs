using PP.Formularios;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PP
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
            menuStrip1.BackColor = ColorTranslator.FromHtml("#0172CE");

        }

        private void agregarAlCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCarrito mfrmAgregarCarrito = new frmAgregarCarrito();
            mfrmAgregarCarrito.MdiParent = this;
            mfrmAgregarCarrito.Show();
        }
        private void procesarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcesarCompra mfrmProcesarCompra = new frmProcesarCompra();
            mfrmProcesarCompra.MdiParent = this;
            mfrmProcesarCompra.Show();

        }

        public void listasConPunteros()
        {

        }
        private void procesoDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }
    }
}
