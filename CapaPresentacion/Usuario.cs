using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Funciones_Extras;

using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    
    public partial class Usuario : Form
    {
       
        public Usuario()
        {
            InitializeComponent();
        }

        void LimpiarCampos()
        {
            Txt_Indice.Text = "-1";
            Txt_Id_Usuario.Text = "0";
            Txt_No_Doc_Usuario.Text = "";
            Txt_Nombre_Usuario.Text = "";
            Txt_Correo_Usuario.Text = "";
            Txt_Password_Usuario.Text = "";
            Txt_PassConfirma_Usuario.Text = "";
            CBox_Estado_Usuario.SelectedIndex = 0;
            CBox_Rol_Usuario.SelectedIndex = 0;

            Txt_No_Doc_Usuario.Select();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

            CBox_Estado_Usuario.Items.Add(new Opcion_ComboBox()
            {
                Valor = 1,
                Texto = "Activo"
            });

            CBox_Estado_Usuario.Items.Add(new Opcion_ComboBox()
            {
                Valor = 0,
                Texto = "Inactivo"
            });

            CBox_Estado_Usuario.DisplayMember = "Texto";
            CBox_Estado_Usuario.ValueMember = "Valor";
            CBox_Estado_Usuario.SelectedIndex = 0;

            List<Roles_sys> Lista_Roles = new CN_Rol().Llenar();

            foreach (Roles_sys item in Lista_Roles)
            {
                CBox_Rol_Usuario.Items.Add(new Opcion_ComboBox()
                {
                    Valor = item.ID_ROL, 
                    Texto = item.DESCRIPCION

                });
                CBox_Rol_Usuario.DisplayMember = "Texto";
                CBox_Rol_Usuario.ValueMember = "Valor";
                CBox_Rol_Usuario.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn Columna in GridView_Usuario.Columns)
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

            //MOSTTRANDO USUARIOS
            List<Usuarios_sys> Lista_Usuarios = new CN_Usuarios().Llenar();

            foreach (Usuarios_sys item in Lista_Usuarios)
            {
                GridView_Usuario.Rows.Add(new object[]
            {
                item.ID_USUARIO,
                item.DOCUMENTO,
                item.NOMBRE,
                item.CORREO,
                item.PASSWORD,
                item.OBJ_ROL.ID_ROL,
                item.OBJ_ROL.DESCRIPCION,
                item.ESTADO == true ? 1 : 0,
                item.ESTADO == true ? "Activo" : "Inactivo"
            }) ;
                
            }
        }

        private void GridView_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;
            
            if(Indice >= 0)
            {
                Txt_Indice.Text = Indice.ToString();
                Txt_Id_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["ID_USUARIO"].Value.ToString();
                Txt_No_Doc_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["DOCUMENTO"].Value.ToString();
                Txt_Nombre_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["NOMBRE"].Value.ToString();
                Txt_Correo_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["CORREO"].Value.ToString();
                Txt_Password_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["PASSWORD"].Value.ToString();
                Txt_PassConfirma_Usuario.Text = GridView_Usuario.Rows[Indice].Cells["PASSWORD"].Value.ToString();
            }

            foreach (Opcion_ComboBox Cbox in CBox_Rol_Usuario.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Usuario.Rows[Indice].Cells["ID_ROL"].Value))
                    {
                    int Indice_CBox = CBox_Rol_Usuario.Items.IndexOf(Cbox);
                    CBox_Rol_Usuario.SelectedIndex = Indice_CBox;
                    break;
                }
            }

            foreach (Opcion_ComboBox Cbox in CBox_Estado_Usuario.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Usuario.Rows[Indice].Cells["ESTADO_VALOR"].Value))
                {
                    int Indice_CBox = CBox_Estado_Usuario.Items.IndexOf(Cbox);
                    CBox_Estado_Usuario.SelectedIndex = Indice_CBox;
                    break;
                }
            }
        }

        private void Btn_Guardar_Usuario_Click(object sender, EventArgs e)
        {
            string MENSAJE = string.Empty;
            Usuarios_sys obj_Usuarios = new Usuarios_sys()
            {
                ID_USUARIO = Convert.ToInt32(Txt_Id_Usuario.Text),
                DOCUMENTO = Txt_No_Doc_Usuario.Text,
                NOMBRE = Txt_Nombre_Usuario.Text,
                CORREO = Txt_Correo_Usuario.Text,
                PASSWORD = Txt_Password_Usuario.Text,
                OBJ_ROL = new Roles_sys()
                {
                    ID_ROL = Convert.ToInt32(((Opcion_ComboBox)CBox_Rol_Usuario.SelectedItem).Valor)
                },
                ESTADO = Convert.ToInt32(((Opcion_ComboBox)CBox_Estado_Usuario.SelectedItem).Valor) == 1 ? true : false,
            };

            if (obj_Usuarios.ID_USUARIO == 0)
            {
                int Id_Usuario_Generado = new CN_Usuarios().Insertar(obj_Usuarios, out MENSAJE);

                if (Id_Usuario_Generado != 0)
                {
                    GridView_Usuario.Rows.Add(new object[] { Id_Usuario_Generado,Txt_No_Doc_Usuario.Text, Txt_Nombre_Usuario.Text, Txt_Correo_Usuario.Text, Txt_Password_Usuario.Text,
                   ((Opcion_ComboBox)CBox_Rol_Usuario.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Rol_Usuario.SelectedItem).Texto.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Usuario.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Usuario.SelectedItem).Texto.ToString()
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
                bool Resultado = new CN_Usuarios().Editar(obj_Usuarios, out MENSAJE);

                if (Resultado)
                {
                    DataGridViewRow row = GridView_Usuario.Rows[Convert.ToInt32(Txt_Indice.Text)];
                    row.Cells["ID_USUARIO"].Value = Txt_Id_Usuario.Text;
                    row.Cells["DOCUMENTO"].Value = Txt_No_Doc_Usuario.Text;
                    row.Cells["NOMBRE"].Value = Txt_Nombre_Usuario.Text;
                    row.Cells["CORREO"].Value = Txt_Correo_Usuario.Text;
                    row.Cells["PASSWORD"].Value = Txt_Password_Usuario.Text;
                    row.Cells["ID_ROL"].Value = ((Opcion_ComboBox)CBox_Rol_Usuario.SelectedItem).Valor.ToString();
                    row.Cells["ROL"].Value = ((Opcion_ComboBox)CBox_Rol_Usuario.SelectedItem).Texto.ToString();
                    row.Cells["ESTADO_VALOR"].Value = ((Opcion_ComboBox)CBox_Estado_Usuario.SelectedItem).Valor.ToString();
                    row.Cells["ESTADO"].Value = ((Opcion_ComboBox)CBox_Estado_Usuario.SelectedItem).Texto.ToString();

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
            foreach (DataGridViewRow row in GridView_Usuario.Rows)
            {
                
                row.Visible = true;
              
            }

        }

        private void Btn_Eliminar_Usuario_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Usuario.Text) != 0)
            {
                if(MessageBox.Show("DESEAS ELIMINAR ESTE USUARIO?","MENSAJE", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MENSAJE = string.Empty;
                    Usuarios_sys obj_Usuarios = new Usuarios_sys()
                    {
                        ID_USUARIO = Convert.ToInt32(Txt_Id_Usuario.Text)

                    };
                    bool Respuesta = new CN_Usuarios().Eliminar(obj_Usuarios, out MENSAJE); 

                    if (Respuesta) 
                    {
                        GridView_Usuario.Rows.RemoveAt(Convert.ToInt32(Txt_Indice.Text));
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

            if (GridView_Usuario.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Usuario.Rows)
                {
                    if (row.Cells[ColumnaFiltrada].Value.ToString().Trim().ToUpper().Contains(Txt_Busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Btn_Limpiar_Usuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void Lbl_PassConfirma_Usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
