using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Compras
    {
        CD_Compras OBJ_CD_COMPRAS = new CD_Compras();

        public int ObtenerCorrelativo()
        {
            return OBJ_CD_COMPRAS.ObtenerCorrelativo();
        }

        public bool Insertar(Compras OBJ, DataTable DETALLE_COMPRA ,out string MENSAJE)
        {

            return OBJ_CD_COMPRAS.Inserta(OBJ, DETALLE_COMPRA, out MENSAJE);


        }

    }
}
