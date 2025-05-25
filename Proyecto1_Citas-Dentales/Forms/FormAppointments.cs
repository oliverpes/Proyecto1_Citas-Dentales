using Entities;
using BusinessLogic;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAppointments : Form
    {
        private int selectedId;

        public FormAppointments()
        {
            InitializeComponent();
            ConfigureDataGridView();
            AddColumns();
            UpdateData();
        }

        // Estilo moderno sin librerías externas
        private void ConfigureDataGridView()
        {
            appointmentsView.BorderStyle = BorderStyle.None;
            appointmentsView.BackgroundColor = Color.White;
            appointmentsView.GridColor = Color.LightGray;
            appointmentsView.EnableHeadersVisualStyles = false;
            appointmentsView.RowHeadersVisible = false;
            appointmentsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsView.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            appointmentsView.DefaultCellStyle.BackColor = Color.White;
            appointmentsView.DefaultCellStyle.ForeColor = Color.Black;
            appointmentsView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            appointmentsView.DefaultCellStyle.SelectionForeColor = Color.Black;
            appointmentsView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Encabezado
            appointmentsView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            appointmentsView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            appointmentsView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            appointmentsView.ColumnHeadersHeight = 60;

            // Redondear con panel si deseas (opcional)
            this.BackColor = Color.White;
            appointmentsView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        // Agregar columnas
        private void AddColumns()
        {
            appointmentsView.Columns.Clear();

            appointmentsView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID" });
            appointmentsView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Fecha" });
            appointmentsView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tipo de Consulta" });
            appointmentsView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Doctor" });
            appointmentsView.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cliente" });
        }

        // Cargar datos
        public void UpdateData()
        {
            Business.LoadAppointmentsFromDatabase();
            appointmentsView.Rows.Clear();

            foreach (Appointment appointment in Business.appointments)
            {
                if (appointment != null)
                {
                    string id = appointment.Id.ToString();
                    string date = appointment.Date.ToString("dd/MM/yyyy HH:mm");
                    string type = appointment.QueryType != null ? $"{appointment.QueryType.Id} - {appointment.QueryType.Description}" : "N/A";
                    string doctor = appointment.Doctor != null ? $"{appointment.Doctor.Id} - {appointment.Doctor.Name} {appointment.Doctor.LastName}" : "N/A";
                    string client = appointment.Client != null ? $"{appointment.Client.Id} - {appointment.Client.Name} {appointment.Client.LastName}" : "N/A";

                    appointmentsView.Rows.Add(id, date, type, doctor, client);
                }
            }
        }

        // Nueva cita
        private void HandleNewAppoiment(object sender, EventArgs e)
        {
            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE EstadoId = 1", conn))
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay clientes activos registrados");
                            return;
                        }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Doctores WHERE EstadoId = 1", conn))
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay doctores activos registrados");
                            return;
                        }

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM TiposConsulta WHERE Estado = 1", conn))
                        if ((int)cmd.ExecuteScalar() == 0)
                        {
                            MessageBox.Show("No hay tipos de consulta activos registrados");
                            return;
                        }
                }

                FormNewAppointment formNewAppointment = new FormNewAppointment();
                formNewAppointment.Owner = this;
                formNewAppointment.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar los datos: " + ex.Message);
            }
        }

        // Selección
        private void HandleClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedId = Convert.ToInt32(appointmentsView.Rows[e.RowIndex].Cells[0].Value);
            else
                selectedId = 0;
        }

        // Eliminar cita
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
                    UpdateData();
                else
                    MessageBox.Show(response.Message, "Eliminar cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAppointments_Load(object sender, EventArgs e)
        {
            // Si necesitas hacer algo al cargar el formulario
        }

        private void appointmentsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
