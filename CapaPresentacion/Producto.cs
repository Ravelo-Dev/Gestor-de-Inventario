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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        void LimpiarCampos()
        {
            Txt_Indice.Text = "-1";
            Txt_Id_Producto.Text = "0";
            Txt_Codigo_Producto.Text = "";
            Txt_Nombre_Producto.Text = "";
            Txt_Descripcion_Producto.Text = "";
            CBox_Estado_Producto.SelectedIndex = 0;
            CBox_Categoria_Producto.SelectedIndex = 0;

            Txt_Codigo_Producto.Select();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            CBox_Estado_Producto.Items.Add(new Opcion_ComboBox()
            {
                Valor = 1,
                Texto = "Activo"
            });

            CBox_Estado_Producto.Items.Add(new Opcion_ComboBox()
            {
                Valor = 0,
                Texto = "Inactivo"
            });

            CBox_Estado_Producto.DisplayMember = "Texto";
            CBox_Estado_Producto.ValueMember = "Valor";
            CBox_Estado_Producto.SelectedIndex = 0;

            List<Categorias> Lista_Categoria = new CN_Categorias().Llenar();

            foreach (Categorias item in Lista_Categoria)
            {
                CBox_Categoria_Producto.Items.Add(new Opcion_ComboBox()
                {
                    Valor = item.ID_CATEGORIA,
                    Texto = item.DESCRIPCION

                });
                CBox_Categoria_Producto.DisplayMember = "Texto";
                CBox_Categoria_Producto.ValueMember = "Valor";
                CBox_Categoria_Producto.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn Columna in GridView_Product.Columns)
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

            //MOSTTRANDO PRODUCTOS
            List<Productos> Lista_Producto = new CN_Productos().Llenar();

            if (Lista_Producto != null && Lista_Producto.Count > 0)
            {
                foreach (Productos item in Lista_Producto)
                {
                    GridView_Product.Rows.Add(new object[]{
                    item.ID_PRODUCTO,
                    item.CODIGO,
                    item.NOMBRE,
                    item.DESCRIPCION,
                    item.OBJ_CATEGORIA.ID_CATEGORIA,
                    item.OBJ_CATEGORIA.DESCRIPCION,
                    item.CANT_DISPONIBLE,
                    item.PRECIO_COMPRA,
                    item.PRECIO_VENTA,
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

        private void Btn_Guardar_Producto_Click(object sender, EventArgs e)
        {
            string MENSAJE = string.Empty;
            Productos obj_Productos = new Productos()
            {
                ID_PRODUCTO = Convert.ToInt32(Txt_Id_Producto.Text),
                CODIGO = Txt_Codigo_Producto.Text,
                NOMBRE = Txt_Nombre_Producto.Text,
                DESCRIPCION = Txt_Descripcion_Producto.Text,
                OBJ_CATEGORIA = new Categorias()
                {
                    ID_CATEGORIA = Convert.ToInt32(((Opcion_ComboBox)CBox_Categoria_Producto.SelectedItem).Valor)
                },
                ESTADO = Convert.ToInt32(((Opcion_ComboBox)CBox_Estado_Producto.SelectedItem).Valor) == 1 ? true : false,
            };

            if (obj_Productos.ID_PRODUCTO == 0)
            {
                int Id_Producto_Generado = new CN_Productos().Insertar(obj_Productos, out MENSAJE);

                if (Id_Producto_Generado != 0)
                {
                    GridView_Product.Rows.Add(new object[] { Id_Producto_Generado,Txt_Codigo_Producto.Text, Txt_Nombre_Producto.Text, Txt_Descripcion_Producto.Text,
                   ((Opcion_ComboBox)CBox_Categoria_Producto.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Categoria_Producto.SelectedItem).Texto.ToString(),
                   "0",
                   "0.00",
                   "0.00",
                   ((Opcion_ComboBox)CBox_Estado_Producto.SelectedItem).Valor.ToString(),
                   ((Opcion_ComboBox)CBox_Estado_Producto.SelectedItem).Texto.ToString()
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
                bool Resultado = new CN_Productos().Editar(obj_Productos, out MENSAJE);

                if (Resultado)
                {
                    DataGridViewRow row = GridView_Product.Rows[Convert.ToInt32(Txt_Indice.Text)];
                    row.Cells["ID_PRODUCTO"].Value = Txt_Id_Producto.Text;
                    row.Cells["CODIGO"].Value = Txt_Codigo_Producto.Text;
                    row.Cells["NOMBRE"].Value = Txt_Nombre_Producto.Text;
                    row.Cells["DESCRIPCION"].Value = Txt_Descripcion_Producto.Text;
                    row.Cells["ID_CATEGORIA"].Value = ((Opcion_ComboBox)CBox_Categoria_Producto.SelectedItem).Valor.ToString();
                    row.Cells["CATEGORIA"].Value = ((Opcion_ComboBox)CBox_Categoria_Producto.SelectedItem).Texto.ToString();

                    row.Cells["ESTADO_VALOR"].Value = ((Opcion_ComboBox)CBox_Estado_Producto.SelectedItem).Valor.ToString();
                    row.Cells["ESTADO"].Value = ((Opcion_ComboBox)CBox_Estado_Producto.SelectedItem).Texto.ToString();

                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show(MENSAJE);
                }
            }
        }

        private void GridView_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Busqueda.Text = "";
            foreach (DataGridViewRow row in GridView_Product.Rows)
            {

                row.Visible = true;

            }
        }

        private void Btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Producto.Text) != 0)
            {
                if (MessageBox.Show("DESEAS ELIMINAR ESTE PRODUCTO?", "MENSAJE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string MENSAJE = string.Empty;
                    Productos obj_Producto = new Productos()
                    {
                        ID_PRODUCTO = Convert.ToInt32(Txt_Id_Producto.Text)

                    };
                    bool Respuesta = new CN_Productos().Eliminar(obj_Producto, out MENSAJE);

                    if (Respuesta)
                    {
                        GridView_Product.Rows.RemoveAt(Convert.ToInt32(Txt_Indice.Text));
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

            if (GridView_Product.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Product.Rows)
                {
                    if (row.Cells[ColumnaFiltrada].Value.ToString().Trim().ToUpper().Contains(Txt_Busqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void Btn_Limpiar_Producto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void GridView_Product_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int Indice = e.RowIndex;

            if (Indice >= 0)
            {
                Txt_Indice.Text = Indice.ToString();
                Txt_Id_Producto.Text = GridView_Product.Rows[Indice].Cells["ID_PRODUCTO"].Value.ToString();
                Txt_Codigo_Producto.Text = GridView_Product.Rows[Indice].Cells["CODIGO"].Value.ToString();
                Txt_Nombre_Producto.Text = GridView_Product.Rows[Indice].Cells["NOMBRE"].Value.ToString();
                Txt_Descripcion_Producto.Text = GridView_Product.Rows[Indice].Cells["DESCRIPCION"].Value.ToString();

            }

            foreach (Opcion_ComboBox Cbox in CBox_Categoria_Producto.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Product.Rows[Indice].Cells["ID_CATEGORIA"].Value))
                {
                    int Indice_CBox = CBox_Categoria_Producto.Items.IndexOf(Cbox);
                    CBox_Categoria_Producto.SelectedIndex = Indice_CBox;
                    break;
                }
            }

            foreach (Opcion_ComboBox Cbox in CBox_Estado_Producto.Items)
            {
                if (Convert.ToInt32(Cbox.Valor) == Convert.ToInt32(GridView_Product.Rows[Indice].Cells["ESTADO_VALOR"].Value))
                {
                    int Indice_CBox = CBox_Estado_Producto.Items.IndexOf(Cbox);
                    CBox_Estado_Producto.SelectedIndex = Indice_CBox;
                    break;
                }
            }
        }
    }
}
