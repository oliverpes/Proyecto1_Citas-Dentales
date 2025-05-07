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
using static System.Windows.Forms.AxHost;
using System.Data.SqlClient;


namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAdminClients : Form
    {
        public FormAdminClients()
        {
            InitializeComponent();

            // Agregar columnas al DataGridView
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnFLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnSLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnBirthday = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnGender = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnEstado = new DataGridViewTextBoxColumn(); // NUEVA COLUMNA

            columnId.HeaderText = "ID";
            columnName.HeaderText = "Nombre";
            columnFLName.HeaderText = "Primer apellido";
            columnSLName.HeaderText = "Segundo apellido";
            columnBirthday.HeaderText = "Cumpleaños";
            columnGender.HeaderText = "Género";
            columnEstado.HeaderText = "Estado"; // NUEVA COLUMNA

            clientDataViewer.Columns.Add(columnId);
            clientDataViewer.Columns.Add(columnName);
            clientDataViewer.Columns.Add(columnFLName);
            clientDataViewer.Columns.Add(columnSLName);
            clientDataViewer.Columns.Add(columnBirthday);
            clientDataViewer.Columns.Add(columnGender);
            clientDataViewer.Columns.Add(columnEstado); // NUEVA COLUMNA

            UpdateData();
        }

        // Boton para agregar un nuevo cliente
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            FormNewClient formNewClient = new FormNewClient();
            formNewClient.Owner = this;
            formNewClient.ShowDialog();
        }

        // Actualizar los datos del DataGridView
        public void UpdateData()
        {
            clientDataViewer.Rows.Clear();

            string connectionString = File.ReadAllText("config.txt").Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Genero, EstadoId 
                         FROM Clientes";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["Id"].ToString();
                        string name = reader["Nombre"].ToString();
                        string firstLastName = reader["ApellidoPaterno"].ToString();
                        string secondLastName = reader["ApellidoMaterno"].ToString();
                        string birthday = Convert.ToDateTime(reader["FechaNacimiento"]).ToString("dd/MM/yyyy");

                        string genderCode = reader["Genero"].ToString();
                        string gender = genderCode == "F" ? "Femenino" : genderCode == "M" ? "Masculino" : "No especificado";

                        int estadoId = Convert.ToInt32(reader["EstadoId"]);
                        string estado = estadoId == 1 ? "Activo" : "Inactivo";

                        string[] row = { id, name, firstLastName, secondLastName, birthday, gender, estado };
                        clientDataViewer.Rows.Add(row);
                    }
                }
            }
        }



        // Seleccionar una fila del DataGridView
        private void HandleSelectId(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Business.selectedClientId = Convert.ToInt32(clientDataViewer.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                Business.selectedClientId = 0;
            }
        }

        // Boton para editar un cliente
        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            if (Business.selectedClientId == 0)
            {
                MessageBox.Show("Seleccione la fila a editar", "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEditClient formEditClient = new FormEditClient();
            formEditClient.Owner = this;
            formEditClient.ShowDialog();
        }

        // Boton para eliminar un cliente
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (Business.selectedClientId != 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Response response = Business.DeleteClient();
                    if (response.Success)
                    {
                        UpdateData();
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
