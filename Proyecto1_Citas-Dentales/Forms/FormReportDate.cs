using BusinessLogic;
using Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportDate : Form
    {
        public FormReportDate()
        {
            InitializeComponent();

            resultsView.Columns.Add("ID", "ID");
            resultsView.Columns.Add("Fecha", "Fecha");
            resultsView.Columns.Add("Tipo", "Tipo");
            resultsView.Columns.Add("Doctor", "Doctor");
            resultsView.Columns.Add("Cliente", "Cliente");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            resultsView.Rows.Clear();

            DateTime selectedDate = inputDateSearch.Value.Date;
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
                            WHERE CAST(c.Fecha AS DATE) = @Fecha";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@Fecha", selectedDate);
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
