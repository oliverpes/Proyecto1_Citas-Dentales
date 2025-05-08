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



namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormNewQueryType : Form
    {

        public FormNewQueryType()
        {
            InitializeComponent();
        }

        // Boton para agregar un nuevo tipo de consulta
        private void ButtonAddQueryType_Click(object sender, EventArgs e)
        {
            char state = stateQueryType.Text.Length > 0 ? stateQueryType.Text[0] : 'N';
            Response res = Business.SaveQueryType((int)idQueryType.Value, descriptionQueryType.Text, state);

            if (res.Success)
            {
                if (MessageBox.Show("Se ha agregado el nuevo tipo de consulta. ¿Desea agregar otro?", "Nuevo tipo de consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    idQueryType.Value = 0;
                    descriptionQueryType.Text = "";
                    stateQueryType.Text = "Inactivo";
                    return;
                }
                if (Owner is FormQueryTypes formQueryTypes)
                {
                    formQueryTypes.UpdateData();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message, "Nuevo tipo de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
