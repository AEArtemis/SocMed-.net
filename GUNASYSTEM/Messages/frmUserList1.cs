using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUNASYSTEM
{
    public partial class frmUserList : UserControl
    {
        private static frmUserList _selectedUserControl = null;
        public event EventHandler<int> UserClicked;

        public frmUserList()
        {
            InitializeComponent();
            this.MouseEnter += frmUserList_MouseEnter;
            this.MouseLeave += frmUserList_MouseLeave;
            this.MouseClick += frmUserList_MouseClick;
            guna2Panel3.MouseEnter += frmUserList_MouseEnter;
            guna2Panel3.MouseLeave += frmUserList_MouseLeave;
            guna2Panel3.MouseClick += frmUserList_MouseClick;

            // Subscribe to theme changes
            ThemeManager.onThemeChanged += ThemeChanged;
        }

        private Image usersProfilePicture;
        private Image userStatus;
        private string usersName;
        private string usersLastMessage;
        private string usersID;

        [Category("CustomProps")]
        public Image UsersProfile
        {
            get { return usersProfilePicture; }
            set { usersProfilePicture = value; pctUsersProfile.Image = value; }
        }
        public Image UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; pctUserStatus.Image = value; }
        }
        [Category("CustomProps")]
        public string UsersID
        {
            get { return usersID; }
            set { usersID = value; lblUsersID.Text = value; }
        }

        public string UsersName
        {
            get { return usersName; }
            set { usersName = value; lblUsersName.Text = value; }
        }

        [Category("CustomProps")]
        public string UsersLastMessage
        {
            get { return usersLastMessage; }
            set { usersLastMessage = value; lblUsersLastMessage.Text = value; }
        }

        private void frmUserList_MouseLeave(object sender, EventArgs e)
        {
            //if (_selectedUserControl != this)
            //{
            //    UpdateTheme();
            //}
        }

        private void frmUserList_MouseEnter(object sender, EventArgs e)
        {
            //if (_selectedUserControl != this)
            //{
            //    guna2Panel3.FillColor = ThemeManager.CurrentTheme == "dark" ? Color.Gray : Color.LightGray;
            //}
        }

        private void frmUserList_MouseClick(object sender, MouseEventArgs e)
        {
            // Handle mouse click if needed
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            UpdateTheme();
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
                this.BackColor = Color.FromArgb(35, 35, 35);
                guna2Panel3.FillColor = Color.FromArgb(35, 35, 35);
                lblUsersName.ForeColor = Color.White;
                lblUsersLastMessage.ForeColor = Color.Gray;
                guna2Button1.FillColor = Color.Transparent;
            }
            else
            {
                this.BackColor = Color.White;
                guna2Panel3.FillColor = Color.White;
                lblUsersName.ForeColor = Color.Black;
                lblUsersLastMessage.ForeColor = Color.DarkGray;
                guna2Button1.FillColor = Color.Transparent;
            }
        }

        private void frmUserList_Disposed(object sender, EventArgs e)
        {
            ThemeManager.onThemeChanged -= ThemeChanged;
        }

        private void frmUserList_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int clickedUserID = Convert.ToInt32(UsersID);
            //    UserClicked?.Invoke(this, clickedUserID);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception occurred: " + ex.Message);
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int clickedUserID = Convert.ToInt32(UsersID);
                UserClicked?.Invoke(this, clickedUserID);

                if (_selectedUserControl != null && _selectedUserControl != this)
                {
                    _selectedUserControl.UpdateTheme();
                }

                _selectedUserControl = this;

                guna2Panel3.FillColor = ThemeManager.CurrentTheme == "dark" ? Color.FromArgb(65, 65, 65) : Color.FromArgb(240, 240, 240);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred: " + ex.Message);
            }
        }

        private void pctUsersProfile_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int clickedUserID = Convert.ToInt32(UsersID);
            //    UserClicked?.Invoke(this, clickedUserID);

            //    if (_selectedUserControl != null && _selectedUserControl != this)
            //    {
            //        _selectedUserControl.UpdateTheme();
            //    }

            //    _selectedUserControl = this;

            //    guna2Panel3.FillColor = ThemeManager.CurrentTheme == "dark" ? Color.FromArgb(65, 65, 65) : Color.FromArgb(240, 240, 240);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception occurred: " + ex.Message);
            //}
        }
    }
}
