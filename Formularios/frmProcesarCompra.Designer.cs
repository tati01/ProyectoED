
namespace PP.Formularios
{
    partial class frmProcesarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesarCompra));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_procesarProductos = new System.Windows.Forms.Button();
            this.dgv_listaProductos = new System.Windows.Forms.DataGridView();
            this.dgv_listaProductosCola = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductosCola)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de productos seleccionados:";
            // 
            // btn_procesarProductos
            // 
            this.btn_procesarProductos.Location = new System.Drawing.Point(496, 256);
            this.btn_procesarProductos.Name = "btn_procesarProductos";
            this.btn_procesarProductos.Size = new System.Drawing.Size(173, 82);
            this.btn_procesarProductos.TabIndex = 3;
            this.btn_procesarProductos.Text = "Procesar Productos";
            this.btn_procesarProductos.UseVisualStyleBackColor = true;
            this.btn_procesarProductos.Click += new System.EventHandler(this.btn_procesarProductos_Click);
            // 
            // dgv_listaProductos
            // 
            this.dgv_listaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_listaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_listaProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_listaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductos.Location = new System.Drawing.Point(24, 172);
            this.dgv_listaProductos.Name = "dgv_listaProductos";
            this.dgv_listaProductos.RowHeadersWidth = 62;
            this.dgv_listaProductos.RowTemplate.Height = 28;
            this.dgv_listaProductos.Size = new System.Drawing.Size(415, 251);
            this.dgv_listaProductos.TabIndex = 5;
            this.dgv_listaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listaProductos_CellContentClick);
            // 
            // dgv_listaProductosCola
            // 
            this.dgv_listaProductosCola.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listaProductosCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaProductosCola.Location = new System.Drawing.Point(726, 172);
            this.dgv_listaProductosCola.Name = "dgv_listaProductosCola";
            this.dgv_listaProductosCola.RowHeadersWidth = 62;
            this.dgv_listaProductosCola.RowTemplate.Height = 28;
            this.dgv_listaProductosCola.Size = new System.Drawing.Size(415, 251);
            this.dgv_listaProductosCola.TabIndex = 6;
            // 
            // frmProcesarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1181, 574);
            this.Controls.Add(this.dgv_listaProductosCola);
            this.Controls.Add(this.dgv_listaProductos);
            this.Controls.Add(this.btn_procesarProductos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcesarCompra";
            this.Text = "Procesar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaProductosCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_procesarProductos;
        private System.Windows.Forms.DataGridView dgv_listaProductos;
        private System.Windows.Forms.DataGridView dgv_listaProductosCola;
    }
}