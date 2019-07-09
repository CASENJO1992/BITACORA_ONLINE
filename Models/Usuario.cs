using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mantencion.Models
{
    public class Usuario
    {
        static string connectionString = @"Server=tcp:sislansql.database.windows.net,1433;Initial Catalog=MusselsMantencion;Persist Security Info=False;User ID=dba;Password=Sql747526;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        private static string _user;
        public static  string User { get => _user; set => _user = value; }
        public string usuario { set; get; }
        public string pass { set; get; }

        public bool Editar_Usuario(Usuario user)
        {
            if (Usuario_Existe(user.usuario) == 0)
            {
                return false;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("update_pass_usuario", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    RijndaelManaged rij = new RijndaelManaged();
                    string key = GenerateKey(rij, 256);
                    string passencrypted = Encrypt(user.pass, rij, key);

                    cmd.Parameters.AddWithValue("@id_usuario", user.usuario.ToUpper());
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.Parameters.AddWithValue("@pass", passencrypted);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch { return false; }
            }
        }

        public static string GenerateKey(SymmetricAlgorithm algorithm, int keySize)
        {
            if (algorithm.ValidKeySize(keySize))
            {
                algorithm.KeySize = keySize;
                algorithm.GenerateKey();
                return Convert.ToBase64String(algorithm.Key);
            }
            else
                throw new ArgumentException("Invalid key size");
        }

        public static string Encrypt(string message, SymmetricAlgorithm algorithm, string key)
        {
            algorithm.Key = Convert.FromBase64String(key);
            algorithm.Mode = CipherMode.ECB;
            ICryptoTransform encryptor = algorithm.CreateEncryptor();
            byte[] data = Encoding.Unicode.GetBytes(message);
            byte[] dataEncrypted = encryptor.TransformFinalBlock(data, 0, data.Length);
            return Convert.ToBase64String(dataEncrypted);
        }

        public int Usuario_Existe(string user)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT count(*) FROM usuarios WHERE id_usuario='" + user + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int existe = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return existe;
            }
        }
    }
}
