using Guna.UI2.WinForms;

namespace Proyecto1_Citas_Dentales
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelSideMenu = new Panel();
            button1 = new Button();
            buttonReportDoctor = new Button();
            buttonReportClient = new Button();
            buttonReportDate = new Button();
            label4 = new Label();
            buttonAdmDoctors = new Button();
            buttonAdmClients = new Button();
            label3 = new Label();
            buttonNewQueryType = new Button();
            buttonNewDates = new Button();
            label2 = new Label();
            panelLogo = new Panel();
            button3 = new Button();
            label5 = new Label();
            panelDesktopPanel = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            guna2ComboBox1 = new Guna2ComboBox();
            panel2 = new Panel();
            button4 = new Button();
            panelSideMenu.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AccessibleName = "PanelSideMenu";
            panelSideMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.SteelBlue;
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(buttonReportDoctor);
            panelSideMenu.Controls.Add(buttonReportClient);
            panelSideMenu.Controls.Add(buttonReportDate);
            panelSideMenu.Controls.Add(label4);
            panelSideMenu.Controls.Add(buttonAdmDoctors);
            panelSideMenu.Controls.Add(buttonAdmClients);
            panelSideMenu.Controls.Add(label3);
            panelSideMenu.Controls.Add(buttonNewQueryType);
            panelSideMenu.Controls.Add(buttonNewDates);
            panelSideMenu.Controls.Add(label2);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Location = new Point(0, 226);
            panelSideMenu.Margin = new Padding(3, 4, 3, 4);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(328, 565);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(0, 504);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(18, 0, 0, 0);
            button1.Size = new Size(328, 60);
            button1.TabIndex = 10;
            button1.Text = "Acuerdo de privacidad";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonReportDoctor
            // 
            buttonReportDoctor.Cursor = Cursors.Hand;
            buttonReportDoctor.Dock = DockStyle.Top;
            buttonReportDoctor.FlatAppearance.BorderSize = 0;
            buttonReportDoctor.FlatStyle = FlatStyle.Flat;
            buttonReportDoctor.Font = new Font("Segoe UI", 10F);
            buttonReportDoctor.ForeColor = Color.LightGray;
            buttonReportDoctor.Location = new Point(0, 444);
            buttonReportDoctor.Margin = new Padding(3, 4, 3, 4);
            buttonReportDoctor.Name = "buttonReportDoctor";
            buttonReportDoctor.Padding = new Padding(18, 0, 0, 0);
            buttonReportDoctor.Size = new Size(328, 60);
            buttonReportDoctor.TabIndex = 9;
            buttonReportDoctor.Text = "Por Doctor";
            buttonReportDoctor.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportDoctor.UseVisualStyleBackColor = true;
            buttonReportDoctor.Click += buttonReportDoctor_Click;
            // 
            // buttonReportClient
            // 
            buttonReportClient.Cursor = Cursors.Hand;
            buttonReportClient.Dock = DockStyle.Top;
            buttonReportClient.FlatAppearance.BorderSize = 0;
            buttonReportClient.FlatStyle = FlatStyle.Flat;
            buttonReportClient.Font = new Font("Segoe UI", 10F);
            buttonReportClient.ForeColor = Color.LightGray;
            buttonReportClient.Location = new Point(0, 384);
            buttonReportClient.Margin = new Padding(3, 4, 3, 4);
            buttonReportClient.Name = "buttonReportClient";
            buttonReportClient.Padding = new Padding(18, 0, 0, 0);
            buttonReportClient.Size = new Size(328, 60);
            buttonReportClient.TabIndex = 8;
            buttonReportClient.Text = "Por Cliente";
            buttonReportClient.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportClient.UseVisualStyleBackColor = true;
            buttonReportClient.Click += buttonReportClient_Click;
            // 
            // buttonReportDate
            // 
            buttonReportDate.Cursor = Cursors.Hand;
            buttonReportDate.Dock = DockStyle.Top;
            buttonReportDate.FlatAppearance.BorderSize = 0;
            buttonReportDate.FlatStyle = FlatStyle.Flat;
            buttonReportDate.Font = new Font("Segoe UI", 10F);
            buttonReportDate.ForeColor = Color.LightGray;
            buttonReportDate.Location = new Point(0, 324);
            buttonReportDate.Margin = new Padding(3, 4, 3, 4);
            buttonReportDate.Name = "buttonReportDate";
            buttonReportDate.Padding = new Padding(18, 0, 0, 0);
            buttonReportDate.Size = new Size(328, 60);
            buttonReportDate.TabIndex = 7;
            buttonReportDate.Text = "Por Fecha";
            buttonReportDate.TextAlign = ContentAlignment.MiddleLeft;
            buttonReportDate.UseVisualStyleBackColor = true;
            buttonReportDate.Click += buttonReportDate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 296);
            label4.Name = "label4";
            label4.Padding = new Padding(7, 0, 0, 0);
            label4.Size = new Size(100, 28);
            label4.TabIndex = 6;
            label4.Text = "Reportes";
            // 
            // buttonAdmDoctors
            // 
            buttonAdmDoctors.Cursor = Cursors.Hand;
            buttonAdmDoctors.Dock = DockStyle.Top;
            buttonAdmDoctors.FlatAppearance.BorderSize = 0;
            buttonAdmDoctors.FlatStyle = FlatStyle.Flat;
            buttonAdmDoctors.Font = new Font("Segoe UI", 10F);
            buttonAdmDoctors.ForeColor = Color.LightGray;
            buttonAdmDoctors.Location = new Point(0, 236);
            buttonAdmDoctors.Margin = new Padding(3, 4, 3, 4);
            buttonAdmDoctors.Name = "buttonAdmDoctors";
            buttonAdmDoctors.Padding = new Padding(18, 0, 0, 0);
            buttonAdmDoctors.Size = new Size(328, 60);
            buttonAdmDoctors.TabIndex = 5;
            buttonAdmDoctors.Text = "Doctores";
            buttonAdmDoctors.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdmDoctors.UseVisualStyleBackColor = true;
            buttonAdmDoctors.Click += buttonAdmDoctors_Click;
            // 
            // buttonAdmClients
            // 
            buttonAdmClients.Cursor = Cursors.Hand;
            buttonAdmClients.Dock = DockStyle.Top;
            buttonAdmClients.FlatAppearance.BorderSize = 0;
            buttonAdmClients.FlatStyle = FlatStyle.Flat;
            buttonAdmClients.Font = new Font("Segoe UI", 10F);
            buttonAdmClients.ForeColor = Color.LightGray;
            buttonAdmClients.Location = new Point(0, 176);
            buttonAdmClients.Margin = new Padding(3, 4, 3, 4);
            buttonAdmClients.Name = "buttonAdmClients";
            buttonAdmClients.Padding = new Padding(18, 0, 0, 0);
            buttonAdmClients.Size = new Size(328, 60);
            buttonAdmClients.TabIndex = 4;
            buttonAdmClients.Text = "Clientes";
            buttonAdmClients.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdmClients.UseVisualStyleBackColor = true;
            buttonAdmClients.Click += buttonAdmClients_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 148);
            label3.Name = "label3";
            label3.Padding = new Padding(7, 0, 0, 0);
            label3.Size = new Size(155, 28);
            label3.TabIndex = 1;
            label3.Text = "Administración";
            // 
            // buttonNewQueryType
            // 
            buttonNewQueryType.Cursor = Cursors.Hand;
            buttonNewQueryType.Dock = DockStyle.Top;
            buttonNewQueryType.FlatAppearance.BorderSize = 0;
            buttonNewQueryType.FlatStyle = FlatStyle.Flat;
            buttonNewQueryType.Font = new Font("Segoe UI", 10F);
            buttonNewQueryType.ForeColor = Color.LightGray;
            buttonNewQueryType.Location = new Point(0, 88);
            buttonNewQueryType.Margin = new Padding(3, 4, 3, 4);
            buttonNewQueryType.Name = "buttonNewQueryType";
            buttonNewQueryType.Padding = new Padding(18, 0, 0, 0);
            buttonNewQueryType.Size = new Size(328, 60);
            buttonNewQueryType.TabIndex = 3;
            buttonNewQueryType.Text = "Tipo Consulta";
            buttonNewQueryType.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewQueryType.UseVisualStyleBackColor = true;
            buttonNewQueryType.Click += buttonNewQueryType_Click;
            // 
            // buttonNewDates
            // 
            buttonNewDates.Cursor = Cursors.Hand;
            buttonNewDates.Dock = DockStyle.Top;
            buttonNewDates.FlatAppearance.BorderSize = 0;
            buttonNewDates.FlatStyle = FlatStyle.Flat;
            buttonNewDates.Font = new Font("Segoe UI", 10F);
            buttonNewDates.ForeColor = Color.LightGray;
            buttonNewDates.Location = new Point(0, 28);
            buttonNewDates.Margin = new Padding(3, 4, 3, 4);
            buttonNewDates.Name = "buttonNewDates";
            buttonNewDates.Padding = new Padding(18, 0, 0, 0);
            buttonNewDates.Size = new Size(328, 60);
            buttonNewDates.TabIndex = 2;
            buttonNewDates.Text = "Citas";
            buttonNewDates.TextAlign = ContentAlignment.MiddleLeft;
            buttonNewDates.UseVisualStyleBackColor = true;
            buttonNewDates.Click += buttonNewDates_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(7, 0, 0, 0);
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Registro";
            // 
            // panelLogo
            // 
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(328, 93);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(51, 99);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(18, 0, 0, 0);
            button3.Size = new Size(214, 45);
            button3.TabIndex = 11;
            button3.Text = "Cerrar Sesion";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(200, 779);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 5);
            label5.Size = new Size(0, 51);
            label5.TabIndex = 23;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelDesktopPanel.BackColor = Color.White;
            panelDesktopPanel.Controls.Add(pictureBox4);
            panelDesktopPanel.Controls.Add(pictureBox3);
            panelDesktopPanel.Controls.Add(label5);
            panelDesktopPanel.Location = new Point(351, 113);
            panelDesktopPanel.Margin = new Padding(3, 4, 3, 4);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1346, 846);
            panelDesktopPanel.TabIndex = 1;
            panelDesktopPanel.Paint += panelDesktopPanel_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1198, 769);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(148, 68);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(664, 320);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(124, 106);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(118, 76);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 5);
            label6.Size = new Size(146, 51);
            label6.TabIndex = 24;
            label6.Text = "CDental";
            label6.Click += label6_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.AutoSize = true;
            btnMinimizar.BackColor = Color.White;
            btnMinimizar.FlatAppearance.BorderColor = Color.DimGray;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizar.ForeColor = Color.Black;
            btnMinimizar.Location = new Point(1596, 0);
            btnMinimizar.Margin = new Padding(3, 8, 3, 8);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(44, 37);
            btnMinimizar.TabIndex = 22;
            btnMinimizar.Text = "▁";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.AutoSize = true;
            btnMaximizar.BackColor = Color.White;
            btnMaximizar.FlatAppearance.BorderColor = Color.DimGray;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximizar.ForeColor = Color.Black;
            btnMaximizar.Location = new Point(1633, 0);
            btnMaximizar.Margin = new Padding(3, 8, 3, 8);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(43, 37);
            btnMaximizar.TabIndex = 21;
            btnMaximizar.Text = "◰";
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.BackColor = Color.DarkRed;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1675, 0);
            button2.Margin = new Padding(3, 8, 3, 8);
            button2.Name = "button2";
            button2.Size = new Size(48, 37);
            button2.TabIndex = 20;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(323, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 37);
            panel1.TabIndex = 24;
            panel1.Paint += panel1_Paint_1;
            panel1.MouseDown += panelSuperior_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(328, 228);
            panel3.TabIndex = 26;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 68);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.CustomizableEdges = customizableEdges1;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(376, 50);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox1.Size = new Size(592, 36);
            guna2ComboBox1.TabIndex = 25;
            guna2ComboBox1.SelectedIndexChanged += guna2ComboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button3);
            panel2.Location = new Point(0, 790);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 155);
            panel2.TabIndex = 27;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Navy;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(1506, 55);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(18, 0, 0, 0);
            button4.Size = new Size(170, 45);
            button4.TabIndex = 12;
            button4.Text = "Backup General";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1723, 947);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(btnMinimizar);
            Controls.Add(btnMaximizar);
            Controls.Add(guna2ComboBox1);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMainMenu";
            Text = "CDental";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelSideMenu.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelDesktopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button buttonNewDates;
        private Label label2;
        private Label label3;
        private Button buttonNewQueryType;
        private Button buttonAdmDoctors;
        private Button buttonAdmClients;
        private Button buttonReportDoctor;
        private Button buttonReportClient;
        private Button buttonReportDate;
        private Label label4;
        private Panel panelDesktopPanel;
        private Button button1;
        private Button button2;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Label label5;
        private Button button3;
        private Panel panel1;
        private Panel panel3;
        private Label label6;
        private Guna2ComboBox guna2ComboBox1;
        private Panel panel2;
        private Button button4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}