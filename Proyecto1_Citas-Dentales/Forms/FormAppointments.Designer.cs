namespace Proyecto1_Citas_Dentales.Forms
{
    partial class FormAppointments
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
            button1 = new Button();
            label1 = new Label();
            appointmentsView = new DataGridView();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 17, 34);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(25, 25, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(685, 17);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 4, 8, 4);
            button1.Size = new Size(93, 35);
            button1.TabIndex = 1;
            button1.Text = "Nueva Cita";
            button1.UseVisualStyleBackColor = false;
            button1.Click += HandleNewAppoiment;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 45);
            label1.TabIndex = 0;
            label1.Text = "Citas";
            // 
            // appointmentsView
            // 
            appointmentsView.BackgroundColor = Color.FromArgb(25, 25, 50);
            appointmentsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsView.Dock = DockStyle.Top;
            appointmentsView.Location = new Point(0, 70);
            appointmentsView.Name = "appointmentsView";
            appointmentsView.ReadOnly = true;
            appointmentsView.RowTemplate.Height = 25;
            appointmentsView.Size = new Size(800, 276);
            appointmentsView.TabIndex = 1;
            appointmentsView.CellClick += HandleClickCell;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSize = true;
            buttonDelete.BackColor = Color.FromArgb(25, 25, 50);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(23, 367);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(93, 35);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Borrar cita";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += DeleteAppointment;
            // 
            // FormAppointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(appointmentsView);
            Controls.Add(panel1);
            Name = "FormAppointments";
            Text = "FormNewDates";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private DataGridView appointmentsView;
        private Button buttonDelete;
    }
}