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
using System.IO;

namespace CapaPresentacion
{
    public partial class Negocio : Form
    {
        public Negocio()
        {
            InitializeComponent();
        }

        public Image ByteToImagen(byte[] ImagenBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(ImagenBytes,0,ImagenBytes.Length);
            Image Imagen = new Bitmap(ms);
            return Imagen;
        }

        private void Negocio_Load(object sender, EventArgs e)
        {
            bool Obtenido = true;
            byte[] byteImangen = new CN_Negocio().ObtenerLogo(out Obtenido);

            if (Obtenido)
                pictureBox2.Image = ByteToImagen(byteImangen);

            Negocios Datos = new CN_Negocio().LlenarDatos();

            Txt_Nombre_Negocio.Text = Datos.NOMBRE;
            Txt_RNC_Negocio.Text = Datos.RNC;
            Txt_Direccion_Negocio.Text = Datos.DIRECCION;
        }

        private void Btn_Subir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Files|*.jpg;*.jpeg;*.png";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimagen = File.ReadAllBytes(dlg.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimagen, out mensaje);

                if (respuesta)
                {
                    pictureBox2.Image = ByteToImagen(byteimagen);

                }
                else
                {
                    MessageBox.Show(mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        
                }
       
       }    }
    }
}
