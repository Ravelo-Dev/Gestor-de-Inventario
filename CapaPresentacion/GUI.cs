using CapaEntidad;
using CapaNegocios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class GUI : Form
    {
        private static Usuarios_sys UsuarioActual;
        private static Button BtnActivo = null;
        private static Form FormularioActivo = null;

        public GUI(Usuarios_sys OBJ_USUARIO = null)
        {
            if (OBJ_USUARIO == null)

                UsuarioActual = new Usuarios_sys()
                {
                    NOMBRE = "ADMIN-CREADOR",
                    ID_USUARIO = 1
                };

            else
                UsuarioActual = OBJ_USUARIO;

            InitializeComponent();
            PersonalizarDiseno();


        }

        private void GUI_Load(object sender, EventArgs e)
        {

            List<Permisos_sys> Lista_Permisos = new CN_Permisos().Llenar(UsuarioActual.ID_USUARIO);

            foreach (Control control in this.Panel_Menu_Lateral.Controls)
            {
                if (control is Button)
                {
                    bool Encontrado = Lista_Permisos.Any(m => m.NOMBRE_MENU == control.Name);
                    if (Encontrado == false)
                    {
                        control.Visible = false;
                    }
                }

            }

            Lbl_Usuario.Text = UsuarioActual.NOMBRE;
        }

        private void PersonalizarDiseno()
        {
            PanelSubMenu.Visible = false;
            PanelSubMenu_Compras.Visible = false;
            PanelSubMenu_Ventas.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (PanelSubMenu.Visible == true)
            {
                PanelSubMenu.Visible = false;
            }
            if (PanelSubMenu_Compras.Visible == true)
            {
                PanelSubMenu_Compras.Visible = false;
            }
            if (PanelSubMenu_Ventas.Visible == true)
            {
                PanelSubMenu_Ventas.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }

        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cerrar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cerrar.BackColor = System.Drawing.Color.Crimson;
        }

        private void Btn_Cerrar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cerrar.BackColor = Color.FromArgb(12, 12, 12);
        }

        private void Btn_Ocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Ocultar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Ocultar.BackColor = Color.FromArgb(31, 30, 30);
        }

        private void Btn_Ocultar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Ocultar.BackColor = Color.FromArgb(12, 12, 12);
        }

        private void Btn_Menu_Mantenimiento_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenu);
        }

        private void Btn_Categoria_Click(object sender, EventArgs e)
        {

            AbrirForm(Btn_Menu_Mantenimiento, new Categoria());
            OcultarSubMenu();
        }

        private void Btn_Producto_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Mantenimiento, new Producto());
            OcultarSubMenu();
        }

        private void AbrirForm(Button Btn, Form Formulario)
        {
            if (BtnActivo != null)
            {
                BtnActivo.BackColor = System.Drawing.Color.Crimson;
            }
            Btn.BackColor = Color.FromArgb(231, 61, 95);
            BtnActivo = Btn;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();

            }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;

            Contenedor.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void Btn_Menu_Usuario_Click(object sender, EventArgs e)
        {
            AbrirForm((Button)sender, new Usuario());

        }

        private void Btn_Registrar_Venta_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Ventas, new Venta(UsuarioActual));
            OcultarSubMenu();
        }

        private void Btn_Detalles_Venta_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Ventas, new Detalle_Venta());
            OcultarSubMenu();
        }

        private void Btn_Registrar_Compra_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Compras, new Compra(UsuarioActual));
            OcultarSubMenu();
        }

        private void Btn_Detalle_Compra_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Compras, new Detalle_Compras());
            OcultarSubMenu();
        }

        private void Btn_Menu_Clientes_Click(object sender, EventArgs e)
        {
            AbrirForm((Button)sender, new Cliente());
        }

        private void Btn_Menu_Proveedores_Click(object sender, EventArgs e)
        {
            AbrirForm((Button)sender, new Proveedor());
        }

        private void Btn_Menu_Reportes_Click(object sender, EventArgs e)
        {
            AbrirForm((Button)sender, new Reportes());
        }

        private void Btn_Menu_AcercaDe_Click(object sender, EventArgs e)
        {
            AbrirForm((Button)sender, new AcercaDe());
        }

        private void Btn_Menu_Ventas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenu_Ventas);
        }

        private void Btn_Menu_Compras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSubMenu_Compras);
        }

        private void Btn_Negocio_Click(object sender, EventArgs e)
        {
            AbrirForm(Btn_Menu_Mantenimiento, new Negocio());
            OcultarSubMenu();
        }
    }
}
