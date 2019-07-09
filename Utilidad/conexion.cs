using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mantencion.Utilidad
{
    public class conexion
    {
        static string cadena = @"Server=tcp:sislansql.database.windows.net,1433;Initial Catalog=MusselsMantencion;Persist Security Info=False;User ID=dba;Password=Sql747526;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection AbrirConexion()
        {
            try
            {
                SqlConnection _connection = new SqlConnection(cadena);
                _connection.Open();
                return _connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Se ha producido un erro en el metodo AbrirConexion()", ex);
            }
        }

        public static int correlativos(int num)
        {
            try
            {
                SqlConnection conn = AbrirConexion();
                SqlCommand cmd = new SqlCommand("consulta_correlativos", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@modo", SqlDbType.Int).Value = num;
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    int corre = leer.GetInt32(0);
                    conn.Close();
                    return corre;
                }
                conn.Close();
                return 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
