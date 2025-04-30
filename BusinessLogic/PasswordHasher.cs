using BCrypt.Net;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLogic
{
    public static class PasswordHasher
    {
        // Método que usa BCrypt para hacer hash de la contraseña
        public static string HashPassword(string password)
        {
            // Hashing de la contraseña con BCrypt
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Método para verificar la contraseña con un hash previamente generado
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            // Verificación de la contraseña contra el hash almacenado
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
