using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Negocio
    {
        CD_Negocio OBJ_CD_NEGOCIO = new CD_Negocio();

        public Negocios LlenarDatos()
        {
            return OBJ_CD_NEGOCIO.LlenarDatos();
        }

        public bool GuardarDatos(Negocios OBJ, out string MENSAJE)
        {
            MENSAJE = string.Empty;
            if (OBJ.NOMBRE == "")
            {
                MENSAJE += "ES NECESARIO EL DOCUMENTO DEL USUARIO\n";
            }


            if (OBJ.RNC == "")
            {
                MENSAJE += "ES NECESARIO EL NOMBRE DEL USUARIO\n";
            }


            if (OBJ.DIRECCION == "")
            {
                MENSAJE += "ES NECESARIO EL PASSWORD DEL USUARIO\n";
            }

            if (MENSAJE != string.Empty)
            {
                return false;
            }
            else
            {
                return OBJ_CD_NEGOCIO.GuardarDatos(OBJ, out MENSAJE);
            }
        }

        public byte[] ObtenerLogo(out bool Obtenido)
        {
            return OBJ_CD_NEGOCIO.ObtenerLogo(out Obtenido);
        }

        public bool ActualizarLogo(byte[] IMAGEN , out string MENSAJE)
        {
            return OBJ_CD_NEGOCIO.ActualizarLogo(IMAGEN, out MENSAJE);
        }
    }
}
