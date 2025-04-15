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
 * Clase de la interfaz de administracion de citas
 */

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAppointments : Form
    {
        // Variable para guardar el id de la fila seleccionada
        private int selectedId;

        public FormAppointments()
        {
            InitializeComponent();

            // Agregar columnas al DataGridView
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

            appointmentsView.Columns.Add(columnId);
            appointmentsView.Columns.Add(columnDate);
            appointmentsView.Columns.Add(columnType);
            appointmentsView.Columns.Add(columnDoctor);
            appointmentsView.Columns.Add(columnClient);

            UpdateData();
        }

        // Actualizar datos del DataGridView
        public void UpdateData()
        {
            appointmentsView.Rows.Clear();

            foreach (Appointment appointment in Business.appointments)
            {
                if (appointment != null)
                {
                    // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                    string id = appointment.Id.ToString();
                    string date = appointment.Date.ToString();

                    QueryType qt = appointment.QueryType;
                    Client client = appointment.Client;
                    Doctor doctor = appointment.Doctor;

                    string type = qt != null ? qt.Id.ToString() + " - " + qt.Description : "N/A";
                    string doctorName = doctor != null ? doctor.Id.ToString() + " - " + doctor.Name + " " + doctor.LastName : "N/A";
                    string clientName = client != null ? client.Id.ToString() + " - " + client.Name + " " + client.LastName : "N/A";

                    string[] row = { id, date, type, doctorName, clientName };

                    appointmentsView.Rows.Add(row);
                }
            }
        }

        // Boton para crear una nueva cita
        private void HandleNewAppoiment(object sender, EventArgs e)
        {
            // Variables para saber si existe el cliente, doctor y tipo de consulta
            bool foundClient = false;
            bool foundDoctor = false;
            bool foundQueryType = false;

            // Verificar si existen clientes, doctores y tipos de consulta
            foreach (Client client in Business.clients)
            {
                if (client != null)
                {
                    foundClient = true;
                    break;
                }
            }
            foreach (Doctor doctor in Business.doctors)
            {
                if (doctor != null && doctor.State == 'A')
                {
                    foundDoctor = true;
                    break;
                }
            }
            foreach (QueryType queryType in Business.queryTypes)
            {
                if (queryType != null && queryType.State == 'A')
                {
                    foundQueryType = true;
                    break;
                }
            }
            if (!foundClient)
            {
                MessageBox.Show("No hay clientes registrados");
                return;
            }
            if (!foundDoctor)
            {
                MessageBox.Show("No hay doctores registrados");
                return;
            }
            if (!foundQueryType)
            {
                MessageBox.Show("No hay tipos de consulta registrados");
                return;
            }

            // Abrir formulario para crear una nueva cita
            FormNewAppointment formNewAppointment = new FormNewAppointment();
            formNewAppointment.Owner = this;
            formNewAppointment.ShowDialog();
        }

        // Seleccionar una cita
        private void HandleClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(appointmentsView.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                selectedId = 0;
            }
        }

        // Boton para eliminar una cita
        private void DeleteAppointment(object sender, EventArgs e)
        {
            if (selectedId <= 0)
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro que desea eliminar la cita?", "Eliminar cita", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Response response = Business.DeleteAppointment(selectedId);

                if (response.Success)
                {
                    UpdateData();
                }
                else
                {
                    MessageBox.Show(response.Message, "Eliminar cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
