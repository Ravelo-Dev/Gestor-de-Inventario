using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Permisos
    {
        private CD_Permisos OBJ_CD_PERMISOS = new CD_Permisos();

        public List<Permisos_sys> Llenar(int ID_USUARIO)
        {
            return OBJ_CD_PERMISOS.Llenar(ID_USUARIO);
        }
    }
}
