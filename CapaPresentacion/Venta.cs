using CapaEntidad;
using CapaNegocios;
using CapaPresentacion.Form_Floatting;
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
    public partial class Venta : Form
    {

        private Usuarios_sys usuarios_;
        public Venta(Usuarios_sys Obj_usuarios = null)
        {
            usuarios_ = Obj_usuarios;
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            CBox_Tipo_Doc.Items.Add(new Opcion_ComboBox()
            {
                Valor = "BOLETA",
                Texto = "BOLETA"
            });

            CBox_Tipo_Doc.Items.Add(new Opcion_ComboBox()
            {
                Valor = "FACTURA",
                Texto = "FACTURA"
            });

            CBox_Tipo_Doc.DisplayMember = "Texto";
            CBox_Tipo_Doc.ValueMember = "Valor";
            CBox_Tipo_Doc.SelectedIndex = 0;

            Txt_Fecha_Compra.Text = DateTime.Now.ToString("dd/mm/yyyy");

            Txt_Id_Producto.Text = "0";

            Txt_Pagado_Venta.Text = "";
            Txt_Cambio_Venta.Text = "";
            Txt_MontoPagar_Venta.Text = "0";
        }

        private void Btn_Buscar_Cliente_Click(object sender, EventArgs e)
        {
            using (var Floatting = new FF_Cliente())
            {
                var result = Floatting.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Txt_No_Doc_Cliente.Text = Floatting._Cliente.DOCUMENTO.ToString();
                    Txt_Nombre_Cliente.Text = Floatting._Cliente.NOMBRE.ToString();
                    Txt_Codigo_Producto.Select();
                }
                else
                {
                    Txt_No_Doc_Cliente.Select();
                }
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            using (var Floatting = new FF_Producto())
            {
                var result = Floatting.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Txt_Id_Producto.Text = Floatting._Producto.ID_PRODUCTO.ToString();
                    Txt_Codigo_Producto.Text = Floatting._Producto.CODIGO.ToString();
                    Txt_Nombre_Producto.Text = Floatting._Producto.NOMBRE.ToString();
                    Txt_Precio_Producto.Text = Floatting._Producto.PRECIO_VENTA.ToString("0.00");
                    Txt_CantDispo_Producto.Text = Floatting._Producto.CANT_DISPONIBLE.ToString();
                    Txt_Cantidad_Producto.Select();

                }
                else
                {
                    Txt_Codigo_Producto.Select();
                }
            }
        }

        private void Txt_Codigo_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Productos Obj_Producto = new CN_Productos().Llenar().Where(p => p.CODIGO == Txt_Codigo_Producto.Text && p.ESTADO == true).FirstOrDefault();


                if (Obj_Producto != null)
                {
                    Txt_Codigo_Producto.BackColor = Color.Honeydew;
                    Txt_Id_Producto.Text = Obj_Producto.ID_PRODUCTO.ToString();
                    Txt_Nombre_Producto.Text = Obj_Producto.NOMBRE;
                    Txt_Precio_Producto.Text = Obj_Producto.PRECIO_VENTA.ToString("0.00");
                    Txt_CantDispo_Producto.Text = Obj_Producto.CANT_DISPONIBLE.ToString();
                    Txt_Cantidad_Producto.Select();
                }
                else
                {
                    Txt_Codigo_Producto.BackColor = Color.MistyRose;
                    Txt_Id_Producto.Text = "0";
                    Txt_Nombre_Producto.Text = "";
                    Txt_Precio_Producto.Text = "";
                    Txt_CantDispo_Producto.Text = "";
                    Txt_Cantidad_Producto.Value = 1;
                }
            }
        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool existe = false;

            if (int.Parse(Txt_Id_Producto.Text) == 0)
            {
                MessageBox.Show("DEBE SELECIONAR UN PRODUCTO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(Txt_Precio_Producto.Text, out precio))
            {
                MessageBox.Show("FORMATO INCORRECTO INGRESE UNO VALIDO - PRECIO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Precio_Producto.Select();
                return;

            }
            if (Convert.ToInt32(Txt_CantDispo_Producto.Text) < Convert.ToInt32(Txt_Cantidad_Producto.Value.ToString()))
            {
                MessageBox.Show("LA CANTIDAD NO PUEDE SER MAYOR QUE EL STOCK", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          
                return;

            }

            foreach (DataGridViewRow row in GridView_Producto.Rows)
            {
                if (row.Cells["ID_PRODUCTO"].Value.ToString() == Txt_Id_Producto.Text)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                GridView_Producto.Rows.Add(new object[]
                {
                    Txt_Id_Producto.Text,
                    Txt_Nombre_Producto.Text,
                    precio.ToString("0.00"),
                    Txt_Cantidad_Producto.Value.ToString(),
                    (Txt_Cantidad_Producto.Value * precio).ToString("0.00")
                });
                CalcularTotal();
                LimpiarProducto();
                Txt_Codigo_Producto.Select();
            }

        }

        private void LimpiarProducto()
        {
            Txt_Id_Producto.Text = "0";
            Txt_Codigo_Producto.Text = "";
            Txt_Nombre_Producto.Text = "";
            Txt_Precio_Producto.Text = "";
            Txt_CantDispo_Producto.Text = "";
            Txt_Cantidad_Producto.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (GridView_Producto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in GridView_Producto.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SUB_TOTAL"].Value.ToString());
                }
            }
            Txt_MontoPagar_Venta.Text = total.ToString("0.00");
        }


        private void CalcularCambio()
        {
            if (Txt_MontoPagar_Venta.Text.Trim() == "")
            {
                MessageBox.Show("NO EXISTEN PRODUCTOS EN LA VENTA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal pagado;
            decimal Total = Convert.ToDecimal(Txt_MontoPagar_Venta.Text);

            if(Txt_Pagado_Venta.Text.Trim() == "")
            {
                Txt_Pagado_Venta.Text = "0";
            }

            if(decimal.TryParse(Txt_Pagado_Venta.Text.Trim(), out pagado))
            {
                if(pagado < Total)
                {
                    Txt_Cambio_Venta.Text = "0.00";

                }
                else
                {
                    decimal cambio = pagado - Total;
                    Txt_Cambio_Venta.Text = cambio.ToString("0.00");
                }
            }
        }

        private void Txt_Pagado_Venta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }
    }
}


