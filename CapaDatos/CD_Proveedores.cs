using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public List<Proveedores> Llenar()
        {
            List<Proveedores> Lista_Proveedores = new List<Proveedores>();

            try
            {
                SqlCommand CMD = new SqlCommand("SP_LLENAR_PROVEEDOR", Cnxion);
                CMD.CommandType = CommandType.StoredProcedure;

                Cnxion.Open();

                using (SqlDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Lista_Proveedores.Add(new Proveedores()
                        {
                            ID_PROVEEDOR = Convert.ToInt32(Reader["ID_PROVEEDOR"]),
                            DOCUMENTO = Reader["DOCUMENTO"].ToString(),
                            RAZON_SOCIAL = Reader["RAZON_SOCIAL"].ToString(),
                            CORREO = Reader["CORREO"].ToString(),
                            TELEFONO = Reader["TELEFONO"].ToString(),
                            ESTADO = Convert.ToBoolean(Reader["ESTADO"]),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Lista_Proveedores = new List<Proveedores>();
            }
            return Lista_Proveedores;
        }

        public int Insertar(Proveedores OBJ_PROVEEDOR, out string MENSAJE)
        {
            int Id_Proveedor_Generado = 0;
            MENSAJE = string.Empty;

            try
            {
                Cnxion.Open();
                SqlCommand CMD_INSERT = new SqlCommand("SP_INSERTAR_PROVEEDOR", Cnxion);

                CMD_INSERT.CommandType = CommandType.StoredProcedure;
                CMD_INSERT.Parameters.AddWithValue("@DOCUMENTO", OBJ_PROVEEDOR.DOCUMENTO);
                CMD_INSERT.Parameters.AddWithValue("@RAZON_SOCIAL", OBJ_PROVEEDOR.RAZON_SOCIAL);
                CMD_INSERT.Parameters.AddWithValue("@CORREO", OBJ_PROVEEDOR.CORREO);
                CMD_INSERT.Parameters.AddWithValue("@TELEFONO", OBJ_PROVEEDOR.TELEFONO);
                CMD_INSERT.Parameters.AddWithValue("@ESTADO", OBJ_PROVEEDOR.ESTADO);
                CMD_INSERT.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_INSERT.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_INSERT.ExecuteNonQuery();
                Id_Proveedor_Generado = Convert.ToInt32(CMD_INSERT.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_INSERT.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Id_Proveedor_Generado = 0;
                MENSAJE = ex.Message;
            }

            return Id_Proveedor_Generado;
        }

        public bool Editar(Proveedores OBJ_PROVEEDOR, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_UPDATE = new SqlCommand("SP_EDITAR_PROVEEDOR", Cnxion);

                CMD_UPDATE.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE.Parameters.AddWithValue("@ID_PROVEEDOR", OBJ_PROVEEDOR.ID_PROVEEDOR);
                CMD_UPDATE.Parameters.AddWithValue("@DOCUMENTO", OBJ_PROVEEDOR.DOCUMENTO);
                CMD_UPDATE.Parameters.AddWithValue("@RAZON_SOCIAL", OBJ_PROVEEDOR.RAZON_SOCIAL);
                CMD_UPDATE.Parameters.AddWithValue("@CORREO", OBJ_PROVEEDOR.CORREO);
                CMD_UPDATE.Parameters.AddWithValue("@TELEFONO", OBJ_PROVEEDOR.TELEFONO);
                CMD_UPDATE.Parameters.AddWithValue("@ESTADO", OBJ_PROVEEDOR.ESTADO);
                CMD_UPDATE.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_UPDATE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_UPDATE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_UPDATE.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_UPDATE.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Respuesta = false;
                MENSAJE = ex.Message;
            }

            return Respuesta;
        }

        public bool Eliminar(Proveedores OBJ_PROVEEDOR, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_DELETE = new SqlCommand("SP_ELIMINAR_PROVEEDOR", Cnxion);

                CMD_DELETE.CommandType = CommandType.StoredProcedure;
                CMD_DELETE.Parameters.AddWithValue("@ID_PROVEEDOR", OBJ_PROVEEDOR.ID_PROVEEDOR);
                CMD_DELETE.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_DELETE.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_DELETE.ExecuteNonQuery();

                Respuesta = Convert.ToBoolean(CMD_DELETE.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_DELETE.Parameters["MENSAJE"].Value.ToString();
                Cnxion.Close();

            }
            catch (Exception ex)
            {
                Respuesta = false;
                MENSAJE = ex.Message;
            }

            return Respuesta;
        }
    }
}
