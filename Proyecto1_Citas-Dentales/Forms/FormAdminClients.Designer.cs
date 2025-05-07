namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormAdminClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            panel1 = new Panel();
            buttonNewClient = new Button();
            label1 = new Label();
            clientDataViewer = new DataGridView();
            buttonDeleteClient = new Button();
            buttonEditClient = new Button();
            CambiarEstadoCliente = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientDataViewer).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(25, 25, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1435, 23);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 5, 9, 5);
            button1.Size = new Size(139, 53);
            button1.TabIndex = 2;
            button1.Text = "Agregar tipo";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(buttonNewClient);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 1;
            // 
            // buttonNewClient
            // 
            buttonNewClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewClient.AutoSize = true;
            buttonNewClient.BackColor = Color.FromArgb(25, 25, 50);
            buttonNewClient.FlatStyle = FlatStyle.Flat;
            buttonNewClient.ForeColor = Color.White;
            buttonNewClient.Location = new Point(741, 23);
            buttonNewClient.Margin = new Padding(3, 4, 3, 4);
            buttonNewClient.Name = "buttonNewClient";
            buttonNewClient.Padding = new Padding(9, 5, 9, 5);
            buttonNewClient.Size = new Size(149, 53);
            buttonNewClient.TabIndex = 3;
            buttonNewClient.Text = "Nuevo Cliente";
            buttonNewClient.UseVisualStyleBackColor = false;
            buttonNewClient.Click += buttonNewClient_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(172, 54);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // clientDataViewer
            // 
            clientDataViewer.BackgroundColor = Color.FromArgb(25, 25, 50);
            clientDataViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataViewer.Dock = DockStyle.Top;
            clientDataViewer.Location = new Point(0, 93);
            clientDataViewer.Margin = new Padding(3, 4, 3, 4);
            clientDataViewer.Name = "clientDataViewer";
            clientDataViewer.ReadOnly = true;
            clientDataViewer.RowHeadersWidth = 51;
            clientDataViewer.RowTemplate.Height = 25;
            clientDataViewer.Size = new Size(914, 436);
            clientDataViewer.TabIndex = 2;
            clientDataViewer.CellClick += HandleSelectId;
            // 
            // buttonDeleteClient
            // 
            buttonDeleteClient.AutoSize = true;
            buttonDeleteClient.BackColor = Color.FromArgb(192, 0, 0);
            buttonDeleteClient.FlatStyle = FlatStyle.Flat;
            buttonDeleteClient.ForeColor = Color.White;
            buttonDeleteClient.Location = new Point(741, 541);
            buttonDeleteClient.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Padding = new Padding(9, 5, 9, 5);
            buttonDeleteClient.Size = new Size(143, 47);
            buttonDeleteClient.TabIndex = 4;
            buttonDeleteClient.Text = "Eliminar cliente";
            buttonDeleteClient.UseVisualStyleBackColor = false;
            buttonDeleteClient.Click += buttonDeleteClient_Click;
            // 
            // buttonEditClient
            // 
            buttonEditClient.AutoSize = true;
            buttonEditClient.BackColor = Color.FromArgb(17, 17, 34);
            buttonEditClient.FlatStyle = FlatStyle.Flat;
            buttonEditClient.ForeColor = Color.White;
            buttonEditClient.Location = new Point(14, 541);
            buttonEditClient.Margin = new Padding(3, 4, 3, 4);
            buttonEditClient.Name = "buttonEditClient";
            buttonEditClient.Padding = new Padding(9, 5, 9, 5);
            buttonEditClient.Size = new Size(144, 47);
            buttonEditClient.TabIndex = 3;
            buttonEditClient.Text = "Modificar datos";
            buttonEditClient.UseVisualStyleBackColor = false;
            buttonEditClient.Click += buttonEditClient_Click;
            // 
            // CambiarEstadoCliente
            // 
            CambiarEstadoCliente.AutoSize = true;
            CambiarEstadoCliente.BackColor = Color.FromArgb(17, 17, 34);
            CambiarEstadoCliente.FlatStyle = FlatStyle.Flat;
            CambiarEstadoCliente.ForeColor = Color.White;
            CambiarEstadoCliente.Location = new Point(164, 541);
            CambiarEstadoCliente.Margin = new Padding(3, 4, 3, 4);
            CambiarEstadoCliente.Name = "CambiarEstadoCliente";
            CambiarEstadoCliente.Padding = new Padding(9, 5, 9, 5);
            CambiarEstadoCliente.Size = new Size(144, 47);
            CambiarEstadoCliente.TabIndex = 6;
            CambiarEstadoCliente.Text = "Cambiar estado";
            CambiarEstadoCliente.UseVisualStyleBackColor = false;
            CambiarEstadoCliente.Click += CambiarEstadoCliente_Click;
            // 
            // FormAdminClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(CambiarEstadoCliente);
            Controls.Add(buttonDeleteClient);
            Controls.Add(buttonEditClient);
            Controls.Add(clientDataViewer);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAdminClients";
            Text = "FormAdminClients";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)clientDataViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Button buttonNewClient;
        private DataGridView clientDataViewer;
        private Button buttonDeleteClient;
        private Button buttonEditClient;
        private Button CambiarEstadoCliente;
    }
}