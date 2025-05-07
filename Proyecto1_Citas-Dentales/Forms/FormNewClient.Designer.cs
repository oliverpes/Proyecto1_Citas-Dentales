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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(25, 25, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1426, 23);
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
            button1.Location = new Point(2121, 23);
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
            label1.Size = new Size(283, 54);
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
            panel2.Location = new Point(81, 163);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 13, 11, 13);
            panel2.Size = new Size(338, 333);
            panel2.TabIndex = 3;
            // 
            // inputSecondLastName
            // 
            inputSecondLastName.BackColor = Color.FromArgb(17, 17, 34);
            inputSecondLastName.BorderStyle = BorderStyle.FixedSingle;
            inputSecondLastName.Cursor = Cursors.IBeam;
            inputSecondLastName.Dock = DockStyle.Top;
            inputSecondLastName.Font = new Font("Segoe UI", 10F);
            inputSecondLastName.ForeColor = Color.White;
            inputSecondLastName.Location = new Point(11, 274);
            inputSecondLastName.Margin = new Padding(3, 4, 3, 4);
            inputSecondLastName.Name = "inputSecondLastName";
            inputSecondLastName.Size = new Size(316, 30);
            inputSecondLastName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(11, 228);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 13, 0, 5);
            label5.Size = new Size(171, 46);
            label5.TabIndex = 13;
            label5.Text = "Segundo apellido:";
            // 
            // inputFirstLastName
            // 
            inputFirstLastName.BackColor = Color.FromArgb(17, 17, 34);
            inputFirstLastName.BorderStyle = BorderStyle.FixedSingle;
            inputFirstLastName.Cursor = Cursors.IBeam;
            inputFirstLastName.Dock = DockStyle.Top;
            inputFirstLastName.Font = new Font("Segoe UI", 10F);
            inputFirstLastName.ForeColor = Color.White;
            inputFirstLastName.Location = new Point(11, 198);
            inputFirstLastName.Margin = new Padding(3, 4, 3, 4);
            inputFirstLastName.Name = "inputFirstLastName";
            inputFirstLastName.Size = new Size(316, 30);
            inputFirstLastName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(11, 152);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 13, 0, 5);
            label4.Size = new Size(149, 46);
            label4.TabIndex = 11;
            label4.Text = "Primer apellido:";
            // 
            // inputName
            // 
            inputName.BackColor = Color.FromArgb(17, 17, 34);
            inputName.BorderStyle = BorderStyle.FixedSingle;
            inputName.Cursor = Cursors.IBeam;
            inputName.Dock = DockStyle.Top;
            inputName.Font = new Font("Segoe UI", 10F);
            inputName.ForeColor = Color.White;
            inputName.Location = new Point(11, 122);
            inputName.Margin = new Padding(3, 4, 3, 4);
            inputName.Name = "inputName";
            inputName.Size = new Size(316, 30);
            inputName.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(11, 76);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 13, 0, 5);
            label3.Size = new Size(89, 46);
            label3.TabIndex = 9;
            label3.Text = "Nombre:";
            // 
            // inputId
            // 
            inputId.BackColor = Color.FromArgb(17, 17, 34);
            inputId.BorderStyle = BorderStyle.FixedSingle;
            inputId.Cursor = Cursors.IBeam;
            inputId.Dock = DockStyle.Top;
            inputId.Font = new Font("Segoe UI", 10F);
            inputId.ForeColor = Color.White;
            inputId.Location = new Point(11, 46);
            inputId.Margin = new Padding(3, 4, 3, 4);
            inputId.Name = "inputId";
            inputId.Size = new Size(316, 30);
            inputId.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(234, 33);
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
            panel3.Location = new Point(480, 163);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(11, 13, 11, 13);
            panel3.Size = new Size(335, 333);
            panel3.TabIndex = 4;
            // 
            // buttonSaveClient
            // 
            buttonSaveClient.AutoSize = true;
            buttonSaveClient.Cursor = Cursors.Hand;
            buttonSaveClient.Dock = DockStyle.Bottom;
            buttonSaveClient.FlatAppearance.BorderColor = Color.DimGray;
            buttonSaveClient.FlatStyle = FlatStyle.Flat;
            buttonSaveClient.Font = new Font("Segoe UI", 12F);
            buttonSaveClient.ForeColor = Color.White;
            buttonSaveClient.Location = new Point(11, 267);
            buttonSaveClient.Margin = new Padding(3, 4, 3, 4);
            buttonSaveClient.Name = "buttonSaveClient";
            buttonSaveClient.Size = new Size(313, 53);
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
            inputGender.Font = new Font("Segoe UI", 10F);
            inputGender.ForeColor = Color.White;
            inputGender.FormattingEnabled = true;
            inputGender.Items.AddRange(new object[] { "No especificado", "Femenino", "Masculino" });
            inputGender.Location = new Point(11, 122);
            inputGender.Margin = new Padding(3, 4, 3, 4);
            inputGender.Name = "inputGender";
            inputGender.Size = new Size(313, 31);
            inputGender.TabIndex = 3;
            inputGender.Text = "No especificado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(11, 76);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 13, 0, 5);
            label6.Size = new Size(80, 46);
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
            inputBirthday.Font = new Font("Segoe UI", 10F);
            inputBirthday.Location = new Point(11, 46);
            inputBirthday.Margin = new Padding(3, 4, 3, 4);
            inputBirthday.MaxDate = new DateTime(2023, 9, 29, 0, 0, 0, 0);
            inputBirthday.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            inputBirthday.Name = "inputBirthday";
            inputBirthday.Size = new Size(313, 30);
            inputBirthday.TabIndex = 1;
            inputBirthday.Value = new DateTime(2023, 9, 29, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Top;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(11, 13);
            label9.Name = "label9";
            label9.Padding = new Padding(0, 0, 0, 5);
            label9.Size = new Size(195, 33);
            label9.TabIndex = 0;
            label9.Text = "Fecha de nacimiento:";
            // 
            // FormNewClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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