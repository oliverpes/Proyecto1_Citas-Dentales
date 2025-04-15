using Entities;
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
 * Clase de la interfaz grafica para generar un reporte de citas por fecha
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportDate : Form
    {
        public FormReportDate()
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
        }

        // Boton para generar el reporte
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            DateTime date = inputDateSearch.Value;

            for (int i = 0; i < Business.appointments.Length; i++)
            {
                if (Business.appointments[i] != null)
                {
                    if (Business.appointments[i].Date.Date == date.Date)
                    {
                        // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                        string id = Business.appointments[i].Id.ToString();
                        string dateStr = Business.appointments[i].Date.ToString();

                        QueryType qt = Business.appointments[i].QueryType;
                        Client client = Business.appointments[i].Client;
                        Doctor doctor = Business.appointments[i].Doctor;

                        string type = qt.Description;
                        string doctorName = doctor.Name;
                        string clientName = client.Name;

                        string[] row = { id, dateStr, type, doctorName, clientName };

                        resultsView.Rows.Add(row);
                    }
                }
            }
        }
    }
}
