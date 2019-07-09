using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mantencion.Models;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Mantencion.Controllers
{
    public class HomeController : Controller
    {
        Usuario user = null;

        public HomeController()
        {
            user = new Usuario();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string usuario, string pass)
        {
            
            if (consulta_usuario(usuario.Trim().ToUpper(), pass.Trim()) == 1)
            {
                HttpContext.Session.SetString("Usuario", usuario.ToUpper());
                consulta_acceso();
                //Usuario.User = usuario.ToUpper();
                return View("Bienvenido");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Cuenta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cuenta(Usuario usu, string usuario, string pass)
        {
            if (user.Editar_Usuario(usu))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int consulta_usuario(string nom, string pass)
        {
            RijndaelManaged rij = new RijndaelManaged();
            string descryp = Decrypt(consulta("password", nom.Trim().ToUpper()), rij, consulta("id_key", nom.Trim().ToUpper()));
            if (descryp == pass)
            {
                int ok = 1;
                return ok;
            }
            return 0;
        }

        private string consulta(string campo, string user)
        {
            SqlConnection conn = Mantencion.Utilidad.conexion.AbrirConexion();
            string query = "select " + campo + " from usuarios where id_usuario='" + user + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string pass = leer.GetString(0);
                conn.Close();
                return pass;
            }
            conn.Close();
            return "";
        }

        private void consulta_acceso()
        {
            SqlConnection conn = Mantencion.Utilidad.conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("consulta_acceso_usuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id_usuario", HttpContext.Session.GetString("Usuario"));
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                HttpContext.Session.SetInt32("log_lectura_tareas", Convert.ToInt32(leer.GetBoolean(0)));
                HttpContext.Session.SetInt32("log_escritura_tareas", Convert.ToInt32(leer.GetBoolean(1)));
                HttpContext.Session.SetInt32("log_lectura_controles", Convert.ToInt32(leer.GetBoolean(2)));
                HttpContext.Session.SetInt32("log_escritura_controles", Convert.ToInt32(leer.GetBoolean(3)));
                conn.Close();
            }
            conn.Close();
        }

        public static string Decrypt(string message, SymmetricAlgorithm algorithm, string key)
        {
            try
            {
                algorithm.Key = Convert.FromBase64String(key);
                algorithm.Mode = CipherMode.ECB;
                ICryptoTransform decryptor = algorithm.CreateDecryptor();
                byte[] data = Convert.FromBase64String(message);
                byte[] dataDecrypted = decryptor.TransformFinalBlock(data, 0, data.Length);
                return Encoding.Unicode.GetString(dataDecrypted);
            }
            catch
            {
                throw;
            }
        }
    }
}
