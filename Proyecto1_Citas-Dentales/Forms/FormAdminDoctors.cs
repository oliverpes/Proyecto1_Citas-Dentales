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


namespace Proyecto1_Citas_Dentales.Forms
{
    public partial class FormAdminDoctors : Form
    {
        // variable para guardar el id del doctor seleccionado
        private int selectedId;

        public FormAdminDoctors()
        {
            InitializeComponent();

            // Agregar columnas al DataGridView
            DataGridViewTextBoxColumn columnId = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnFLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnSLName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columnState = new DataGridViewTextBoxColumn();

            columnId.HeaderText = "ID";
            columnName.HeaderText = "Nombre";
            columnFLName.HeaderText = "Primer apellido";
            columnSLName.HeaderText = "Segundo apellido";
            columnState.HeaderText = "Estado";

            doctorDataViewer.Columns.Add(columnId);
            doctorDataViewer.Columns.Add(columnName);
            doctorDataViewer.Columns.Add(columnFLName);
            doctorDataViewer.Columns.Add(columnSLName);
            doctorDataViewer.Columns.Add(columnState);

            
            this.Load += FormAdminDoctors_Load;
        }

        //metodo que actualiza los doctores en el DataGrid
        private void FormAdminDoctors_Load(object sender, EventArgs e)
        {
            UpdateData();
        }


        // Actualiza los datos del DataGridView
        public void UpdateData()
        {
            doctorDataViewer.Rows.Clear();

            List<Doctor> doctoresBD = Business.GetDoctorsFromDatabase();

            foreach (Doctor doctor in doctoresBD)
            {
                if (doctor != null)
                {
                    // Agrega una nueva fila al DataGridView con los datos de cada Doctor
                    string id = doctor.Id.ToString();
                    string name = doctor.Name;
                    string firstLastName = doctor.LastName;
                    string secondLastName = doctor.SecondLastName;
                    string state = doctor.State == 1 ? "Activo" : "Inactivo";

                    string[] row = { id, name, firstLastName, secondLastName, state };

                    doctorDataViewer.Rows.Add(row);
                }
            }
        }

        // Boton para agregar un nuevo doctor
        private void buttonNewDoctor_Click(object sender, EventArgs e)
        {
            
            FormNewDoctor formNewDoctor = new FormNewDoctor();
            formNewDoctor.Owner = this;
            formNewDoctor.ShowDialog();
        }

        // Seleccionar un doctor del DataGridView
        private void HandleCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = Convert.ToInt32(doctorDataViewer.Rows[e.RowIndex].Cells[0].Value);
            }
            else
            {
                selectedId = 0;
            }
        }

        // Boton para editar un doctor
        private void buttonChangeState_Click(object sender, EventArgs e)
        {
            Response response = Business.ChangeStatusDoctor(selectedId);
            if (response.Success)
            {
                UpdateData();
                selectedId = 0;
            }
            else
            {
                MessageBox.Show(response.Message, "Cambiar estado de Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton para eliminar un doctor
        private void buttonDeleteDoctor_Click(object sender, EventArgs e)
        {
            if (selectedId == 0)
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Eliminar Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("¿Está seguro de que desea eliminar el doctor?", "Eliminar doctor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Response response = Business.DeleteDoctor(selectedId);
                if (response.Success)
                {
                    UpdateData();
                    selectedId = 0;
                }
                else
                {
                    MessageBox.Show(response.Message, "Eliminar Doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doctorDataViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
