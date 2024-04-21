using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compras
    {
        public int ID_COMPRA {  get; set; }
        public Usuarios_sys OBJ_USUARIO { get; set; }
        public Proveedores OBJ_PROVEEDOR { get; set; }
        public string TIPO_DOCUMENTO {  get; set; }
        public string NUM_DOCUMENTO { get; set; }
        public List<Detalles_Compras> OBJ_DETALLE_COMPRA { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }
}
