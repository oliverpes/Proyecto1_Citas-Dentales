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

        // Boton para generar el reporte fecha
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            DateTime selectedDate = inputDateSearch.Value.Date;

            foreach (Appointment appointment in Business.appointments)
            {
                if (appointment != null && appointment.Date.Date == selectedDate)
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
