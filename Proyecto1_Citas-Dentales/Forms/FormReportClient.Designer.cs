namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormReportClient
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
            //button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            inputClients = new ComboBox();
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
            //panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 4;
            // 
            // button3
            //// 
            //button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            //button3.AutoSize = true;
            //button3.BackColor = Color.FromArgb(25, 25, 50);
            //button3.FlatStyle = FlatStyle.Flat;
            //button3.ForeColor = Color.White;
            //button3.Location = new Point(2112, 24);
            //button3.Margin = new Padding(3, 4, 3, 4);
            //button3.Name = "button3";
            //button3.Padding = new Padding(9, 5, 9, 5);
            //button3.Size = new Size(149, 53);
            //button3.TabIndex = 4;
            //button3.Text = "Nuevo Doctor";
            //button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(25, 25, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(2798, 23);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 5, 9, 5);
            button2.Size = new Size(149, 53);
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
            button1.Location = new Point(3493, 23);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 5, 9, 5);
            button1.Size = new Size(139, 53);
            button1.TabIndex = 2;
            button1.Text = "Agregar tipo";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(392, 54);
            label1.TabIndex = 1;
            label1.Text = "Reporte por Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 107);
            label2.Name = "label2";
            label2.Size = new Size(325, 23);
            label2.TabIndex = 5;
            label2.Text = "Seleccione el cliente que desea consultar:";
            // 
            // inputClients
            // 
            inputClients.FormattingEnabled = true;
            inputClients.Location = new Point(14, 136);
            inputClients.Margin = new Padding(3, 4, 3, 4);
            inputClients.Name = "inputClients";
            inputClients.Size = new Size(342, 28);
            inputClients.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.AutoSize = true;
            searchButton.FlatAppearance.BorderColor = Color.DimGray;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(376, 133);
            searchButton.Margin = new Padding(3, 8, 3, 8);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(86, 36);
            searchButton.TabIndex = 7;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultsView
            // 
            resultsView.Anchor = AnchorStyles.Top;
            resultsView.BackgroundColor = Color.FromArgb(25, 25, 50);
            resultsView.BorderStyle = BorderStyle.None;
            resultsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsView.Location = new Point(9, 11);
            resultsView.Margin = new Padding(3, 4, 3, 4);
            resultsView.Name = "resultsView";
            resultsView.ReadOnly = true;
            resultsView.RowHeadersWidth = 51;
            resultsView.RowTemplate.Height = 25;
            resultsView.Size = new Size(896, 399);
            resultsView.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(resultsView);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 180);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 11, 9, 11);
            panel2.Size = new Size(914, 420);
            panel2.TabIndex = 9;
            // 
            // FormReportClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(searchButton);
            Controls.Add(inputClients);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReportClient";
            Text = "Reporte por cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultsView).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        //private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox inputClients;
        private Button searchButton;
        private DataGridView resultsView;
        private Panel panel2;
    }
}