namespace CapaPresentacion
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.Btn_Ocultar = new System.Windows.Forms.Label();
            this.Btn_Cerrar = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_Menu_Lateral = new System.Windows.Forms.Panel();
            this.Btn_Menu_AcercaDe = new System.Windows.Forms.Button();
            this.Btn_Menu_Reportes = new System.Windows.Forms.Button();
            this.Btn_Menu_Proveedores = new System.Windows.Forms.Button();
            this.Btn_Menu_Clientes = new System.Windows.Forms.Button();
            this.PanelSubMenu_Compras = new System.Windows.Forms.Panel();
            this.Btn_Detalle_Compra = new System.Windows.Forms.Button();
            this.Btn_Registrar_Compra = new System.Windows.Forms.Button();
            this.Btn_Menu_Compras = new System.Windows.Forms.Button();
            this.PanelSubMenu_Ventas = new System.Windows.Forms.Panel();
            this.Btn_Detalles_Venta = new System.Windows.Forms.Button();
            this.Btn_Registrar_Venta = new System.Windows.Forms.Button();
            this.Btn_Menu_Ventas = new System.Windows.Forms.Button();
            this.PanelSubMenu = new System.Windows.Forms.Panel();
            this.Btn_Negocio = new System.Windows.Forms.Button();
            this.Btn_Producto = new System.Windows.Forms.Button();
            this.Btn_Categoria = new System.Windows.Forms.Button();
            this.Btn_Menu_Mantenimiento = new System.Windows.Forms.Button();
            this.Btn_Menu_Usuario = new System.Windows.Forms.Button();
            this.Panel_Logo = new System.Windows.Forms.Panel();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Sesion = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            this.Panel_Menu_Lateral.SuspendLayout();
            this.PanelSubMenu_Compras.SuspendLayout();
            this.PanelSubMenu_Ventas.SuspendLayout();
            this.PanelSubMenu.SuspendLayout();
            this.Panel_Logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ocultar
            // 
            this.Btn_Ocultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Ocultar.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ocultar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ocultar.Location = new System.Drawing.Point(878, 0);
            this.Btn_Ocultar.Name = "Btn_Ocultar";
            this.Btn_Ocultar.Size = new System.Drawing.Size(50, 42);
            this.Btn_Ocultar.TabIndex = 1;
            this.Btn_Ocultar.Text = "-";
            this.Btn_Ocultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Ocultar.Click += new System.EventHandler(this.Btn_Ocultar_Click);
            this.Btn_Ocultar.MouseEnter += new System.EventHandler(this.Btn_Ocultar_MouseEnter);
            this.Btn_Ocultar.MouseLeave += new System.EventHandler(this.Btn_Ocultar_MouseLeave);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cerrar.Location = new System.Drawing.Point(928, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(50, 42);
            this.Btn_Cerrar.TabIndex = 0;
            this.Btn_Cerrar.Text = "X";
            this.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            this.Btn_Cerrar.MouseEnter += new System.EventHandler(this.Btn_Cerrar_MouseEnter);
            this.Btn_Cerrar.MouseLeave += new System.EventHandler(this.Btn_Cerrar_MouseLeave);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.BarraTitulo.Controls.Add(this.panel1);
            this.BarraTitulo.Controls.Add(this.Btn_Ocultar);
            this.BarraTitulo.Controls.Add(this.Btn_Cerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(978, 42);
            this.BarraTitulo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(285, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 22);
            this.panel1.TabIndex = 3;
            // 
            // Panel_Menu_Lateral
            // 
            this.Panel_Menu_Lateral.AutoScroll = true;
            this.Panel_Menu_Lateral.BackColor = System.Drawing.Color.Crimson;
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_AcercaDe);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Reportes);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Proveedores);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Clientes);
            this.Panel_Menu_Lateral.Controls.Add(this.PanelSubMenu_Compras);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Compras);
            this.Panel_Menu_Lateral.Controls.Add(this.PanelSubMenu_Ventas);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Ventas);
            this.Panel_Menu_Lateral.Controls.Add(this.PanelSubMenu);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Mantenimiento);
            this.Panel_Menu_Lateral.Controls.Add(this.Btn_Menu_Usuario);
            this.Panel_Menu_Lateral.Controls.Add(this.Panel_Logo);
            this.Panel_Menu_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu_Lateral.Location = new System.Drawing.Point(0, 42);
            this.Panel_Menu_Lateral.Name = "Panel_Menu_Lateral";
            this.Panel_Menu_Lateral.Size = new System.Drawing.Size(289, 571);
            this.Panel_Menu_Lateral.TabIndex = 2;
            // 
            // Btn_Menu_AcercaDe
            // 
            this.Btn_Menu_AcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_AcercaDe.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_AcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_AcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_AcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_AcercaDe.Image")));
            this.Btn_Menu_AcercaDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_AcercaDe.Location = new System.Drawing.Point(0, 794);
            this.Btn_Menu_AcercaDe.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_AcercaDe.Name = "Btn_Menu_AcercaDe";
            this.Btn_Menu_AcercaDe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_AcercaDe.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_AcercaDe.TabIndex = 24;
            this.Btn_Menu_AcercaDe.Text = "    Acerca De";
            this.Btn_Menu_AcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_AcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_AcercaDe.UseVisualStyleBackColor = true;
            this.Btn_Menu_AcercaDe.Click += new System.EventHandler(this.Btn_Menu_AcercaDe_Click);
            // 
            // Btn_Menu_Reportes
            // 
            this.Btn_Menu_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Reportes.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Reportes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Reportes.Image")));
            this.Btn_Menu_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Reportes.Location = new System.Drawing.Point(0, 740);
            this.Btn_Menu_Reportes.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Reportes.Name = "Btn_Menu_Reportes";
            this.Btn_Menu_Reportes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Reportes.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Reportes.TabIndex = 23;
            this.Btn_Menu_Reportes.Text = "    Reportes";
            this.Btn_Menu_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Reportes.UseVisualStyleBackColor = true;
            this.Btn_Menu_Reportes.Click += new System.EventHandler(this.Btn_Menu_Reportes_Click);
            // 
            // Btn_Menu_Proveedores
            // 
            this.Btn_Menu_Proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Proveedores.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Proveedores.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Proveedores.Image")));
            this.Btn_Menu_Proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Proveedores.Location = new System.Drawing.Point(0, 686);
            this.Btn_Menu_Proveedores.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Proveedores.Name = "Btn_Menu_Proveedores";
            this.Btn_Menu_Proveedores.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Proveedores.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Proveedores.TabIndex = 22;
            this.Btn_Menu_Proveedores.Text = "    Proveedores";
            this.Btn_Menu_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Proveedores.UseVisualStyleBackColor = true;
            this.Btn_Menu_Proveedores.Click += new System.EventHandler(this.Btn_Menu_Proveedores_Click);
            // 
            // Btn_Menu_Clientes
            // 
            this.Btn_Menu_Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Clientes.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Clientes.Image")));
            this.Btn_Menu_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Clientes.Location = new System.Drawing.Point(0, 632);
            this.Btn_Menu_Clientes.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Clientes.Name = "Btn_Menu_Clientes";
            this.Btn_Menu_Clientes.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Clientes.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Clientes.TabIndex = 21;
            this.Btn_Menu_Clientes.Text = "    Clientes";
            this.Btn_Menu_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Clientes.UseVisualStyleBackColor = true;
            this.Btn_Menu_Clientes.Click += new System.EventHandler(this.Btn_Menu_Clientes_Click);
            // 
            // PanelSubMenu_Compras
            // 
            this.PanelSubMenu_Compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.PanelSubMenu_Compras.Controls.Add(this.Btn_Detalle_Compra);
            this.PanelSubMenu_Compras.Controls.Add(this.Btn_Registrar_Compra);
            this.PanelSubMenu_Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu_Compras.Location = new System.Drawing.Point(0, 569);
            this.PanelSubMenu_Compras.Name = "PanelSubMenu_Compras";
            this.PanelSubMenu_Compras.Size = new System.Drawing.Size(272, 63);
            this.PanelSubMenu_Compras.TabIndex = 17;
            // 
            // Btn_Detalle_Compra
            // 
            this.Btn_Detalle_Compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Detalle_Compra.FlatAppearance.BorderSize = 0;
            this.Btn_Detalle_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detalle_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detalle_Compra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Detalle_Compra.Image")));
            this.Btn_Detalle_Compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detalle_Compra.Location = new System.Drawing.Point(0, 63);
            this.Btn_Detalle_Compra.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Detalle_Compra.Name = "Btn_Detalle_Compra";
            this.Btn_Detalle_Compra.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Detalle_Compra.Size = new System.Drawing.Size(272, 48);
            this.Btn_Detalle_Compra.TabIndex = 13;
            this.Btn_Detalle_Compra.Text = "    Detalles";
            this.Btn_Detalle_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detalle_Compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Detalle_Compra.UseVisualStyleBackColor = true;
            this.Btn_Detalle_Compra.Visible = false;
            this.Btn_Detalle_Compra.Click += new System.EventHandler(this.Btn_Detalle_Compra_Click);
            // 
            // Btn_Registrar_Compra
            // 
            this.Btn_Registrar_Compra.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Registrar_Compra.FlatAppearance.BorderSize = 0;
            this.Btn_Registrar_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registrar_Compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar_Compra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registrar_Compra.Image")));
            this.Btn_Registrar_Compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Compra.Location = new System.Drawing.Point(0, 0);
            this.Btn_Registrar_Compra.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Registrar_Compra.Name = "Btn_Registrar_Compra";
            this.Btn_Registrar_Compra.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Registrar_Compra.Size = new System.Drawing.Size(272, 63);
            this.Btn_Registrar_Compra.TabIndex = 12;
            this.Btn_Registrar_Compra.Text = "    Registrar";
            this.Btn_Registrar_Compra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Compra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Registrar_Compra.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Compra.Click += new System.EventHandler(this.Btn_Registrar_Compra_Click);
            // 
            // Btn_Menu_Compras
            // 
            this.Btn_Menu_Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Compras.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Compras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Compras.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Compras.Image")));
            this.Btn_Menu_Compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Compras.Location = new System.Drawing.Point(0, 511);
            this.Btn_Menu_Compras.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Compras.Name = "Btn_Menu_Compras";
            this.Btn_Menu_Compras.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Compras.Size = new System.Drawing.Size(272, 58);
            this.Btn_Menu_Compras.TabIndex = 16;
            this.Btn_Menu_Compras.Text = "    Compras";
            this.Btn_Menu_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Compras.UseVisualStyleBackColor = true;
            this.Btn_Menu_Compras.Click += new System.EventHandler(this.Btn_Menu_Compras_Click);
            // 
            // PanelSubMenu_Ventas
            // 
            this.PanelSubMenu_Ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.PanelSubMenu_Ventas.Controls.Add(this.Btn_Detalles_Venta);
            this.PanelSubMenu_Ventas.Controls.Add(this.Btn_Registrar_Venta);
            this.PanelSubMenu_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu_Ventas.Location = new System.Drawing.Point(0, 449);
            this.PanelSubMenu_Ventas.Name = "PanelSubMenu_Ventas";
            this.PanelSubMenu_Ventas.Size = new System.Drawing.Size(272, 62);
            this.PanelSubMenu_Ventas.TabIndex = 11;
            // 
            // Btn_Detalles_Venta
            // 
            this.Btn_Detalles_Venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Detalles_Venta.FlatAppearance.BorderSize = 0;
            this.Btn_Detalles_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detalles_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detalles_Venta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Detalles_Venta.Image")));
            this.Btn_Detalles_Venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detalles_Venta.Location = new System.Drawing.Point(0, 62);
            this.Btn_Detalles_Venta.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Detalles_Venta.Name = "Btn_Detalles_Venta";
            this.Btn_Detalles_Venta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Detalles_Venta.Size = new System.Drawing.Size(272, 39);
            this.Btn_Detalles_Venta.TabIndex = 12;
            this.Btn_Detalles_Venta.Text = "    Detalles";
            this.Btn_Detalles_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detalles_Venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Detalles_Venta.UseVisualStyleBackColor = true;
            this.Btn_Detalles_Venta.Visible = false;
            this.Btn_Detalles_Venta.Click += new System.EventHandler(this.Btn_Detalles_Venta_Click);
            // 
            // Btn_Registrar_Venta
            // 
            this.Btn_Registrar_Venta.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Registrar_Venta.FlatAppearance.BorderSize = 0;
            this.Btn_Registrar_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registrar_Venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar_Venta.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Registrar_Venta.Image")));
            this.Btn_Registrar_Venta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Venta.Location = new System.Drawing.Point(0, 0);
            this.Btn_Registrar_Venta.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Registrar_Venta.Name = "Btn_Registrar_Venta";
            this.Btn_Registrar_Venta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Registrar_Venta.Size = new System.Drawing.Size(272, 62);
            this.Btn_Registrar_Venta.TabIndex = 11;
            this.Btn_Registrar_Venta.Text = "    Registrar";
            this.Btn_Registrar_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar_Venta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Registrar_Venta.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Venta.Click += new System.EventHandler(this.Btn_Registrar_Venta_Click);
            // 
            // Btn_Menu_Ventas
            // 
            this.Btn_Menu_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Ventas.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Ventas.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Ventas.Image")));
            this.Btn_Menu_Ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Ventas.Location = new System.Drawing.Point(0, 395);
            this.Btn_Menu_Ventas.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Ventas.Name = "Btn_Menu_Ventas";
            this.Btn_Menu_Ventas.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Ventas.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Ventas.TabIndex = 10;
            this.Btn_Menu_Ventas.Text = "    Ventas";
            this.Btn_Menu_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Menu_Ventas.Click += new System.EventHandler(this.Btn_Menu_Ventas_Click);
            // 
            // PanelSubMenu
            // 
            this.PanelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.PanelSubMenu.Controls.Add(this.Btn_Negocio);
            this.PanelSubMenu.Controls.Add(this.Btn_Producto);
            this.PanelSubMenu.Controls.Add(this.Btn_Categoria);
            this.PanelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubMenu.Location = new System.Drawing.Point(0, 230);
            this.PanelSubMenu.Name = "PanelSubMenu";
            this.PanelSubMenu.Size = new System.Drawing.Size(272, 165);
            this.PanelSubMenu.TabIndex = 9;
            // 
            // Btn_Negocio
            // 
            this.Btn_Negocio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Negocio.FlatAppearance.BorderSize = 0;
            this.Btn_Negocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Negocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Negocio.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Negocio.Image")));
            this.Btn_Negocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Negocio.Location = new System.Drawing.Point(0, 108);
            this.Btn_Negocio.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Negocio.Name = "Btn_Negocio";
            this.Btn_Negocio.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Negocio.Size = new System.Drawing.Size(272, 54);
            this.Btn_Negocio.TabIndex = 4;
            this.Btn_Negocio.Text = "    Negocio";
            this.Btn_Negocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Negocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Negocio.UseVisualStyleBackColor = true;
            this.Btn_Negocio.Click += new System.EventHandler(this.Btn_Negocio_Click);
            // 
            // Btn_Producto
            // 
            this.Btn_Producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Producto.FlatAppearance.BorderSize = 0;
            this.Btn_Producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Producto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Producto.Image")));
            this.Btn_Producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Producto.Location = new System.Drawing.Point(0, 54);
            this.Btn_Producto.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Producto.Name = "Btn_Producto";
            this.Btn_Producto.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Producto.Size = new System.Drawing.Size(272, 54);
            this.Btn_Producto.TabIndex = 3;
            this.Btn_Producto.Text = "    Productos";
            this.Btn_Producto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Producto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Producto.UseVisualStyleBackColor = true;
            this.Btn_Producto.Click += new System.EventHandler(this.Btn_Producto_Click);
            // 
            // Btn_Categoria
            // 
            this.Btn_Categoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Categoria.FlatAppearance.BorderSize = 0;
            this.Btn_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Categoria.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Categoria.Image")));
            this.Btn_Categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Categoria.Location = new System.Drawing.Point(0, 0);
            this.Btn_Categoria.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Categoria.Name = "Btn_Categoria";
            this.Btn_Categoria.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Categoria.Size = new System.Drawing.Size(272, 54);
            this.Btn_Categoria.TabIndex = 2;
            this.Btn_Categoria.Text = "    Categorias";
            this.Btn_Categoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Categoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Categoria.UseVisualStyleBackColor = true;
            this.Btn_Categoria.Click += new System.EventHandler(this.Btn_Categoria_Click);
            // 
            // Btn_Menu_Mantenimiento
            // 
            this.Btn_Menu_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Mantenimiento.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Mantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Mantenimiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Menu_Mantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Mantenimiento.Image")));
            this.Btn_Menu_Mantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Mantenimiento.Location = new System.Drawing.Point(0, 176);
            this.Btn_Menu_Mantenimiento.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Mantenimiento.Name = "Btn_Menu_Mantenimiento";
            this.Btn_Menu_Mantenimiento.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Mantenimiento.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Mantenimiento.TabIndex = 2;
            this.Btn_Menu_Mantenimiento.Text = "    Mantenimiento";
            this.Btn_Menu_Mantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Mantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Mantenimiento.UseVisualStyleBackColor = true;
            this.Btn_Menu_Mantenimiento.Click += new System.EventHandler(this.Btn_Menu_Mantenimiento_Click);
            // 
            // Btn_Menu_Usuario
            // 
            this.Btn_Menu_Usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Menu_Usuario.FlatAppearance.BorderSize = 0;
            this.Btn_Menu_Usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Menu_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Menu_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Menu_Usuario.Image")));
            this.Btn_Menu_Usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Usuario.Location = new System.Drawing.Point(0, 122);
            this.Btn_Menu_Usuario.Margin = new System.Windows.Forms.Padding(9);
            this.Btn_Menu_Usuario.Name = "Btn_Menu_Usuario";
            this.Btn_Menu_Usuario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Btn_Menu_Usuario.Size = new System.Drawing.Size(272, 54);
            this.Btn_Menu_Usuario.TabIndex = 1;
            this.Btn_Menu_Usuario.Text = "    Usuarios";
            this.Btn_Menu_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Menu_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Menu_Usuario.UseVisualStyleBackColor = true;
            this.Btn_Menu_Usuario.Click += new System.EventHandler(this.Btn_Menu_Usuario_Click);
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.Controls.Add(this.Lbl_Usuario);
            this.Panel_Logo.Controls.Add(this.Sesion);
            this.Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(272, 122);
            this.Panel_Logo.TabIndex = 0;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(61, 20);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(63, 13);
            this.Lbl_Usuario.TabIndex = 1;
            this.Lbl_Usuario.Text = "Lbl_Usuario";
            // 
            // Sesion
            // 
            this.Sesion.AutoSize = true;
            this.Sesion.Location = new System.Drawing.Point(3, 20);
            this.Sesion.Name = "Sesion";
            this.Sesion.Size = new System.Drawing.Size(52, 13);
            this.Sesion.TabIndex = 0;
            this.Sesion.Text = "Usuario : ";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Contenedor.Location = new System.Drawing.Point(289, 42);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(689, 559);
            this.Contenedor.TabIndex = 3;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(978, 613);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Panel_Menu_Lateral);
            this.Controls.Add(this.BarraTitulo);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GUI";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GUI_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.Panel_Menu_Lateral.ResumeLayout(false);
            this.PanelSubMenu_Compras.ResumeLayout(false);
            this.PanelSubMenu_Ventas.ResumeLayout(false);
            this.PanelSubMenu.ResumeLayout(false);
            this.Panel_Logo.ResumeLayout(false);
            this.Panel_Logo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Btn_Ocultar;
        private System.Windows.Forms.Label Btn_Cerrar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel Panel_Menu_Lateral;
        private System.Windows.Forms.Button Btn_Menu_Mantenimiento;
        private System.Windows.Forms.Button Btn_Menu_Usuario;
        private System.Windows.Forms.Panel Panel_Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel PanelSubMenu;
        private System.Windows.Forms.Button Btn_Producto;
        private System.Windows.Forms.Button Btn_Categoria;
        private System.Windows.Forms.Button Btn_Menu_Ventas;
        private System.Windows.Forms.Button Btn_Menu_Compras;
        private System.Windows.Forms.Panel PanelSubMenu_Ventas;
        private System.Windows.Forms.Button Btn_Detalles_Venta;
        private System.Windows.Forms.Button Btn_Registrar_Venta;
        private System.Windows.Forms.Button Btn_Menu_AcercaDe;
        private System.Windows.Forms.Button Btn_Menu_Reportes;
        private System.Windows.Forms.Button Btn_Menu_Proveedores;
        private System.Windows.Forms.Button Btn_Menu_Clientes;
        private System.Windows.Forms.Panel PanelSubMenu_Compras;
        private System.Windows.Forms.Button Btn_Detalle_Compra;
        private System.Windows.Forms.Button Btn_Registrar_Compra;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Sesion;
        private System.Windows.Forms.Button Btn_Negocio;
    }
}

