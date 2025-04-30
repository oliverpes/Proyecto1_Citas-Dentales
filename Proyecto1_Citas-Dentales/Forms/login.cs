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

            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            UserService userService = new UserService();

            bool esValido = userService.ValidarUsuario(usuario, contraseña);

            if (esValido)
            {
                MessageBox.Show("¡Login exitoso!");
                //OpenC(new Forms.FormAppointments(), sender);
                FormMainMenu mainMenu = new FormMainMenu();
                mainMenu.Show();
                this.Hide(); // Oculta el login, o usa this.Close() para cerrarlo completamente
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }


        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
