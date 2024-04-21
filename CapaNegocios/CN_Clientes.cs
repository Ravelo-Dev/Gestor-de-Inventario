using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Clientes
    {
        CD_Clientes OBJ_CD_CLIENTE = new CD_Clientes();

        public List<Clientes> Llenar()
        {
            return OBJ_CD_CLIENTE.Llenar();
        }

        public int Insertar(Clientes OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL CLIENTE\n";
            }


            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL CLIENTE\n";
            }


            if (OBJ.CORREO == "")
            {
                MENSAJE += "ES NECESARIO EL CORREO DEL CLIENTE\n";
            }

            if (MENSAJE != string.Empty)
            {
                return 0;
            }
            else
            {
                return OBJ_CD_CLIENTE.Insertar(OBJ, out MENSAJE);
            }


        }

        public bool Editar(Clientes OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.DOCUMENTO == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL CLIENTE\n";
            }


            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL CLIENTE\n";
            }


            if (OBJ.CORREO == "")
            {
                MENSAJE += "ES NECESARIO EL CORREO DEL CLIENTE\n";
            }
            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_CLIENTE.Editar(OBJ, out MENSAJE);
            }

        }

        public bool Eliminar(Clientes OBJ, out string MENSAJE)
        {
            return OBJ_CD_CLIENTE.Eliminar(OBJ, out MENSAJE);
        }
    }
}
