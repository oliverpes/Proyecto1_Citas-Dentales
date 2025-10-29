namespace Proyecto1_Citas_Dentales.Forms
{
    partial class login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            labelTitulo = new Label();
            labelMarca = new Label();
            buttonCerrar = new Button();
            UsuarioTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ContraseñaTxt = new Guna.UI2.WinForms.Guna2TextBox();
            ButtonLogin = new Guna.UI2.WinForms.Guna2Button();
            labelNota = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(218, 180);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(151, 54);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Sign in";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelMarca.ForeColor = Color.White;
            labelMarca.Location = new Point(12, 9);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(151, 46);
            labelMarca.TabIndex = 1;
            labelMarca.Text = "Cdental.";
            // 
            // buttonCerrar
            // 
            buttonCerrar.Anchor = AnchorStyles.None;
            buttonCerrar.AutoSize = true;
            buttonCerrar.BackColor = Color.DarkRed;
            buttonCerrar.FlatStyle = FlatStyle.Flat;
            buttonCerrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            buttonCerrar.ForeColor = Color.White;
            buttonCerrar.Location = new Point(564, 0);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(46, 37);
            buttonCerrar.TabIndex = 2;
            buttonCerrar.Text = "X";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // UsuarioTxt
            // 
            UsuarioTxt.CustomizableEdges = customizableEdges1;
            UsuarioTxt.DefaultText = "";
            UsuarioTxt.FillColor = SystemColors.Window;
            UsuarioTxt.Font = new Font("Segoe UI", 9F);
            UsuarioTxt.Location = new Point(110, 280);
            UsuarioTxt.Margin = new Padding(3, 4, 3, 4);
            UsuarioTxt.Name = "UsuarioTxt";
            UsuarioTxt.PlaceholderText = "Correo electrónico";
            UsuarioTxt.SelectedText = "";
            UsuarioTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UsuarioTxt.Size = new Size(370, 50);
            UsuarioTxt.TabIndex = 3;
            UsuarioTxt.TextChanged += UsuarioTxt_TextChanged;
            // 
            // ContraseñaTxt
            // 
            ContraseñaTxt.CustomizableEdges = customizableEdges3;
            ContraseñaTxt.DefaultText = "";
            ContraseñaTxt.Font = new Font("Segoe UI", 9F);
            ContraseñaTxt.Location = new Point(110, 361);
            ContraseñaTxt.Margin = new Padding(3, 4, 3, 4);
            ContraseñaTxt.Name = "ContraseñaTxt";
            ContraseñaTxt.PlaceholderText = "Contraseña";
            ContraseñaTxt.SelectedText = "";
            ContraseñaTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ContraseñaTxt.Size = new Size(370, 50);
            ContraseñaTxt.TabIndex = 4;
            ContraseñaTxt.UseSystemPasswordChar = true;
            ContraseñaTxt.TextChanged += ContraseñaTxt_TextChanged;
            // 
            // ButtonLogin
            // 
            ButtonLogin.CustomizableEdges = customizableEdges5;
            ButtonLogin.FillColor = Color.FromArgb(93, 95, 238);
            ButtonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ButtonLogin.ForeColor = Color.White;
            ButtonLogin.Location = new Point(178, 449);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ButtonLogin.Size = new Size(230, 50);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Iniciar Sesión";
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // labelNota
            // 
            labelNota.AutoSize = true;
            labelNota.Font = new Font("Segoe UI", 10F);
            labelNota.ForeColor = Color.White;
            labelNota.Location = new Point(125, 524);
            labelNota.Name = "labelNota";
            labelNota.Size = new Size(397, 23);
            labelNota.TabIndex = 6;
            labelNota.Text = "¿No tienes cuenta? Contactanos y únete a Cdental";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(610, 700);
            Controls.Add(labelNota);
            Controls.Add(ButtonLogin);
            Controls.Add(ContraseñaTxt);
            Controls.Add(UsuarioTxt);
            Controls.Add(buttonCerrar);
            Controls.Add(labelMarca);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Button buttonCerrar;
        private Guna.UI2.WinForms.Guna2TextBox UsuarioTxt;
        private Guna.UI2.WinForms.Guna2TextBox ContraseñaTxt;
        private Guna.UI2.WinForms.Guna2Button ButtonLogin;
        private System.Windows.Forms.Label labelNota;
    }
}
