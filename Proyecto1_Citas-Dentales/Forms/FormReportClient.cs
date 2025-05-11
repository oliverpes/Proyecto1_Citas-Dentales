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



namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportClient : Form
    {
        public FormReportClient()
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

            // Agregar los clientes al ComboBox
            foreach (var client in Business.clients)
            {
                if (client != null)
                {
                    string clientData = client.Id.ToString() + " - " + client.Name + " " + client.LastName;
                    inputClients.Items.Add(clientData);
                }
            }
        }


        // Boton para generar el reporte cliente
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            string clientInput = inputClients.Text;
            string[] clientData = clientInput.Split('-');
            int clientId;

            if (!int.TryParse(clientData[0].Trim(), out clientId))
            {
                MessageBox.Show("Seleccione un cliente.", "Reporte clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Appointment appointment in Business.appointments)
            {
                if (appointment != null && appointment.Client.Id == clientId)
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
