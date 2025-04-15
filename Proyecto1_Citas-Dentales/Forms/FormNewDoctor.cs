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
 * Clase de formulario para agregar un nuevo doctor
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewDoctor : Form
    {
        public FormNewDoctor()
        {
            InitializeComponent();
        }

        // Boton para guardar un nuevo doctor
        private void buttonSaveDoctor_Click(object sender, EventArgs e)
        {
            char state = inputState.Text[0];
            Response res = Business.SaveDoctor(inputId.Text, inputName.Text, inputFirstLastName.Text, inputSecondLastName.Text, state);
            if (res.Success)
            {
                if (MessageBox.Show("Doctor agregado. ¿desea agregar otro?", "Nuevo doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    inputId.Text = "";
                    inputName.Text = "";
                    inputFirstLastName.Text = "";
                    inputSecondLastName.Text = "";
                    inputState.Text = "Inactivo";
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
    }
}
