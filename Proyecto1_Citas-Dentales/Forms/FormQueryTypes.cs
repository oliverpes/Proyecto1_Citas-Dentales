using BusinessLogic;
using Entities;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormQueryTypes : Form
    {
        private int selectedId;

        public FormQueryTypes()
        {
            InitializeComponent();

            // Agrega las columnas al DataGridView
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnDescription = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnState = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnDescription.HeaderText = "Descripción";
            columnState.HeaderText = "Estado";

            dataGridView1.Columns.Add(columnId);
            dataGridView1.Columns.Add(columnDescription);
            dataGridView1.Columns.Add(columnState);

            UpdateData();
        }

        // Botón para agregar un nuevo tipo de consulta
        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            
            FormNewQueryType formNewQueryType = new FormNewQueryType(this); // Pasa el formulario actual
            formNewQueryType.ShowDialog();
        }

        // Actualiza los datos del DataGridView
        public void UpdateData()
        {
            dataGridView1.Rows.Clear();
            string connectionString = File.ReadAllText("config.txt").Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT Id, Descripcion, Estado FROM TiposConsulta";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string description = reader.GetString(1);
                        bool estado = reader.GetBoolean(2);
                        string estadoTexto = estado ? "Activo" : "Inactivo";

                        dataGridView1.Rows.Add(id.ToString(), description, estadoTexto);
                    }
                }
            }
        }

        // Selecciona el ID de la fila seleccionada
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                selectedId = 0;
            }
        }

        // Botón para modificar el estado de un tipo de consulta
        private void ChangeState(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                Response res = Business.ChangeStatusQueryType(selectedId);

                if (res.Success)
                {
                    UpdateData();
                    selectedId = 0;
                }
                else
                {
                    MessageBox.Show(res.Message, "Cambiar estado de tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar", "Cambiar estado de tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para eliminar un tipo de consulta
        private void DeleteQueryType(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar el tipo de consulta?", "Eliminar tipo de consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Response res = Business.DeleteQueryType(selectedId);

                    if (res.Success)
                    {
                        UpdateData();
                        selectedId = 0;
                    }
                    else
                    {
                        MessageBox.Show(res.Message, "Eliminar tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar Tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
