using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Funciones_Extras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        void LimpiarCampos()
        {
            Txt_Indice.Text = "-1";
            Txt_Id_Cliente.Text = "0";
            Txt_No_Doc_Cliente.Text = "";
            Txt_Nombre_Cliente.Text = "";
            Txt_Correo_Cliente.Text = "";
            Txt_Telefono_Cliente.Text = "";
            CBox_Estado_Cliente.SelectedIndex = 0;

            Txt_No_Doc_Cliente.Select();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CBox_Estado_Cliente.Items.Add(new Opcion_ComboBox()
            {
                Valor = 1,
                Texto = "Activo"
            });

            CBox_Estado_Cliente.Items.Add(new Opcion_ComboBox()
            {
                Valor = 0,
                Texto = "Inactivo"
            });

            CBox_Estado_Cliente.DisplayMember = "Texto";
            CBox_Estado_Cliente.ValueMember = "Valor";
            CBox_Estado_Cliente.SelectedIndex = 0;


            foreach (DataGridViewColumn Columna in GridView_Cliente.Columns)
            {
                if (Columna.Visible == true)
                {
                    CBox_Busqueda.Items.Add(new Opcion_ComboBox()
                    {
                        Valor = Columna.Name,
                        Texto = Columna.HeaderText
                    });
                }
            }
            CBox_Busqueda.DisplayMember = "Texto";
            CBox_Busqueda.ValueMember = "Valor";
            CBox_Busqueda.SelectedIndex = 0;

            //MOSTTRANDO CLIENTE

            List<Clientes> Lista_Clientes = new CN_Clientes().Llenar();

            if (Lista_Clientes != null && Lista_Clientes.Count > 0)
            {
                foreach (Clientes item in Lista_Clientes)
                {
                    GridView_Cliente.Rows.Add(new object[]
                {
                    item.ID_CLIENTE,
                    item.DOCUMENTO,
                    item.NOMBRE,
                    item.CORREO,
                    item.TELEFONO,
                    item.ESTADO == true ? 1 : 0,
                    item.ESTADO == true ? "Activo" : "Inactivo"
                });

                }
            }
            else
            {
                MessageBox.Show("NO HAY DATOS EN LA TABLA");
            }

        }

        private void Btn_Guardar_Cliente_Click(object sender, EventArgs e)
        {
            string MENSAJE = string.Empty;
            Clientes obj_Clientes = new Clientes()
            {
                ID_CLIENTE = Convert.ToInt32(Txt_Id_Cliente.Text),
                DOCUMENTO = Txt_No_Doc_Cliente.Text,
                NOMBRE = Txt_Nombre_Cliente.Text,
                CORREO = Txt_Correo_Cliente.Text,
                TELEFONO = Txt_Telefono_Cliente.Text,
                ESTADO = Convert.ToInt32(((Opcion_ComboBox)CBox_Estado_Cliente.SelectedItem).Valor) == 1 ? true : false,
            };

            if (obj_Clientes.ID_CLIENTE == 0)
            {
                int Id_Cliente_Generado = new CN_Clientes().Insertar(obj_Clientes, out MENSAJE);

                if (Id_Cliente_Generado != 0)
                {
                    GridView_Cliente.Rows.Add(new object[] { Id_Cliente_Generado,Txt_No_Doc_Cliente.Text, Txt_Nombre_Cliente.Text, Txt_Correo_Cliente.Text, Txt_Telefono_Cliente.Text,
                   ((Opcion_ComboBox)CBox_Estado_Cliente.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Cliente.SelectedItem).Texto.ToString()
                });
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(MENSAJE);
                }
            }
            else
            {
                bool Resultado = new CN_Clientes().Editar(obj_Clientes, out MENSAJE);

                if (Resultado)
                {
                    DataGridViewRow row = GridView_Cliente.Rows[Convert.ToInt32(Txt_Indice.Text)];
                    row.Cells["ID_Cliente"].Value = Txt_Id_Cliente.Text;
                    row.Cells["DOCUMENTO"].Value = Txt_No_Doc_Cliente.Text;
                    row.Cells["NOMBRE"].Value = Txt_Nombre_Cliente.Text;
                    row.Cells["CORREO"].Value = Txt_Correo_Cliente.Text;
                    row.Cells["TELEFONO"].Value = Txt_Telefono_Cliente.Text;
                    row.Cells["ESTADO_VALOR"].Value = ((Opcion_ComboBox)CBox_Estado_Cliente.SelectedItem).Valor.ToString();
                    row.Cells["ESTADO"].Value = ((Opcion_ComboBox)CBox_Estado_Cliente.SelectedItem).Texto.ToString();

                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show(MENSAJE);
                }
            }
        }

        private void Btn_Limpiar_Cliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Eliminar_Cliente_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Cliente.Text) != 0)
            {
                if (MessageBox.Show("DESEAS ELIMINAR ESTE CLIENTE?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MENSAJE = string.Empty;
                    Clientes obj_Clientes = new Clientes()
                    {
                        ID_CLIENTE = Convert.ToInt32(Txt_Id_Cliente.Text)

                    };
                    bool Respuesta = new CN_Clientes().Eliminar(obj_Clientes, out MENSAJE);

                    if (Respuesta)
                    {
                        GridView_Cliente.Rows.RemoveAt(Convert.ToInt32(Txt_Indice.Text));
                    }
                    else
                    {
                        MessageBox.Show(MENSAJE, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            LimpiarCampos();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string ColumnaFiltrada = ((Opcion_ComboBox)CBox_Busqueda.SelectedItem).Valor.ToString();

            if (GridView_Cliente.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Cliente.Rows)
                {
                    if (row.Cells[ColumnaFiltrada].Value.ToString().Trim().ToUpper().Contains(Txt_Busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Busqueda.Text = "";
            foreach (DataGridViewRow row in GridView_Cliente.Rows)
            {

                row.Visible = true;

            }
        }

        private void GridView_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;

            if (Indice >= 0)
            {
                Txt_Indice.Text = Indice.ToString();
                Txt_Id_Cliente.Text = GridView_Cliente.Rows[Indice].Cells["ID_CLIENTE"].Value.ToString();
                Txt_No_Doc_Cliente.Text = GridView_Cliente.Rows[Indice].Cells["DOCUMENTO"].Value.ToString();
                Txt_Nombre_Cliente.Text = GridView_Cliente.Rows[Indice].Cells["NOMBRE"].Value.ToString();
                Txt_Correo_Cliente.Text = GridView_Cliente.Rows[Indice].Cells["CORREO"].Value.ToString();
                Txt_Telefono_Cliente.Text = GridView_Cliente.Rows[Indice].Cells["TELEFONO"].Value.ToString();
   
            }

            foreach (Opcion_ComboBox Cbox in CBox_Estado_Cliente.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Cliente.Rows[Indice].Cells["ESTADO_VALOR"].Value))
                {
                    int Indice_CBox = CBox_Estado_Cliente.Items.IndexOf(Cbox);
                    CBox_Estado_Cliente.SelectedIndex = Indice_CBox;
                    break;
                }
            }
        }

        private void Separador_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Titulo_Main_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Busqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridView_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
