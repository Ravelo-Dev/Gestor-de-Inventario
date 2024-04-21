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
using System.Xml.Linq;

namespace CapaPresentacion.Form_Floatting
{
    public partial class FF_Proveedor : Form
    {
        public Proveedores _Proveedor { get; set; }
        public FF_Proveedor()
        {
            InitializeComponent();
        }

        private void FF_Proveedor_Load(object sender, EventArgs e)
        {
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
            });

        }   }

        private void GridView_Proveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IRow = e.RowIndex;
            int IColumn = e.ColumnIndex;

            if(IRow >=0 && IColumn > 0) {

                _Proveedor = new Proveedores()
                {
                    ID_PROVEEDOR = Convert.ToInt32(GridView_Proveedor.Rows[IRow].Cells["ID_PROVEEDOR"].Value.ToString()),
                    DOCUMENTO = GridView_Proveedor.Rows[IRow].Cells["DOCUMENTO"].Value.ToString(),
                    RAZON_SOCIAL = GridView_Proveedor.Rows[IRow].Cells["RAZON_SOCIAL"].Value.ToString()

                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
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

        private void Separador_Click(object sender, EventArgs e)
        {

        }
    }
}
