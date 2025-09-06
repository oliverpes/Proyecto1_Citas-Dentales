using BusinessLogic;
using Entities;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
            ConfigureDataGridView();
            ConfigureColumns();
            UpdateData();
        }

        // Estilo moderno al DataGridView
        private void ConfigureDataGridView()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 60;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            this.BackColor = Color.White;
        }

        // Crea las columnas del DataGridView
        private void ConfigureColumns()
        {
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "ID"
            };

            DataGridViewTextBoxColumn columnDescription = new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripción",
                Name = "Descripcion"
            };

            DataGridViewTextBoxColumn columnState = new DataGridViewTextBoxColumn
            {
                HeaderText = "Estado",
                Name = "Estado"
            };

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                columnId,
                columnDescription,
                columnState
            });
        }

        // Botón para agregar un nuevo tipo de consulta
        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            FormNewQueryType formNewQueryType = new FormNewQueryType(this);
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

            selectedId = 0;
        }

        // Selecciona el ID de la fila seleccionada
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);
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
                }
                else
                {
                    MessageBox.Show(res.Message, "Cambiar estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar", "Cambiar estado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Botón para eliminar un tipo de consulta
        private void DeleteQueryType(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                var result = MessageBox.Show("¿Está seguro de que desea eliminar el tipo de consulta?", "Eliminar tipo de consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Response res = Business.DeleteQueryType(selectedId);

                    if (res.Success)
                    {
                        UpdateData();
                    }
                    else
                    {
                        MessageBox.Show(res.Message, "Eliminar tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Si usas un panel de encabezado visual
        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejarlo vacío si es solo decorativo.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
