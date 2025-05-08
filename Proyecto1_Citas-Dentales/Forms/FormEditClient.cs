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
using System.Data.SqlClient;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormEditClient : Form
    {

        public FormEditClient()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;


            int id = Business.selectedClientId;

            string connectionString = File.ReadAllText("config.txt").Trim();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Clientes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            inputId.Text = reader["Id"].ToString();
                            inputName.Text = reader["Nombre"].ToString();
                            inputFirstLastName.Text = reader["ApellidoPaterno"].ToString();
                            inputSecondLastName.Text = reader["ApellidoMaterno"].ToString();
                            inputBirthday.Value = Convert.ToDateTime(reader["FechaNacimiento"]);

                            string genero = reader["Genero"].ToString();
                            inputGender.Text = genero == "M" ? "Masculino" :
                                               genero == "F" ? "Femenino" : "No especificado";
                        }
                    }
                }
            }

            // Bloquear edición de campos que no se pueden cambiar (si es necesario)
            inputId.ReadOnly = true;
            inputName.ReadOnly = true;
            inputFirstLastName.ReadOnly = true;
            inputSecondLastName.ReadOnly = true;
        }


        // Boton para guardar los cambios y cerrar la ventana
        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            char gender = inputGender.Text.StartsWith("M") ? 'M' :
                          inputGender.Text.StartsWith("F") ? 'F' : 'N';

            Response res = Business.UpdateClientData(inputBirthday.Value, gender);

            if (res.Success)
            {
                if (Owner is FormAdminClients formAdminClients)
                {
                    formAdminClients.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message, "Editar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
