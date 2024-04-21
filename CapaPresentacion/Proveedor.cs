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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        void LimpiarCampos()
        {
            Txt_Indice.Text = "-1";
            Txt_Id_Proveedor.Text = "0";
            Txt_No_Doc_Proveedor.Text = "";
            Txt_Razon_Proveedor.Text = "";
            Txt_Correo_Proveedor.Text = "";
            Txt_Telefono_Proveedor.Text = "";

            CBox_Estado_Proveedor.SelectedIndex = 0;


            Txt_No_Doc_Proveedor.Select();
        }
        private void Proveedor_Load(object sender, EventArgs e)
        {
            CBox_Estado_Proveedor.Items.Add(new Opcion_ComboBox()
            {
                Valor = 1,
                Texto = "Activo"
            });

            CBox_Estado_Proveedor.Items.Add(new Opcion_ComboBox()
            {
                Valor = 0,
                Texto = "Inactivo"
            });

            CBox_Estado_Proveedor.DisplayMember = "Texto";
            CBox_Estado_Proveedor.ValueMember = "Valor";
            CBox_Estado_Proveedor.SelectedIndex = 0;

            foreach (DataGridViewColumn Columna in GridView_Proveedor.Columns)
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

            //MOSTTRANDO PROVEEDORES
            List<Proveedores> Lista_Proveedor = new CN_Proveedores().Llenar();

            foreach (Proveedores item in Lista_Proveedor)
            {
                GridView_Proveedor.Rows.Add(new object[]
            {
                item.ID_PROVEEDOR,
                item.DOCUMENTO,
                item.RAZON_SOCIAL,
                item.CORREO,
                item.TELEFONO,
                item.ESTADO == true ? 1 : 0,
                item.ESTADO == true ? "Activo" : "Inactivo"
            });

            }
        }

        private void Btn_Guardar_Proveedor_Click(object sender, EventArgs e)
        {
            string MENSAJE = string.Empty;
            Proveedores obj_Proveedor = new Proveedores()
            {
                ID_PROVEEDOR = Convert.ToInt32(Txt_Id_Proveedor.Text),
                DOCUMENTO = Txt_No_Doc_Proveedor.Text,
                RAZON_SOCIAL = Txt_Razon_Proveedor.Text,
                CORREO = Txt_Correo_Proveedor.Text,
                TELEFONO = Txt_Telefono_Proveedor.Text,
                ESTADO = Convert.ToInt32(((Opcion_ComboBox)CBox_Estado_Proveedor.SelectedItem).Valor) == 1 ? true : false,
            };

            if (obj_Proveedor.ID_PROVEEDOR == 0)
            {
                int Id_Proveedor_Generado = new CN_Proveedores().Insertar(obj_Proveedor, out MENSAJE);

                if (Id_Proveedor_Generado != 0)
                {
                    GridView_Proveedor.Rows.Add(new object[] { Id_Proveedor_Generado,Txt_No_Doc_Proveedor.Text, Txt_Razon_Proveedor.Text, Txt_Correo_Proveedor.Text, Txt_Telefono_Proveedor.Text,
                   ((Opcion_ComboBox)CBox_Estado_Proveedor.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Proveedor.SelectedItem).Texto.ToString()
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
                bool Resultado = new CN_Proveedores().Editar(obj_Proveedor, out MENSAJE);

                if (Resultado)
                {
                    DataGridViewRow row = GridView_Proveedor.Rows[Convert.ToInt32(Txt_Indice.Text)];
                    row.Cells["ID_PROVEEDOR"].Value = Txt_Id_Proveedor.Text;
                    row.Cells["DOCUMENTO"].Value = Txt_No_Doc_Proveedor.Text;
                    row.Cells["NOMBRE"].Value = Txt_Razon_Proveedor.Text;
                    row.Cells["CORREO"].Value = Txt_Correo_Proveedor.Text;
                    row.Cells["TELEFONO"].Value = Txt_Telefono_Proveedor.Text;
                    row.Cells["ESTADO_VALOR"].Value = ((Opcion_ComboBox)CBox_Estado_Proveedor.SelectedItem).Valor.ToString();
                    row.Cells["ESTADO"].Value = ((Opcion_ComboBox)CBox_Estado_Proveedor.SelectedItem).Texto.ToString();

                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show(MENSAJE);
                }
            }


        }

        private void GridView_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;

            if (Indice >= 0)
            {
                Txt_Indice.Text = Indice.ToString();
                Txt_Id_Proveedor.Text = GridView_Proveedor.Rows[Indice].Cells["ID_PROVEEDOR"].Value.ToString();
                Txt_No_Doc_Proveedor.Text = GridView_Proveedor.Rows[Indice].Cells["DOCUMENTO"].Value.ToString();
                Txt_Razon_Proveedor.Text = GridView_Proveedor.Rows[Indice].Cells["RAZON_SOCIAL"].Value.ToString();
                Txt_Correo_Proveedor.Text = GridView_Proveedor.Rows[Indice].Cells["CORREO"].Value.ToString();
                Txt_Telefono_Proveedor.Text = GridView_Proveedor.Rows[Indice].Cells["TELEFONO"].Value.ToString();
            }

            foreach (Opcion_ComboBox Cbox in CBox_Estado_Proveedor.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Proveedor.Rows[Indice].Cells["ESTADO_VALOR"].Value))
                {
                    int Indice_CBox = CBox_Estado_Proveedor.Items.IndexOf(Cbox);
                    CBox_Estado_Proveedor.SelectedIndex = Indice_CBox;
                    break;
                }
            }
        }

        private void Btn_Limpiar_Proveedor_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Btn_Eliminar_Proveedor_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Proveedor.Text) != 0)
            {
                if (MessageBox.Show("DESEAS ELIMINAR ESTE PROVEEDOR?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MENSAJE = string.Empty;
                    Proveedores obj_Proveedor = new Proveedores()
                    {
                        ID_PROVEEDOR = Convert.ToInt32(Txt_Id_Proveedor.Text)

                    };
                    bool Respuesta = new CN_Proveedores().Eliminar(obj_Proveedor, out MENSAJE);

                    if (Respuesta)
                    {
                        GridView_Proveedor.Rows.RemoveAt(Convert.ToInt32(Txt_Indice.Text));
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

            if (GridView_Proveedor.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Proveedor.Rows)
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
            foreach (DataGridViewRow row in GridView_Proveedor.Rows)
            {

                row.Visible = true;

            }
        }
    }
}
