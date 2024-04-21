namespace CapaPresentacion
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Main_Compras = new System.Windows.Forms.Label();
            this.Contendor_Info_Compra = new System.Windows.Forms.GroupBox();
            this.CBox_Tipo_Doc = new System.Windows.Forms.ComboBox();
            this.Txt_Fecha_Compra = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha_Compra = new System.Windows.Forms.Label();
            this.Lbl_Tipo_Doc = new System.Windows.Forms.Label();
            this.Contenedor_Info_Proveedor = new System.Windows.Forms.GroupBox();
            this.Txt_Id_Proveedor = new System.Windows.Forms.TextBox();
            this.Btn_Buscar_Proveedor = new System.Windows.Forms.Button();
            this.Txt_Razon_Proveedor = new System.Windows.Forms.TextBox();
            this.Txt_No_Doc_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_No_Doc_Proveedor = new System.Windows.Forms.Label();
            this.Lbl_Razon_Proveedor = new System.Windows.Forms.Label();
            this.Contenedor_Info_Producto = new System.Windows.Forms.GroupBox();
            this.Btn_Agregar_Producto = new System.Windows.Forms.Button();
            this.Lbl_Cantidad_Producto = new System.Windows.Forms.Label();
            this.Txt_Cantidad_Producto = new System.Windows.Forms.NumericUpDown();
            this.Txt_PrecioVenta_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_PrecioVenta_Producto = new System.Windows.Forms.Label();
            this.Txt_PrecioCompra_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_PrecioCompra_Producto = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Id_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Producto = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.GridView_Producto = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_MontoPagar_Compra = new System.Windows.Forms.TextBox();
            this.Lbl_MontoPagar_Compra = new System.Windows.Forms.Label();
            this.Btn_Registrar_Compra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Contendor_Info_Compra.SuspendLayout();
            this.Contenedor_Info_Proveedor.SuspendLayout();
            this.Contenedor_Info_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Cantidad_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo_Main_Compras
            // 
            this.Titulo_Main_Compras.AutoSize = true;
            this.Titulo_Main_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Compras.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Compras.Location = new System.Drawing.Point(67, 18);
            this.Titulo_Main_Compras.Name = "Titulo_Main_Compras";
            this.Titulo_Main_Compras.Size = new System.Drawing.Size(155, 20);
            this.Titulo_Main_Compras.TabIndex = 73;
            this.Titulo_Main_Compras.Text = "Gestion de Compras";
            // 
            // Contendor_Info_Compra
            // 
            this.Contendor_Info_Compra.Controls.Add(this.CBox_Tipo_Doc);
            this.Contendor_Info_Compra.Controls.Add(this.Txt_Fecha_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.Lbl_Fecha_Compra);
            this.Contendor_Info_Compra.Controls.Add(this.Lbl_Tipo_Doc);
            this.Contendor_Info_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contendor_Info_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contendor_Info_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Contendor_Info_Compra.Location = new System.Drawing.Point(18, 57);
            this.Contendor_Info_Compra.Name = "Contendor_Info_Compra";
            this.Contendor_Info_Compra.Size = new System.Drawing.Size(315, 139);
            this.Contendor_Info_Compra.TabIndex = 75;
            this.Contendor_Info_Compra.TabStop = false;
            this.Contendor_Info_Compra.Text = "Informacion Compra";
            // 
            // CBox_Tipo_Doc
            // 
            this.CBox_Tipo_Doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Tipo_Doc.FormattingEnabled = true;
            this.CBox_Tipo_Doc.Location = new System.Drawing.Point(6, 97);
            this.CBox_Tipo_Doc.Name = "CBox_Tipo_Doc";
            this.CBox_Tipo_Doc.Size = new System.Drawing.Size(303, 24);
            this.CBox_Tipo_Doc.TabIndex = 17;
            // 
            // Txt_Fecha_Compra
            // 
            this.Txt_Fecha_Compra.Location = new System.Drawing.Point(6, 42);
            this.Txt_Fecha_Compra.Name = "Txt_Fecha_Compra";
            this.Txt_Fecha_Compra.Size = new System.Drawing.Size(303, 23);
            this.Txt_Fecha_Compra.TabIndex = 16;
            // 
            // Lbl_Fecha_Compra
            // 
            this.Lbl_Fecha_Compra.AutoSize = true;
            this.Lbl_Fecha_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Fecha_Compra.Location = new System.Drawing.Point(3, 22);
            this.Lbl_Fecha_Compra.Name = "Lbl_Fecha_Compra";
            this.Lbl_Fecha_Compra.Size = new System.Drawing.Size(47, 17);
            this.Lbl_Fecha_Compra.TabIndex = 14;
            this.Lbl_Fecha_Compra.Text = "Fecha";
            // 
            // Lbl_Tipo_Doc
            // 
            this.Lbl_Tipo_Doc.AutoSize = true;
            this.Lbl_Tipo_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tipo_Doc.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Tipo_Doc.Location = new System.Drawing.Point(1, 77);
            this.Lbl_Tipo_Doc.Name = "Lbl_Tipo_Doc";
            this.Lbl_Tipo_Doc.Size = new System.Drawing.Size(112, 17);
            this.Lbl_Tipo_Doc.TabIndex = 15;
            this.Lbl_Tipo_Doc.Text = "Tipo Documento";
            // 
            // Contenedor_Info_Proveedor
            // 
            this.Contenedor_Info_Proveedor.Controls.Add(this.Txt_Id_Proveedor);
            this.Contenedor_Info_Proveedor.Controls.Add(this.Btn_Buscar_Proveedor);
            this.Contenedor_Info_Proveedor.Controls.Add(this.Txt_Razon_Proveedor);
            this.Contenedor_Info_Proveedor.Controls.Add(this.Txt_No_Doc_Proveedor);
            this.Contenedor_Info_Proveedor.Controls.Add(this.Lbl_No_Doc_Proveedor);
            this.Contenedor_Info_Proveedor.Controls.Add(this.Lbl_Razon_Proveedor);
            this.Contenedor_Info_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contenedor_Info_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor_Info_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Contenedor_Info_Proveedor.Location = new System.Drawing.Point(348, 57);
            this.Contenedor_Info_Proveedor.Name = "Contenedor_Info_Proveedor";
            this.Contenedor_Info_Proveedor.Size = new System.Drawing.Size(329, 139);
            this.Contenedor_Info_Proveedor.TabIndex = 76;
            this.Contenedor_Info_Proveedor.TabStop = false;
            this.Contenedor_Info_Proveedor.Text = "Informacion Proveedor";
            // 
            // Txt_Id_Proveedor
            // 
            this.Txt_Id_Proveedor.Location = new System.Drawing.Point(297, 98);
            this.Txt_Id_Proveedor.Name = "Txt_Id_Proveedor";
            this.Txt_Id_Proveedor.Size = new System.Drawing.Size(26, 23);
            this.Txt_Id_Proveedor.TabIndex = 30;
            this.Txt_Id_Proveedor.Visible = false;
            // 
            // Btn_Buscar_Proveedor
            // 
            this.Btn_Buscar_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Buscar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Buscar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Buscar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Buscar_Proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Buscar_Proveedor.Image")));
            this.Btn_Buscar_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar_Proveedor.Location = new System.Drawing.Point(279, 37);
            this.Btn_Buscar_Proveedor.Name = "Btn_Buscar_Proveedor";
            this.Btn_Buscar_Proveedor.Size = new System.Drawing.Size(44, 33);
            this.Btn_Buscar_Proveedor.TabIndex = 29;
            this.Btn_Buscar_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Buscar_Proveedor.Click += new System.EventHandler(this.Btn_Buscar_Proveedor_Click);
            // 
            // Txt_Razon_Proveedor
            // 
            this.Txt_Razon_Proveedor.Location = new System.Drawing.Point(6, 99);
            this.Txt_Razon_Proveedor.Name = "Txt_Razon_Proveedor";
            this.Txt_Razon_Proveedor.Size = new System.Drawing.Size(265, 23);
            this.Txt_Razon_Proveedor.TabIndex = 17;
            // 
            // Txt_No_Doc_Proveedor
            // 
            this.Txt_No_Doc_Proveedor.Location = new System.Drawing.Point(6, 42);
            this.Txt_No_Doc_Proveedor.Name = "Txt_No_Doc_Proveedor";
            this.Txt_No_Doc_Proveedor.Size = new System.Drawing.Size(265, 23);
            this.Txt_No_Doc_Proveedor.TabIndex = 16;
            // 
            // Lbl_No_Doc_Proveedor
            // 
            this.Lbl_No_Doc_Proveedor.AutoSize = true;
            this.Lbl_No_Doc_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Doc_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_No_Doc_Proveedor.Location = new System.Drawing.Point(3, 22);
            this.Lbl_No_Doc_Proveedor.Name = "Lbl_No_Doc_Proveedor";
            this.Lbl_No_Doc_Proveedor.Size = new System.Drawing.Size(106, 17);
            this.Lbl_No_Doc_Proveedor.TabIndex = 14;
            this.Lbl_No_Doc_Proveedor.Text = "No. Documento";
            // 
            // Lbl_Razon_Proveedor
            // 
            this.Lbl_Razon_Proveedor.AutoSize = true;
            this.Lbl_Razon_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Razon_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Razon_Proveedor.Location = new System.Drawing.Point(1, 77);
            this.Lbl_Razon_Proveedor.Name = "Lbl_Razon_Proveedor";
            this.Lbl_Razon_Proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_Razon_Proveedor.TabIndex = 15;
            this.Lbl_Razon_Proveedor.Text = "Razon Social";
            // 
            // Contenedor_Info_Producto
            // 
            this.Contenedor_Info_Producto.Controls.Add(this.Btn_Agregar_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Lbl_Cantidad_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_Cantidad_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_PrecioVenta_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Lbl_PrecioVenta_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_PrecioCompra_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Lbl_PrecioCompra_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Btn_Buscar);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_Id_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_Nombre_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Txt_Codigo_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Lbl_Nombre_Producto);
            this.Contenedor_Info_Producto.Controls.Add(this.Lbl_Codigo_Producto);
            this.Contenedor_Info_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contenedor_Info_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Contenedor_Info_Producto.Location = new System.Drawing.Point(18, 211);
            this.Contenedor_Info_Producto.Name = "Contenedor_Info_Producto";
            this.Contenedor_Info_Producto.Size = new System.Drawing.Size(659, 138);
            this.Contenedor_Info_Producto.TabIndex = 77;
            this.Contenedor_Info_Producto.TabStop = false;
            this.Contenedor_Info_Producto.Text = "Informacion de Producto";
            // 
            // Btn_Agregar_Producto
            // 
            this.Btn_Agregar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Agregar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Agregar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Agregar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agregar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Agregar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Agregar_Producto.Image")));
            this.Btn_Agregar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Producto.Location = new System.Drawing.Point(282, 80);
            this.Btn_Agregar_Producto.Name = "Btn_Agregar_Producto";
            this.Btn_Agregar_Producto.Size = new System.Drawing.Size(133, 49);
            this.Btn_Agregar_Producto.TabIndex = 62;
            this.Btn_Agregar_Producto.Text = "   Agregar";
            this.Btn_Agregar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agregar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Agregar_Producto.UseVisualStyleBackColor = false;
            this.Btn_Agregar_Producto.Click += new System.EventHandler(this.Btn_Agregar_Producto_Click);
            // 
            // Lbl_Cantidad_Producto
            // 
            this.Lbl_Cantidad_Producto.AutoSize = true;
            this.Lbl_Cantidad_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Cantidad_Producto.Location = new System.Drawing.Point(155, 82);
            this.Lbl_Cantidad_Producto.Name = "Lbl_Cantidad_Producto";
            this.Lbl_Cantidad_Producto.Size = new System.Drawing.Size(64, 17);
            this.Lbl_Cantidad_Producto.TabIndex = 61;
            this.Lbl_Cantidad_Producto.Text = "Cantidad";
            // 
            // Txt_Cantidad_Producto
            // 
            this.Txt_Cantidad_Producto.Location = new System.Drawing.Point(158, 102);
            this.Txt_Cantidad_Producto.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Txt_Cantidad_Producto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Txt_Cantidad_Producto.Name = "Txt_Cantidad_Producto";
            this.Txt_Cantidad_Producto.Size = new System.Drawing.Size(114, 23);
            this.Txt_Cantidad_Producto.TabIndex = 60;
            this.Txt_Cantidad_Producto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Txt_PrecioVenta_Producto
            // 
            this.Txt_PrecioVenta_Producto.Location = new System.Drawing.Point(9, 102);
            this.Txt_PrecioVenta_Producto.Name = "Txt_PrecioVenta_Producto";
            this.Txt_PrecioVenta_Producto.Size = new System.Drawing.Size(140, 23);
            this.Txt_PrecioVenta_Producto.TabIndex = 59;
            // 
            // Lbl_PrecioVenta_Producto
            // 
            this.Lbl_PrecioVenta_Producto.AutoSize = true;
            this.Lbl_PrecioVenta_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrecioVenta_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_PrecioVenta_Producto.Location = new System.Drawing.Point(6, 82);
            this.Lbl_PrecioVenta_Producto.Name = "Lbl_PrecioVenta_Producto";
            this.Lbl_PrecioVenta_Producto.Size = new System.Drawing.Size(89, 17);
            this.Lbl_PrecioVenta_Producto.TabIndex = 58;
            this.Lbl_PrecioVenta_Producto.Text = "Precio Venta";
            // 
            // Txt_PrecioCompra_Producto
            // 
            this.Txt_PrecioCompra_Producto.Location = new System.Drawing.Point(509, 48);
            this.Txt_PrecioCompra_Producto.Name = "Txt_PrecioCompra_Producto";
            this.Txt_PrecioCompra_Producto.Size = new System.Drawing.Size(140, 23);
            this.Txt_PrecioCompra_Producto.TabIndex = 57;
            // 
            // Lbl_PrecioCompra_Producto
            // 
            this.Lbl_PrecioCompra_Producto.AutoSize = true;
            this.Lbl_PrecioCompra_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PrecioCompra_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_PrecioCompra_Producto.Location = new System.Drawing.Point(506, 28);
            this.Lbl_PrecioCompra_Producto.Name = "Lbl_PrecioCompra_Producto";
            this.Lbl_PrecioCompra_Producto.Size = new System.Drawing.Size(101, 17);
            this.Lbl_PrecioCompra_Producto.TabIndex = 56;
            this.Lbl_PrecioCompra_Producto.Text = "Precio Compra";
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
            this.Btn_Buscar.Location = new System.Drawing.Point(228, 43);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(44, 33);
            this.Btn_Buscar.TabIndex = 31;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Id_Producto
            // 
            this.Txt_Id_Producto.Location = new System.Drawing.Point(202, 19);
            this.Txt_Id_Producto.Name = "Txt_Id_Producto";
            this.Txt_Id_Producto.Size = new System.Drawing.Size(20, 23);
            this.Txt_Id_Producto.TabIndex = 55;
            this.Txt_Id_Producto.Visible = false;
            // 
            // Txt_Nombre_Producto
            // 
            this.Txt_Nombre_Producto.Location = new System.Drawing.Point(281, 48);
            this.Txt_Nombre_Producto.Name = "Txt_Nombre_Producto";
            this.Txt_Nombre_Producto.Size = new System.Drawing.Size(222, 23);
            this.Txt_Nombre_Producto.TabIndex = 54;
            // 
            // Txt_Codigo_Producto
            // 
            this.Txt_Codigo_Producto.Location = new System.Drawing.Point(9, 48);
            this.Txt_Codigo_Producto.Name = "Txt_Codigo_Producto";
            this.Txt_Codigo_Producto.Size = new System.Drawing.Size(213, 23);
            this.Txt_Codigo_Producto.TabIndex = 53;
            this.Txt_Codigo_Producto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Codigo_Producto_KeyDown);
            // 
            // Lbl_Nombre_Producto
            // 
            this.Lbl_Nombre_Producto.AutoSize = true;
            this.Lbl_Nombre_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Nombre_Producto.Location = new System.Drawing.Point(278, 28);
            this.Lbl_Nombre_Producto.Name = "Lbl_Nombre_Producto";
            this.Lbl_Nombre_Producto.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Nombre_Producto.TabIndex = 52;
            this.Lbl_Nombre_Producto.Text = "Producto";
            // 
            // Lbl_Codigo_Producto
            // 
            this.Lbl_Codigo_Producto.AutoSize = true;
            this.Lbl_Codigo_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Codigo_Producto.Location = new System.Drawing.Point(6, 28);
            this.Lbl_Codigo_Producto.Name = "Lbl_Codigo_Producto";
            this.Lbl_Codigo_Producto.Size = new System.Drawing.Size(98, 17);
            this.Lbl_Codigo_Producto.TabIndex = 51;
            this.Lbl_Codigo_Producto.Text = "Cod. Producto";
            // 
            // GridView_Producto
            // 
            this.GridView_Producto.AllowUserToAddRows = false;
            this.GridView_Producto.AllowUserToDeleteRows = false;
            this.GridView_Producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Producto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.PRODUCTO,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.CANTIDAD,
            this.SUB_TOTAL});
            this.GridView_Producto.Location = new System.Drawing.Point(15, 357);
            this.GridView_Producto.MultiSelect = false;
            this.GridView_Producto.Name = "GridView_Producto";
            this.GridView_Producto.ReadOnly = true;
            this.GridView_Producto.Size = new System.Drawing.Size(662, 152);
            this.GridView_Producto.TabIndex = 78;
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.ReadOnly = true;
            this.ID_PRODUCTO.Visible = false;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.ReadOnly = true;
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            this.PRECIO_VENTA.ReadOnly = true;
            this.PRECIO_VENTA.Visible = false;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // SUB_TOTAL
            // 
            this.SUB_TOTAL.HeaderText = "SUB TOTAL";
            this.SUB_TOTAL.Name = "SUB_TOTAL";
            this.SUB_TOTAL.ReadOnly = true;
            // 
            // Txt_MontoPagar_Compra
            // 
            this.Txt_MontoPagar_Compra.Location = new System.Drawing.Point(101, 525);
            this.Txt_MontoPagar_Compra.Name = "Txt_MontoPagar_Compra";
            this.Txt_MontoPagar_Compra.Size = new System.Drawing.Size(104, 20);
            this.Txt_MontoPagar_Compra.TabIndex = 80;
            this.Txt_MontoPagar_Compra.Text = "0";
            // 
            // Lbl_MontoPagar_Compra
            // 
            this.Lbl_MontoPagar_Compra.AutoSize = true;
            this.Lbl_MontoPagar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MontoPagar_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_MontoPagar_Compra.Location = new System.Drawing.Point(11, 526);
            this.Lbl_MontoPagar_Compra.Name = "Lbl_MontoPagar_Compra";
            this.Lbl_MontoPagar_Compra.Size = new System.Drawing.Size(87, 17);
            this.Lbl_MontoPagar_Compra.TabIndex = 79;
            this.Lbl_MontoPagar_Compra.Text = "Monto Total:";
            // 
            // Btn_Registrar_Compra
            // 
            this.Btn_Registrar_Compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Registrar_Compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar_Compra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Registrar_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registrar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar_Compra.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Registrar_Compra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registrar_Compra.Image")));
            this.Btn_Registrar_Compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Compra.Location = new System.Drawing.Point(554, 515);
            this.Btn_Registrar_Compra.Name = "Btn_Registrar_Compra";
            this.Btn_Registrar_Compra.Size = new System.Drawing.Size(123, 38);
            this.Btn_Registrar_Compra.TabIndex = 81;
            this.Btn_Registrar_Compra.Text = "   Registrar";
            this.Btn_Registrar_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Registrar_Compra.UseVisualStyleBackColor = false;
            this.Btn_Registrar_Compra.Click += new System.EventHandler(this.Btn_Registrar_Compra_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 565);
            this.Controls.Add(this.Btn_Registrar_Compra);
            this.Controls.Add(this.Txt_MontoPagar_Compra);
            this.Controls.Add(this.Lbl_MontoPagar_Compra);
            this.Controls.Add(this.GridView_Producto);
            this.Controls.Add(this.Contenedor_Info_Producto);
            this.Controls.Add(this.Contenedor_Info_Proveedor);
            this.Controls.Add(this.Contendor_Info_Compra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Contendor_Info_Compra.ResumeLayout(false);
            this.Contendor_Info_Compra.PerformLayout();
            this.Contenedor_Info_Proveedor.ResumeLayout(false);
            this.Contenedor_Info_Proveedor.PerformLayout();
            this.Contenedor_Info_Producto.ResumeLayout(false);
            this.Contenedor_Info_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Cantidad_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo_Main_Compras;
        private System.Windows.Forms.GroupBox Contendor_Info_Compra;
        private System.Windows.Forms.ComboBox CBox_Tipo_Doc;
        private System.Windows.Forms.TextBox Txt_Fecha_Compra;
        private System.Windows.Forms.Label Lbl_Fecha_Compra;
        private System.Windows.Forms.Label Lbl_Tipo_Doc;
        private System.Windows.Forms.GroupBox Contenedor_Info_Proveedor;
        private System.Windows.Forms.TextBox Txt_No_Doc_Proveedor;
        private System.Windows.Forms.Label Lbl_No_Doc_Proveedor;
        private System.Windows.Forms.Label Lbl_Razon_Proveedor;
        private System.Windows.Forms.TextBox Txt_Razon_Proveedor;
        private System.Windows.Forms.Button Btn_Buscar_Proveedor;
        private System.Windows.Forms.TextBox Txt_Id_Proveedor;
        private System.Windows.Forms.GroupBox Contenedor_Info_Producto;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Id_Producto;
        private System.Windows.Forms.TextBox Txt_Nombre_Producto;
        private System.Windows.Forms.TextBox Txt_Codigo_Producto;
        private System.Windows.Forms.Label Lbl_Nombre_Producto;
        private System.Windows.Forms.Label Lbl_Codigo_Producto;
        private System.Windows.Forms.TextBox Txt_PrecioVenta_Producto;
        private System.Windows.Forms.Label Lbl_PrecioVenta_Producto;
        private System.Windows.Forms.TextBox Txt_PrecioCompra_Producto;
        private System.Windows.Forms.Label Lbl_PrecioCompra_Producto;
        private System.Windows.Forms.Label Lbl_Cantidad_Producto;
        private System.Windows.Forms.NumericUpDown Txt_Cantidad_Producto;
        private System.Windows.Forms.Button Btn_Agregar_Producto;
        private System.Windows.Forms.DataGridView GridView_Producto;
        private System.Windows.Forms.TextBox Txt_MontoPagar_Compra;
        private System.Windows.Forms.Label Lbl_MontoPagar_Compra;
        private System.Windows.Forms.Button Btn_Registrar_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
    }
}