using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalles_Compras
    {
        public int ID_DETALLE_COMPRA {  get; set; }
        public Productos OBJ_PRODUCTO { get; set; }
        public decimal PRECIO_COMPRA { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public int CANTIDAD {  get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public string FECHA_REGISTRO { get; set; }
    }
}
