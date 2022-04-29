namespace PP
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesoDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empaqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoDeCompraToolStripMenuItem,
            this.pagarToolStripMenuItem,
            this.empaqueToolStripMenuItem,
            this.facturacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1013, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // procesoDeCompraToolStripMenuItem
            // 
            this.procesoDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlCarritoToolStripMenuItem});
            this.procesoDeCompraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesoDeCompraToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.procesoDeCompraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCompraToolStripMenuItem.Image")));
            this.procesoDeCompraToolStripMenuItem.Name = "procesoDeCompraToolStripMenuItem";
            this.procesoDeCompraToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.procesoDeCompraToolStripMenuItem.Text = "Mi carrito";
            this.procesoDeCompraToolStripMenuItem.Click += new System.EventHandler(this.procesoDeCompraToolStripMenuItem_Click);
            // 
            // agregarAlCarritoToolStripMenuItem
            // 
            this.agregarAlCarritoToolStripMenuItem.Name = "agregarAlCarritoToolStripMenuItem";
            this.agregarAlCarritoToolStripMenuItem.Size = new System.Drawing.Size(285, 38);
            this.agregarAlCarritoToolStripMenuItem.Text = "Agregar al carrito";
            this.agregarAlCarritoToolStripMenuItem.Click += new System.EventHandler(this.agregarAlCarritoToolStripMenuItem_Click);
            // 
            // pagarToolStripMenuItem
            // 
            this.pagarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesarCompraToolStripMenuItem});
            this.pagarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pagarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pagarToolStripMenuItem.Image")));
            this.pagarToolStripMenuItem.Name = "pagarToolStripMenuItem";
            this.pagarToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.pagarToolStripMenuItem.Text = "Realizar pago";
            this.pagarToolStripMenuItem.Click += new System.EventHandler(this.pagarToolStripMenuItem_Click);
            // 
            // procesarCompraToolStripMenuItem
            // 
            this.procesarCompraToolStripMenuItem.Name = "procesarCompraToolStripMenuItem";
            this.procesarCompraToolStripMenuItem.Size = new System.Drawing.Size(279, 38);
            this.procesarCompraToolStripMenuItem.Text = "Procesar compra";
            this.procesarCompraToolStripMenuItem.Click += new System.EventHandler(this.procesarCompraToolStripMenuItem_Click);
            // 
            // empaqueToolStripMenuItem
            // 
            this.empaqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empaqueToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.empaqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empaqueToolStripMenuItem.Image")));
            this.empaqueToolStripMenuItem.Name = "empaqueToolStripMenuItem";
            this.empaqueToolStripMenuItem.Size = new System.Drawing.Size(144, 34);
            this.empaqueToolStripMenuItem.Text = "Empaque";
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturacionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.facturacionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturacionToolStripMenuItem.Image")));
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(162, 34);
            this.facturacionToolStripMenuItem.Text = "Facturacion";
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1013, 752);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PaginaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walmart";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem procesoDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlCarritoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empaqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
    }
}

