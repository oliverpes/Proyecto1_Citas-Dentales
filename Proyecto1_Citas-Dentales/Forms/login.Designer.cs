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
            txtContraseña = new TextBox();
            label2 = new Label();
            label1 = new Label();
            loginButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.BackColor = Color.FromArgb(17, 17, 34);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Gray;
            txtUsuario.Location = new Point(97, 301);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(443, 35);
            txtUsuario.TabIndex = 18;
            txtUsuario.Text = "Usuario";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.BackColor = Color.FromArgb(17, 17, 34);
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Location = new Point(97, 388);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(443, 35);
            txtContraseña.TabIndex = 13;
            txtContraseña.Text = "Contraseña";
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txContraseña_Leave;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(216, 176);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 5);
            label2.Size = new Size(151, 59);
            label2.TabIndex = 15;
            label2.Text = "Sign in";
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
            loginButton.BackColor = Color.DodgerBlue;
            loginButton.FlatAppearance.BorderColor = Color.DimGray;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(239, 490);
            loginButton.Margin = new Padding(3, 8, 3, 8);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(141, 50);
            loginButton.TabIndex = 17;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += searchButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = Color.DarkRed;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(556, -4);
            button1.Margin = new Padding(3, 8, 3, 8);
            button1.Name = "button1";
            button1.Size = new Size(60, 37);
            button1.TabIndex = 19;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 30, 48);
            ClientSize = new Size(614, 701);
            Controls.Add(button1);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label2;
        private Label label1;
        private Button loginButton;
        private Button button1;
    }
}