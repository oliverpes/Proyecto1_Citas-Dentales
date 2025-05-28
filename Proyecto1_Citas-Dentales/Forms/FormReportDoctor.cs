using BusinessLogic;
using Entities;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportDoctor : Form
    {
        public FormReportDoctor()
        {
            InitializeComponent();

            // Estilizar el DataGridView
            SetupDataGridView();

            // Crear columnas
            resultsView.Columns.Add("ID", "ID");
            resultsView.Columns.Add("Fecha", "Fecha");
            resultsView.Columns.Add("Tipo", "Tipo");
            resultsView.Columns.Add("Doctor", "Doctor");
            resultsView.Columns.Add("Cliente", "Cliente");


            LoadDoctors();
        }

        private void SetupDataGridView()
        {
            resultsView.BorderStyle = BorderStyle.None;
            resultsView.BackgroundColor = Color.White;
            resultsView.GridColor = Color.LightGray;
            resultsView.EnableHeadersVisualStyles = false;
            resultsView.RowHeadersVisible = false;
            resultsView.ReadOnly = true;
            resultsView.AllowUserToAddRows = false;
            resultsView.AllowUserToDeleteRows = false;
            resultsView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            resultsView.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            resultsView.DefaultCellStyle.BackColor = Color.White;
            resultsView.DefaultCellStyle.ForeColor = Color.Black;
            resultsView.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            resultsView.DefaultCellStyle.SelectionForeColor = Color.Black;
            resultsView.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            resultsView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            resultsView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            resultsView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            resultsView.ColumnHeadersHeight = 30;
            resultsView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Altura uniforme para las filas
            resultsView.RowTemplate.Height = 30;
        }



        private void LoadDoctors()
        {
            inputDoctors.Items.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno FROM Doctores WHERE EstadoId = 1";
            using SqlCommand cmd = new(query, conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string fullName = $"{reader.GetString(1)} {reader.GetString(2)} {reader.GetString(3)}";
                inputDoctors.Items.Add($"{id} - {fullName}");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            if (inputDoctors.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int doctorId = int.Parse(inputDoctors.Text.Split('-')[0].Trim());
            string connectionString = File.ReadAllText("config.txt").Trim();

            using SqlConnection conn = new(connectionString);
            conn.Open();
            string query = @"SELECT c.Id, c.Fecha, t.Descripcion, 
                            d.Nombre + ' ' + d.ApellidoPaterno + ' ' + d.ApellidoMaterno AS DoctorNombre,
                            cl.Nombre + ' ' + cl.ApellidoPaterno + ' ' + cl.ApellidoMaterno AS ClienteNombre
                            FROM Citas c
                            JOIN Doctores d ON c.DoctorId = d.Id
                            JOIN Clientes cl ON c.ClienteId = cl.Id
                            JOIN TiposConsulta t ON c.TipoConsultaId = t.Id
                            WHERE c.DoctorId = @DoctorId";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@DoctorId", doctorId);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                resultsView.Rows.Add(
                    reader["Id"],
                    Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"),
                    reader["Descripcion"],
                    reader["DoctorNombre"],
                    reader["ClienteNombre"]
                );
            }
        }

        private void resultsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes dejar esto vacío si no es necesario
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejar esto vacío si no es necesario
        }
    }
}
