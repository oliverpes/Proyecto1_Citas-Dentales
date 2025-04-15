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
 * Clase de formulario para generar el reporte de citas por cliente
 */

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
            for (int i = 0; i < Business.clients.Length; i++)
            {
                if (Business.clients[i] != null)
                {
                    Client client = Business.clients[i];
                    string clientData = client.Id.ToString() + " - " + client.Name + " " + client.LastName;
                    inputClients.Items.Add(clientData);
                }
            }
        }

        // Boton para generar el reporte
        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            string clientInput = inputClients.Text;
            string[] clientData = clientInput.Split('-');
            int clientId;
            if (int.TryParse(clientData[0], out clientId) == false)
            {
                MessageBox.Show("Seleccione un cliente.", "Reporte clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar las citas que coincidan con el cliente
            for (int i = 0; i < Business.appointments.Length; i++)
            {
                if (Business.appointments[i] != null)
                {
                    if (Business.appointments[i].Client.Id == clientId)
                    {
                        // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                        string id = Business.appointments[i].Id.ToString();
                        string dateStr = Business.appointments[i].Date.ToString();

                        QueryType qt = Business.appointments[i].QueryType;
                        Client client = Business.appointments[i].Client;
                        Doctor doctor = Business.appointments[i].Doctor;

                        string type = qt.Description;
                        string doctorName = doctor.Name + " " + doctor.LastName;
                        string clientName = client.Name + " " + client.LastName;

                        string[] row = { id, dateStr, type, doctorName, clientName };
                        resultsView.Rows.Add(row);
                    }
                }
            }
        }
    }
}
