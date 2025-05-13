using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            /*codigo de prueba para abrir la trancision*/
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            UserService userService = new UserService();
            bool esValido = userService.ValidarUsuario(usuario, contraseña);

            if (esValido)
            {
                //permite centrar la apliacion y que sea responsive
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.StartPosition = FormStartPosition.CenterScreen;
                mainMenu.Location = this.Location; // Misma posición que el login
                //mainMenu.Size = this.Size;         // Misma dimensión (opcional)

                mainMenu.Show();
                this.Hide(); // O this.Close() si quieres cerrarlo
            }

            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
   
        }
        private void txContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
