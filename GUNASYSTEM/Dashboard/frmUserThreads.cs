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
    public partial class frmUserThreads : UserControl
    {
        public event EventHandler<int> UserClicked;
        //private Image usersStory;
        private string usersID;
        private string usersName;
        private string userThreadDuration;
        private string userThreadCaption;
        private Image userAvatar;
        private Image userThreadImage;
        public frmUserThreads()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
        }

        private void frmUserThreads_Load(object sender, EventArgs e)
        {
            UpdateTheme();
        }

        private void frmUserThreads_Disposed(object sender, EventArgs e)
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
                lblUsersName.ForeColor = Color.White;
                lblThreadDuration.ForeColor = Color.White;
                lblShareCount.ForeColor = Color.White;
                lblCommentCount.ForeColor = Color.White;
                btnReact.ForeColor = Color.White;
                btnComments.ForeColor = Color.White;
                btnShare.ForeColor = Color.White;
                lblThreadCaption.ForeColor = Color.White;
                pnlContainer.FillColor = Color.FromArgb(34, 34, 34);
            }
            else
            {
                lblUsersName.ForeColor = Color.Black;
                lblThreadDuration.ForeColor = Color.Black;
                lblShareCount.ForeColor = Color.Black;
                lblCommentCount.ForeColor = Color.Black;
                btnReact.ForeColor = Color.Black;
                btnComments.ForeColor = Color.Black;
                btnShare.ForeColor = Color.Black;
                lblThreadCaption.ForeColor = Color.Black;
                pnlContainer.FillColor = Color.White;
            }
        }
        private void lblUsersName_Click(object sender, EventArgs e)
        {

        }
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
        public string UsersThreadDuration
        {
            get { return userThreadDuration; }
            set { userThreadDuration = value; lblThreadDuration.Text = value; }
        }
        public string UsersThreadCaption
        {
            get { return userThreadCaption; }
            set { userThreadCaption = value; lblThreadCaption.Text = value;
            }
        }
        public Image UserAvatar
        {
            get { return userAvatar; }
            set { userAvatar = value; pctUsersAvatar.Image = value; }
        }
        public Image UsersThreadImage
        {
            get { return userThreadImage; }
            set { userThreadImage = value; pctThreadImage.Image = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void lblThreadCaption_Click(object sender, EventArgs e)
        {

        }
    }
}
