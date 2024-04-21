namespace CapaPresentacion
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.CBox_Busqueda = new System.Windows.Forms.ComboBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Separador = new System.Windows.Forms.Label();
            this.Txt_Id_Cliente = new System.Windows.Forms.TextBox();
            this.GridView_Cliente = new System.Windows.Forms.DataGridView();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Main_Cliente = new System.Windows.Forms.Label();
            this.Btn_Eliminar_Cliente = new System.Windows.Forms.Button();
            this.Btn_Guardar_Cliente = new System.Windows.Forms.Button();
            this.CBox_Estado_Cliente = new System.Windows.Forms.ComboBox();
            this.Txt_Telefono_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Correo_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.Txt_No_Doc_Cliente = new System.Windows.Forms.TextBox();
            this.Lbl_Estado_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Telefono_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Correo_Cliente = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Cliente = new System.Windows.Forms.Label();
            this.Lbl_No_Doc_Cliente = new System.Windows.Forms.Label();
            this.Txt_Indice = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar_Cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cliente)).BeginInit();
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
            this.Btn_Buscar.Location = new System.Drawing.Point(557, 295);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Buscar.TabIndex = 55;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(379, 308);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.PasswordChar = '●';
            this.Txt_Busqueda.Size = new System.Drawing.Size(172, 20);
            this.Txt_Busqueda.TabIndex = 54;
            this.Txt_Busqueda.TextChanged += new System.EventHandler(this.Txt_Busqueda_TextChanged);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Buscar.Location = new System.Drawing.Point(153, 311);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Buscar.TabIndex = 53;
            this.Lbl_Buscar.Text = "Buscar Por:";
            this.Lbl_Buscar.Click += new System.EventHandler(this.Lbl_Buscar_Click);
            // 
            // CBox_Busqueda
            // 
            this.CBox_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Busqueda.FormattingEnabled = true;
            this.CBox_Busqueda.Location = new System.Drawing.Point(237, 308);
            this.CBox_Busqueda.Name = "CBox_Busqueda";
            this.CBox_Busqueda.Size = new System.Drawing.Size(133, 21);
            this.CBox_Busqueda.TabIndex = 52;
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
            this.Btn_Limpiar.Location = new System.Drawing.Point(610, 295);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Limpiar.TabIndex = 51;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Separador
            // 
            this.Separador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Separador.Location = new System.Drawing.Point(11, 276);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(665, 18);
            this.Separador.TabIndex = 50;
            this.Separador.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            this.Separador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Separador.Click += new System.EventHandler(this.Separador_Click);
            // 
            // Txt_Id_Cliente
            // 
            this.Txt_Id_Cliente.Location = new System.Drawing.Point(246, 31);
            this.Txt_Id_Cliente.Name = "Txt_Id_Cliente";
            this.Txt_Id_Cliente.Size = new System.Drawing.Size(20, 20);
            this.Txt_Id_Cliente.TabIndex = 49;
            this.Txt_Id_Cliente.Text = "0";
            this.Txt_Id_Cliente.Visible = false;
            // 
            // GridView_Cliente
            // 
            this.GridView_Cliente.AllowUserToAddRows = false;
            this.GridView_Cliente.AllowUserToDeleteRows = false;
            this.GridView_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CLIENTE,
            this.DOCUMENTO,
            this.NOMBRE,
            this.CORREO,
            this.TELEFONO,
            this.ESTADO_VALOR,
            this.ESTADO});
            this.GridView_Cliente.Location = new System.Drawing.Point(10, 352);
            this.GridView_Cliente.MultiSelect = false;
            this.GridView_Cliente.Name = "GridView_Cliente";
            this.GridView_Cliente.ReadOnly = true;
            this.GridView_Cliente.Size = new System.Drawing.Size(668, 189);
            this.GridView_Cliente.TabIndex = 48;
            this.GridView_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Cliente_CellClick);
            this.GridView_Cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Cliente_CellContentClick);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.HeaderText = "ID_CLIENTE";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            this.ID_CLIENTE.Visible = false;
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.HeaderText = "No. DOCUMENTO";
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // CORREO
            // 
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            this.CORREO.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.Visible = false;
            // 
            // ESTADO_VALOR
            // 
            this.ESTADO_VALOR.HeaderText = "ESTADO VALOR";
            this.ESTADO_VALOR.Name = "ESTADO_VALOR";
            this.ESTADO_VALOR.ReadOnly = true;
            this.ESTADO_VALOR.Visible = false;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Titulo_Main_Cliente
            // 
            this.Titulo_Main_Cliente.AutoSize = true;
            this.Titulo_Main_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Cliente.Location = new System.Drawing.Point(86, 31);
            this.Titulo_Main_Cliente.Name = "Titulo_Main_Cliente";
            this.Titulo_Main_Cliente.Size = new System.Drawing.Size(148, 20);
            this.Titulo_Main_Cliente.TabIndex = 46;
            this.Titulo_Main_Cliente.Text = "Gestion de Clientes";
            this.Titulo_Main_Cliente.Click += new System.EventHandler(this.Titulo_Main_Cliente_Click);
            // 
            // Btn_Eliminar_Cliente
            // 
            this.Btn_Eliminar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Eliminar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Cliente.Image")));
            this.Btn_Eliminar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Cliente.Location = new System.Drawing.Point(318, 224);
            this.Btn_Eliminar_Cliente.Name = "Btn_Eliminar_Cliente";
            this.Btn_Eliminar_Cliente.Size = new System.Drawing.Size(133, 49);
            this.Btn_Eliminar_Cliente.TabIndex = 45;
            this.Btn_Eliminar_Cliente.Text = "   Eliminar";
            this.Btn_Eliminar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Cliente.Click += new System.EventHandler(this.Btn_Eliminar_Cliente_Click);
            // 
            // Btn_Guardar_Cliente
            // 
            this.Btn_Guardar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Guardar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Guardar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Cliente.Image")));
            this.Btn_Guardar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Cliente.Location = new System.Drawing.Point(31, 224);
            this.Btn_Guardar_Cliente.Name = "Btn_Guardar_Cliente";
            this.Btn_Guardar_Cliente.Size = new System.Drawing.Size(133, 49);
            this.Btn_Guardar_Cliente.TabIndex = 43;
            this.Btn_Guardar_Cliente.Text = "   Guardar";
            this.Btn_Guardar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Cliente.Click += new System.EventHandler(this.Btn_Guardar_Cliente_Click);
            // 
            // CBox_Estado_Cliente
            // 
            this.CBox_Estado_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Estado_Cliente.FormattingEnabled = true;
            this.CBox_Estado_Cliente.Location = new System.Drawing.Point(254, 179);
            this.CBox_Estado_Cliente.Name = "CBox_Estado_Cliente";
            this.CBox_Estado_Cliente.Size = new System.Drawing.Size(193, 21);
            this.CBox_Estado_Cliente.TabIndex = 42;
            // 
            // Txt_Telefono_Cliente
            // 
            this.Txt_Telefono_Cliente.Location = new System.Drawing.Point(33, 179);
            this.Txt_Telefono_Cliente.Name = "Txt_Telefono_Cliente";
            this.Txt_Telefono_Cliente.Size = new System.Drawing.Size(190, 20);
            this.Txt_Telefono_Cliente.TabIndex = 39;
            // 
            // Txt_Correo_Cliente
            // 
            this.Txt_Correo_Cliente.Location = new System.Drawing.Point(467, 110);
            this.Txt_Correo_Cliente.Name = "Txt_Correo_Cliente";
            this.Txt_Correo_Cliente.Size = new System.Drawing.Size(190, 20);
            this.Txt_Correo_Cliente.TabIndex = 38;
            // 
            // Txt_Nombre_Cliente
            // 
            this.Txt_Nombre_Cliente.Location = new System.Drawing.Point(251, 109);
            this.Txt_Nombre_Cliente.Name = "Txt_Nombre_Cliente";
            this.Txt_Nombre_Cliente.Size = new System.Drawing.Size(190, 20);
            this.Txt_Nombre_Cliente.TabIndex = 37;
            // 
            // Txt_No_Doc_Cliente
            // 
            this.Txt_No_Doc_Cliente.Location = new System.Drawing.Point(33, 109);
            this.Txt_No_Doc_Cliente.Name = "Txt_No_Doc_Cliente";
            this.Txt_No_Doc_Cliente.Size = new System.Drawing.Size(190, 20);
            this.Txt_No_Doc_Cliente.TabIndex = 36;
            // 
            // Lbl_Estado_Usuario
            // 
            this.Lbl_Estado_Usuario.AutoSize = true;
            this.Lbl_Estado_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Usuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Estado_Usuario.Location = new System.Drawing.Point(254, 151);
            this.Lbl_Estado_Usuario.Name = "Lbl_Estado_Usuario";
            this.Lbl_Estado_Usuario.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Estado_Usuario.TabIndex = 35;
            this.Lbl_Estado_Usuario.Text = "Estado";
            // 
            // Lbl_Telefono_Cliente
            // 
            this.Lbl_Telefono_Cliente.AutoSize = true;
            this.Lbl_Telefono_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefono_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Telefono_Cliente.Location = new System.Drawing.Point(30, 151);
            this.Lbl_Telefono_Cliente.Name = "Lbl_Telefono_Cliente";
            this.Lbl_Telefono_Cliente.Size = new System.Drawing.Size(64, 17);
            this.Lbl_Telefono_Cliente.TabIndex = 32;
            this.Lbl_Telefono_Cliente.Text = "Telefono";
            // 
            // Lbl_Correo_Cliente
            // 
            this.Lbl_Correo_Cliente.AutoSize = true;
            this.Lbl_Correo_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Correo_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Correo_Cliente.Location = new System.Drawing.Point(464, 82);
            this.Lbl_Correo_Cliente.Name = "Lbl_Correo_Cliente";
            this.Lbl_Correo_Cliente.Size = new System.Drawing.Size(51, 17);
            this.Lbl_Correo_Cliente.TabIndex = 31;
            this.Lbl_Correo_Cliente.Text = "Correo";
            // 
            // Lbl_Nombre_Cliente
            // 
            this.Lbl_Nombre_Cliente.AutoSize = true;
            this.Lbl_Nombre_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Nombre_Cliente.Location = new System.Drawing.Point(248, 82);
            this.Lbl_Nombre_Cliente.Name = "Lbl_Nombre_Cliente";
            this.Lbl_Nombre_Cliente.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Nombre_Cliente.TabIndex = 30;
            this.Lbl_Nombre_Cliente.Text = "Nombre";
            // 
            // Lbl_No_Doc_Cliente
            // 
            this.Lbl_No_Doc_Cliente.AutoSize = true;
            this.Lbl_No_Doc_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Doc_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_No_Doc_Cliente.Location = new System.Drawing.Point(30, 82);
            this.Lbl_No_Doc_Cliente.Name = "Lbl_No_Doc_Cliente";
            this.Lbl_No_Doc_Cliente.Size = new System.Drawing.Size(106, 17);
            this.Lbl_No_Doc_Cliente.TabIndex = 29;
            this.Lbl_No_Doc_Cliente.Text = "No. Documento";
            // 
            // Txt_Indice
            // 
            this.Txt_Indice.Location = new System.Drawing.Point(272, 31);
            this.Txt_Indice.Name = "Txt_Indice";
            this.Txt_Indice.Size = new System.Drawing.Size(20, 20);
            this.Txt_Indice.TabIndex = 56;
            this.Txt_Indice.Text = "-1";
            this.Txt_Indice.Visible = false;
            // 
            // Btn_Limpiar_Cliente
            // 
            this.Btn_Limpiar_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Limpiar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar_Cliente.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Limpiar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Cliente.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Limpiar_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Cliente.Image")));
            this.Btn_Limpiar_Cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Cliente.Location = new System.Drawing.Point(174, 224);
            this.Btn_Limpiar_Cliente.Name = "Btn_Limpiar_Cliente";
            this.Btn_Limpiar_Cliente.Size = new System.Drawing.Size(133, 49);
            this.Btn_Limpiar_Cliente.TabIndex = 57;
            this.Btn_Limpiar_Cliente.Text = "   Limpiar";
            this.Btn_Limpiar_Cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Cliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar_Cliente.UseVisualStyleBackColor = false;
            this.Btn_Limpiar_Cliente.Click += new System.EventHandler(this.Btn_Limpiar_Cliente_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 559);
            this.Controls.Add(this.Btn_Limpiar_Cliente);
            this.Controls.Add(this.Txt_Indice);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.CBox_Busqueda);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.Txt_Id_Cliente);
            this.Controls.Add(this.GridView_Cliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Cliente);
            this.Controls.Add(this.Btn_Eliminar_Cliente);
            this.Controls.Add(this.Btn_Guardar_Cliente);
            this.Controls.Add(this.CBox_Estado_Cliente);
            this.Controls.Add(this.Txt_Telefono_Cliente);
            this.Controls.Add(this.Txt_Correo_Cliente);
            this.Controls.Add(this.Txt_Nombre_Cliente);
            this.Controls.Add(this.Txt_No_Doc_Cliente);
            this.Controls.Add(this.Lbl_Estado_Usuario);
            this.Controls.Add(this.Lbl_Telefono_Cliente);
            this.Controls.Add(this.Lbl_Correo_Cliente);
            this.Controls.Add(this.Lbl_Nombre_Cliente);
            this.Controls.Add(this.Lbl_No_Doc_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Cliente)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_Id_Cliente;
        private System.Windows.Forms.DataGridView GridView_Cliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo_Main_Cliente;
        private System.Windows.Forms.Button Btn_Eliminar_Cliente;
        private System.Windows.Forms.Button Btn_Guardar_Cliente;
        private System.Windows.Forms.ComboBox CBox_Estado_Cliente;
        private System.Windows.Forms.TextBox Txt_Telefono_Cliente;
        private System.Windows.Forms.TextBox Txt_Correo_Cliente;
        private System.Windows.Forms.TextBox Txt_Nombre_Cliente;
        private System.Windows.Forms.TextBox Txt_No_Doc_Cliente;
        private System.Windows.Forms.Label Lbl_Estado_Usuario;
        private System.Windows.Forms.Label Lbl_Telefono_Cliente;
        private System.Windows.Forms.Label Lbl_Correo_Cliente;
        private System.Windows.Forms.Label Lbl_Nombre_Cliente;
        private System.Windows.Forms.Label Lbl_No_Doc_Cliente;
        private System.Windows.Forms.TextBox Txt_Indice;
        private System.Windows.Forms.Button Btn_Limpiar_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}