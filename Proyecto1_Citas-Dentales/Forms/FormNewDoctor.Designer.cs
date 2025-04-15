namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormNewDoctor
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
            panel3 = new Panel();
            buttonSaveDoctor = new Button();
            inputState = new ComboBox();
            label6 = new Label();
            panel2 = new Panel();
            inputSecondLastName = new TextBox();
            label5 = new Label();
            inputFirstLastName = new TextBox();
            label4 = new Label();
            inputName = new TextBox();
            label3 = new Label();
            inputId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(25, 25, 50);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(2112, 23);
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
            button1.Location = new Point(2807, 23);
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
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(282, 54);
            label1.TabIndex = 1;
            label1.Text = "Nuevo doctor";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.AutoSize = true;
            panel3.Controls.Add(buttonSaveDoctor);
            panel3.Controls.Add(inputState);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(487, 160);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(11, 13, 11, 13);
            panel3.Size = new Size(335, 333);
            panel3.TabIndex = 6;
            // 
            // buttonSaveDoctor
            // 
            buttonSaveDoctor.AutoSize = true;
            buttonSaveDoctor.Dock = DockStyle.Bottom;
            buttonSaveDoctor.FlatAppearance.BorderColor = Color.DimGray;
            buttonSaveDoctor.FlatStyle = FlatStyle.Flat;
            buttonSaveDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveDoctor.ForeColor = Color.White;
            buttonSaveDoctor.Location = new Point(11, 267);
            buttonSaveDoctor.Margin = new Padding(3, 4, 3, 4);
            buttonSaveDoctor.Name = "buttonSaveDoctor";
            buttonSaveDoctor.Size = new Size(313, 53);
            buttonSaveDoctor.TabIndex = 4;
            buttonSaveDoctor.Text = "Guardar doctor";
            buttonSaveDoctor.UseVisualStyleBackColor = true;
            buttonSaveDoctor.Click += buttonSaveDoctor_Click;
            // 
            // inputState
            // 
            inputState.BackColor = Color.FromArgb(17, 17, 34);
            inputState.Dock = DockStyle.Top;
            inputState.FlatStyle = FlatStyle.Flat;
            inputState.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            inputState.ForeColor = Color.White;
            inputState.FormattingEnabled = true;
            inputState.Items.AddRange(new object[] { "Inactivo", "Activo" });
            inputState.Location = new Point(11, 59);
            inputState.Margin = new Padding(3, 4, 3, 4);
            inputState.Name = "inputState";
            inputState.Size = new Size(313, 31);
            inputState.TabIndex = 3;
            inputState.Text = "Inactivo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(11, 13);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 13, 0, 5);
            label6.Size = new Size(75, 46);
            label6.TabIndex = 2;
            label6.Text = "Estado:";
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
            panel2.Location = new Point(88, 160);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(11, 13, 11, 13);
            panel2.Size = new Size(338, 333);
            panel2.TabIndex = 5;
            // 
            // inputSecondLastName
            // 
            inputSecondLastName.BackColor = Color.FromArgb(17, 17, 34);
            inputSecondLastName.BorderStyle = BorderStyle.FixedSingle;
            inputSecondLastName.Dock = DockStyle.Top;
            inputSecondLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            inputFirstLastName.Dock = DockStyle.Top;
            inputFirstLastName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            inputName.Dock = DockStyle.Top;
            inputName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            inputId.Dock = DockStyle.Top;
            inputId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(229, 33);
            label2.TabIndex = 0;
            label2.Text = "Identificación del doctor:";
            // 
            // FormNewDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNewDoctor";
            Text = "FormNewDoctor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Panel panel3;
        private Button buttonSaveDoctor;
        private ComboBox inputState;
        private Label label6;
        private Panel panel2;
        private TextBox inputSecondLastName;
        private Label label5;
        private TextBox inputFirstLastName;
        private Label label4;
        private TextBox inputName;
        private Label label3;
        private TextBox inputId;
        private Label label2;
    }
}