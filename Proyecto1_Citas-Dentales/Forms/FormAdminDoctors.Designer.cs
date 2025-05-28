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
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(buttonNewDoctor);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 93);
            panel1.TabIndex = 2;
            // 
            // buttonNewDoctor
            // 
            buttonNewDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonNewDoctor.AutoSize = true;
            buttonNewDoctor.BackColor = Color.FromArgb(25, 25, 50);
            buttonNewDoctor.FlatStyle = FlatStyle.Flat;
            buttonNewDoctor.ForeColor = Color.White;
            buttonNewDoctor.Location = new Point(741, 24);
            buttonNewDoctor.Margin = new Padding(3, 4, 3, 4);
            buttonNewDoctor.Name = "buttonNewDoctor";
            buttonNewDoctor.Padding = new Padding(9, 5, 9, 5);
            buttonNewDoctor.Size = new Size(149, 53);
            buttonNewDoctor.TabIndex = 4;
            buttonNewDoctor.Text = "Nuevo Doctor";
            buttonNewDoctor.UseVisualStyleBackColor = false;
            buttonNewDoctor.Click += buttonNewDoctor_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(192, 54);
            label1.TabIndex = 1;
            label1.Text = "Doctores";
            // 
            // doctorDataViewer
            // 
            doctorDataViewer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            doctorDataViewer.BackgroundColor = Color.White;
            doctorDataViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorDataViewer.Location = new Point(3, 0);
            doctorDataViewer.Margin = new Padding(3, 4, 3, 4);
            doctorDataViewer.Name = "doctorDataViewer";
            doctorDataViewer.ReadOnly = true;
            doctorDataViewer.RowHeadersWidth = 51;
            doctorDataViewer.RowTemplate.Height = 25;
            doctorDataViewer.Size = new Size(911, 427);
            doctorDataViewer.TabIndex = 3;
            doctorDataViewer.CellClick += HandleCellClick;
            doctorDataViewer.CellContentClick += doctorDataViewer_CellContentClick;
            // 
            // buttonDeleteDoctor
            // 
            buttonDeleteDoctor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDeleteDoctor.AutoSize = true;
            buttonDeleteDoctor.BackColor = Color.FromArgb(192, 0, 0);
            buttonDeleteDoctor.FlatStyle = FlatStyle.Flat;
            buttonDeleteDoctor.ForeColor = Color.White;
            buttonDeleteDoctor.Location = new Point(167, 550);
            buttonDeleteDoctor.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteDoctor.Name = "buttonDeleteDoctor";
            buttonDeleteDoctor.Padding = new Padding(9, 5, 9, 5);
            buttonDeleteDoctor.Size = new Size(141, 47);
            buttonDeleteDoctor.TabIndex = 5;
            buttonDeleteDoctor.Text = "Eliminar doctor";
            buttonDeleteDoctor.UseVisualStyleBackColor = false;
            buttonDeleteDoctor.Click += buttonDeleteDoctor_Click;
            // 
            // buttonChangeState
            // 
            buttonChangeState.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonChangeState.AutoSize = true;
            buttonChangeState.BackColor = Color.FromArgb(17, 17, 34);
            buttonChangeState.FlatStyle = FlatStyle.Flat;
            buttonChangeState.ForeColor = Color.White;
            buttonChangeState.Location = new Point(14, 550);
            buttonChangeState.Margin = new Padding(3, 4, 3, 4);
            buttonChangeState.Name = "buttonChangeState";
            buttonChangeState.Padding = new Padding(9, 5, 9, 5);
            buttonChangeState.Size = new Size(144, 47);
            buttonChangeState.TabIndex = 4;
            buttonChangeState.Text = "Cambiar estado";
            buttonChangeState.UseVisualStyleBackColor = false;
            buttonChangeState.Click += buttonChangeState_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(doctorDataViewer);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 93);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 24, 9, 0);
            panel2.Size = new Size(914, 427);
            panel2.TabIndex = 6;
            // 
            // FormAdminDoctors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 634);
            Controls.Add(panel2);
            Controls.Add(buttonDeleteDoctor);
            Controls.Add(buttonChangeState);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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
        //private Button button2;
        //private Button button1;
        private Label label1;
        private Button buttonNewDoctor;
        private DataGridView doctorDataViewer;
        private Button buttonDeleteDoctor;
        private Button buttonChangeState;
        private Panel panel2;
    }
}