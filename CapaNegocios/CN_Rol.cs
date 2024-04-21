using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Rol
    {
        private CD_Rol OBJ_CD_ROLES = new CD_Rol();

        public List<Roles_sys> Llenar()
        {
            return OBJ_CD_ROLES.Llenar();
        }
    }
}
