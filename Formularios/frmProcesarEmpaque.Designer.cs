
namespace PP.Formularios
{
    partial class frmProcesarEmpaque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.dgv_Apilado = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmpacar = new System.Windows.Forms.Button();
            this.dgv_PilaLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apilado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PilaLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, -199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Productos pagados:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Productos pagados:";
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToResizeColumns = false;
            this.dgv_Lista.AllowUserToResizeRows = false;
            this.dgv_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lista.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lista.EnableHeadersVisualStyles = false;
            this.dgv_Lista.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_Lista.Location = new System.Drawing.Point(133, 58);
            this.dgv_Lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Lista.RowHeadersVisible = false;
            this.dgv_Lista.RowHeadersWidth = 62;
            this.dgv_Lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_Lista.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lista.Size = new System.Drawing.Size(532, 117);
            this.dgv_Lista.TabIndex = 17;
            // 
            // dgv_Apilado
            // 
            this.dgv_Apilado.AllowUserToAddRows = false;
            this.dgv_Apilado.AllowUserToDeleteRows = false;
            this.dgv_Apilado.AllowUserToResizeColumns = false;
            this.dgv_Apilado.AllowUserToResizeRows = false;
            this.dgv_Apilado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Apilado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Apilado.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Apilado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Apilado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Apilado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Apilado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Apilado.EnableHeadersVisualStyles = false;
            this.dgv_Apilado.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_Apilado.Location = new System.Drawing.Point(130, 477);
            this.dgv_Apilado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Apilado.Name = "dgv_Apilado";
            this.dgv_Apilado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Apilado.RowHeadersVisible = false;
            this.dgv_Apilado.RowHeadersWidth = 62;
            this.dgv_Apilado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_Apilado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Apilado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Apilado.Size = new System.Drawing.Size(532, 194);
            this.dgv_Apilado.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Productos pagados:";
            // 
            // btnEmpacar
            // 
            this.btnEmpacar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmpacar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmpacar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpacar.Location = new System.Drawing.Point(261, 390);
            this.btnEmpacar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmpacar.Name = "btnEmpacar";
            this.btnEmpacar.Size = new System.Drawing.Size(255, 78);
            this.btnEmpacar.TabIndex = 14;
            this.btnEmpacar.Text = "Empacar los productos";
            this.btnEmpacar.UseVisualStyleBackColor = true;
            this.btnEmpacar.Click += new System.EventHandler(this.btnEmpacar_Click_1);
            // 
            // dgv_PilaLista
            // 
            this.dgv_PilaLista.AllowUserToAddRows = false;
            this.dgv_PilaLista.AllowUserToDeleteRows = false;
            this.dgv_PilaLista.AllowUserToResizeColumns = false;
            this.dgv_PilaLista.AllowUserToResizeRows = false;
            this.dgv_PilaLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_PilaLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PilaLista.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PilaLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_PilaLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_PilaLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PilaLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PilaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PilaLista.EnableHeadersVisualStyles = false;
            this.dgv_PilaLista.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgv_PilaLista.Location = new System.Drawing.Point(133, 247);
            this.dgv_PilaLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_PilaLista.Name = "dgv_PilaLista";
            this.dgv_PilaLista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_PilaLista.RowHeadersVisible = false;
            this.dgv_PilaLista.RowHeadersWidth = 62;
            this.dgv_PilaLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            this.dgv_PilaLista.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_PilaLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PilaLista.Size = new System.Drawing.Size(532, 123);
            this.dgv_PilaLista.TabIndex = 13;
            // 
            // frmProcesarEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Lista);
            this.Controls.Add(this.dgv_Apilado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEmpacar);
            this.Controls.Add(this.dgv_PilaLista);
            this.Controls.Add(this.label2);
            this.Name = "frmProcesarEmpaque";
            this.Text = "frmProcesarEmpaque";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Apilado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PilaLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private System.Windows.Forms.DataGridView dgv_Apilado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmpacar;
        private System.Windows.Forms.DataGridView dgv_PilaLista;
    }
}