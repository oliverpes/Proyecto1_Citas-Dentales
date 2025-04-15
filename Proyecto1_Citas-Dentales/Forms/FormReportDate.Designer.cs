namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormReportDate
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            inputDateSearch = new DateTimePicker();
            searchButton = new Button();
            resultsView = new DataGridView();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(25, 25, 50);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(1268, 18);
            button3.Name = "button3";
            button3.Padding = new Padding(8, 4, 8, 4);
            button3.Size = new Size(110, 35);
            button3.TabIndex = 4;
            button3.Text = "Nuevo Doctor";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(25, 25, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1868, 17);
            button2.Name = "button2";
            button2.Padding = new Padding(8, 4, 8, 4);
            button2.Size = new Size(110, 35);
            button2.TabIndex = 3;
            button2.Text = "Nuevo Cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(25, 25, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(2477, 17);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 4, 8, 4);
            button1.Size = new Size(101, 35);
            button1.TabIndex = 2;
            button1.Text = "Agregar tipo";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(296, 45);
            label1.TabIndex = 1;
            label1.Text = "Reporte por Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(191, 19);
            label2.TabIndex = 4;
            label2.Text = "Ingrese una fecha a consultar:";
            // 
            // inputDateSearch
            // 
            inputDateSearch.CustomFormat = "dd/MM/yyyy";
            inputDateSearch.Format = DateTimePickerFormat.Custom;
            inputDateSearch.Location = new Point(12, 102);
            inputDateSearch.Name = "inputDateSearch";
            inputDateSearch.Size = new Size(300, 23);
            inputDateSearch.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.AutoSize = true;
            searchButton.FlatAppearance.BorderColor = Color.DimGray;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(328, 100);
            searchButton.Margin = new Padding(3, 6, 3, 6);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 27);
            searchButton.TabIndex = 6;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultsView
            // 
            resultsView.BackgroundColor = Color.FromArgb(25, 25, 50);
            resultsView.BorderStyle = BorderStyle.None;
            resultsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsView.Dock = DockStyle.Fill;
            resultsView.Location = new Point(8, 8);
            resultsView.Name = "resultsView";
            resultsView.ReadOnly = true;
            resultsView.RowTemplate.Height = 25;
            resultsView.Size = new Size(784, 299);
            resultsView.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(resultsView);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 135);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8);
            panel2.Size = new Size(800, 315);
            panel2.TabIndex = 8;
            // 
            // FormReportDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(searchButton);
            Controls.Add(inputDateSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormReportDate";
            Text = "FormReportDate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private DateTimePicker inputDateSearch;
        private Button searchButton;
        private DataGridView resultsView;
        private Panel panel2;
    }
}