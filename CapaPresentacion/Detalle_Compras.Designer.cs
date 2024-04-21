namespace CapaPresentacion
{
    partial class Detalle_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle_Compras));
            this.Contendor_Info_Compra = new System.Windows.Forms.GroupBox();
            this.Txt_Usuario_Compra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Tipo_Doc_Compra = new System.Windows.Forms.TextBox();
            this.Txt_Fecha_Compra = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Compra = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Doc_Compra = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Main_Negocio = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Lbl_No_Doc = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Contenedor_Info_Compra = new System.Windows.Forms.GroupBox();
            this.Txt_Razon_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_Razon_Proveedor = new System.Windows.Forms.Label();
            this.Txt_No_Doc = new System.Windows.Forms.TextBox();
            this.Txt_No_Doc_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_No_Doc_Proveedro = new System.Windows.Forms.Label();
            this.GridView_Producto = new System.Windows.Forms.DataGridView();
            this.Btn_DescargarPDF = new System.Windows.Forms.Button();
            this.Txt_MontoPagar_Compra = new System.Windows.Forms.TextBox();
            this.Lbl_MontoPagar_Compra = new System.Windows.Forms.Label();
            this.Contendor_Info_Compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Contenedor_Info_Compra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // Contendor_Info_Compra
            // 
            this.Contendor_Info_Compra.Controls.Add(this.Txt_Usuario_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.label1);
            this.Contendor_Info_Compra.Controls.Add(this.Txt_Tipo_Doc_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.Txt_Fecha_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.Lbl_Fecha_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.Lbl_Tipo_Doc_Compra);
            this.Contendor_Info_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contendor_Info_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contendor_Info_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Contendor_Info_Compra.Location = new System.Drawing.Point(10, 102);
            this.Contendor_Info_Compra.Name = "Contendor_Info_Compra";
            this.Contendor_Info_Compra.Size = new System.Drawing.Size(667, 81);
            this.Contendor_Info_Compra.TabIndex = 78;
            this.Contendor_Info_Compra.TabStop = false;
            this.Contendor_Info_Compra.Text = "Informacion Compra";
            // 
            // Txt_Usuario_Compra
            // 
            this.Txt_Usuario_Compra.Location = new System.Drawing.Point(417, 42);
            this.Txt_Usuario_Compra.Name = "Txt_Usuario_Compra";
            this.Txt_Usuario_Compra.Size = new System.Drawing.Size(230, 23);
            this.Txt_Usuario_Compra.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(412, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario";
            // 
            // Txt_Tipo_Doc_Compra
            // 
            this.Txt_Tipo_Doc_Compra.Location = new System.Drawing.Point(169, 42);
            this.Txt_Tipo_Doc_Compra.Name = "Txt_Tipo_Doc_Compra";
            this.Txt_Tipo_Doc_Compra.Size = new System.Drawing.Size(230, 23);
            this.Txt_Tipo_Doc_Compra.TabIndex = 17;
            this.Txt_Tipo_Doc_Compra.TextChanged += new System.EventHandler(this.Txt_TipoDoc_DetalleCompra_TextChanged);
            // 
            // Txt_Fecha_Compra
            // 
            this.Txt_Fecha_Compra.Location = new System.Drawing.Point(18, 42);
            this.Txt_Fecha_Compra.Name = "Txt_Fecha_Compra";
            this.Txt_Fecha_Compra.Size = new System.Drawing.Size(131, 23);
            this.Txt_Fecha_Compra.TabIndex = 16;
            // 
            // Lbl_Fecha_Compra
            // 
            this.Lbl_Fecha_Compra.AutoSize = true;
            this.Lbl_Fecha_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Fecha_Compra.Location = new System.Drawing.Point(15, 22);
            this.Lbl_Fecha_Compra.Name = "Lbl_Fecha_Compra";
            this.Lbl_Fecha_Compra.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Fecha_Compra.TabIndex = 14;
            this.Lbl_Fecha_Compra.Text = "Fecha";
            // 
            // Lbl_Tipo_Doc_Compra
            // 
            this.Lbl_Tipo_Doc_Compra.AutoSize = true;
            this.Lbl_Tipo_Doc_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Doc_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Tipo_Doc_Compra.Location = new System.Drawing.Point(164, 22);
            this.Lbl_Tipo_Doc_Compra.Name = "Lbl_Tipo_Doc_Compra";
            this.Lbl_Tipo_Doc_Compra.Size = new System.Drawing.Size(112, 17);
            this.Lbl_Tipo_Doc_Compra.TabIndex = 15;
            this.Lbl_Tipo_Doc_Compra.Text = "Tipo Documento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo_Main_Negocio
            // 
            this.Titulo_Main_Negocio.AutoSize = true;
            this.Titulo_Main_Negocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Negocio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Negocio.Location = new System.Drawing.Point(59, 23);
            this.Titulo_Main_Negocio.Name = "Titulo_Main_Negocio";
            this.Titulo_Main_Negocio.Size = new System.Drawing.Size(157, 20);
            this.Titulo_Main_Negocio.TabIndex = 76;
            this.Titulo_Main_Negocio.Text = "Detalles de Compras";
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
            this.Btn_Buscar.Location = new System.Drawing.Point(580, 40);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Buscar.TabIndex = 82;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(402, 53);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.PasswordChar = '●';
            this.Txt_Busqueda.Size = new System.Drawing.Size(172, 20);
            this.Txt_Busqueda.TabIndex = 81;
            // 
            // Lbl_No_Doc
            // 
            this.Lbl_No_Doc.AutoSize = true;
            this.Lbl_No_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Doc.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_No_Doc.Location = new System.Drawing.Point(290, 56);
            this.Lbl_No_Doc.Name = "Lbl_No_Doc";
            this.Lbl_No_Doc.Size = new System.Drawing.Size(106, 17);
            this.Lbl_No_Doc.TabIndex = 80;
            this.Lbl_No_Doc.Text = "No. Documento";
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
            this.Btn_Limpiar.Location = new System.Drawing.Point(633, 40);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Limpiar.TabIndex = 79;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            // 
            // Contenedor_Info_Compra
            // 
            this.Contenedor_Info_Compra.Controls.Add(this.Txt_Razon_Proveedor);
            this.Contenedor_Info_Compra.Controls.Add(this.Lbl_Razon_Proveedor);
            this.Contenedor_Info_Compra.Controls.Add(this.Txt_No_Doc);
            this.Contenedor_Info_Compra.Controls.Add(this.Txt_No_Doc_Proveedor);
            this.Contenedor_Info_Compra.Controls.Add(this.Lbl_No_Doc_Proveedro);
            this.Contenedor_Info_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contenedor_Info_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor_Info_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Contenedor_Info_Compra.Location = new System.Drawing.Point(10, 189);
            this.Contenedor_Info_Compra.Name = "Contenedor_Info_Compra";
            this.Contenedor_Info_Compra.Size = new System.Drawing.Size(667, 81);
            this.Contenedor_Info_Compra.TabIndex = 79;
            this.Contenedor_Info_Compra.TabStop = false;
            this.Contenedor_Info_Compra.Text = "Informacion Proveedor";
            // 
            // Txt_Razon_Proveedor
            // 
            this.Txt_Razon_Proveedor.Location = new System.Drawing.Point(240, 42);
            this.Txt_Razon_Proveedor.Name = "Txt_Razon_Proveedor";
            this.Txt_Razon_Proveedor.Size = new System.Drawing.Size(265, 23);
            this.Txt_Razon_Proveedor.TabIndex = 21;
            // 
            // Lbl_Razon_Proveedor
            // 
            this.Lbl_Razon_Proveedor.AutoSize = true;
            this.Lbl_Razon_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Razon_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Razon_Proveedor.Location = new System.Drawing.Point(235, 20);
            this.Lbl_Razon_Proveedor.Name = "Lbl_Razon_Proveedor";
            this.Lbl_Razon_Proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_Razon_Proveedor.TabIndex = 20;
            this.Lbl_Razon_Proveedor.Text = "Razon Social";
            // 
            // Txt_No_Doc
            // 
            this.Txt_No_Doc.Location = new System.Drawing.Point(570, 42);
            this.Txt_No_Doc.Name = "Txt_No_Doc";
            this.Txt_No_Doc.Size = new System.Drawing.Size(77, 23);
            this.Txt_No_Doc.TabIndex = 19;
            // 
            // Txt_No_Doc_Proveedor
            // 
            this.Txt_No_Doc_Proveedor.Location = new System.Drawing.Point(18, 42);
            this.Txt_No_Doc_Proveedor.Name = "Txt_No_Doc_Proveedor";
            this.Txt_No_Doc_Proveedor.Size = new System.Drawing.Size(202, 23);
            this.Txt_No_Doc_Proveedor.TabIndex = 16;
            // 
            // Lbl_No_Doc_Proveedro
            // 
            this.Lbl_No_Doc_Proveedro.AutoSize = true;
            this.Lbl_No_Doc_Proveedro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Doc_Proveedro.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_No_Doc_Proveedro.Location = new System.Drawing.Point(15, 22);
            this.Lbl_No_Doc_Proveedro.Name = "Lbl_No_Doc_Proveedro";
            this.Lbl_No_Doc_Proveedro.Size = new System.Drawing.Size(106, 17);
            this.Lbl_No_Doc_Proveedro.TabIndex = 14;
            this.Lbl_No_Doc_Proveedro.Text = "No. Documento";
            // 
            // GridView_Producto
            // 
            this.GridView_Producto.AllowUserToAddRows = false;
            this.GridView_Producto.AllowUserToDeleteRows = false;
            this.GridView_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Producto.Location = new System.Drawing.Point(12, 276);
            this.GridView_Producto.MultiSelect = false;
            this.GridView_Producto.Name = "GridView_Producto";
            this.GridView_Producto.ReadOnly = true;
            this.GridView_Producto.Size = new System.Drawing.Size(662, 214);
            this.GridView_Producto.TabIndex = 83;
            // 
            // Btn_DescargarPDF
            // 
            this.Btn_DescargarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_DescargarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DescargarPDF.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_DescargarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DescargarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DescargarPDF.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_DescargarPDF.Image = ((System.Drawing.Image)(resources.GetObject("Btn_DescargarPDF.Image")));
            this.Btn_DescargarPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DescargarPDF.Location = new System.Drawing.Point(503, 504);
            this.Btn_DescargarPDF.Name = "Btn_DescargarPDF";
            this.Btn_DescargarPDF.Size = new System.Drawing.Size(171, 46);
            this.Btn_DescargarPDF.TabIndex = 86;
            this.Btn_DescargarPDF.Text = "   Descargar PDF";
            this.Btn_DescargarPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_DescargarPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_DescargarPDF.UseVisualStyleBackColor = false;
            // 
            // Txt_MontoPagar_Compra
            // 
            this.Txt_MontoPagar_Compra.Location = new System.Drawing.Point(102, 518);
            this.Txt_MontoPagar_Compra.Name = "Txt_MontoPagar_Compra";
            this.Txt_MontoPagar_Compra.Size = new System.Drawing.Size(104, 20);
            this.Txt_MontoPagar_Compra.TabIndex = 85;
            this.Txt_MontoPagar_Compra.Text = "0";
            // 
            // Lbl_MontoPagar_Compra
            // 
            this.Lbl_MontoPagar_Compra.AutoSize = true;
            this.Lbl_MontoPagar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MontoPagar_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_MontoPagar_Compra.Location = new System.Drawing.Point(12, 519);
            this.Lbl_MontoPagar_Compra.Name = "Lbl_MontoPagar_Compra";
            this.Lbl_MontoPagar_Compra.Size = new System.Drawing.Size(87, 17);
            this.Lbl_MontoPagar_Compra.TabIndex = 84;
            this.Lbl_MontoPagar_Compra.Text = "Monto Total:";
            // 
            // Detalle_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 559);
            this.Controls.Add(this.Btn_DescargarPDF);
            this.Controls.Add(this.Txt_MontoPagar_Compra);
            this.Controls.Add(this.Lbl_MontoPagar_Compra);
            this.Controls.Add(this.GridView_Producto);
            this.Controls.Add(this.Contenedor_Info_Compra);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.Lbl_No_Doc);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Contendor_Info_Compra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Negocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Detalle_Compras";
            this.Text = "Detalle_Compras";
            this.Contendor_Info_Compra.ResumeLayout(false);
            this.Contendor_Info_Compra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Contenedor_Info_Compra.ResumeLayout(false);
            this.Contenedor_Info_Compra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Contendor_Info_Compra;
        private System.Windows.Forms.TextBox Txt_Fecha_Compra;
        private System.Windows.Forms.Label Lbl_Fecha_Compra;
        private System.Windows.Forms.Label Lbl_Tipo_Doc_Compra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo_Main_Negocio;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.Label Lbl_No_Doc;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.TextBox Txt_Usuario_Compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Tipo_Doc_Compra;
        private System.Windows.Forms.GroupBox Contenedor_Info_Compra;
        private System.Windows.Forms.TextBox Txt_No_Doc_Proveedor;
        private System.Windows.Forms.Label Lbl_No_Doc_Proveedro;
        private System.Windows.Forms.TextBox Txt_Razon_Proveedor;
        private System.Windows.Forms.Label Lbl_Razon_Proveedor;
        private System.Windows.Forms.TextBox Txt_No_Doc;
        private System.Windows.Forms.DataGridView GridView_Producto;
        private System.Windows.Forms.Button Btn_DescargarPDF;
        private System.Windows.Forms.TextBox Txt_MontoPagar_Compra;
        private System.Windows.Forms.Label Lbl_MontoPagar_Compra;
    }
}