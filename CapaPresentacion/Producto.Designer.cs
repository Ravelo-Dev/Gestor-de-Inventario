namespace CapaPresentacion
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.Txt_Id_Producto = new System.Windows.Forms.TextBox();
            this.Btn_Eliminar_Producto = new System.Windows.Forms.Button();
            this.Btn_Guardar_Producto = new System.Windows.Forms.Button();
            this.CBox_Estado_Producto = new System.Windows.Forms.ComboBox();
            this.CBox_Categoria_Producto = new System.Windows.Forms.ComboBox();
            this.Txt_Descripcion_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Codigo_Producto = new System.Windows.Forms.TextBox();
            this.Lbl_Estado_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Rol_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Descripcion_Producto = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Producto = new System.Windows.Forms.Label();
            this.Lbl_Codigo_Producto = new System.Windows.Forms.Label();
            this.Txt_Indice = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar_Producto = new System.Windows.Forms.Button();
            this.Titulo_Main_Productos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Separador = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.CBox_Busqueda = new System.Windows.Forms.ComboBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.GridView_Product = new System.Windows.Forms.DataGridView();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT_DISPONIBLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Id_Producto
            // 
            this.Txt_Id_Producto.Location = new System.Drawing.Point(252, 45);
            this.Txt_Id_Producto.Name = "Txt_Id_Producto";
            this.Txt_Id_Producto.Size = new System.Drawing.Size(20, 20);
            this.Txt_Id_Producto.TabIndex = 50;
            this.Txt_Id_Producto.Text = "0";
            this.Txt_Id_Producto.Visible = false;
            // 
            // Btn_Eliminar_Producto
            // 
            this.Btn_Eliminar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Eliminar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Producto.Image")));
            this.Btn_Eliminar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Producto.Location = new System.Drawing.Point(319, 236);
            this.Btn_Eliminar_Producto.Name = "Btn_Eliminar_Producto";
            this.Btn_Eliminar_Producto.Size = new System.Drawing.Size(133, 49);
            this.Btn_Eliminar_Producto.TabIndex = 46;
            this.Btn_Eliminar_Producto.Text = "   Eliminar";
            this.Btn_Eliminar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar_Producto.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Producto.Click += new System.EventHandler(this.Btn_Eliminar_Producto_Click);
            // 
            // Btn_Guardar_Producto
            // 
            this.Btn_Guardar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Guardar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Guardar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Producto.Image")));
            this.Btn_Guardar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Producto.Location = new System.Drawing.Point(32, 236);
            this.Btn_Guardar_Producto.Name = "Btn_Guardar_Producto";
            this.Btn_Guardar_Producto.Size = new System.Drawing.Size(133, 49);
            this.Btn_Guardar_Producto.TabIndex = 44;
            this.Btn_Guardar_Producto.Text = "   Guardar";
            this.Btn_Guardar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar_Producto.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Producto.Click += new System.EventHandler(this.Btn_Guardar_Producto_Click);
            // 
            // CBox_Estado_Producto
            // 
            this.CBox_Estado_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Estado_Producto.FormattingEnabled = true;
            this.CBox_Estado_Producto.Location = new System.Drawing.Point(252, 188);
            this.CBox_Estado_Producto.Name = "CBox_Estado_Producto";
            this.CBox_Estado_Producto.Size = new System.Drawing.Size(200, 21);
            this.CBox_Estado_Producto.TabIndex = 43;
            // 
            // CBox_Categoria_Producto
            // 
            this.CBox_Categoria_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Categoria_Producto.FormattingEnabled = true;
            this.CBox_Categoria_Producto.Location = new System.Drawing.Point(31, 188);
            this.CBox_Categoria_Producto.Name = "CBox_Categoria_Producto";
            this.CBox_Categoria_Producto.Size = new System.Drawing.Size(200, 21);
            this.CBox_Categoria_Producto.TabIndex = 42;
            // 
            // Txt_Descripcion_Producto
            // 
            this.Txt_Descripcion_Producto.Location = new System.Drawing.Point(468, 121);
            this.Txt_Descripcion_Producto.Name = "Txt_Descripcion_Producto";
            this.Txt_Descripcion_Producto.Size = new System.Drawing.Size(197, 20);
            this.Txt_Descripcion_Producto.TabIndex = 39;
            // 
            // Txt_Nombre_Producto
            // 
            this.Txt_Nombre_Producto.Location = new System.Drawing.Point(252, 121);
            this.Txt_Nombre_Producto.Name = "Txt_Nombre_Producto";
            this.Txt_Nombre_Producto.Size = new System.Drawing.Size(197, 20);
            this.Txt_Nombre_Producto.TabIndex = 38;
            // 
            // Txt_Codigo_Producto
            // 
            this.Txt_Codigo_Producto.Location = new System.Drawing.Point(34, 121);
            this.Txt_Codigo_Producto.Name = "Txt_Codigo_Producto";
            this.Txt_Codigo_Producto.Size = new System.Drawing.Size(197, 20);
            this.Txt_Codigo_Producto.TabIndex = 37;
            // 
            // Lbl_Estado_Usuario
            // 
            this.Lbl_Estado_Usuario.AutoSize = true;
            this.Lbl_Estado_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Estado_Usuario.Location = new System.Drawing.Point(255, 163);
            this.Lbl_Estado_Usuario.Name = "Lbl_Estado_Usuario";
            this.Lbl_Estado_Usuario.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Estado_Usuario.TabIndex = 36;
            this.Lbl_Estado_Usuario.Text = "Estado";
            // 
            // Lbl_Rol_Usuario
            // 
            this.Lbl_Rol_Usuario.AutoSize = true;
            this.Lbl_Rol_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rol_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Rol_Usuario.Location = new System.Drawing.Point(31, 163);
            this.Lbl_Rol_Usuario.Name = "Lbl_Rol_Usuario";
            this.Lbl_Rol_Usuario.Size = new System.Drawing.Size(69, 17);
            this.Lbl_Rol_Usuario.TabIndex = 35;
            this.Lbl_Rol_Usuario.Text = "Categoria";
            // 
            // Lbl_Descripcion_Producto
            // 
            this.Lbl_Descripcion_Producto.AutoSize = true;
            this.Lbl_Descripcion_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descripcion_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Descripcion_Producto.Location = new System.Drawing.Point(465, 94);
            this.Lbl_Descripcion_Producto.Name = "Lbl_Descripcion_Producto";
            this.Lbl_Descripcion_Producto.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Descripcion_Producto.TabIndex = 32;
            this.Lbl_Descripcion_Producto.Text = "Descripcion";
            // 
            // Lbl_Nombre_Producto
            // 
            this.Lbl_Nombre_Producto.AutoSize = true;
            this.Lbl_Nombre_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Nombre_Producto.Location = new System.Drawing.Point(249, 94);
            this.Lbl_Nombre_Producto.Name = "Lbl_Nombre_Producto";
            this.Lbl_Nombre_Producto.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Nombre_Producto.TabIndex = 31;
            this.Lbl_Nombre_Producto.Text = "Nombre";
            // 
            // Lbl_Codigo_Producto
            // 
            this.Lbl_Codigo_Producto.AutoSize = true;
            this.Lbl_Codigo_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Codigo_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Codigo_Producto.Location = new System.Drawing.Point(31, 94);
            this.Lbl_Codigo_Producto.Name = "Lbl_Codigo_Producto";
            this.Lbl_Codigo_Producto.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Codigo_Producto.TabIndex = 30;
            this.Lbl_Codigo_Producto.Text = "Codigo";
            // 
            // Txt_Indice
            // 
            this.Txt_Indice.Location = new System.Drawing.Point(278, 45);
            this.Txt_Indice.Name = "Txt_Indice";
            this.Txt_Indice.Size = new System.Drawing.Size(20, 20);
            this.Txt_Indice.TabIndex = 57;
            this.Txt_Indice.Text = "-1";
            this.Txt_Indice.Visible = false;
            // 
            // Btn_Limpiar_Producto
            // 
            this.Btn_Limpiar_Producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Limpiar_Producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar_Producto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Limpiar_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Producto.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Limpiar_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Producto.Image")));
            this.Btn_Limpiar_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Producto.Location = new System.Drawing.Point(175, 236);
            this.Btn_Limpiar_Producto.Name = "Btn_Limpiar_Producto";
            this.Btn_Limpiar_Producto.Size = new System.Drawing.Size(133, 49);
            this.Btn_Limpiar_Producto.TabIndex = 58;
            this.Btn_Limpiar_Producto.Text = "   Limpiar";
            this.Btn_Limpiar_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar_Producto.UseVisualStyleBackColor = false;
            this.Btn_Limpiar_Producto.Click += new System.EventHandler(this.Btn_Limpiar_Producto_Click);
            // 
            // Titulo_Main_Productos
            // 
            this.Titulo_Main_Productos.AutoSize = true;
            this.Titulo_Main_Productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Productos.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Productos.Location = new System.Drawing.Point(87, 43);
            this.Titulo_Main_Productos.Name = "Titulo_Main_Productos";
            this.Titulo_Main_Productos.Size = new System.Drawing.Size(163, 20);
            this.Titulo_Main_Productos.TabIndex = 47;
            this.Titulo_Main_Productos.Text = "Gestion de Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Separador
            // 
            this.Separador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Separador.Location = new System.Drawing.Point(12, 288);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(665, 18);
            this.Separador.TabIndex = 51;
            this.Separador.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            this.Separador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Btn_Limpiar.Location = new System.Drawing.Point(611, 307);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Limpiar.TabIndex = 52;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // CBox_Busqueda
            // 
            this.CBox_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Busqueda.FormattingEnabled = true;
            this.CBox_Busqueda.Location = new System.Drawing.Point(238, 320);
            this.CBox_Busqueda.Name = "CBox_Busqueda";
            this.CBox_Busqueda.Size = new System.Drawing.Size(133, 21);
            this.CBox_Busqueda.TabIndex = 53;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Buscar.Location = new System.Drawing.Point(154, 323);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Buscar.TabIndex = 54;
            this.Lbl_Buscar.Text = "Buscar Por:";
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(380, 320);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.PasswordChar = '●';
            this.Txt_Busqueda.Size = new System.Drawing.Size(172, 20);
            this.Txt_Busqueda.TabIndex = 55;
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
            this.Btn_Buscar.Location = new System.Drawing.Point(558, 307);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Buscar.TabIndex = 56;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // GridView_Product
            // 
            this.GridView_Product.AllowUserToAddRows = false;
            this.GridView_Product.AllowUserToDeleteRows = false;
            this.GridView_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PRODUCTO,
            this.CODIGO,
            this.NOMBRE,
            this.DESCRIPCION,
            this.ID_CATEGORIA,
            this.CATEGORIA,
            this.CANT_DISPONIBLE,
            this.PRECIO_COMPRA,
            this.PRECIO_VENTA,
            this.ESTADO_VALOR,
            this.ESTADO});
            this.GridView_Product.Location = new System.Drawing.Point(15, 363);
            this.GridView_Product.MultiSelect = false;
            this.GridView_Product.Name = "GridView_Product";
            this.GridView_Product.ReadOnly = true;
            this.GridView_Product.Size = new System.Drawing.Size(662, 184);
            this.GridView_Product.TabIndex = 59;
            this.GridView_Product.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Product_CellClick_1);
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.HeaderText = "ID_PRODUCTO";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            this.ID_PRODUCTO.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // ID_CATEGORIA
            // 
            this.ID_CATEGORIA.HeaderText = "ID_CATEGORIA";
            this.ID_CATEGORIA.Name = "ID_CATEGORIA";
            this.ID_CATEGORIA.Visible = false;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            // 
            // CANT_DISPONIBLE
            // 
            this.CANT_DISPONIBLE.HeaderText = "STOCK";
            this.CANT_DISPONIBLE.Name = "CANT_DISPONIBLE";
            // 
            // PRECIO_COMPRA
            // 
            this.PRECIO_COMPRA.HeaderText = "PRECIO_COMPRA";
            this.PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            // 
            // PRECIO_VENTA
            // 
            this.PRECIO_VENTA.HeaderText = "PRECIO_VENTA";
            this.PRECIO_VENTA.Name = "PRECIO_VENTA";
            // 
            // ESTADO_VALOR
            // 
            this.ESTADO_VALOR.HeaderText = "ESTADO_VALOR";
            this.ESTADO_VALOR.Name = "ESTADO_VALOR";
            this.ESTADO_VALOR.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 559);
            this.Controls.Add(this.GridView_Product);
            this.Controls.Add(this.Btn_Limpiar_Producto);
            this.Controls.Add(this.Txt_Indice);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.CBox_Busqueda);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.Txt_Id_Producto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Productos);
            this.Controls.Add(this.Btn_Eliminar_Producto);
            this.Controls.Add(this.Btn_Guardar_Producto);
            this.Controls.Add(this.CBox_Estado_Producto);
            this.Controls.Add(this.CBox_Categoria_Producto);
            this.Controls.Add(this.Txt_Descripcion_Producto);
            this.Controls.Add(this.Txt_Nombre_Producto);
            this.Controls.Add(this.Txt_Codigo_Producto);
            this.Controls.Add(this.Lbl_Estado_Usuario);
            this.Controls.Add(this.Lbl_Rol_Usuario);
            this.Controls.Add(this.Lbl_Descripcion_Producto);
            this.Controls.Add(this.Lbl_Nombre_Producto);
            this.Controls.Add(this.Lbl_Codigo_Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Id_Producto;
        private System.Windows.Forms.Button Btn_Eliminar_Producto;
        private System.Windows.Forms.Button Btn_Guardar_Producto;
        private System.Windows.Forms.ComboBox CBox_Estado_Producto;
        private System.Windows.Forms.ComboBox CBox_Categoria_Producto;
        private System.Windows.Forms.TextBox Txt_Descripcion_Producto;
        private System.Windows.Forms.TextBox Txt_Nombre_Producto;
        private System.Windows.Forms.TextBox Txt_Codigo_Producto;
        private System.Windows.Forms.Label Lbl_Estado_Usuario;
        private System.Windows.Forms.Label Lbl_Rol_Usuario;
        private System.Windows.Forms.Label Lbl_Descripcion_Producto;
        private System.Windows.Forms.Label Lbl_Nombre_Producto;
        private System.Windows.Forms.Label Lbl_Codigo_Producto;
        private System.Windows.Forms.TextBox Txt_Indice;
        private System.Windows.Forms.Button Btn_Limpiar_Producto;
        private System.Windows.Forms.Label Titulo_Main_Productos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Separador;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.ComboBox CBox_Busqueda;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView GridView_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT_DISPONIBLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}