using System.Windows.Forms;

namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormNewClient
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
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            inputSecondLastName = new TextBox();
            label5 = new Label();
            inputFirstLastName = new TextBox();
            label4 = new Label();
            inputName = new TextBox();
            label3 = new Label();
            inputId = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            buttonSaveClient = new Button();
            inputGender = new ComboBox();
            label6 = new Label();
            inputBirthday = new DateTimePicker();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(25, 25, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1268, 17);
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
            button1.Location = new Point(1877, 17);
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
            label1.Size = new Size(225, 45);
            label1.TabIndex = 1;
            label1.Text = "Nuevo cliente";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.AutoSize = true;
            panel2.Controls.Add(inputSecondLastName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(inputFirstLastName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(inputName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(inputId);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(71, 122);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(296, 250);
            panel2.TabIndex = 3;
            // 
            // inputSecondLastName
            // 
            inputSecondLastName.BackColor = Color.FromArgb(17, 17, 34);
            inputSecondLastName.BorderStyle = BorderStyle.FixedSingle;
            inputSecondLastName.Cursor = Cursors.IBeam;
            inputSecondLastName.Dock = DockStyle.Top;
            inputSecondLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputSecondLastName.ForeColor = Color.White;
            inputSecondLastName.Location = new Point(10, 215);
            inputSecondLastName.Name = "inputSecondLastName";
            inputSecondLastName.Size = new Size(276, 25);
            inputSecondLastName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(10, 180);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 10, 0, 4);
            label5.Size = new Size(134, 35);
            label5.TabIndex = 13;
            label5.Text = "Segundo apellido:";
            // 
            // inputFirstLastName
            // 
            inputFirstLastName.BackColor = Color.FromArgb(17, 17, 34);
            inputFirstLastName.BorderStyle = BorderStyle.FixedSingle;
            inputFirstLastName.Cursor = Cursors.IBeam;
            inputFirstLastName.Dock = DockStyle.Top;
            inputFirstLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputFirstLastName.ForeColor = Color.White;
            inputFirstLastName.Location = new Point(10, 155);
            inputFirstLastName.Name = "inputFirstLastName";
            inputFirstLastName.Size = new Size(276, 25);
            inputFirstLastName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(10, 120);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 10, 0, 4);
            label4.Size = new Size(119, 35);
            label4.TabIndex = 11;
            label4.Text = "Primer apellido:";
            // 
            // inputName
            // 
            inputName.BackColor = Color.FromArgb(17, 17, 34);
            inputName.BorderStyle = BorderStyle.FixedSingle;
            inputName.Cursor = Cursors.IBeam;
            inputName.Dock = DockStyle.Top;
            inputName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputName.ForeColor = Color.White;
            inputName.Location = new Point(10, 95);
            inputName.Name = "inputName";
            inputName.Size = new Size(276, 25);
            inputName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(10, 60);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 4);
            label3.Size = new Size(71, 35);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // inputId
            // 
            inputId.BackColor = Color.FromArgb(17, 17, 34);
            inputId.BorderStyle = BorderStyle.FixedSingle;
            inputId.Cursor = Cursors.IBeam;
            inputId.Dock = DockStyle.Top;
            inputId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputId.ForeColor = Color.White;
            inputId.Location = new Point(10, 35);
            inputId.Name = "inputId";
            inputId.Size = new Size(276, 25);
            inputId.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 4);
            label2.Size = new Size(186, 25);
            label2.TabIndex = 0;
            label2.Text = "Identificación del usuario:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSize = true;
            panel3.Controls.Add(buttonSaveClient);
            panel3.Controls.Add(inputGender);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(inputBirthday);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(420, 122);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(293, 250);
            panel3.TabIndex = 4;
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.AutoSize = true;
            buttonSaveClient.Cursor = Cursors.Hand;
            buttonSaveClient.Dock = DockStyle.Bottom;
            buttonSaveClient.FlatAppearance.BorderColor = Color.DimGray;
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveClient.ForeColor = Color.White;
            buttonSaveClient.Location = new Point(10, 207);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(273, 33);
            buttonSaveClient.TabIndex = 4;
            buttonSaveClient.Text = "Guardar cliente";
            buttonSaveClient.UseVisualStyleBackColor = true;
            buttonSaveClient.Click += buttonSaveClient_Click;
            // 
            // inputGender
            // 
            inputGender.BackColor = Color.FromArgb(17, 17, 34);
            inputGender.Cursor = Cursors.IBeam;
            inputGender.Dock = DockStyle.Top;
            inputGender.FlatStyle = FlatStyle.Flat;
            inputGender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputGender.ForeColor = Color.White;
            inputGender.FormattingEnabled = true;
            inputGender.Items.AddRange(new object[] { "No especificado", "Femenino", "Masculino" });
            inputGender.Location = new Point(10, 95);
            inputGender.Name = "inputGender";
            inputGender.Size = new Size(273, 25);
            inputGender.TabIndex = 3;
            inputGender.Text = "No especificado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(10, 60);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 10, 0, 4);
            label6.Size = new Size(64, 35);
            label6.TabIndex = 2;
            label6.Text = "Género:";
            // 
            // inputBirthday
            // 
            inputBirthday.CalendarForeColor = Color.White;
            inputBirthday.CalendarMonthBackground = Color.FromArgb(17, 17, 34);
            inputBirthday.CalendarTitleBackColor = Color.DimGray;
            inputBirthday.CalendarTitleForeColor = Color.White;
            inputBirthday.CalendarTrailingForeColor = Color.Silver;
            inputBirthday.Cursor = Cursors.IBeam;
            inputBirthday.CustomFormat = "dd/mm/yyyy";
            inputBirthday.Dock = DockStyle.Top;
            inputBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputBirthday.Location = new Point(10, 35);
            inputBirthday.MaxDate = new DateTime(2023, 9, 29, 0, 0, 0, 0);
            inputBirthday.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            inputBirthday.Name = "inputBirthday";
            inputBirthday.Size = new Size(273, 25);
            inputBirthday.TabIndex = 1;
            inputBirthday.Value = new DateTime(2023, 9, 29, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(10, 10);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 4);
            label9.Size = new Size(155, 25);
            label9.TabIndex = 0;
            label9.Text = "Fecha de nacimiento:";
            // 
            // FormNewClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormNewClient";
            Text = "FormNewClient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label9;
        private ComboBox inputGender;
        private Label label6;
        private DateTimePicker inputBirthday;
        private Button buttonSaveClient;
        private TextBox inputId;
        private TextBox inputSecondLastName;
        private Label label5;
        private TextBox inputFirstLastName;
        private Label label4;
        private TextBox inputName;
        private Label label3;
    }
}