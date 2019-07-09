using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mantencion.Models
{
    public class ControlDataAccessLayer
    {
        static string connectionString = @"Server=tcp:sislansql.database.windows.net,1433;Initial Catalog=MusselsMantencion;Persist Security Info=False;User ID=dba;Password=Sql747526;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public IEnumerable<Control> ObtenerTodosLosConsumos(DateTime f, int t, int tipo)
        {
            List<Control> lstControl = new List<Control>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("consulta_all_controles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", f);
                cmd.Parameters.AddWithValue("@id_turno", t);
                cmd.Parameters.AddWithValue("@id_tipo_consumo", tipo);
                con.Open();
                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    Control co = new Control();
                    co.id_registro = leer.GetInt32(0);
                    co.fecha = leer.GetDateTime(1);
                    co.id_turno = leer.GetInt32(2);
                    co.id_tipo_consumo = leer.GetInt32(3);
                    co.consumo_entrada = leer.GetInt32(4);
                    co.consumo_salida = leer.GetInt32(5);
                    co.consumo_total = leer.GetInt32(6);
                    co.id_usuario = leer.GetString(7);
                    co.fec_registro = leer.GetDateTime(8);

                    lstControl.Add(co);
                }
                con.Close();
            }
            return lstControl;
        }

        public void Agregar_Control(Control co)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update_controles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@modo", 1);
                cmd.Parameters.AddWithValue("@id_registro", Mantencion.Utilidad.conexion.correlativos(10));
                cmd.Parameters.AddWithValue("@fecha", co.fecha);
                cmd.Parameters.AddWithValue("@id_turno", co.id_turno);
                cmd.Parameters.AddWithValue("@id_tipo_consumo", co.id_tipo_consumo);
                cmd.Parameters.AddWithValue("@consumo_entrada", co.consumo_entrada);
                cmd.Parameters.AddWithValue("@consumo_salida", co.consumo_salida);
                cmd.Parameters.AddWithValue("@id_usuario", co.id_usuario);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Editar_Control(Control co)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update_controles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@modo", 2);
                cmd.Parameters.AddWithValue("@id_registro", co.id_registro);
                cmd.Parameters.AddWithValue("@fecha", co.fecha);
                cmd.Parameters.AddWithValue("@id_turno", co.id_turno);
                cmd.Parameters.AddWithValue("@id_tipo_consumo", co.id_tipo_consumo);
                cmd.Parameters.AddWithValue("@consumo_entrada", co.consumo_entrada);
                cmd.Parameters.AddWithValue("@consumo_salida", co.consumo_salida);
                cmd.Parameters.AddWithValue("@id_usuario", co.id_usuario);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Control ObtenerControl(int? id)
        {
            Control co = new Control();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM control WHERE id_registro=" + id;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    co.id_registro = leer.GetInt32(0);
                    co.fecha = leer.GetDateTime(1);
                    co.id_turno = leer.GetInt32(2);
                    co.id_tipo_consumo = leer.GetInt32(3);
                    co.consumo_entrada = leer.GetInt32(4);
                    co.consumo_salida = leer.GetInt32(5);
                    co.consumo_total = leer.GetInt32(6);
                    co.id_usuario = leer.GetString(7);
                    co.fec_registro = leer.GetDateTime(8);
                }
            }
            return co;
        }
    }
}
