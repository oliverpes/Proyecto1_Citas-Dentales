using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormReportDate : Form
    {
        public FormReportDate()
        {
            InitializeComponent();

            // Estilo moderno claro para DataGridView (como en FormQueryTypes)
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
            resultsView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resultsView.ColumnHeadersHeight = 30;
            resultsView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Columnas
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
                    Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"),
                    reader["Descripcion"],
                    reader["DoctorNombre"],
                    reader["ClienteNombre"]
                );
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejarlo vacío o remover el evento si no se necesita
        }
    }
}
