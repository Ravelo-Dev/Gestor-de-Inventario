using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalles_Ventas
    {
        public int ID_DETALLE_VENTA {  get; set; }
        public Productos OBJ_PRODUCTO { get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public int CANTIDAD { get; set; }
        public decimal SUB_TOTAL { get; set; }
        public string FECHA_REGISTRO { get; set; }



    }
}
