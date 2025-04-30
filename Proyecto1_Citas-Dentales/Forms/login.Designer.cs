namespace Proyecto1_Citas_Dentales.Forms
{
    partial class login
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
            txtUsuario = new TextBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(17, 17, 34);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(295, 213);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(443, 30);
            txtUsuario.TabIndex = 9;
            txtUsuario.TextChanged += inputId_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(456, 144);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 5);
            label3.Size = new Size(119, 46);
            label3.TabIndex = 12;
            label3.Text = "Usuario";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.BackColor = Color.FromArgb(17, 17, 34);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10F);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(295, 333);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(443, 30);
            txtContraseña.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(437, 264);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 5);
            label4.Size = new Size(168, 46);
            label4.TabIndex = 14;
            label4.Text = "Contraseña";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(456, 42);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(127, 59);
            label2.TabIndex = 15;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 5);
            label1.Size = new Size(146, 51);
            label1.TabIndex = 16;
            label1.Text = "CDental";
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.AutoSize = true;
            loginButton.FlatAppearance.BorderColor = Color.DimGray;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(442, 399);
            loginButton.Margin = new Padding(3, 8, 3, 8);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(141, 50);
            loginButton.TabIndex = 17;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += searchButton_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 50);
            ClientSize = new Size(1010, 537);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtUsuario);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private Label label3;
        private TextBox txtContraseña;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button loginButton;
    }
}