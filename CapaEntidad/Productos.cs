using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Productos
    {
        public int ID_PRODUCTO { get; set; }
        public string CODIGO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public Categorias OBJ_CATEGORIA { get; set; }
        public int CANT_DISPONIBLE { get; set; }
        public decimal PRECIO_COMPRA {  get; set; }
        public decimal PRECIO_VENTA { get; set; }
        public bool ESTADO { get; set; }
        public string FECHA_REGISTRO { get; set; }

    }
}
