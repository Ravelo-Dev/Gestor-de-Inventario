using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compras
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public int ObtenerCorrelativo()
        {
            int id_correlativo = 0;

            try
            {
                StringBuilder Consulta = new StringBuilder();
                Consulta.AppendLine("SELECT COUNT(*) + 1 FROM COMPRAS");
                SqlCommand CMD = new SqlCommand(Consulta.ToString(), Cnxion);
                CMD.CommandType = CommandType.Text;

                Cnxion.Open();

                id_correlativo = Convert.ToInt32(CMD.ExecuteScalar());

                
            }
            catch (Exception ex)
            {
                id_correlativo = 0;
            }

            return id_correlativo;
        }

        public bool Inserta(Compras obj, DataTable DETALLE_COMPRA, out string MENSAJE)
        {
            bool RESULTADO = false;
            MENSAJE = string.Empty;

            try
            {
                Cnxion.Open();
                SqlCommand CMD = new SqlCommand("SP_REGISTRAR_COMPRA", Cnxion);
                CMD.Parameters.AddWithValue("ID_USUARIO", obj.OBJ_USUARIO.ID_USUARIO);
                CMD.Parameters.AddWithValue("ID_PROVEEDOR", obj.OBJ_PROVEEDOR.ID_PROVEEDOR);
                CMD.Parameters.AddWithValue("TIPO_DOCUMENTO", obj.TIPO_DOCUMENTO);
                CMD.Parameters.AddWithValue("NUM_DOCUMENTO", obj.NUM_DOCUMENTO);
                CMD.Parameters.AddWithValue("MONTO_TOTAL", obj.MONTO_TOTAL);
                CMD.Parameters.AddWithValue("DETALLE_COMPRA", DETALLE_COMPRA);
                CMD.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD.CommandType = CommandType.StoredProcedure;

                CMD.ExecuteNonQuery();
                RESULTADO = Convert.ToBoolean(CMD.Parameters["RESULTADO"].Value);
                MENSAJE = CMD.Parameters["MENSAJE"].Value.ToString();

            }
            catch (Exception ex)
            {
                RESULTADO = false;
                MENSAJE = ex.Message;
            }

            return RESULTADO;
        }
    }
}
