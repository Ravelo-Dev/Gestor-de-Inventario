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
    public partial class FF_Cliente : Form
    {
        public Clientes _Cliente {  get; set; }
        public FF_Cliente()
        {
            InitializeComponent();
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

        private void GridView_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IRow = e.RowIndex;
            int IColumn = e.ColumnIndex;

            if (IRow >= 0 && IColumn >= 0)
            {

                _Cliente = new Clientes()
                {
                    DOCUMENTO = GridView_Cliente.Rows[IRow].Cells["DOCUMENTO"].Value.ToString(),
                    NOMBRE = GridView_Cliente.Rows[IRow].Cells["NOMBRE"].Value.ToString(),
                };

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }

        private void FF_Cliente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn Columna in GridView_Cliente.Columns)
            {
               
                    CBox_Busqueda.Items.Add(new Opcion_ComboBox()
                    {
                        Valor = Columna.Name,
                        Texto = Columna.HeaderText
                    });
            }
            CBox_Busqueda.DisplayMember = "Texto";
            CBox_Busqueda.ValueMember = "Valor";
            CBox_Busqueda.SelectedIndex = 0;

            List<Clientes> Lista_Clientes = new CN_Clientes().Llenar();

            foreach (Clientes item in Lista_Clientes)
            {
                if(item.ESTADO)
                    GridView_Cliente.Rows.Add(new object[] {
                    item.DOCUMENTO,
                    item.NOMBRE
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
    }
}
