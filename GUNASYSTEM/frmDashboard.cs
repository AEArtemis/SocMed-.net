using DataManager;
using Guna.UI2.WinForms;
using GUNASYSTEM.Dashboard;
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
    public partial class frmDashboard : Form
    {
        public int UserID { get; set; }
        private int selectedUserId;

        public frmDashboard()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;
            this.MouseWheel += FrmDashboard_MouseWheel; // Register MouseWheel event handler
        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            UpdateTheme();
            await ThemeManager.InitializeUIAsync(this, UserID);
            GetUsersStory();
            GetUserSuggested();
            GetUserThreads();
            SetupScrollbar(); // Ensure scrollbar is set up when the form loads
        }

        private void frmDashboard_Disposed(object sender, EventArgs e)
        {
            ThemeManager.onThemeChanged -= ThemeChanged;
        }

        private void ThemeChanged(string newTheme)
        {
            // Ensure thread safety and avoid exceptions when control is disposed
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateTheme();
                }));
            }
        }

        private void UpdateTheme()
        {
            if (ThemeManager.CurrentTheme == "dark")
            {
                pnlMain.FillColor = Color.FromArgb(23, 23, 23);
                pnlMain.BackColor = Color.FromArgb(23, 23, 23);
                
            }
            else
            {
                pnlMain.FillColor = Color.FromArgb(242, 242, 249);
                pnlMain.BackColor = Color.FromArgb(242, 242, 249);
            }
            //pnlUserThreads.FillColor = Color.Transparent;
            pnlUserThreads.BackColor = Color.Transparent;
            flpStories.BackColor = Color.Transparent;
        }

        private string GetTimeAgo(DateTime createdAt)
        {
            TimeSpan timeDifference = DateTime.Now - createdAt;

            if (timeDifference.TotalSeconds < 60)
                return timeDifference.Seconds == 1 ? "1 second ago" : $"{timeDifference.Seconds} seconds ago";
            else if (timeDifference.TotalMinutes < 60)
                return timeDifference.Minutes == 1 ? "1 minute ago" : $"{timeDifference.Minutes} minutes ago";
            else if (timeDifference.TotalHours < 24)
                return timeDifference.Hours == 1 ? "1 hour ago" : $"{timeDifference.Hours} hours ago";
            else if (timeDifference.TotalDays < 30)
                return timeDifference.Days == 1 ? "1 day ago" : $"{timeDifference.Days} days ago";
            else if (timeDifference.TotalDays < 365)
            {
                int months = (int)Math.Floor(timeDifference.TotalDays / 30);
                return months == 1 ? "1 month ago" : $"{months} months ago";
            }
            else
            {
                int years = (int)Math.Floor(timeDifference.TotalDays / 365);
                return years == 1 ? "1 year ago" : $"{years} years ago";
            }
        }

        private void GetUsersStory()
        {
            List<frmUserStories> usersStory = new List<frmUserStories>();
            DataResultSet m_set = new DataResultSet();

            m_set.Query = @"Select * from users where user_id != @currentUserId";
            m_set.AddParameter("@currentUserId", UserID);

            if (flpStories.Controls.Count > 0)
            {
                flpStories.Controls.Clear();
            }

            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    Image statusImage = m_set.GetString(2) == "Online"
                        ? Properties.Resources.iconOnline
                        : Properties.Resources.iconsOffline;

                    frmUserStories story = new frmUserStories
                    {
                        UsersID = m_set.GetString(0),
                        UsersName = m_set.GetString(1),
                        UsersName2 = m_set.GetString(1),
                    };

                    story.UserClicked += OnUserClicked;
                    usersStory.Add(story);
                    flpStories.Controls.Add(story);
                }
            }
            m_set.Close();
        }

        private void GetUserSuggested()
        {
            List<frmSuggestFriends> userSuggested = new List<frmSuggestFriends>();
            DataResultSet m_set = new DataResultSet();

            m_set.Query = @"SELECT u.user_id, u.username, u.fullname, u.profile_picture
                            FROM users u
                            WHERE NOT EXISTS (
                                SELECT 1 FROM friends f 
                                WHERE (f.user_id = @currentUserId AND f.friend_id = u.user_id)
                                OR (f.friend_id = @currentUserId AND f.user_id = u.user_id)
                            )
                            AND u.user_id != @currentUserId
                            ORDER BY RAND()
                                LIMIT 10";
            m_set.AddParameter("@currentUserId", UserID);

            if (flpSuggested.Controls.Count > 0)
            {
                flpSuggested.Controls.Clear();
            }

            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    //Image statusImage = m_set.GetString(2) == "Online"
                    //    ? Properties.Resources.iconOnline
                    //    : Properties.Resources.iconsOffline;

                    frmSuggestFriends suggested = new frmSuggestFriends
                    {
                        UsersID = m_set.GetString(0),
                        UsersName = m_set.GetString(1),
                    };

                    //suggested.UserClicked += OnUserClicked;
                    userSuggested.Add(suggested);
                    flpSuggested.Controls.Add(suggested);
                }
            }
            m_set.Close();
        }
        private void OnUserClicked(object sender, int clickedUserId)
        {
            selectedUserId = clickedUserId;
        }

        private void GetUserThreads()
        {
            List<frmUserThreads> userThreads = new List<frmUserThreads>();

            DataResultSet m_set = new DataResultSet();
            m_set.Query = @"select u.user_id, u.username, u.fullname, u.profile_picture, t.content, t.images, t.videos, t.privacy, t.created_at from users u join threads t on u.user_id = t.user_id";
            m_set.AddParameter("@currentUserId", UserID);

            if (flpUserThreads.Controls.Count > 0)
            {
                flpUserThreads.Controls.Clear();
            }

            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    string timeAgo = GetTimeAgo(m_set.GetDateTime(8));
                    frmUserThreads threads = new frmUserThreads
                    {
                        UsersID = m_set.GetString(0),
                        UsersName = m_set.GetString(2),
                        UsersThreadCaption = m_set.GetString(4),
                        UsersThreadDuration = timeAgo,
                    };
                    threads.lblThreadCaption.AutoSize = false;
                    threads.lblThreadCaption.MaximumSize = new Size(threads.lblThreadCaption.Width, 0);
                    threads.lblThreadCaption.Text = threads.UsersThreadCaption;
                    threads.PerformLayout();
                    int additionalHeight = threads.lblThreadCaption.PreferredSize.Height;
                    threads.Height += additionalHeight;

                    userThreads.Add(threads);
                    flpUserThreads.Controls.Add(threads);
                }
            }
            m_set.Close();
            UpdateScrollbar(); 
        }


        private void UpdateScrollbar()
        {
            // Update the scrollbar based on the content height
            DashboardScrollbar.Maximum = Math.Max(0, flpUserThreads.DisplayRectangle.Height - flpUserThreads.ClientSize.Height);
            DashboardScrollbar.Value = 0; // Reset scrollbar position
        }

        private void SetupScrollbar()
        {
            // Hide default scrollbar
            flpUserThreads.AutoScroll = false;

            // Initialize scrollbar properties
            DashboardScrollbar.Minimum = 0;
            DashboardScrollbar.SmallChange = 20;
            DashboardScrollbar.LargeChange = flpUserThreads.ClientSize.Height;

            // Attach event handler to custom scrollbar
            DashboardScrollbar.Scroll += DashboardScrollbar_Scroll;

            // Ensure the scrollbar is visible
            DashboardScrollbar.Visible = true;
            DashboardScrollbar.BringToFront();
        }

        private void DashboardScrollbar_Scroll(object sender, ScrollEventArgs e)
        {
            // Sync the FlowLayoutPanel scrolling with the custom scrollbar
            flpUserThreads.AutoScrollPosition = new Point(0, DashboardScrollbar.Value);
        }

        private void FrmDashboard_MouseWheel(object sender, MouseEventArgs e)
        {
            // Calculate the new scrollbar value based on the mouse wheel movement
            int newValue = DashboardScrollbar.Value - e.Delta / 2; // Adjust scroll speed as needed
            newValue = Math.Max(DashboardScrollbar.Minimum, Math.Min(DashboardScrollbar.Maximum, newValue));
            DashboardScrollbar.Value = newValue;

            // Sync the FlowLayoutPanel scrolling with the updated scrollbar value
            flpUserThreads.AutoScrollPosition = new Point(0, DashboardScrollbar.Value);
        }
    }
}
