using Entities;
using BusinessLogic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAdminClients : Form
    {
        public FormAdminClients()
        {
            InitializeComponent();
            ConfigureDataGridView();
            AddColumns();
            UpdateData();
        }

        // Estilo moderno sin librerías externas
        private void ConfigureDataGridView()
        {
            clientDataViewer.BorderStyle = BorderStyle.None;
            clientDataViewer.BackgroundColor = Color.White;
            clientDataViewer.GridColor = Color.LightGray;
            clientDataViewer.EnableHeadersVisualStyles = false;
            clientDataViewer.RowHeadersVisible = false;
            clientDataViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            clientDataViewer.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            clientDataViewer.DefaultCellStyle.BackColor = Color.White;
            clientDataViewer.DefaultCellStyle.ForeColor = Color.Black;
            clientDataViewer.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            clientDataViewer.DefaultCellStyle.SelectionForeColor = Color.Black;
            clientDataViewer.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Encabezado
            clientDataViewer.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            clientDataViewer.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            clientDataViewer.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            clientDataViewer.ColumnHeadersHeight = 60;

            this.BackColor = Color.White;
            clientDataViewer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        // Agregar columnas al DataGridView
        private void AddColumns()
        {
            clientDataViewer.Columns.Clear();

            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ID" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Nombre" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Primer apellido" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Segundo apellido" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Cumpleaños" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Género" });
            clientDataViewer.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Estado" });
        }

        // Botón para agregar un nuevo cliente
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
                string query = @"SELECT Id, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, Genero, EstadoId FROM Clientes";

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
                        string gender = genderCode == "F" ? "Femenino" :
                                        genderCode == "M" ? "Masculino" : "No especificado";

                        int estadoId = Convert.ToInt32(reader["EstadoId"]);
                        string estado = estadoId == 1 ? "Activo" : "Inactivo";

                        clientDataViewer.Rows.Add(id, name, firstLastName, secondLastName, birthday, gender, estado);
                    }
                }
            }
        }

        // Seleccionar una fila del DataGridView
        private void HandleSelectId(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Business.selectedClientId = Convert.ToInt32(clientDataViewer.Rows[e.RowIndex].Cells[0].Value);
            else
                Business.selectedClientId = 0;
        }

        // Botón para editar un cliente
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

        // Botón para eliminar un cliente
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            if (Business.selectedClientId != 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Response response = Business.DeleteClient();
                    if (response.Success)
                        UpdateData();
                    else
                        MessageBox.Show(response.Message, "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para cambiar estado de cliente (activo/inactivo)
        private void CambiarEstadoCliente_Click(object sender, EventArgs e)
        {
            if (clientDataViewer.SelectedRows.Count > 0)
            {
                string selectedId = clientDataViewer.SelectedRows[0].Cells[0].Value.ToString();
                if (int.TryParse(selectedId, out int clientId))
                {
                    Response response = Business.ToggleClientStatus(clientId);
                    if (response.Success)
                        UpdateData();
                    else
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para cambiar su estado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
