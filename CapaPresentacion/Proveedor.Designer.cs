namespace CapaPresentacion
{
    partial class Proveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor));
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.CBox_Busqueda = new System.Windows.Forms.ComboBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Separador = new System.Windows.Forms.Label();
            this.Txt_Id_Proveedor = new System.Windows.Forms.TextBox();
            this.GridView_Proveedor = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Titulo_Main_Proveedor = new System.Windows.Forms.Label();
            this.Btn_Eliminar_Proveedor = new System.Windows.Forms.Button();
            this.Btn_Guardar_Proveedor = new System.Windows.Forms.Button();
            this.CBox_Estado_Proveedor = new System.Windows.Forms.ComboBox();
            this.Txt_Telefono_Proveedor = new System.Windows.Forms.TextBox();
            this.Txt_Razon_Proveedor = new System.Windows.Forms.TextBox();
            this.Txt_No_Doc_Proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_Estado_Proveedor = new System.Windows.Forms.Label();
            this.Lbl_Telefono_Proveedor = new System.Windows.Forms.Label();
            this.Lbl_Razon_Proveedor = new System.Windows.Forms.Label();
            this.Lbl_No_Doc_Proveedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Correo_Proveedor = new System.Windows.Forms.TextBox();
            this.Txt_Indice = new System.Windows.Forms.TextBox();
            this.Btn_Limpiar_Proveedor = new System.Windows.Forms.Button();
            this.ID_PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Btn_Buscar.Location = new System.Drawing.Point(566, 297);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Buscar.TabIndex = 78;
            this.Btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(388, 310);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.PasswordChar = '●';
            this.Txt_Busqueda.Size = new System.Drawing.Size(172, 20);
            this.Txt_Busqueda.TabIndex = 77;
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Buscar.Location = new System.Drawing.Point(162, 313);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Buscar.TabIndex = 76;
            this.Lbl_Buscar.Text = "Buscar Por:";
            // 
            // CBox_Busqueda
            // 
            this.CBox_Busqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Busqueda.FormattingEnabled = true;
            this.CBox_Busqueda.Location = new System.Drawing.Point(246, 310);
            this.CBox_Busqueda.Name = "CBox_Busqueda";
            this.CBox_Busqueda.Size = new System.Drawing.Size(133, 21);
            this.CBox_Busqueda.TabIndex = 75;
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
            this.Btn_Limpiar.Location = new System.Drawing.Point(619, 297);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(47, 49);
            this.Btn_Limpiar.TabIndex = 74;
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Separador
            // 
            this.Separador.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Separador.Location = new System.Drawing.Point(13, 276);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(665, 18);
            this.Separador.TabIndex = 73;
            this.Separador.Text = "_________________________________________________________________________________" +
    "_________________________________________";
            this.Separador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Id_Proveedor
            // 
            this.Txt_Id_Proveedor.Location = new System.Drawing.Point(272, 31);
            this.Txt_Id_Proveedor.Name = "Txt_Id_Proveedor";
            this.Txt_Id_Proveedor.Size = new System.Drawing.Size(20, 20);
            this.Txt_Id_Proveedor.TabIndex = 72;
            this.Txt_Id_Proveedor.Text = "0";
            this.Txt_Id_Proveedor.Visible = false;
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
            this.RAZON_SOCIAL,
            this.CORREO,
            this.TELEFONO,
            this.ESTADO_VALOR,
            this.ESTADO});
            this.GridView_Proveedor.Location = new System.Drawing.Point(10, 360);
            this.GridView_Proveedor.MultiSelect = false;
            this.GridView_Proveedor.Name = "GridView_Proveedor";
            this.GridView_Proveedor.ReadOnly = true;
            this.GridView_Proveedor.Size = new System.Drawing.Size(668, 189);
            this.GridView_Proveedor.TabIndex = 71;
            this.GridView_Proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Proveedor_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo_Main_Proveedor
            // 
            this.Titulo_Main_Proveedor.AutoSize = true;
            this.Titulo_Main_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Main_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Titulo_Main_Proveedor.Location = new System.Drawing.Point(86, 31);
            this.Titulo_Main_Proveedor.Name = "Titulo_Main_Proveedor";
            this.Titulo_Main_Proveedor.Size = new System.Drawing.Size(180, 20);
            this.Titulo_Main_Proveedor.TabIndex = 69;
            this.Titulo_Main_Proveedor.Text = "Gestion de Proveedores";
            // 
            // Btn_Eliminar_Proveedor
            // 
            this.Btn_Eliminar_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Eliminar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Eliminar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Eliminar_Proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar_Proveedor.Image")));
            this.Btn_Eliminar_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Proveedor.Location = new System.Drawing.Point(318, 214);
            this.Btn_Eliminar_Proveedor.Name = "Btn_Eliminar_Proveedor";
            this.Btn_Eliminar_Proveedor.Size = new System.Drawing.Size(133, 49);
            this.Btn_Eliminar_Proveedor.TabIndex = 68;
            this.Btn_Eliminar_Proveedor.Text = "   Eliminar";
            this.Btn_Eliminar_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Eliminar_Proveedor.Click += new System.EventHandler(this.Btn_Eliminar_Proveedor_Click);
            // 
            // Btn_Guardar_Proveedor
            // 
            this.Btn_Guardar_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Guardar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Guardar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Guardar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Guardar_Proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar_Proveedor.Image")));
            this.Btn_Guardar_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Proveedor.Location = new System.Drawing.Point(31, 214);
            this.Btn_Guardar_Proveedor.Name = "Btn_Guardar_Proveedor";
            this.Btn_Guardar_Proveedor.Size = new System.Drawing.Size(133, 49);
            this.Btn_Guardar_Proveedor.TabIndex = 66;
            this.Btn_Guardar_Proveedor.Text = "   Guardar";
            this.Btn_Guardar_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Guardar_Proveedor.Click += new System.EventHandler(this.Btn_Guardar_Proveedor_Click);
            // 
            // CBox_Estado_Proveedor
            // 
            this.CBox_Estado_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_Estado_Proveedor.FormattingEnabled = true;
            this.CBox_Estado_Proveedor.Location = new System.Drawing.Point(258, 173);
            this.CBox_Estado_Proveedor.Name = "CBox_Estado_Proveedor";
            this.CBox_Estado_Proveedor.Size = new System.Drawing.Size(193, 21);
            this.CBox_Estado_Proveedor.TabIndex = 65;
            // 
            // Txt_Telefono_Proveedor
            // 
            this.Txt_Telefono_Proveedor.Location = new System.Drawing.Point(33, 175);
            this.Txt_Telefono_Proveedor.Name = "Txt_Telefono_Proveedor";
            this.Txt_Telefono_Proveedor.Size = new System.Drawing.Size(190, 20);
            this.Txt_Telefono_Proveedor.TabIndex = 64;
            // 
            // Txt_Razon_Proveedor
            // 
            this.Txt_Razon_Proveedor.Location = new System.Drawing.Point(258, 110);
            this.Txt_Razon_Proveedor.Name = "Txt_Razon_Proveedor";
            this.Txt_Razon_Proveedor.Size = new System.Drawing.Size(190, 20);
            this.Txt_Razon_Proveedor.TabIndex = 63;
            // 
            // Txt_No_Doc_Proveedor
            // 
            this.Txt_No_Doc_Proveedor.Location = new System.Drawing.Point(33, 109);
            this.Txt_No_Doc_Proveedor.Name = "Txt_No_Doc_Proveedor";
            this.Txt_No_Doc_Proveedor.Size = new System.Drawing.Size(190, 20);
            this.Txt_No_Doc_Proveedor.TabIndex = 61;
            // 
            // Lbl_Estado_Proveedor
            // 
            this.Lbl_Estado_Proveedor.AutoSize = true;
            this.Lbl_Estado_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Estado_Proveedor.Location = new System.Drawing.Point(258, 147);
            this.Lbl_Estado_Proveedor.Name = "Lbl_Estado_Proveedor";
            this.Lbl_Estado_Proveedor.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Estado_Proveedor.TabIndex = 60;
            this.Lbl_Estado_Proveedor.Text = "Estado";
            // 
            // Lbl_Telefono_Proveedor
            // 
            this.Lbl_Telefono_Proveedor.AutoSize = true;
            this.Lbl_Telefono_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Telefono_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Telefono_Proveedor.Location = new System.Drawing.Point(30, 147);
            this.Lbl_Telefono_Proveedor.Name = "Lbl_Telefono_Proveedor";
            this.Lbl_Telefono_Proveedor.Size = new System.Drawing.Size(64, 17);
            this.Lbl_Telefono_Proveedor.TabIndex = 59;
            this.Lbl_Telefono_Proveedor.Text = "Telefono";
            // 
            // Lbl_Razon_Proveedor
            // 
            this.Lbl_Razon_Proveedor.AutoSize = true;
            this.Lbl_Razon_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Razon_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_Razon_Proveedor.Location = new System.Drawing.Point(255, 82);
            this.Lbl_Razon_Proveedor.Name = "Lbl_Razon_Proveedor";
            this.Lbl_Razon_Proveedor.Size = new System.Drawing.Size(91, 17);
            this.Lbl_Razon_Proveedor.TabIndex = 58;
            this.Lbl_Razon_Proveedor.Text = "Razon Social";
            // 
            // Lbl_No_Doc_Proveedor
            // 
            this.Lbl_No_Doc_Proveedor.AutoSize = true;
            this.Lbl_No_Doc_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_No_Doc_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Lbl_No_Doc_Proveedor.Location = new System.Drawing.Point(30, 82);
            this.Lbl_No_Doc_Proveedor.Name = "Lbl_No_Doc_Proveedor";
            this.Lbl_No_Doc_Proveedor.Size = new System.Drawing.Size(106, 17);
            this.Lbl_No_Doc_Proveedor.TabIndex = 56;
            this.Lbl_No_Doc_Proveedor.Text = "No. Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(473, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Correo";
            // 
            // Txt_Correo_Proveedor
            // 
            this.Txt_Correo_Proveedor.Location = new System.Drawing.Point(476, 109);
            this.Txt_Correo_Proveedor.Name = "Txt_Correo_Proveedor";
            this.Txt_Correo_Proveedor.Size = new System.Drawing.Size(190, 20);
            this.Txt_Correo_Proveedor.TabIndex = 63;
            // 
            // Txt_Indice
            // 
            this.Txt_Indice.Location = new System.Drawing.Point(298, 31);
            this.Txt_Indice.Name = "Txt_Indice";
            this.Txt_Indice.Size = new System.Drawing.Size(20, 20);
            this.Txt_Indice.TabIndex = 79;
            this.Txt_Indice.Text = "-1";
            this.Txt_Indice.Visible = false;
            // 
            // Btn_Limpiar_Proveedor
            // 
            this.Btn_Limpiar_Proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Btn_Limpiar_Proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Limpiar_Proveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Limpiar_Proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar_Proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Limpiar_Proveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Limpiar_Proveedor.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar_Proveedor.Image")));
            this.Btn_Limpiar_Proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Proveedor.Location = new System.Drawing.Point(175, 214);
            this.Btn_Limpiar_Proveedor.Name = "Btn_Limpiar_Proveedor";
            this.Btn_Limpiar_Proveedor.Size = new System.Drawing.Size(133, 49);
            this.Btn_Limpiar_Proveedor.TabIndex = 80;
            this.Btn_Limpiar_Proveedor.Text = "   Limpiar";
            this.Btn_Limpiar_Proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar_Proveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Limpiar_Proveedor.UseVisualStyleBackColor = false;
            this.Btn_Limpiar_Proveedor.Click += new System.EventHandler(this.Btn_Limpiar_Proveedor_Click);
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
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(689, 559);
            this.Controls.Add(this.Btn_Limpiar_Proveedor);
            this.Controls.Add(this.Txt_Indice);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.CBox_Busqueda);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Separador);
            this.Controls.Add(this.Txt_Id_Proveedor);
            this.Controls.Add(this.GridView_Proveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_Main_Proveedor);
            this.Controls.Add(this.Btn_Eliminar_Proveedor);
            this.Controls.Add(this.Btn_Guardar_Proveedor);
            this.Controls.Add(this.CBox_Estado_Proveedor);
            this.Controls.Add(this.Txt_Telefono_Proveedor);
            this.Controls.Add(this.Txt_Correo_Proveedor);
            this.Controls.Add(this.Txt_Razon_Proveedor);
            this.Controls.Add(this.Txt_No_Doc_Proveedor);
            this.Controls.Add(this.Lbl_Estado_Proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Telefono_Proveedor);
            this.Controls.Add(this.Lbl_Razon_Proveedor);
            this.Controls.Add(this.Lbl_No_Doc_Proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proveedor";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedor_Load);
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
        private System.Windows.Forms.TextBox Txt_Id_Proveedor;
        private System.Windows.Forms.DataGridView GridView_Proveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo_Main_Proveedor;
        private System.Windows.Forms.Button Btn_Eliminar_Proveedor;
        private System.Windows.Forms.Button Btn_Guardar_Proveedor;
        private System.Windows.Forms.ComboBox CBox_Estado_Proveedor;
        private System.Windows.Forms.TextBox Txt_Telefono_Proveedor;
        private System.Windows.Forms.TextBox Txt_Razon_Proveedor;
        private System.Windows.Forms.TextBox Txt_No_Doc_Proveedor;
        private System.Windows.Forms.Label Lbl_Estado_Proveedor;
        private System.Windows.Forms.Label Lbl_Telefono_Proveedor;
        private System.Windows.Forms.Label Lbl_Razon_Proveedor;
        private System.Windows.Forms.Label Lbl_No_Doc_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Correo_Proveedor;
        private System.Windows.Forms.TextBox Txt_Indice;
        private System.Windows.Forms.Button Btn_Limpiar_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}