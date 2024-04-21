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
    public partial class Categoria : Form
    {
        public Categoria()
        {
            InitializeComponent();
        }

        void LimpiarCampos()
        {
            Txt_Indice.Text = "-1";
            Txt_Id_Categoria.Text = "0";
            Txt_Descripcion_Categoria.Text = "";
           
            CBox_Estado_Categoria.SelectedIndex = 0;


            Txt_Descripcion_Categoria.Select();
        }
        private void Categoria_Load(object sender, EventArgs e)
        {
            CBox_Estado_Categoria.Items.Add(new Opcion_ComboBox()
            {
                Valor = 1,
                Texto = "Activo"
            });

            CBox_Estado_Categoria.Items.Add(new Opcion_ComboBox()
            {
                Valor = 0,
                Texto = "Inactivo"
            });

            CBox_Estado_Categoria.DisplayMember = "Texto";
            CBox_Estado_Categoria.ValueMember = "Valor";
            CBox_Estado_Categoria.SelectedIndex = 0;

            

            foreach (DataGridViewColumn Columna in GridView_Categoria.Columns)
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

            //MOSTTRANDO CATEGORIAS
            List<Categorias> Lista_Categorias = new CN_Categorias().Llenar();

            foreach (Categorias item in Lista_Categorias)
            {
                GridView_Categoria.Rows.Add(new object[]
            {
                item.ID_CATEGORIA,
                item.DESCRIPCION,
                item.ESTADO == true ? 1 : 0,
                item.ESTADO == true ? "Activo" : "Inactivo"
            });

            }
        }

        

        private void Btn_Guardar_Categoria_Click(object sender, EventArgs e)
        {
            string MENSAJE = string.Empty;
            Categorias obj_Categorias = new Categorias()
            {
                ID_CATEGORIA = Convert.ToInt32(Txt_Id_Categoria.Text),
                DESCRIPCION = Txt_Descripcion_Categoria.Text,
                ESTADO = Convert.ToInt32(((Opcion_ComboBox)CBox_Estado_Categoria.SelectedItem).Valor) == 1 ? true : false
            };

            if (obj_Categorias.ID_CATEGORIA == 0)
            {
                int Id_Categoria_Generado = new CN_Categorias().Insertar(obj_Categorias, out MENSAJE);

                if (Id_Categoria_Generado != 0)
                {
                   GridView_Categoria.Rows.Add(new object[] { Id_Categoria_Generado,Txt_Descripcion_Categoria.Text,
                   ((Opcion_ComboBox)CBox_Estado_Categoria.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Categoria.SelectedItem).Texto.ToString()
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
                bool Resultado = new CN_Categorias().Editar(obj_Categorias, out MENSAJE);

                if (Resultado)
                {
                    DataGridViewRow row = GridView_Categoria.Rows[Convert.ToInt32(Txt_Indice.Text)];
                    row.Cells["ID_CATEGORIA"].Value = Txt_Id_Categoria.Text;
                    row.Cells["DESCRIPCION"].Value = Txt_Descripcion_Categoria.Text;
                    row.Cells["ESTADO_VALOR"].Value = ((Opcion_ComboBox)CBox_Estado_Categoria.SelectedItem).Valor.ToString();
                    row.Cells["ESTADO"].Value = ((Opcion_ComboBox)CBox_Estado_Categoria.SelectedItem).Texto.ToString();

                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show(MENSAJE);
                }
            }


        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Busqueda.Text = "";
            foreach (DataGridViewRow row in GridView_Categoria.Rows)
            {

                row.Visible = true;

            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string ColumnaFiltrada = ((Opcion_ComboBox)CBox_Busqueda.SelectedItem).Valor.ToString();

            if (GridView_Categoria.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Categoria.Rows)
                {
                    if (row.Cells[ColumnaFiltrada].Value.ToString().Trim().ToUpper().Contains(Txt_Busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Btn_Eliminar_Categoria_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Categoria.Text) != 0)
            {
                if (MessageBox.Show("DESEAS ELIMINAR ESTA CATEGORIA?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MENSAJE = string.Empty;
                    Categorias obj_Categorias = new Categorias()
                    {
                        ID_CATEGORIA = Convert.ToInt32(Txt_Id_Categoria.Text)

                    };
                    bool Respuesta = new CN_Categorias().Eliminar(obj_Categorias, out MENSAJE);

                    if (Respuesta)
                    {
                        GridView_Categoria.Rows.RemoveAt(Convert.ToInt32(Txt_Indice.Text));
                    }
                    else
                    {
                        MessageBox.Show(MENSAJE, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            LimpiarCampos();
        }

        private void GridView_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;

            if (Indice >= 0)
            {
                Txt_Indice.Text = Indice.ToString();
                Txt_Id_Categoria.Text = GridView_Categoria.Rows[Indice].Cells["ID_CATEGORIA"].Value.ToString();
                Txt_Descripcion_Categoria.Text = GridView_Categoria.Rows[Indice].Cells["DESCRIPCION"].Value.ToString();
                foreach (Opcion_ComboBox Cbox in CBox_Estado_Categoria.Items)
                {
                    if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Categoria.Rows[Indice].Cells["ESTADO_VALOR"].Value))
                    {
                        int Indice_CBox = CBox_Estado_Categoria.Items.IndexOf(Cbox);
                        CBox_Estado_Categoria.SelectedIndex = Indice_CBox;
                        break;
                    }
                }
            }

        }
    }
}
