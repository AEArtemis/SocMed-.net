using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNASYSTEM.Dashboard
{
    public partial class frmSuggestFriends : UserControl
    {
        private string usersID;
        private string usersName;
        private Image usersAvatar;
        public frmSuggestFriends()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }

        private void frmSuggestFriends_Load(object sender, EventArgs e)
        {
            UpdateTheme();
        }

        private void frmSuggestFriends_Disposed(object sender, EventArgs e)
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
                lblFullname.ForeColor = Color.White;
                btnAddFriend.ForeColor = Color.FromArgb(0, 102, 204);
                lblSuggested.ForeColor = Color.White;

            }
            else
            {
                lblFullname.ForeColor = Color.FromArgb(26, 26, 26);
                lblSuggested.ForeColor = Color.FromArgb(26, 26, 26);
                btnAddFriend.ForeColor = Color.FromArgb(0, 102, 204);
            }
            
        }
        public string UsersID
        {
            get { return usersID; }
            set { usersID = value; lblUserID.Text = value; }
        }

        public string UsersName
        {
            get { return usersName; }
            set { usersName = value; lblFullname.Text = value; }
        }
        public Image UserAvatar
        {
            get { return usersAvatar; }
            set { usersAvatar = value; pctUsersAvatar.Image = value; }
        }
    }
}
