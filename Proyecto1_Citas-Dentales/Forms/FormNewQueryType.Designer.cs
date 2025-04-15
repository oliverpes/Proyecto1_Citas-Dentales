namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormNewQueryType
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
            ButtonAddQueryType = new Button();
            label1 = new Label();
            panel2 = new Panel();
            buttonAddNewType = new Button();
            label4 = new Label();
            stateQueryType = new ComboBox();
            descriptionQueryType = new TextBox();
            label3 = new Label();
            label2 = new Label();
            idQueryType = new NumericUpDown();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idQueryType).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(ButtonAddQueryType);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 1;
            // 
            // ButtonAddQueryType
            // 
            ButtonAddQueryType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonAddQueryType.AutoSize = true;
            ButtonAddQueryType.BackColor = Color.FromArgb(25, 25, 50);
            ButtonAddQueryType.FlatStyle = FlatStyle.Flat;
            ButtonAddQueryType.ForeColor = Color.White;
            ButtonAddQueryType.Location = new Point(1277, 17);
            ButtonAddQueryType.Name = "ButtonAddQueryType";
            ButtonAddQueryType.Padding = new Padding(8, 4, 8, 4);
            ButtonAddQueryType.Size = new Size(101, 35);
            ButtonAddQueryType.TabIndex = 2;
            ButtonAddQueryType.Text = "Agregar tipo";
            ButtonAddQueryType.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(422, 37);
            label1.TabIndex = 1;
            label1.Text = "Agregar nuevo tipo de consulta";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAddNewType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(stateQueryType);
            panel2.Controls.Add(descriptionQueryType);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(idQueryType);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 378);
            panel2.TabIndex = 4;
            // 
            // buttonAddNewType
            // 
            buttonAddNewType.AutoSize = true;
            buttonAddNewType.BackColor = Color.FromArgb(17, 17, 34);
            buttonAddNewType.FlatStyle = FlatStyle.Flat;
            buttonAddNewType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddNewType.ForeColor = Color.LightGray;
            buttonAddNewType.Location = new Point(350, 245);
            buttonAddNewType.Name = "buttonAddNewType";
            buttonAddNewType.Padding = new Padding(8, 0, 8, 0);
            buttonAddNewType.Size = new Size(94, 33);
            buttonAddNewType.TabIndex = 7;
            buttonAddNewType.Text = "Agregar";
            buttonAddNewType.UseVisualStyleBackColor = false;
            buttonAddNewType.Click += ButtonAddQueryType_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(247, 167);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 6;
            label4.Text = "Seleccione el estado:";
            // 
            // stateQueryType
            // 
            stateQueryType.BackColor = Color.FromArgb(17, 17, 34);
            stateQueryType.FlatStyle = FlatStyle.Flat;
            stateQueryType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            stateQueryType.ForeColor = Color.White;
            stateQueryType.FormattingEnabled = true;
            stateQueryType.Items.AddRange(new object[] { "Activo", "Inactivo" });
            stateQueryType.Location = new Point(247, 195);
            stateQueryType.Name = "stateQueryType";
            stateQueryType.Size = new Size(310, 29);
            stateQueryType.TabIndex = 5;
            stateQueryType.Text = "Inactivo";
            // 
            // descriptionQueryType
            // 
            descriptionQueryType.BackColor = Color.FromArgb(17, 17, 34);
            descriptionQueryType.BorderStyle = BorderStyle.FixedSingle;
            descriptionQueryType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionQueryType.ForeColor = Color.White;
            descriptionQueryType.Location = new Point(247, 127);
            descriptionQueryType.Name = "descriptionQueryType";
            descriptionQueryType.Size = new Size(310, 29);
            descriptionQueryType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(247, 99);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(247, 31);
            label2.Name = "label2";
            label2.Size = new Size(310, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese un numero para el tipo de consulta:";
            // 
            // idQueryType
            // 
            idQueryType.BackColor = Color.FromArgb(17, 17, 34);
            idQueryType.BorderStyle = BorderStyle.FixedSingle;
            idQueryType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idQueryType.ForeColor = Color.White;
            idQueryType.Location = new Point(247, 59);
            idQueryType.Name = "idQueryType";
            idQueryType.Size = new Size(310, 29);
            idQueryType.TabIndex = 2;
            // 
            // FormNewQueryType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormNewQueryType";
            Text = "FormNewQueryType";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)idQueryType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonAddQueryType;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private ComboBox stateQueryType;
        private TextBox descriptionQueryType;
        private Label label3;
        private Label label2;
        private NumericUpDown idQueryType;
        private Button buttonAddNewType;

    }
}