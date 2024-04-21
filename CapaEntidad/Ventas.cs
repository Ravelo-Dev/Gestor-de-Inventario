using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Ventas
    {
        public int ID_VENTA {  get; set; }
        public Usuarios_sys OBJ_USUARIO { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
        public string NUM_DOCUMENTO { get; set; }
        public string DOC_CLIENTE {  get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public decimal MONTO_PAGO { get; set; }
        public decimal MONTO_CAMBIO { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public List<Detalles_Ventas> OBJ_DETALLE_VENTA { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }
}
