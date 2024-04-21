using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios_sys
    {
        public int ID_USUARIO {  get; set; }

        public string DOCUMENTO {  get; set; }

        public string NOMBRE { get; set;}

        public string CORREO { get; set; }

        public string PASSWORD { get; set; }

        public Roles_sys OBJ_ROL { get; set; }

        public bool ESTADO {  get; set; }

        public string FECHA_REGISTRO { get; set; }




    }
}
