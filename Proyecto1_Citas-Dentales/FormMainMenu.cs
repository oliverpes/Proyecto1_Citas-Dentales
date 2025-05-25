using Proyecto1_Citas_Dentales.Forms;
using System.ComponentModel;
using BusinessLogic;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace Proyecto1_Citas_Dentales
{
    public partial class FormMainMenu : Form
    {
        // Mover el formulario sin la barra general
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        // Constantes para el redimensionamiento
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int WM_NCHITTEST = 0x84;
        private const int resizeAreaSize = 10;

        // Variables para botones y formularios
        private Button currentButton;
        private Form activeForm;

        // Variables para maximizar sin cubrir la barra de tareas
        private bool isMaximized = false;
        private Rectangle previousBounds;

        public FormMainMenu()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(600, 400);

            guna2ComboBox1.BorderRadius = 10;
            guna2ComboBox1.Font = new Font("Segoe UI", 10);
            guna2ComboBox1.ForeColor = Color.Black;
            guna2ComboBox1.ItemHeight = 35;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Forzar el enfoque para que se activen los bordes desde el inicio
            this.Activate();
        }


        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(135, 206, 250);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color = Color.FromArgb(70, 130, 180);
                    previousBtn.BackColor = color;
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonNewDates_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAppointments(), sender);
        }

        private void buttonNewQueryType_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQueryTypes(), sender);
        }

        private void buttonAdmClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdminClients(), sender);
        }

        private void buttonAdmDoctors_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdminDoctors(), sender);
        }

        private void buttonReportDate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportDate(), sender);
        }

        private void buttonReportClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportClient(), sender);
        }

        private void buttonReportDoctor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReportDoctor(), sender);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                previousBounds = this.Bounds;
                Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea;
                this.Bounds = workingArea;
                isMaximized = true;
            }
            else
            {
                this.Bounds = previousBounds;
                isMaximized = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void panelLogo_Paint(object sender, PaintEventArgs e) { }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = File.ReadAllText("config.txt").Trim();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }

            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }

        private void inputAvailableTimes_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbInputAvailableTimes_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox cmb = sender as ComboBox;
            e.DrawBackground();
            using (Brush brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(), e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void panel1_Paint_1(object sender, PaintEventArgs e) { }

        // Redimensionar bordes y esquinas del formulario sin bordes
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.X <= resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPLEFT;
                    else if (pos.Y >= this.ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)HTLEFT;
                }
                else if (pos.X >= this.ClientSize.Width - resizeAreaSize)
                {
                    if (pos.Y <= resizeAreaSize)
                        m.Result = (IntPtr)HTTOPRIGHT;
                    else if (pos.Y >= this.ClientSize.Height - resizeAreaSize)
                        m.Result = (IntPtr)HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)HTRIGHT;
                }
                else if (pos.Y <= resizeAreaSize)
                {
                    m.Result = (IntPtr)HTTOP;
                }
                else if (pos.Y >= this.ClientSize.Height - resizeAreaSize)
                {
                    m.Result = (IntPtr)HTBOTTOM;
                }
            }
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
