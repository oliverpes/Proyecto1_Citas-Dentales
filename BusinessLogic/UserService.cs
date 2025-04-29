using System;
using System.Data.SqlClient;
using Entities;
using System.Data;

namespace BusinessLogic
{
    public class UserService
    {
        private string connectionString = "Server=TU_SERVIDOR;Database=CitasDentales;User Id=CDENTAL;Password=OLIVER4209;";

        public bool RegistrarUsuario(string usuario, string contraseña)
        {
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

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            string contraseñaHash = PasswordHasher.HashPassword(contraseña);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseñaHash);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
