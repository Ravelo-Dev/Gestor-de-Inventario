using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
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

        private void Btn_Ocultar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Ocultar.BackColor = Color.FromArgb(31, 30, 30);
        }

        private void Btn_Ocultar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Ocultar.BackColor = Color.FromArgb(12, 12, 12);
        }

        private void Btn_Ocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //bool vai = false;

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            //vai = true;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            /* if (vai == true)
             {
                 this.Location = Cursor.Position;
             }*/
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            //vai = false;
        }



        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Entrar_Click(object sender, EventArgs e)
        {
            Usuarios_sys OBJ_USUARIO = new CN_Usuarios().Llenar().Where(U => U.DOCUMENTO == Txt_No_Cedula.Text && U.PASSWORD == Txt_Password.Text).FirstOrDefault(); 

            if(OBJ_USUARIO != null)
            {
                GUI gUI = new GUI(OBJ_USUARIO);
                gUI.Show();
                this.Hide();

                gUI.FormClosing += Cerrando;
            }
            else
            {
                MessageBox.Show("USUARIO NO REGISTRADO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
        }

        private void Cerrando(object sender, FormClosingEventArgs e)
        {
            Txt_No_Cedula.Text = "";
            Txt_Password.Text = "";

            this.Show();
        }

        private void Btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Cancelar.BackColor = System.Drawing.Color.Crimson;
        }

        private void Btn_Entrar_MouseLeave(object sender, EventArgs e)
        {
            Btn_Entrar.BackColor = System.Drawing.Color.Crimson;
        }

        private void Btn_Entrar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Entrar.BackColor = Color.FromArgb(223, 73, 103);
        }

        private void Btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            Btn_Cancelar.BackColor = Color.FromArgb(223, 73, 103);
        }
    }
}
