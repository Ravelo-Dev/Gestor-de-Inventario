using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos_sys
    {
        public int ID_PERMISO {  get; set; }

        public Roles_sys OBJ_ROL { get; set; }

        public string NOMBRE_MENU { get; set; }

        public string FECHA_REGISTRO { get; set; }
    }
}
