﻿using Entities;
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

/* UNED: Proyecto III Cuatrimestre
 * Proyecto #1: Aplicacion para gestionar citas de una clinica dental
 * Estidiante: Marco Fernando Agüero Barboza
 * Fecha: 11/10/2023
 * 
 * Clase de la interfaz de administracion de clientes
 */

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

            columnId.HeaderText = "ID";
            columnName.HeaderText = "Nombre";
            columnFLName.HeaderText = "Primer apellido";
            columnSLName.HeaderText = "Segundo apellido";
            columnBirthday.HeaderText = "Cumpleaños";
            columnGender.HeaderText = "Genero";

            clientDataViewer.Columns.Add(columnId);
            clientDataViewer.Columns.Add(columnName);
            clientDataViewer.Columns.Add(columnFLName);
            clientDataViewer.Columns.Add(columnSLName);
            clientDataViewer.Columns.Add(columnBirthday);
            clientDataViewer.Columns.Add(columnGender);

            UpdateData();
        }

        // Boton para agregar un nuevo cliente
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            if (Business.clients[19] != null)
            {
                MessageBox.Show("No se pueden agregar mas clientes", "Nuevo cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormNewClient formNewClient = new FormNewClient();
            formNewClient.Owner = this;
            formNewClient.ShowDialog();
        }

        // Actualizar los datos del DataGridView
        public void UpdateData()
        {
            clientDataViewer.Rows.Clear();

            foreach (Client client in Business.clients)
            {
                if (client != null)
                {
                    string id = client.Id.ToString();
                    string name = client.Name;
                    string firstLastName = client.LastName;
                    string secondLastName = client.SecondLastName;
                    string birthday = client.BirthDate.ToString("dd/MM/yyyy");
                    string gender = client.Gender == 'F' ? "Femenino" : client.Gender == 'M' ? "Masculino" : "No especificado";
                    string[] row = { id, name, firstLastName, secondLastName, birthday, gender };

                    clientDataViewer.Rows.Add(row);
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
