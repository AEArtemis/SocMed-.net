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
    public partial class frmUserStories : UserControl
    {
        private static frmUserStories selectedUserControl = null;
        public event EventHandler<int> UserClicked;
        private Image usersStory;
        private string usersID;
        private string usersName;
        private string usersName2;

        public frmUserStories()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }
        private void frmUserStories_Load(object sender, EventArgs e)
        {
            UpdateTheme();
        }

        private void frmUserStories_Disposed(object sender, EventArgs e)
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
            if (ThemeManager.CurrentTheme == "dark")
            {
                //btnUsersName.ForeColor = Color.Black;
                //btnUsersName.FillColor = Color.Gainsboro;
                //btnUsersName2.ForeColor = Color.White;
                btnUsersName.FillColor = Color.Silver;
            }
            else
            {
                //btnUsersName.ForeColor = Color.Black;
                //btnUsersName.FillColor = Color.Gainsboro;
                //btnUsersName2.ForeColor = Color.White;
                btnUsersName.FillColor = Color.Silver;
            }
        }

        [Category("CustomProps")]
        public Image UsersStory
        {
            get { return usersStory; }
            set { usersStory = value; pctUsersStory.Image = value; }
        }
        [Category("CustomProps")]
        public string UsersName
        {
            get { return usersName; }
            set { usersName = value; btnUsersName.Text = value; }
        }
        public string UsersName2
        {
            get { return usersName2; }
            set { usersName2 = value; btnUsersName2.Text = value; }
        }
        public string UsersID
        {
            get { return usersID; }
            set { usersID = value; lblUserID.Text = value; }
        }


        private void pctUsersStory_Click(object sender, EventArgs e)
        {
            try
            {
                int clickedUserID = Convert.ToInt32(UsersID);
                UserClicked?.Invoke(this, clickedUserID);

                //if (selectedUserControl != null && selectedUserControl != this)
                //{
                //    selectedUserControl.UpdateTheme();
                //}

                //selectedUserControl = this;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }
    }
}
