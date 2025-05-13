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
using System.Data.SqlClient;



namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewAppointment : Form
    {

        public FormNewAppointment()
        {
            InitializeComponent();

            string connectionString = File.ReadAllText("config.txt").Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tipos de Consulta
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Descripcion FROM TiposConsulta WHERE Estado = 1", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string description = reader.GetString(1);
                            string info = $"{id} - {description}";
                            inputType.Items.Add(info);
                        }
                    }

                    // Clientes
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno FROM Clientes WHERE EstadoId = 1", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido1 = reader.GetString(2);
                            string apellido2 = reader.GetString(3);
                            string info = $"{id} - {nombre} {apellido1} {apellido2}";
                            inputClient.Items.Add(info);
                        }
                    }

                    // Doctores
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno FROM Doctores WHERE EstadoId = 1", conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido1 = reader.GetString(2);
                            string apellido2 = reader.GetString(3);
                            string info = $"{id} - {nombre} {apellido1} {apellido2}";
                            inputDoctor.Items.Add(info);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Boton para guardar la cita
        private void buttonSaveAppointment_Click(object sender, EventArgs e)
        {
            Response response = Business.SaveAppointment(inputDate.Value, inputType.Text, inputClient.Text, inputDoctor.Text);

            if (response.Success)
            {
                if (Owner is FormAppointments formAppointments)
                {
                    formAppointments.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Message, "Nueva cita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
