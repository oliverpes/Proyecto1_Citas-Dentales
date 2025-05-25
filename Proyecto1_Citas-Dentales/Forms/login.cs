using BusinessLogic;
using System;
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
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void UsuarioTxt_TextChanged(object sender, EventArgs e) { }
        private void ContraseñaTxt_TextChanged(object sender, EventArgs e) { }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
