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
 * Clase de la interfaz de edicion de clientes
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();

            // Cargar los datos del cliente seleccionado
            for (int i = 0; i < Business.clients.Length; i++)
            {
                if (Business.clients[i] != null && Business.clients[i].Id == Business.selectedClientId)
                {
                    inputId.Text = Business.clients[i].Id.ToString();
                    inputName.Text = Business.clients[i].Name;
                    inputFirstLastName.Text = Business.clients[i].LastName;
                    inputSecondLastName.Text = Business.clients[i].SecondLastName;
                    inputBirthday.Text = Business.clients[i].BirthDate.ToString();
                    if (Business.clients[i].Gender == 'M')
                    {
                        inputGender.Text = "Masculino";
                    }
                    else if (Business.clients[i].Gender == 'F')
                    {
                        inputGender.Text = "Femenino";
                    }
                    else
                    {
                        inputGender.Text = "No especificado";
                    }
                }
            }
        }

        // Boton para guardar los cambios y cerrar la ventana
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            char state = inputGender.Text.Length > 0 ? inputGender.Text[0] : 'N';
            Response res = Business.UpdateClientData(inputBirthday.Value, state);

            if (res.Success)
            {
                if (Owner is FormAdminClients formAdminClients)
                {
                    formAdminClients.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message, "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
