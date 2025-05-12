using BusinessLogic;
using Entities;
using System;
using System.Data;
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

            // Crear columnas
            resultsView.Columns.Add("ID", "ID");
            resultsView.Columns.Add("Fecha", "Fecha");
            resultsView.Columns.Add("Tipo", "Tipo");
            resultsView.Columns.Add("Doctor", "Doctor");
            resultsView.Columns.Add("Cliente", "Cliente");

            LoadDoctors();
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
                    reader["Fecha"],
                    reader["Descripcion"],
                    reader["DoctorNombre"],
                    reader["ClienteNombre"]
                );
            }
        }
    }
}
