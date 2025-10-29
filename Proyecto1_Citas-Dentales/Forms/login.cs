using BusinessLogic;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioTxt.Text.Trim();
            string contraseña = ContraseñaTxt.Text;

            // Validar que sea un correo electrónico
            if (!EsCorreoValido(usuario))
            {
                MessageBox.Show("Por favor ingrese un correo electrónico válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserService userService = new UserService();
                bool esValido = userService.ValidarUsuario(usuario, contraseña);

                if (esValido)
                {
                    FormMainMenu mainMenu = new FormMainMenu();
                    mainMenu.StartPosition = FormStartPosition.CenterScreen;
                    mainMenu.Location = this.Location;
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validar formato de correo electrónico
        private bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e) { }
        private void ContraseñaTxt_TextChanged(object sender, EventArgs e) { }

        private void labelTitulo_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
