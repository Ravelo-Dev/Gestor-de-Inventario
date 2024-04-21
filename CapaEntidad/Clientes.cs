using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int ID_CLIENTE { get; set; }

        public string DOCUMENTO { get; set; }

        public string NOMBRE { get; set; }

        public string CORREO { get; set; }

        public string TELEFONO { get; set; }

        public bool ESTADO { get; set; }

        public string FECHA_REGISTRO { get; set; }
    }
}
