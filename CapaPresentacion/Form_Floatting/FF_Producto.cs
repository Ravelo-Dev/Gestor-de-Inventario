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

namespace CapaPresentacion.Form_Floatting
{
    public partial class FF_Producto : Form
    {
        public Productos _Producto { get; set; }
        public FF_Producto()
        {
            InitializeComponent();
        }

        private void FF_Producto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn Columna in GridView_Producto.Columns)
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

            List<Productos> Lista_Producto = new CN_Productos().Llenar();

            foreach (Productos item in Lista_Producto)
            {
                GridView_Producto.Rows.Add(new object[]
            {
                item.ID_PRODUCTO,
                item.CODIGO,
                item.NOMBRE,
                item.DESCRIPCION,
                item.OBJ_CATEGORIA.DESCRIPCION,
                item.CANT_DISPONIBLE,
                item.PRECIO_COMPRA,
                item.PRECIO_VENTA,

            });
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

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            string ColumnaFiltrada = ((Opcion_ComboBox)CBox_Busqueda.SelectedItem).Valor.ToString();

            if (GridView_Producto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Producto.Rows)
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
            foreach (DataGridViewRow row in GridView_Producto.Rows)
            {

                row.Visible = true;

            }
        }

        private void GridView_Producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = GridView_Producto.Rows[rowIndex];

                if (int.TryParse(selectedRow.Cells["ID_PRODUCTO"].Value?.ToString(), out int idProducto) &&
                    selectedRow.Cells["CODIGO"].Value != null &&
                    selectedRow.Cells["NOMBRE"].Value != null &&
                    int.TryParse(selectedRow.Cells["CANT_DISPONIBLE"].Value?.ToString(), out int cantDisponible) &&
                    decimal.TryParse(selectedRow.Cells["PRECIO_COMPRA"].Value?.ToString(), out decimal precioCompra) &&
                    decimal.TryParse(selectedRow.Cells["PRECIO_VENTA"].Value?.ToString(), out decimal precioVenta))
                {
                    _Producto = new Productos
                    {
                        ID_PRODUCTO = idProducto,
                        CODIGO = selectedRow.Cells["CODIGO"].Value.ToString(),
                        NOMBRE = selectedRow.Cells["NOMBRE"].Value.ToString(),
                        CANT_DISPONIBLE = cantDisponible,
                        PRECIO_COMPRA = precioCompra,
                        PRECIO_VENTA = precioVenta
                    };

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    string errorMessage = "Error de formato en los datos seleccionados. Detalles:\n";

                    if (!int.TryParse(selectedRow.Cells["ID_PRODUCTO"].Value?.ToString(), out _))
                        errorMessage += "- ID_PRODUCTO\n";

                    if (selectedRow.Cells["CODIGO"].Value == null)
                        errorMessage += "- CODIGO\n";

                    if (selectedRow.Cells["NOMBRE"].Value == null)
                        errorMessage += "- NOMBRE\n";

                    if (!int.TryParse(selectedRow.Cells["CANT_DISPONIBLE"].Value?.ToString(), out _))
                        errorMessage += "- CANT_DISPONIBLE\n";

                    if (!decimal.TryParse(selectedRow.Cells["PRECIO_COMPRA"].Value?.ToString(), out _))
                        errorMessage += "- PRECIO_COMPRA\n";

                    if (!decimal.TryParse(selectedRow.Cells["PRECIO_VENTA"].Value?.ToString(), out _))
                        errorMessage += "- PRECIO_VENTA\n";

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
