namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormReportDate
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
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
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(311, 46);
            label1.TabIndex = 0;
            label1.Text = "Reporte por Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 95);
            label2.Name = "label2";
            label2.Size = new Size(239, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingrese una fecha a consultar:";
            // 
            // inputDateSearch
            // 
            inputDateSearch.CustomFormat = "dd/MM/yyyy";
            inputDateSearch.Format = DateTimePickerFormat.Custom;
            inputDateSearch.Location = new Point(20, 120);
            inputDateSearch.Name = "inputDateSearch";
            inputDateSearch.Size = new Size(250, 27);
            inputDateSearch.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(17, 17, 34);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(293, 111);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(111, 48);
            searchButton.TabIndex = 3;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // resultsView
            // 
            resultsView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            resultsView.BackgroundColor = Color.White;
            resultsView.ColumnHeadersHeight = 29;
            resultsView.Location = new Point(12, 13);
            resultsView.Name = "resultsView";
            resultsView.RowHeadersWidth = 51;
            resultsView.Size = new Size(890, 385);
            resultsView.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(resultsView);
            panel2.Location = new Point(0, 170);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(914, 430);
            panel2.TabIndex = 5;
            // 
            // FormReportDate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(searchButton);
            Controls.Add(inputDateSearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportDate";
            Text = "Reporte por Fecha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker inputDateSearch;
        private Button searchButton;
        private DataGridView resultsView;
        private Panel panel2;
    }
}
