using BusinessLogic;
using Entities;
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
 * Clase de la interfaz grafica para generar un reporte de citas por doctor
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportDoctor : Form
    {
        public FormReportDoctor()
        {
            InitializeComponent();

            // Crear las columnas del DataGridView
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDate = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnType = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDoctor = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnClient = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnDate.HeaderText = "Fecha";
            columnType.HeaderText = "Tipo";
            columnDoctor.HeaderText = "Doctor";
            columnClient.HeaderText = "Cliente";

            resultsView.Columns.Add(columnId);
            resultsView.Columns.Add(columnDate);
            resultsView.Columns.Add(columnType);
            resultsView.Columns.Add(columnDoctor);
            resultsView.Columns.Add(columnClient);

            // Agregar los doctores al ComboBox
            for (int i = 0; i < Business.doctors.Length; i++)
            {
                if (Business.doctors[i] != null)
                {
                    Doctor doctor = Business.doctors[i];
                    string doctorData = doctor.Id.ToString() + " - " + doctor.Name + " " + doctor.LastName;
                    inputDoctors.Items.Add(doctorData);
                }
            }
        }

        // Boton para generar el reporte
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            string doctorInput = inputDoctors.Text;
            string[] doctorData = doctorInput.Split('-');
            int doctorId;

            if (int.TryParse(doctorData[0], out doctorId) == false)
            {
                MessageBox.Show("Seleccione un doctor.", "Reporte doctores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < Business.appointments.Length; i++)
            {
                if (Business.appointments[i] != null)
                {
                    Appointment appointment = Business.appointments[i];
                    if (appointment.Doctor.Id == doctorId)
                    {
                        string[] row = new string[]
                        {
                            appointment.Id.ToString(),
                            appointment.Date.ToString(),
                            appointment.QueryType.Description,
                            appointment.Doctor.Name + " " + appointment.Doctor.LastName,
                            appointment.Client.Name + " " + appointment.Client.LastName
                        };
                        resultsView.Rows.Add(row);
                    }
                }
            }
        }
    }
}
