using BusinessLogic;
using System;
using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewQueryType : Form
    {
        private readonly FormQueryTypes parentForm;

        public FormNewQueryType(FormQueryTypes parent)
        {
            InitializeComponent();
            parentForm = parent;

            // Cargar opciones en el combo si aún no están
            if (stateQueryType.Items.Count == 0)
            {
                stateQueryType.Items.Add("Activo");
                stateQueryType.Items.Add("Inactivo");
                stateQueryType.SelectedIndex = 0;
            }
        }

        // Botón para guardar un nuevo tipo de consulta
        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            int estado = stateQueryType.Text == "Activo" ? 1 : 0;
            string descripcion = descriptionQueryType.Text.Trim();

            Response res = Business.SaveQueryType(descripcion, estado);

            if (res.Success)
            {
                parentForm.UpdateData(); // Refresca el DataGridView principal

                DialogResult result = MessageBox.Show(
                    "Tipo de consulta guardado correctamente.\n¿Desea agregar otro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    descriptionQueryType.Clear();
                    stateQueryType.SelectedIndex = 0;
                    descriptionQueryType.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error al guardar: " + res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
