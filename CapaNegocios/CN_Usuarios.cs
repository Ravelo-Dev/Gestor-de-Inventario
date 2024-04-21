using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class CN_Usuarios
    {
        CD_Usuarios OBJ_CD_USUARIO = new CD_Usuarios();

        public List<Usuarios_sys> Llenar()
        {
            return OBJ_CD_USUARIO.Llenar();
        }

        public int Insertar(Usuarios_sys OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL USUARIO\n";
            }
            

            if (OBJ.NOMBRE== "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL USUARIO\n";
            }
          

            if (OBJ.PASSWORD == "")
            {
                MENSAJE += "ES NECESARIO EL PASSWORD DEL USUARIO\n";
            }

            if (MENSAJE != string.Empty)
            {
                return 0;
            }
            else
            {
                return OBJ_CD_USUARIO.Insertar(OBJ, out MENSAJE);
            }
            
            
        }

        public bool Editar(Usuarios_sys OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL USUARIO\n";
            }


            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL USUARIO\n";
            }


            if (OBJ.PASSWORD == "")
            {
                MENSAJE += "ES NECESARIO EL PASSWORD DEL USUARIO\n";
            }
            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_USUARIO.Editar(OBJ, out MENSAJE);
            }

        }

        public bool Eliminar(Usuarios_sys OBJ, out string MENSAJE)
        {
            return OBJ_CD_USUARIO.Eliminar(OBJ, out MENSAJE);
        }
    }
}
