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
    public class CD_Clientes
    {
        SqlConnection Cnxion = new SqlConnection(CD_Conexion.CON_Cnxion);
        public List<Clientes> Llenar()
        {
            List<Clientes> Lista_Clientes = new List<Clientes>();

            try
            {
                SqlCommand CMD = new SqlCommand("SP_LLENAR_CLIENTE", Cnxion);
                CMD.CommandType = CommandType.StoredProcedure;

                Cnxion.Open();

                using (SqlDataReader Reader = CMD.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        Lista_Clientes.Add(new Clientes()
                        {
                            ID_CLIENTE = Convert.ToInt32(Reader["ID_CLIENTE"]),
                            DOCUMENTO = Reader["DOCUMENTO"].ToString(),
                            NOMBRE = Reader["NOMBRE"].ToString(),
                            CORREO = Reader["CORREO"].ToString(),
                            TELEFONO = Reader["TELEFONO"].ToString(),
                            ESTADO = Convert.ToBoolean(Reader["ESTADO"]),
                            
                        });
                    }
                }
            }
            catch (Exception ex)
            {
              Lista_Clientes = new List<Clientes>();
            }
        return Lista_Clientes;
        }

        public int Insertar(Clientes OBJ_CLIENTE, out string MENSAJE)
        {
            int Id_Cliente_Generado = 0;
            MENSAJE = string.Empty;

            try
            {
                Cnxion.Open();
                SqlCommand CMD_INSERT = new SqlCommand("SP_INSERTAR_CLIENTE", Cnxion);

                CMD_INSERT.CommandType = CommandType.StoredProcedure;
                CMD_INSERT.Parameters.AddWithValue("@DOCUMENTO", OBJ_CLIENTE.DOCUMENTO);
                CMD_INSERT.Parameters.AddWithValue("@NOMBRE", OBJ_CLIENTE.NOMBRE);
                CMD_INSERT.Parameters.AddWithValue("@CORREO", OBJ_CLIENTE.CORREO);
                CMD_INSERT.Parameters.AddWithValue("@TELEFONO", OBJ_CLIENTE.TELEFONO);
                CMD_INSERT.Parameters.AddWithValue("@ESTADO", OBJ_CLIENTE.ESTADO);
                CMD_INSERT.Parameters.Add("RESULTADO", SqlDbType.Int).Direction = ParameterDirection.Output;
                CMD_INSERT.Parameters.Add("MENSAJE", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                CMD_INSERT.ExecuteNonQuery();
                Id_Cliente_Generado = Convert.ToInt32(CMD_INSERT.Parameters["RESULTADO"].Value);
                MENSAJE = CMD_INSERT.Parameters["MENSAJE"].Value.ToString();


            }
            catch (Exception ex)
            {
                Id_Cliente_Generado = 0;
                MENSAJE = ex.Message;
            }

            return Id_Cliente_Generado;
        }

        public bool Editar(Clientes OBJ_CLIENTE, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_UPDATE = new SqlCommand("SP_EDITAR_CLIENTE", Cnxion);

                CMD_UPDATE.CommandType = CommandType.StoredProcedure;
                CMD_UPDATE.Parameters.AddWithValue("@ID_CLIENTE", OBJ_CLIENTE.ID_CLIENTE);
                CMD_UPDATE.Parameters.AddWithValue("@DOCUMENTO", OBJ_CLIENTE.DOCUMENTO);
                CMD_UPDATE.Parameters.AddWithValue("@NOMBRE", OBJ_CLIENTE.NOMBRE);
                CMD_UPDATE.Parameters.AddWithValue("@CORREO", OBJ_CLIENTE.CORREO);
                CMD_UPDATE.Parameters.AddWithValue("@TELEFONO", OBJ_CLIENTE.TELEFONO);
                CMD_UPDATE.Parameters.AddWithValue("@ESTADO", OBJ_CLIENTE.ESTADO);
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

        public bool Eliminar(Clientes OBJ_CLIENTE, out string MENSAJE)
        {
            bool Respuesta = false;
            MENSAJE = string.Empty;

            try
            {

                Cnxion.Open();
                SqlCommand CMD_DELETE = new SqlCommand("DELETE FROM CLIENTES WHERE ID_CLIENTE = @ID", Cnxion);

                CMD_DELETE.Parameters.AddWithValue("@ID", OBJ_CLIENTE.ID_CLIENTE);
                CMD_DELETE.CommandType = CommandType.Text;


                Respuesta = CMD_DELETE.ExecuteNonQuery() > 0 ? true : false ;
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
