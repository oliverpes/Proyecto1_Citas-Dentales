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
            label1 = new Label();
            panel2 = new Panel();
            buttonAddNewType = new Button();
            label4 = new Label();
            stateQueryType = new ComboBox();
            descriptionQueryType = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(524, 46);
            label1.TabIndex = 1;
            label1.Text = "Agregar nuevo tipo de consulta";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(buttonAddNewType);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(stateQueryType);
            panel2.Controls.Add(descriptionQueryType);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 93);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 504);
            panel2.TabIndex = 4;
            // 
            // buttonAddNewType
            // 
            buttonAddNewType.AutoSize = true;
            buttonAddNewType.BackColor = Color.Navy;
            buttonAddNewType.FlatStyle = FlatStyle.Flat;
            buttonAddNewType.Font = new Font("Segoe UI", 12F);
            buttonAddNewType.ForeColor = Color.LightGray;
            buttonAddNewType.Location = new Point(400, 327);
            buttonAddNewType.Margin = new Padding(3, 4, 3, 4);
            buttonAddNewType.Name = "buttonAddNewType";
            buttonAddNewType.Padding = new Padding(9, 0, 9, 0);
            buttonAddNewType.Size = new Size(127, 53);
            buttonAddNewType.TabIndex = 7;
            buttonAddNewType.Text = "Agregar";
            buttonAddNewType.UseVisualStyleBackColor = false;
            buttonAddNewType.Click += ButtonAddQueryType_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(282, 223);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 6;
            label4.Text = "Seleccione el estado:";
            // 
            // stateQueryType
            // 
            stateQueryType.BackColor = Color.White;
            stateQueryType.Font = new Font("Segoe UI", 12F);
            stateQueryType.ForeColor = Color.Black;
            stateQueryType.FormattingEnabled = true;
            stateQueryType.Items.AddRange(new object[] { "Activo", "Inactivo" });
            stateQueryType.Location = new Point(282, 260);
            stateQueryType.Margin = new Padding(3, 4, 3, 4);
            stateQueryType.Name = "stateQueryType";
            stateQueryType.Size = new Size(354, 36);
            stateQueryType.TabIndex = 5;
            stateQueryType.Text = "Inactivo";
            // 
            // descriptionQueryType
            // 
            descriptionQueryType.BackColor = Color.White;
            descriptionQueryType.BorderStyle = BorderStyle.FixedSingle;
            descriptionQueryType.Font = new Font("Segoe UI", 12F);
            descriptionQueryType.ForeColor = Color.Black;
            descriptionQueryType.Location = new Point(282, 169);
            descriptionQueryType.Margin = new Padding(3, 4, 3, 4);
            descriptionQueryType.Name = "descriptionQueryType";
            descriptionQueryType.Size = new Size(354, 34);
            descriptionQueryType.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(282, 132);
            label3.Name = "label3";
            label3.Size = new Size(204, 28);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la descripción:";
            // 
            // FormNewQueryType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNewQueryType";
            Text = "FormNewQueryType";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private ComboBox stateQueryType;
        private TextBox descriptionQueryType;
        private Label label3;
        private Button buttonAddNewType;

    }
}