using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Categorias
    {
        CD_Categorias OBJ_CD_CATEGORIA = new CD_Categorias();

        public List<Categorias> Llenar()
        {
            return OBJ_CD_CATEGORIA.Llenar();
        }

        public int Insertar(Categorias OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            

            if (OBJ.DESCRIPCION == "")
            {
                MENSAJE += "ES NECESARIO LA DESCRIPCION DE LA CATEGORIA\n";
            }

            if (MENSAJE != string.Empty)
            {
                return 0;
            }
            else
            {
                return OBJ_CD_CATEGORIA.Insertar(OBJ, out MENSAJE);
            }


        }

        public bool Editar(Categorias OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;

            if (OBJ.DESCRIPCION == "")
            {
                MENSAJE += "ES NECESARIO LA DESCRIPCION DE LA CATEGORIA\n";
            }
            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_CATEGORIA.Editar(OBJ, out MENSAJE);
            }

        }

        public bool Eliminar(Categorias OBJ, out string MENSAJE)
        {
            return OBJ_CD_CATEGORIA.Eliminar(OBJ, out MENSAJE);
        }
    }
}

