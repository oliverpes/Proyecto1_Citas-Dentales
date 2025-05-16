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
        //mover el formulario sin la barra general
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        //evento para mover el windows form usando un panel
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        // variables para manejar los botones y los formularios
        private Button currentButton;
        private Form activeForm;

        public FormMainMenu()
        {
            InitializeComponent();

            guna2ComboBox1.BorderRadius = 10;
            //guna2ComboBox1.FillColor = Color.FromArgb(20, 30, 48);
            guna2ComboBox1.Font = new Font("Segoe UI", 10);
            guna2ComboBox1.ForeColor = Color.Black;
            guna2ComboBox1.ItemHeight = 35;

            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private void panel1_Paint(object sender, PaintEventArgs e)
        { }


        // Dar formato al boton seleccionado
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(25, 25, 50);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // Dar formato por defecto a todos los botones
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color = Color.FromArgb(17, 17, 34);
                    previousBtn.BackColor = color;
                    previousBtn.ForeColor = Color.LightGray;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        // abrir el formulario seleccionado
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


        // Eventos de los botones del side menu
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

        // Cerrar formulario activo para regresar el principal
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
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                // button3.Text = "🗗"; // opcional: ícono de restaurar
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                // button3.Text = "🗖"; // opcional: ícono de maximizar
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

            //btnMaximizar.Text = "◰"; // ícono de restaurar

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Leer la cadena de conexión desde config.txt
                string connectionString = File.ReadAllText("config.txt").Trim();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close(); // Por si acaso está abierta
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
            }

            // Mostrar el formulario de login
            login loginForm = new login();
            loginForm.Show();

            // Ocultar el formulario actual (cerrar sesión) 
            this.Hide();
        }

        private void inputAvailableTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //evento para hacer grande el combobox de ver disponibilidad
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}