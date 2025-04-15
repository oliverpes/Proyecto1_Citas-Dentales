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

/* UNED: Proyecto III Cuatrimestre
 * Proyecto #1: Aplicacion para gestionar citas de una clinica dental
 * Estidiante: Marco Fernando Agüero Barboza
 * Fecha: 11/10/2023
 * 
 * Clase de formulario para agregar un nuevo cliente
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewClient : Form
    {
        public FormNewClient()
        {
            InitializeComponent();

            inputBirthday.Value = DateTime.Parse("01/01/2000");
        }

        // Boton para guardar un nuevo cliente
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            char gndr = inputGender.Text[0];
            Response res = Business.SaveClient(inputId.Text, inputName.Text, inputFirstLastName.Text, inputSecondLastName.Text, inputBirthday.Value.Date, gndr);
            if (res.Success)
            {
                if (MessageBox.Show("Cliente agregado. ¿desea agregar otro?", "Nuevo cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputBirthday.Value = DateTime.Parse("01/01/2000");
                    inputGender.Text = "No especificado";
                }
                else
                {
                    if (Owner is FormAdminClients formClients)
                    {
                        formClients.UpdateData();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(res.Message, "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
