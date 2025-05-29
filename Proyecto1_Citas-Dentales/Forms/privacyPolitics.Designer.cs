namespace Proyecto1_Citas_Dentales.Forms
{
    partial class privacyPolitics
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            txtPolitics = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 10);
            label1.Name = "label1";
            label1.Size = new Size(334, 41);
            label1.TabIndex = 0;
            label1.Text = "Políticas de Privacidad";
            // 
            // txtPolitics
            // 
            txtPolitics.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPolitics.BackColor = Color.White;
            txtPolitics.BorderStyle = BorderStyle.None;
            txtPolitics.Font = new Font("Segoe UI", 10F);
            txtPolitics.Location = new Point(0, 60);
            txtPolitics.Margin = new Padding(20);
            txtPolitics.Multiline = true;
            txtPolitics.Name = "txtPolitics";
            txtPolitics.ReadOnly = true;
            txtPolitics.ScrollBars = ScrollBars.Vertical;
            txtPolitics.Size = new Size(800, 530);
            txtPolitics.TabIndex = 0;
            // 
            // privacyPolitics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(txtPolitics);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "privacyPolitics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Políticas de Privacidad";
            Load += privacyPolitics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPolitics;
    }
}
