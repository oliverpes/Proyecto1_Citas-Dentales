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
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(ButtonAddQueryType);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(914, 93);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // ButtonAddQueryType
            // 
            ButtonAddQueryType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonAddQueryType.AutoSize = true;
            ButtonAddQueryType.BackColor = Color.FromArgb(25, 25, 50);
            ButtonAddQueryType.FlatStyle = FlatStyle.Flat;
            ButtonAddQueryType.ForeColor = Color.White;
            ButtonAddQueryType.Location = new Point(750, 23);
            ButtonAddQueryType.Margin = new Padding(3, 4, 3, 4);
            ButtonAddQueryType.Name = "ButtonAddQueryType";
            ButtonAddQueryType.Padding = new Padding(9, 5, 9, 5);
            ButtonAddQueryType.Size = new Size(139, 53);
            ButtonAddQueryType.TabIndex = 2;
            ButtonAddQueryType.Text = "Agregar tipo";
            ButtonAddQueryType.UseVisualStyleBackColor = false;
            ButtonAddQueryType.Click += ButtonAddQueryType_Click;
            // 
            // labelHeader
            // 
            labelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelHeader.AutoSize = true;
            labelHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(14, 15);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(351, 54);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Tipos de consulta";
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelList.BackColor = Color.White;
            panelList.Controls.Add(button2);
            panelList.Controls.Add(button1);
            panelList.Controls.Add(dataGridView1);
            panelList.Location = new Point(0, 93);
            panelList.Margin = new Padding(3, 4, 3, 4);
            panelList.Name = "panelList";
            panelList.Padding = new Padding(9, 24, 9, 11);
            panelList.Size = new Size(914, 507);
            panelList.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(162, 436);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 5, 9, 5);
            button2.Size = new Size(231, 53);
            button2.TabIndex = 2;
            button2.Text = "Eliminar tipo de consulta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += DeleteQueryType;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(17, 17, 34);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(9, 436);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 5, 9, 5);
            button1.Size = new Size(162, 53);
            button1.TabIndex = 1;
            button1.Text = "Cambiar estado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ChangeState;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(9, 24);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(896, 404);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FormQueryTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(panelList);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
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