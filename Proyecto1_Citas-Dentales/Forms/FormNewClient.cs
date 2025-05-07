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
            Response res = Business.SaveClient(inputName.Text, inputFirstLastName.Text, inputSecondLastName.Text, inputBirthday.Value.Date, gndr);

            if (res.Success)
            {
                string info = res.GeneratedId.HasValue ? $"ID asignado: {res.GeneratedId}" : "";
                if (MessageBox.Show($"Cliente agregado. {info}\n¿Desea agregar otro?", "Nuevo cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
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
