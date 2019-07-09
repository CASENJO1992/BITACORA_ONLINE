using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Mantencion.Models
{
    public class TareasDataAccessLayer
    {
        static string connectionString = @"Server=tcp:sislansql.database.windows.net,1433;Initial Catalog=MusselsMantencion;Persist Security Info=False;User ID=dba;Password=Sql747526;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public IEnumerable<Tareas> ObtenerTodasLasTareas(DateTime f, int t)
        {
            List<Tareas> lstTareas = new List<Tareas>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("consulta_all_tareas", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha", f);
                cmd.Parameters.AddWithValue("@id_turno", t);
                con.Open();
                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    Tareas ta = new Tareas();
                    ta.id_registro = leer.GetInt32(0);
                    ta.fecha = leer.GetDateTime(1);
                    ta.id_turno = leer.GetInt32(2);
                    ta.actividad = leer.GetString(3);
                    ta.log_terminado = leer.GetBoolean(4);
                    ta.id_usuario = leer.GetString(5);
                    ta.fec_registro = leer.GetDateTime(6);

                    lstTareas.Add(ta);
                }
                con.Close();
            }
            return lstTareas;
        }

        public void Agregar_Tarea(Tareas ta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update_tareas_diarias", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@modo", 1);
                cmd.Parameters.AddWithValue("@id_registro", Mantencion.Utilidad.conexion.correlativos(9));
                cmd.Parameters.AddWithValue("@fecha", ta.fecha);
                cmd.Parameters.AddWithValue("@id_turno", ta.id_turno);
                cmd.Parameters.AddWithValue("@actividad", ta.actividad);
                cmd.Parameters.AddWithValue("@log_terminado", ta.log_terminado);
                cmd.Parameters.AddWithValue("@id_usuario", ta.id_usuario);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void Editar_Tarea(Tareas ta)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("update_tareas_diarias", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@modo", 2);
                cmd.Parameters.AddWithValue("@id_registro", ta.id_registro);
                cmd.Parameters.AddWithValue("@fecha", ta.fecha);
                cmd.Parameters.AddWithValue("@id_turno", ta.id_turno);
                cmd.Parameters.AddWithValue("@actividad", ta.actividad);
                cmd.Parameters.AddWithValue("@log_terminado", ta.log_terminado);
                cmd.Parameters.AddWithValue("@id_usuario", ta.id_usuario);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Tareas ObtenerTarea(int? id)
        {
            Tareas ta = new Tareas();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tareas WHERE id_registro=" + id;
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader leer = cmd.ExecuteReader();

                while (leer.Read())
                {
                    ta.id_registro = leer.GetInt32(0);
                    ta.fecha = leer.GetDateTime(1);
                    ta.id_turno = leer.GetInt32(2);
                    ta.actividad = leer.GetString(3);
                    ta.log_terminado = leer.GetBoolean(4);
                    ta.id_usuario = leer.GetString(5);
                    ta.fec_registro = leer.GetDateTime(6);
                }
            }
            return ta;
        }

        public void Eliminar_Tarea(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_registro", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
