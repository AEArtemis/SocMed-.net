//using DataManager;
//using System;
//using System.Drawing;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GUNASYSTEM
//{
//    public partial class frmMain : Form
//    {
//        public int m_user_ID { get; set; }
//        private Rectangle originalBounds;
//        private bool isMaximized = false;
//        frmMessages formMessages = new frmMessages();
//        frmDashboard formDashboard = new frmDashboard();
//        frmSettings formSettings = new frmSettings();
//        public frmMain()
//        {
//            InitializeComponent();
//        }

//        private async void frmMain_Load(object sender, EventArgs e)
//        {
//            // Apply the current theme when the form loads
//            await ThemeManager.InitializeUIAsync(this, m_user_ID);
//            if (ThemeManager.CurrentTheme == "dark")
//            {
//                ThemeManager.ToggleThemeAsync(m_user_ID);
//                //ThemeManager.InitializeUIAsync(this, m_user_ID);
//                //pctMoon.Image = Properties.Resources.iconMoonOn;
//                tgleTheme.Checked = true;
//            }
//            UpdateThemeControls();
//        }

//        private async void tgleTheme_CheckedChanged(object sender, EventArgs e)
//        {
//            // Toggle the theme and apply the changes
//            await ThemeManager.ToggleThemeAsync(m_user_ID);
//            await ThemeManager.InitializeUIAsync(this, m_user_ID);
//            //ThemeManager.ApplyThemeToAllForms();
//            UpdateThemeControls();
//        }


//        private void UpdateThemeControls()
//        {
//            if (ThemeManager.CurrentTheme == "dark")
//            {

//                txtContentTitle.ForeColor = Color.White;
//                pctMoon.Image = Properties.Resources.iconMoonOn;
//                pctSun.Image = Properties.Resources.iconSunOff;
//                pnlHeader.BackColor = Color.FromArgb(26, 26, 26);
//                pnlSide.FillColor = Color.FromArgb(26, 26, 26);
//                pnlMainContents.BackColor = Color.Transparent;
//                pnlMainBG.BackColor = Color.FromArgb(23, 23, 23);

//            }
//            else
//            {

//                txtContentTitle.ForeColor = Color.FromArgb(23, 23, 23);
//                pctMoon.Image = Properties.Resources.iconMoonOff;
//                pctSun.Image = Properties.Resources.iconSunOn;
//                pnlHeader.BackColor = Color.White;
//                pnlSide.FillColor = Color.White;
//                pnlMainContents.BackColor = Color.Transparent;
//                pnlMainBG.BackColor = Color.FromArgb(242, 242, 249);
//            }
//        }

//        private void btnAppMaxMin_Click(object sender, EventArgs e)
//        {
//            if (!isMaximized)
//            {
//                originalBounds = this.Bounds;
//                btnAppMaxMin.Image = Properties.Resources.iconminimize;
//                btnAppMaxMin.ImageSize = new Size(14, 14);
//                this.FormBorderStyle = FormBorderStyle.None;
//                this.Left = 0;
//                this.Top = 0;
//                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
//                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
//                isMaximized = true;
//            }
//            else
//            {
//                btnAppMaxMin.Image = Properties.Resources.iconmaximize;
//                btnAppMaxMin.ImageSize = new Size(15, 15);
//                this.Bounds = originalBounds;
//                isMaximized = false;
//            }
//        }

//        private void btnAppClose_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            frmLogin formMain = new frmLogin();
//            formMain.userID = 0;
//            formMain.Show();
//        }

//        private void btnAppMinimize(object sender, EventArgs e)
//        {
//            this.WindowState = FormWindowState.Minimized;
//        }

//        private void btnMainMessages_Click(object sender, EventArgs e)
//        {
//            pnlMainContents.Controls.Clear();

//            // Hide other forms
//            formDashboard.Hide();
//            formSettings.Hide();

//            // Set title and visibility
//            txtContentTitle.Text = "Messages";
//            pnlMainContents.Visible = true;
//            txtContentTitle.Visible = true;

//            // Prepare and show formMessages
//            formMessages.UserID = m_user_ID;
//            formMessages.TopLevel = false;
//            formMessages.Dock = DockStyle.Fill;

//            // Add formMessages to the panel and show it
//            pnlMainContents.Controls.Add(formMessages);
//            formMessages.Show();
//            pnlMainContents.Refresh();
//        }

//        private void btnMainSettings_Click(object sender, EventArgs e)
//        {
//            pnlMainContents.Controls.Clear();

//            // Hide other forms
//            formDashboard.Hide();
//            formMessages.Hide();

//            // Set title and visibility
//            txtContentTitle.Text = "Settings";
//            pnlMainContents.Visible = true;
//            txtContentTitle.Visible = true;

//            // Prepare and show formSettings
//            formSettings.UserID = m_user_ID;
//            formSettings.TopLevel = false;
//            formSettings.Dock = DockStyle.Fill;

//            // Add formSettings to the panel and show it
//            pnlMainContents.Controls.Add(formSettings);
//            formSettings.Show();
//            pnlMainContents.Refresh();
//        }

//        private void btnMainHome_Click(object sender, EventArgs e)
//        {

//            pnlMainContents.Controls.Clear();
//            //formDashboard.Hide();
//            formMessages.Hide();
//            formSettings.Hide();

//            txtContentTitle.Text = "Dashboard";
//        }
//    }
//}

using DataManager;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNASYSTEM
{
    public partial class frmMain : Form
    {
        public int m_user_ID { get; set; }
        private Rectangle originalBounds;
        private bool isMaximized = false;
        frmMessages formMessages = new frmMessages();
        frmDashboard formDashboard = new frmDashboard();
        frmSettings formSettings = new frmSettings();
        public frmMain()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }

        private async void frmMain_Load(object sender, EventArgs e)
        {
            UpdateTheme();
            if (ThemeManager.CurrentTheme == "dark")
            {
                ThemeManager.ToggleThemeAsync(m_user_ID);
                //ThemeManager.InitializeUIAsync(this, m_user_ID);
                //pctMoon.Image = Properties.Resources.iconMoonOn;
                tgleTheme.Checked = true;
            }
            await ThemeManager.InitializeUIAsync(this, m_user_ID);
            pnlMainContents.Controls.Clear();

            // Hide other forms
            formMessages.Hide();
            formSettings.Hide();

            // Set title and visibility
            //txtContentTitle.Text = "Dashboard";
            pnlMainContents.Visible = true;
            //txtContentTitle.Visible = true;

            // Prepare and show formMessages
            formDashboard.UserID = m_user_ID;
            formDashboard.TopLevel = false;
            formDashboard.Dock = DockStyle.Fill;

            // Add formMessages to the panel and show it
            pnlMainContents.Controls.Add(formDashboard);
            formDashboard.Show();
            pnlMainContents.Refresh();
        }
        private void frmMain_Disposed(object sender, EventArgs e)
        {
            ThemeManager.onThemeChanged -= ThemeChanged;
        }
        private void ThemeChanged(string newTheme)
        {
            // Ensure thread safety and avoid exceptions when control is disposed
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() => UpdateTheme()));
            }
        }


        private async void tgleTheme_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the theme and apply the changes
            await ThemeManager.ToggleThemeAsync(m_user_ID);
            await ThemeManager.InitializeUIAsync(this, m_user_ID);
            //ThemeManager.ApplyThemeToAllForms();
            UpdateTheme();
        }


        private void UpdateTheme()
        {
            if (ThemeManager.CurrentTheme == "dark")
            {

                //txtContentTitle.ForeColor = Color.White;
                //pctMoon.Image = Properties.Resources.iconMoonOn;
                //pctSun.Image = Properties.Resources.iconSunOff;
                pnlHeader.BackColor = Color.FromArgb(26, 26, 26);
                pnlSide.FillColor = Color.FromArgb(26, 26, 26);
                pnlMainContents.BackColor = Color.Transparent;
                pnlMainBG.BackColor = Color.FromArgb(23, 23, 23);

            }
            else
            {

                //txtContentTitle.ForeColor = Color.FromArgb(23, 23, 23);
                //pctMoon.Image = Properties.Resources.iconMoonOff;
                //pctSun.Image = Properties.Resources.iconSunOn;
                pnlHeader.BackColor = Color.White;
                pnlSide.FillColor = Color.White;
                pnlMainContents.BackColor = Color.Transparent;
                pnlMainBG.BackColor = Color.FromArgb(242, 242, 249);
            }
        }

        private void btnAppMaxMin_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                originalBounds = this.Bounds;
                btnAppMaxMin.Image = Properties.Resources.iconminimize;
                btnAppMaxMin.ImageSize = new Size(14, 14);
                this.FormBorderStyle = FormBorderStyle.None;
                this.Left = 0;
                this.Top = 0;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                isMaximized = true;
            }
            else
            {
                btnAppMaxMin.Image = Properties.Resources.iconmaximize;
                btnAppMaxMin.ImageSize = new Size(15, 15);
                this.Bounds = originalBounds;
                isMaximized = false;
            }
        }

        private void btnAppClose_Click(object sender, EventArgs e)
        {
            DataResultSet m_set = new DataResultSet();
            m_set.Query = @"UPDATE users set status = @status where user_id = @user_id";
            m_set.AddParameter("@status", "Offline");
            m_set.AddParameter("user_id", m_user_ID);
            m_set.Execute();
            m_set.Close();

            this.Hide();
            frmLogin formMain = new frmLogin();
            formMain.userID = 0;
            formMain.Show();
        }

        private void btnAppMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMainMessages_Click(object sender, EventArgs e)
        {
            pnlMainContents.Controls.Clear();

            // Hide other forms
            formDashboard.Hide();
            formSettings.Hide();

            // Set title and visibility
            //txtContentTitle.Text = "Messages";
            pnlMainContents.Visible = true;
            //txtContentTitle.Visible = true;

            // Prepare and show formMessages
            formMessages.UserID = m_user_ID;
            formMessages.TopLevel = false;
            formMessages.Dock = DockStyle.Fill;

            // Add formMessages to the panel and show it
            pnlMainContents.Controls.Add(formMessages);
            formMessages.Show();
            pnlMainContents.Refresh();
        }

        private void btnMainSettings_Click(object sender, EventArgs e)
        {
            pnlMainContents.Controls.Clear();

            // Hide other forms
            formDashboard.Hide();
            formMessages.Hide();

            // Set title and visibility
            //txtContentTitle.Text = "Settings";
            pnlMainContents.Visible = true;
            //txtContentTitle.Visible = true;

            // Prepare and show formSettings
            formSettings.UserID = m_user_ID;
            formSettings.TopLevel = false;
            formSettings.Dock = DockStyle.Fill;

            // Add formSettings to the panel and show it
            pnlMainContents.Controls.Add(formSettings);
            formSettings.Show();
            pnlMainContents.Refresh();
        }

        private void btnMainHome_Click(object sender, EventArgs e)
        {
            pnlMainContents.Controls.Clear();

            // Hide other forms
            formMessages.Hide();
            formSettings.Hide();

            // Set title and visibility
            //txtContentTitle.Text = "Dashboard";
            pnlMainContents.Visible = true;
            //txtContentTitle.Visible = true;

            // Prepare and show formMessages
            formDashboard.UserID = m_user_ID;
            formDashboard.TopLevel = false;
            formDashboard.Dock = DockStyle.Fill;

            // Add formMessages to the panel and show it
            pnlMainContents.Controls.Add(formDashboard);
            formDashboard.Show();
            pnlMainContents.Refresh();
        }
    }
}