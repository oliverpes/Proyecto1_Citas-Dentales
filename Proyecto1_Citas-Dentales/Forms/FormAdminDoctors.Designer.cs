namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormAdminDoctors
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
            buttonNewDoctor = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            doctorDataViewer = new DataGridView();
            buttonDeleteDoctor = new Button();
            buttonChangeState = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorDataViewer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(buttonNewDoctor);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 2;
            // 
            // buttonNewDoctor
            // 
            buttonNewDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewDoctor.AutoSize = true;
            buttonNewDoctor.BackColor = Color.FromArgb(25, 25, 50);
            buttonNewDoctor.FlatStyle = FlatStyle.Flat;
            buttonNewDoctor.ForeColor = Color.White;
            buttonNewDoctor.Location = new Point(668, 18);
            buttonNewDoctor.Name = "buttonNewDoctor";
            buttonNewDoctor.Padding = new Padding(8, 4, 8, 4);
            buttonNewDoctor.Size = new Size(110, 35);
            buttonNewDoctor.TabIndex = 4;
            buttonNewDoctor.Text = "Nuevo Doctor";
            buttonNewDoctor.UseVisualStyleBackColor = false;
            buttonNewDoctor.Click += buttonNewDoctor_Click;
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
            label1.Size = new Size(155, 45);
            label1.TabIndex = 1;
            label1.Text = "Doctores";
            // 
            // doctorDataViewer
            // 
            doctorDataViewer.BackgroundColor = Color.FromArgb(25, 25, 50);
            doctorDataViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorDataViewer.Dock = DockStyle.Fill;
            doctorDataViewer.Location = new Point(8, 18);
            doctorDataViewer.Name = "doctorDataViewer";
            doctorDataViewer.ReadOnly = true;
            doctorDataViewer.RowTemplate.Height = 25;
            doctorDataViewer.Size = new Size(784, 302);
            doctorDataViewer.TabIndex = 3;
            doctorDataViewer.CellClick += HandleCellClick;
            // 
            // buttonDeleteDoctor
            // 
            buttonDeleteDoctor.AutoSize = true;
            buttonDeleteDoctor.BackColor = Color.FromArgb(192, 0, 0);
            buttonDeleteDoctor.FlatStyle = FlatStyle.Flat;
            buttonDeleteDoctor.ForeColor = Color.White;
            buttonDeleteDoctor.Location = new Point(142, 404);
            buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            buttonDeleteDoctor.Padding = new Padding(8, 4, 8, 4);
            buttonDeleteDoctor.Size = new Size(118, 35);
            buttonDeleteDoctor.TabIndex = 5;
            buttonDeleteDoctor.Text = "Eliminar doctor";
            buttonDeleteDoctor.UseVisualStyleBackColor = false;
            buttonDeleteDoctor.Click += buttonDeleteDoctor_Click;
            // 
            // buttonChangeState
            // 
            buttonChangeState.AutoSize = true;
            buttonChangeState.BackColor = Color.FromArgb(17, 17, 34);
            buttonChangeState.FlatStyle = FlatStyle.Flat;
            buttonChangeState.ForeColor = Color.White;
            buttonChangeState.Location = new Point(8, 404);
            buttonChangeState.Name = "buttonChangeState";
            buttonChangeState.Padding = new Padding(8, 4, 8, 4);
            buttonChangeState.Size = new Size(118, 35);
            buttonChangeState.TabIndex = 4;
            buttonChangeState.Text = "Cambiar estado";
            buttonChangeState.UseVisualStyleBackColor = false;
            buttonChangeState.Click += buttonChangeState_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(doctorDataViewer);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 18, 8, 0);
            panel2.Size = new Size(800, 320);
            panel2.TabIndex = 6;
            // 
            // FormAdminDoctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(buttonDeleteDoctor);
            Controls.Add(buttonChangeState);
            Controls.Add(panel1);
            Name = "FormAdminDoctors";
            Text = "FormAdminDoctors";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)doctorDataViewer).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button buttonNewDoctor;
        private DataGridView doctorDataViewer;
        private Button buttonDeleteDoctor;
        private Button buttonChangeState;
        private Panel panel2;
    }
}