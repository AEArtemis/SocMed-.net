using GUNASYSTEM.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNASYSTEM
{
    public partial class frmSettings : Form
    {
        public int UserID { get; set; }
        public frmSettings()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }
        private async void frmSettings_Load(object sender, EventArgs e)
        {
            UpdateTheme();
            await ThemeManager.InitializeUIAsync(this, UserID);
        }
        private void frmSettings_Disposed(object sender, EventArgs e)
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
        private void UpdateTheme()
        {
            //if (ThemeManager.CurrentTheme == "dark")
            //{
            //}
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            frmDarkMode formDarkMode = new frmDarkMode();
            formDarkMode.UserID = UserID;
            formDarkMode.TopLevel = false;
            formDarkMode.Dock = DockStyle.Fill;

            // Add formMessages to the panel and show it
            pnlSettingContent.Controls.Add(formDarkMode);
            formDarkMode.Show();
            pnlSettingContent.Refresh();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            frmEditProfile formEditProfile = new frmEditProfile();
            formEditProfile.UserID = UserID;
            formEditProfile.TopLevel = false;
            formEditProfile.Dock = DockStyle.Fill;

            // Add formMessages to the panel and show it
            pnlSettingContent.Controls.Add(formEditProfile);
            formEditProfile.Show();
            pnlSettingContent.Refresh();
        }
    }

}
