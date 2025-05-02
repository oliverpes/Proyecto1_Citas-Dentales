using BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewDoctor : Form
    {
        public FormNewDoctor()
        {
            InitializeComponent();

            // Configurar ComboBox de estados
            inputState.DataSource = new List<KeyValuePair<int, string>> {
                new KeyValuePair<int, string>(1, "Activo"),
                new KeyValuePair<int, string>(0, "Inactivo")
            };
            inputState.DisplayMember = "Value";
            inputState.ValueMember = "Key";
        }

        private void buttonSaveDoctor_Click(object sender, EventArgs e)
        {
            int estadoId = ((KeyValuePair<int, string>)inputState.SelectedItem).Key;
            Response res = Business.SaveDoctor(inputId.Text, inputName.Text, inputFirstLastName.Text, inputSecondLastName.Text, estadoId);

            if (res.Success)
            {
                if (MessageBox.Show("Doctor agregado. ¿Desea agregar otro?", "Nuevo doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputState.SelectedIndex = 1; // "Inactivo"
                }
                else
                {
                    if (Owner is FormAdminDoctors formDoctors)
                    {
                        formDoctors.UpdateData();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(res.Message, "Nuevo doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputState_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No es necesario hacer nada aquí por ahora
        }
    }
}
