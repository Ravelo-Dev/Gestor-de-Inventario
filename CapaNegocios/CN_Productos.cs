using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Productos
    {
        private CD_Productos OBJ_CD_PRODUCTO = new CD_Productos();

        public List<Productos> Llenar()
        {
            return OBJ_CD_PRODUCTO.Llenar();
        }

        public int Insertar(Productos OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.CODIGO == "")
            {
                MENSAJE += "ES NECESARIO EL CODIGO DEL PRODUCTO\n";
            }


            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL PRODUCTO\n";
            }


            if (OBJ.DESCRIPCION == "")
            {
                MENSAJE += "ES NECESARIO LA DESCRIPCION DEL PRODUCTO\n";
            }

            if (MENSAJE != string.Empty)
            {
                return 0;
            }
            else
            {
                return OBJ_CD_PRODUCTO.Insertar(OBJ, out MENSAJE);
            }


        }

        public bool Editar(Productos OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.CODIGO == "")
            {
                MENSAJE += "ES NECESARIO EL CODIGO DEL PRODUCTO\n";
            }


            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL PRODUCTO\n";
            }


            if (OBJ.DESCRIPCION == "")
            {
                MENSAJE += "ES NECESARIO LA DESCRIPCION DEL PRODUCTO\n";
            }
            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_PRODUCTO.Editar(OBJ, out MENSAJE);
            }

        }

        public bool Eliminar(Productos OBJ, out string MENSAJE)
        {
            return OBJ_CD_PRODUCTO.Eliminar(OBJ, out MENSAJE);
        }
    }
}

    

