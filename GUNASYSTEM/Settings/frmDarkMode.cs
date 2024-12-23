using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNASYSTEM.Settings
{
    public partial class frmDarkMode : Form
    {
        public int UserID { get; set; }
        public frmDarkMode()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }
        private async void frmDarkMode_Load(object sender, EventArgs e)
        {
            UpdateTheme();
            if (ThemeManager.CurrentTheme == "dark")
            {
                ThemeManager.ToggleThemeAsync(UserID);
                //ThemeManager.InitializeUIAsync(this, m_user_ID);
                //pctMoon.Image = Properties.Resources.iconMoonOn;
                tgleTheme.Checked = true;
            }
            await ThemeManager.InitializeUIAsync(this, UserID);
        }
        private void frmDarkMode_Disposed(object sender, EventArgs e)
        {
            ThemeManager.onThemeChanged -= ThemeChanged;
        }
        private void ThemeChanged(string newTheme)
        {
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() => UpdateTheme()));
            }
        }
        private void UpdateTheme()
        {
            if (ThemeManager.CurrentTheme == "dark")
            {
                pctMoon.Image = Properties.Resources.iconMoonOn;
                pctSun.Image = Properties.Resources.iconSunOff;
            }
            else
            {
                pctMoon.Image = Properties.Resources.iconMoonOff;
                pctSun.Image = Properties.Resources.iconSunOn;
            }
        }

        private async void tgleTheme_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the theme and apply the changes
            await ThemeManager.ToggleThemeAsync(UserID);
            await ThemeManager.InitializeUIAsync(this, UserID);
            //ThemeManager.ApplyThemeToAllForms();
            UpdateTheme();
        }
    }
}
