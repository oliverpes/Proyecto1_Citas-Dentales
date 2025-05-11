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
using System.Data.SqlClient;



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
            // Cargar los datos desde la base
            Business.LoadAppointmentsFromDatabase();

            appointmentsView.Rows.Clear();

            foreach (Appointment appointment in Business.appointments)
            {
                if (appointment != null)
                {
                    string id = appointment.Id.ToString();
                    string date = appointment.Date.ToString();

                    QueryType qt = appointment.QueryType;
                    Client client = appointment.Client;
                    Doctor doctor = appointment.Doctor;

                    string type = qt != null ? qt.Id + " - " + qt.Description : "N/A";
                    string doctorName = doctor != null ? doctor.Id + " - " + doctor.Name + " " + doctor.LastName : "N/A";
                    string clientName = client != null ? client.Id + " - " + client.Name + " " + client.LastName : "N/A";

                    string[] row = { id, date, type, doctorName, clientName };

                    appointmentsView.Rows.Add(row);
                }
            }
        }


        // Boton para crear una nueva cita
        private void HandleNewAppoiment(object sender, EventArgs e)
        {
            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE EstadoId = 1", conn))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay clientes activos registrados");
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Doctores WHERE EstadoId = 1", conn))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay doctores activos registrados");
                            return;
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TiposConsulta WHERE Estado = 1", conn))
                    {
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay tipos de consulta activos registrados");
                            return;
                        }
                    }
                }

                // Abrir formulario si pasa la validación
                FormNewAppointment formNewAppointment = new FormNewAppointment();
                formNewAppointment.Owner = this;
                formNewAppointment.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar los datos desde la base de datos: " + ex.Message);
            }
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
