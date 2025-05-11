namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormNewAppointment
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
            label7 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            inputClient = new ComboBox();
            label6 = new Label();
            inputDoctor = new ComboBox();
            label5 = new Label();
            inputType = new ComboBox();
            label4 = new Label();
            inputDate = new DateTimePicker();
            label3 = new Label();
            inputID = new TextBox();
            label2 = new Label();
            buttonSaveAppointment = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 23);
            label7.Name = "label7";
            label7.Size = new Size(406, 54);
            label7.TabIndex = 2;
            label7.Text = "Agendar Cita Dental";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(inputClient);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(inputDoctor);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inputType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inputDate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputID);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(105, 129);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 419);
            panel2.TabIndex = 2;
            // 
            // inputClient
            // 
            inputClient.BackColor = Color.FromArgb(17, 17, 34);
            inputClient.Dock = DockStyle.Top;
            inputClient.FlatStyle = FlatStyle.Flat;
            inputClient.Font = new Font("Segoe UI", 10F);
            inputClient.ForeColor = Color.White;
            inputClient.FormattingEnabled = true;
            inputClient.Location = new Point(0, 337);
            inputClient.Margin = new Padding(3, 4, 3, 4);
            inputClient.Name = "inputClient";
            inputClient.Size = new Size(406, 31);
            inputClient.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 293);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 5, 0, 11);
            label6.Size = new Size(76, 44);
            label6.TabIndex = 8;
            label6.Text = "Cliente:";
            // 
            // inputDoctor
            // 
            inputDoctor.BackColor = Color.FromArgb(17, 17, 34);
            inputDoctor.Dock = DockStyle.Top;
            inputDoctor.FlatStyle = FlatStyle.Flat;
            inputDoctor.Font = new Font("Segoe UI", 10F);
            inputDoctor.ForeColor = Color.White;
            inputDoctor.FormattingEnabled = true;
            inputDoctor.Location = new Point(0, 262);
            inputDoctor.Margin = new Padding(3, 4, 3, 4);
            inputDoctor.Name = "inputDoctor";
            inputDoctor.Size = new Size(406, 31);
            inputDoctor.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 218);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 11);
            label5.Size = new Size(77, 44);
            label5.TabIndex = 6;
            label5.Text = "Doctor:";
            // 
            // inputType
            // 
            inputType.BackColor = Color.FromArgb(17, 17, 34);
            inputType.Dock = DockStyle.Top;
            inputType.FlatStyle = FlatStyle.Flat;
            inputType.Font = new Font("Segoe UI", 10F);
            inputType.ForeColor = Color.White;
            inputType.FormattingEnabled = true;
            inputType.Location = new Point(0, 187);
            inputType.Margin = new Padding(3, 4, 3, 4);
            inputType.Name = "inputType";
            inputType.Size = new Size(406, 31);
            inputType.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 143);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 11);
            label4.Size = new Size(118, 44);
            label4.TabIndex = 4;
            label4.Text = "Tipo de cita:";
            // 
            // inputDate
            // 
            inputDate.CalendarForeColor = Color.White;
            inputDate.CalendarMonthBackground = Color.FromArgb(17, 17, 34);
            inputDate.CalendarTitleBackColor = Color.DimGray;
            inputDate.CalendarTitleForeColor = Color.White;
            inputDate.CalendarTrailingForeColor = Color.Silver;
            inputDate.CustomFormat = "dd/MM/yyyy HH:mm";
            inputDate.Dock = DockStyle.Top;
            inputDate.Font = new Font("Segoe UI", 10F);
            inputDate.Format = DateTimePickerFormat.Custom;
            inputDate.Location = new Point(0, 113);
            inputDate.Margin = new Padding(3, 4, 3, 4);
            inputDate.MaxDate = new DateTime(2025, 9, 29, 0, 0, 0, 0);
            inputDate.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            inputDate.Name = "inputDate";
            inputDate.Size = new Size(406, 30);
            inputDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 69);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 11);
            label3.Size = new Size(149, 44);
            label3.TabIndex = 2;
            label3.Text = "Fecha de la cita:";
            // 
            // inputID
            // 
            inputID.BackColor = Color.FromArgb(17, 17, 34);
            inputID.BorderStyle = BorderStyle.FixedSingle;
            inputID.Dock = DockStyle.Top;
            inputID.Font = new Font("Segoe UI", 10F);
            inputID.ForeColor = Color.White;
            inputID.Location = new Point(0, 39);
            inputID.Margin = new Padding(3, 4, 3, 4);
            inputID.Name = "inputID";
            inputID.Size = new Size(406, 30);
            inputID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 11);
            label2.Size = new Size(151, 39);
            label2.TabIndex = 0;
            label2.Text = "Numero de cita:";
            // 
            // buttonSaveAppointment
            // 
            buttonSaveAppointment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSaveAppointment.AutoSize = true;
            buttonSaveAppointment.FlatAppearance.BorderColor = Color.DimGray;
            buttonSaveAppointment.FlatStyle = FlatStyle.Flat;
            buttonSaveAppointment.Font = new Font("Segoe UI", 12F);
            buttonSaveAppointment.ForeColor = Color.White;
            buttonSaveAppointment.Location = new Point(586, 504);
            buttonSaveAppointment.Margin = new Padding(3, 4, 3, 4);
            buttonSaveAppointment.Name = "buttonSaveAppointment";
            buttonSaveAppointment.Size = new Size(218, 44);
            buttonSaveAppointment.TabIndex = 5;
            buttonSaveAppointment.Text = "Crear cita";
            buttonSaveAppointment.UseVisualStyleBackColor = true;
            buttonSaveAppointment.Click += buttonSaveAppointment_Click;
            // 
            // FormNewAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(buttonSaveAppointment);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNewAppointment";
            Text = "Nueva cita";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        //private Button button1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox inputID;
        private Label label4;
        private DateTimePicker inputDate;
        private ComboBox inputClient;
        private Label label6;
        private ComboBox inputDoctor;
        private Label label5;
        private ComboBox inputType;
        private Button buttonSaveAppointment;
        private Label label7;
    }
}