using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Proveedores
    {
        CD_Proveedores OBJ_CD_PROVEEDOR = new CD_Proveedores();

        public List<Proveedores> Llenar()
        {
            return OBJ_CD_PROVEEDOR.Llenar();
        }

        public int Insertar(Proveedores OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL PROVEEDOR\n";
            }


            if (OBJ.RAZON_SOCIAL == "")
            {
                MENSAJE += "ES NECESARIO LA RAZON SOCIAL DEL PROVEEDOR\n";
            }


            if (OBJ.CORREO == "")
            {
                MENSAJE += "ES NECESARIO EL CORREO DEL USUARIO\n";
            }

            if (MENSAJE != string.Empty)
            {
                return 0;
            }
            else
            {
                return OBJ_CD_PROVEEDOR.Insertar(OBJ, out MENSAJE);
            }


        }

        public bool Editar(Proveedores OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL PROVEEDOR\n";
            }


            if (OBJ.RAZON_SOCIAL == "")
            {
                MENSAJE += "ES NECESARIO LA RAZON SOCIAL DEL PROVEEDOR\n";
            }


            if (OBJ.CORREO == "")
            {
                MENSAJE += "ES NECESARIO EL CORREO DEL USUARIO\n";
            }
            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_PROVEEDOR.Editar(OBJ, out MENSAJE);
            }

        }

        public bool Eliminar(Proveedores OBJ, out string MENSAJE)
        {
            return OBJ_CD_PROVEEDOR.Eliminar(OBJ, out MENSAJE);
        }
    }
}
