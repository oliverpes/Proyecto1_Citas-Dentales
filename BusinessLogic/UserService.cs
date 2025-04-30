using System;
using System.Data.SqlClient;
using Entities;
using System.Data;
using System.IO;

namespace BusinessLogic
{
    public class UserService
    {
        private string connectionString;

        public UserService()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt");

            if (File.Exists(configPath))
            {
                connectionString = File.ReadAllText(configPath).Trim();
            }
            else
            {
                throw new Exception("No se encontró el archivo config.txt con la cadena de conexión.");
            }
        }

        // Método para registrar un usuario
        public bool RegistrarUsuario(string usuario, string contraseña)
        {
            // Hashear la contraseña usando BCrypt
            string contraseñaHash = PasswordHasher.HashPassword(contraseña);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@usuario, @contraseña)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contraseña", contraseñaHash);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Error al registrar usuario: " + ex.Message);
                }
            }
        }

        // Método para validar un usuario
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Contraseña FROM Usuarios WHERE Usuario = @usuario";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        string contraseñaGuardada = resultado.ToString();
                        return contraseña == contraseñaGuardada; // compara directamente texto plano
                    }

                    return false; // Usuario no encontrado
                }
            }
        }
    }
}
