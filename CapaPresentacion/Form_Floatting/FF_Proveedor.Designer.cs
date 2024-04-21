namespace CapaPresentacion.Form_Floatting
{
    partial class FF_Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FF_Proveedor));
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.CBox_Busqueda = new System.Windows.Forms.ComboBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Separador = new System.Windows.Forms.Label();
            this.GridView_Proveedor = new System.Windows.Forms.DataGridView();
            this.ID_PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Main_Proveedor = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar.Image")));
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.Location = new System.Drawing.Point(566, 85);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Buscar.TabIndex = 87;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(388, 98);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(172, 20);
            this.Txt_Busqueda.TabIndex = 86;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Buscar.Location = new System.Drawing.Point(162, 101);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Buscar.TabIndex = 85;
            this.Lbl_Buscar.Text = "Buscar Por:";
            // 
            // CBox_Busqueda
            // 
            this.CBox_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Busqueda.FormattingEnabled = true;
            this.CBox_Busqueda.Location = new System.Drawing.Point(246, 98);
            this.CBox_Busqueda.Name = "CBox_Busqueda";
            this.CBox_Busqueda.Size = new System.Drawing.Size(133, 21);
            this.CBox_Busqueda.TabIndex = 84;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.Location = new System.Drawing.Point(619, 85);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Limpiar.TabIndex = 83;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Separador
            // 
            this.Separador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Separador.Location = new System.Drawing.Point(13, 64);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(665, 18);
            this.Separador.TabIndex = 82;
            this.Separador.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            this.Separador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Separador.Click += new System.EventHandler(this.Separador_Click);
            // 
            // GridView_Proveedor
            // 
            this.GridView_Proveedor.AllowUserToAddRows = false;
            this.GridView_Proveedor.AllowUserToDeleteRows = false;
            this.GridView_Proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PROVEEDOR,
            this.DOCUMENTO,
            this.RAZON_SOCIAL});
            this.GridView_Proveedor.Location = new System.Drawing.Point(10, 148);
            this.GridView_Proveedor.MultiSelect = false;
            this.GridView_Proveedor.Name = "GridView_Proveedor";
            this.GridView_Proveedor.ReadOnly = true;
            this.GridView_Proveedor.Size = new System.Drawing.Size(668, 316);
            this.GridView_Proveedor.TabIndex = 81;
            this.GridView_Proveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Proveedor_CellDoubleClick);
            // 
            // ID_PROVEEDOR
            // 
            this.ID_PROVEEDOR.HeaderText = "ID_PROVEEDOR";
            this.ID_PROVEEDOR.Name = "ID_PROVEEDOR";
            this.ID_PROVEEDOR.ReadOnly = true;
            this.ID_PROVEEDOR.Visible = false;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.HeaderText = "No. DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.HeaderText = "RAZON SOCIAL";
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo_Main_Proveedor
            // 
            this.Titulo_Main_Proveedor.AutoSize = true;
            this.Titulo_Main_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Proveedor.Location = new System.Drawing.Point(86, 27);
            this.Titulo_Main_Proveedor.Name = "Titulo_Main_Proveedor";
            this.Titulo_Main_Proveedor.Size = new System.Drawing.Size(180, 20);
            this.Titulo_Main_Proveedor.TabIndex = 79;
            this.Titulo_Main_Proveedor.Text = "Gestion de Proveedores";
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(637, -4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(50, 42);
            this.Btn_Cerrar.TabIndex = 88;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            this.Btn_Cerrar.MouseEnter += new System.EventHandler(this.Btn_Cerrar_MouseEnter);
            this.Btn_Cerrar.MouseLeave += new System.EventHandler(this.Btn_Cerrar_MouseLeave);
            // 
            // FF_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 476);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.CBox_Busqueda);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.GridView_Proveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FF_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FF_Proveedor";
            this.Load += new System.EventHandler(this.FF_Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.ComboBox CBox_Busqueda;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Label Separador;
        private System.Windows.Forms.DataGridView GridView_Proveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo_Main_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.Label Btn_Cerrar;
    }
}