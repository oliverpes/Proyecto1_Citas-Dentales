// using Proyecto1_Citas_Dentales.Classes;

namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormQueryTypes
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
            panelHeader = new Panel();
            ButtonAddQueryType = new Button();
            labelHeader = new Label();
            panelList = new Panel();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panelHeader.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 17, 34);
            panelHeader.Controls.Add(ButtonAddQueryType);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 70);
            panelHeader.TabIndex = 0;
            // 
            // ButtonAddQueryType
            // 
            ButtonAddQueryType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonAddQueryType.AutoSize = true;
            ButtonAddQueryType.BackColor = Color.FromArgb(25, 25, 50);
            ButtonAddQueryType.FlatStyle = FlatStyle.Flat;
            ButtonAddQueryType.ForeColor = Color.White;
            ButtonAddQueryType.Location = new Point(677, 17);
            ButtonAddQueryType.Name = "ButtonAddQueryType";
            ButtonAddQueryType.Padding = new Padding(8, 4, 8, 4);
            ButtonAddQueryType.Size = new Size(101, 35);
            ButtonAddQueryType.TabIndex = 2;
            ButtonAddQueryType.Text = "Agregar tipo";
            ButtonAddQueryType.UseVisualStyleBackColor = false;
            ButtonAddQueryType.Click += ButtonAddQueryType_Click;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(12, 11);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(282, 45);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Tipos de consulta";
            // 
            // panelList
            // 
            panelList.Controls.Add(button2);
            panelList.Controls.Add(button1);
            panelList.Controls.Add(dataGridView1);
            panelList.Dock = DockStyle.Fill;
            panelList.Location = new Point(0, 70);
            panelList.Name = "panelList";
            panelList.Padding = new Padding(8, 18, 8, 8);
            panelList.Size = new Size(800, 380);
            panelList.TabIndex = 3;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(142, 334);
            button2.Name = "button2";
            button2.Padding = new Padding(8, 4, 8, 4);
            button2.Size = new Size(166, 35);
            button2.TabIndex = 2;
            button2.Text = "Eliminar tipo de consulta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DeleteQueryType;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(17, 17, 34);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 334);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 4, 8, 4);
            button1.Size = new Size(118, 35);
            button1.TabIndex = 1;
            button1.Text = "Cambiar estado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ChangeState;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 50);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(8, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(784, 304);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView_CellClick;
            // 
            // FormQueryTypes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(panelList);
            Controls.Add(panelHeader);
            Name = "FormQueryTypes";
            Text = "FormNewType";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelHeader;
        private Button ButtonAddQueryType;
        private Panel panelList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private Button button1;
        private Button button2;
    }
}