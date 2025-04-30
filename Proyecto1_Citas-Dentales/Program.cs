using Proyecto1_Citas_Dentales.Forms;

namespace Proyecto1_Citas_Dentales
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Crear una instancia de login
            login loginForm = new login();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Size = new Size(1000, 700);
            Application.Run(loginForm);
        }
    }
}
