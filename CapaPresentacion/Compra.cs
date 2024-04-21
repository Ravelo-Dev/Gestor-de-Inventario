using CapaEntidad;
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
using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class Compra : Form
    {

        private Usuarios_sys usuarios_;
        public Compra(Usuarios_sys Obj_usuarios = null)
        {
            usuarios_ = Obj_usuarios;
            InitializeComponent();
        }

        private void Compra_Load(object sender, EventArgs e)
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
            Txt_Id_Proveedor.Text = "0";
        }

        private void Btn_Buscar_Proveedor_Click(object sender, EventArgs e)
        {
            using(var Floatting = new FF_Proveedor())
            {
                var result = Floatting.ShowDialog();    
                if(result == DialogResult.OK)
                {
                    Txt_Id_Proveedor.Text = Floatting._Proveedor.ID_PROVEEDOR.ToString();
                    Txt_No_Doc_Proveedor.Text = Floatting._Proveedor.DOCUMENTO.ToString();
                    Txt_Razon_Proveedor.Text = Floatting._Proveedor.RAZON_SOCIAL.ToString();

                }
                else
                {
                    Txt_No_Doc_Proveedor.Select();
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
                    Txt_PrecioCompra_Producto.Select();

                }
                else
                {
                    Txt_Codigo_Producto.Select();
                }
            }
        }

        private void Txt_Codigo_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Productos Obj_Producto = new CN_Productos().Llenar().Where(p => p.CODIGO == Txt_Codigo_Producto.Text && p.ESTADO == true).FirstOrDefault();


                if(Obj_Producto != null)
                {
                    Txt_Codigo_Producto.BackColor = Color.Honeydew;
                    Txt_Id_Producto.Text = Obj_Producto.ID_PRODUCTO.ToString();
                    Txt_Nombre_Producto.Text = Obj_Producto.NOMBRE;
                    Txt_PrecioCompra_Producto.Select();
                }
                else{
                    Txt_Codigo_Producto.BackColor = Color.MistyRose;
                    Txt_Id_Producto.Text = "0";
                    Txt_Nombre_Producto.Text = "";
                }
            }
        }

        private void Btn_Agregar_Producto_Click(object sender, EventArgs e)
        {
            decimal precio_compra = 0;
            decimal precio_venta = 0;
            bool existe = false;

            if (int.Parse(Txt_Id_Producto.Text) == 0)
            {
                MessageBox.Show("DEBE SELECIONAR UN PRODUCTO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(!decimal.TryParse(Txt_PrecioCompra_Producto.Text, out precio_compra) )
            {
                MessageBox.Show("FORMATO INCORRECTO INGRESE UNO VALIDO - PRECIO COMPRA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_PrecioCompra_Producto.Select();
                return;
                
            }
            if (!decimal.TryParse(Txt_PrecioVenta_Producto.Text, out precio_venta))
            {
                MessageBox.Show("FORMATO INCORRECTO INGRESE UNO VALIDO - PRECIO VENTA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_PrecioVenta_Producto.Select();
                return;

            }

            foreach (DataGridViewRow row in GridView_Producto.Rows)
            {
                if (row.Cells["ID_PRODUCTO"].Value.ToString() == Txt_Id_Producto.Text) {
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
                    precio_compra.ToString("0.00"), 
                    precio_venta.ToString("0.00"),
                    Txt_Cantidad_Producto.Value.ToString(),
                    (Txt_Cantidad_Producto.Value * precio_compra).ToString("0.00")
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
            Txt_Codigo_Producto.BackColor = Color.White;
            Txt_Nombre_Producto.Text = "";
            Txt_PrecioCompra_Producto.Text = "";
            Txt_PrecioVenta_Producto.Text = "";
            Txt_Cantidad_Producto.Value = 1;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if(GridView_Producto.Rows.Count > 0)
            { 
                foreach (DataGridViewRow row in GridView_Producto.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SUB_TOTAL"].Value.ToString());
                }
            }
            Txt_MontoPagar_Compra.Text = total.ToString("0.00");
        }

        private void Btn_Registrar_Compra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Txt_Id_Proveedor.Text) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (GridView_Producto.Rows.Count < 1)
            {
                MessageBox.Show("DEBE AGREGAR PRODUCTOS A SU COMPRA", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable DETALLE_COMPRA = new DataTable();
            DETALLE_COMPRA.Columns.Add("ID_PRODUCTO", typeof(int));
            DETALLE_COMPRA.Columns.Add("PRECIO_COMPRA", typeof(decimal));
            DETALLE_COMPRA.Columns.Add("PRECIO_VENTA", typeof(decimal));
            DETALLE_COMPRA.Columns.Add("CANTIDAD", typeof(int));
            DETALLE_COMPRA.Columns.Add("MONTO_TOTAL", typeof(decimal));

            foreach (DataGridViewRow row in GridView_Producto.Rows)
            {
                DETALLE_COMPRA.Rows.Add(new object[]
                {
                   row.Cells["ID_PRODUCTO"].Value.ToString(),
                   row.Cells["PRECIO_COMPRA"].Value.ToString(),
                   row.Cells["PRECIO_VENTA"].Value.ToString(),
                   row.Cells["CANTIDAD"].Value.ToString(),
                   row.Cells["SUB_TOTAL"].Value.ToString()
                });
            }

            int Id_Correlativo = new CN_Compras().ObtenerCorrelativo();
            string num_documento = string.Format("{0:00000}", Id_Correlativo);


            Compras obj_compra = new Compras()
            {
                OBJ_USUARIO = new Usuarios_sys()
                {
                    ID_USUARIO = usuarios_.ID_USUARIO
                },
                OBJ_PROVEEDOR = new Proveedores()
                {
                    ID_PROVEEDOR = Convert.ToInt32(Txt_Id_Proveedor.Text)
                },
                TIPO_DOCUMENTO = ((Opcion_ComboBox)CBox_Tipo_Doc.SelectedItem).Texto,
                NUM_DOCUMENTO = num_documento,
                MONTO_TOTAL = Convert.ToDecimal(Txt_MontoPagar_Compra.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compras().Insertar(obj_compra, DETALLE_COMPRA, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("NUMERO DE COMPRA: \n" + num_documento + "\n\n DESEAS COPIAR EL NUMERO DE COMPRA?", "MENSAJE", MessageBoxButtons.YesNo
                    , MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(num_documento);
                }

                Txt_Id_Proveedor.Text = "0";
                Txt_No_Doc_Proveedor.Text = "";
                Txt_Razon_Proveedor.Text = "";
                GridView_Producto.Rows.Clear();
                CalcularTotal();

            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
