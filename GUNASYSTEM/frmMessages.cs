using DataManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GUNASYSTEM.Messages;
using Guna.UI2.WinForms;
using System.Threading.Tasks;

namespace GUNASYSTEM
{
    public partial class frmMessages : Form
    {
        public int UserID { get; set; }
        private int _selectedUserId;
        private Timer messageRefreshTimer;
        public event Action NewMessageReceived;
        protected override CreateParams CreateParams //DOuble buffering to reduce flickering
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }
        public frmMessages()
        {
            InitializeComponent();
            ThemeManager.onThemeChanged += ThemeChanged;

            ChatScroll.Scroll += ChatScroll_Scroll;
            ChatScroll.Minimum = 0;
            NewMessageReceived += RefreshUserList;
        }
        private async void RefreshUserList()
        {
            await GetUsers();
        }
        private async void frmMessages_Load(object sender, EventArgs e)
        {
            UpdateTheme();
            await ThemeManager.InitializeUIAsync(this, UserID);

            GetUsers();

            txtMessage.TextChanged += txtMessage_TextChanged;
            btnSendMessage.Click += BtnSendMessage_Click;
            StartPollingForMessages();
        }

        private void frmMessages_Disposed(object sender, EventArgs e)
        {
            ThemeManager.onThemeChanged -= ThemeChanged;
        }

        private void ThemeChanged(string newTheme)
        {
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateTheme();

                    _selectedUserId = 0;
                    pnlSlctdUserheader.Visible = false;
                    pctStatus.Visible = false;
                    pnlMessageArea.Visible = false;
                    pnlMessages.Controls.Clear();
                    pnlNoMessage.Visible = true;

                    if (!pnlMessages.Controls.Contains(pnlNoMessage))
                    {
                        pnlMessages.Controls.Add(pnlNoMessage);
                    }
                }));
            }
        }

        private void UpdateTheme()
        {
            if (ThemeManager.CurrentTheme == "dark")
            {
                pnlMessages.BackColor = Color.FromArgb(34, 34, 34);
                pnlMessages.FillColor = Color.FromArgb(34, 34, 34);
                pnlMessages.FillColor2 = Color.FromArgb(34, 34, 34);
            }
            else
            {
                pnlMessages.BackColor = Color.White;
                pnlMessages.FillColor = Color.White;
                pnlMessages.FillColor2 = Color.White;
            }
        }
        private void StartPollingForMessages()
        {
            messageRefreshTimer = new Timer();
            messageRefreshTimer.Interval = 5000; // Check every 3 second
            messageRefreshTimer.Tick += async (sender, e) =>
            {
                await GetUsers();
            };
            messageRefreshTimer.Start();
        }

        private void StopPollingForMessages()
        {
            if (messageRefreshTimer != null)
            {
                messageRefreshTimer.Stop();
                messageRefreshTimer.Dispose();
            }
        }

        private async Task GetUsers()
        {
            List<frmUserList> userList = new List<frmUserList>();
            DataResultSet m_set = new DataResultSet();
            m_set.Query = @"
            SELECT 
                u.user_id, 
                u.fullname, 
                u.status, 
                (
                    SELECT m.content
                    FROM messages m
                    WHERE 
                        (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
                        OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
                    ORDER BY m.timestamp DESC
                    LIMIT 1
                ) AS last_message,
                (
                    SELECT m.sender_id
                    FROM messages m
                    WHERE 
                        (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
                        OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
                    ORDER BY m.timestamp DESC
                    LIMIT 1
                ) AS last_message_sender,
                (
                    SELECT m.timestamp
                    FROM messages m
                    WHERE 
                        (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
                        OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
                    ORDER BY m.timestamp DESC
                    LIMIT 1
                ) AS last_message_timestamp
            FROM users u
            WHERE u.user_id != @currentUserId
            ORDER BY last_message_timestamp DESC";

            //m_set.Query = @"
            //SELECT 
            //    u.user_id, 
            //    u.fullname, 
            //    u.status, 
            //    (
            //        SELECT m.content
            //        FROM messages m
            //        WHERE 
            //            (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
            //            OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
            //        ORDER BY m.timestamp DESC
            //        LIMIT 1
            //    ) AS last_message,
            //    (
            //        SELECT m.sender_id
            //        FROM messages m
            //        WHERE 
            //            (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
            //            OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
            //        ORDER BY m.timestamp DESC
            //        LIMIT 1
            //    ) AS last_message_sender,
            //    (
            //        SELECT m.timestamp
            //        FROM messages m
            //        WHERE 
            //            (m.sender_id = u.user_id AND m.recipient_id = @currentUserId)
            //            OR (m.sender_id = @currentUserId AND m.recipient_id = u.user_id)
            //        ORDER BY m.timestamp DESC
            //        LIMIT 1
            //    ) AS last_message_timestamp
            //FROM users u
            //WHERE u.user_id != @currentUserId
            //ORDER BY last_message_timestamp DESC";

            m_set.AddParameter("@currentUserId", UserID);

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    Image statusImage = m_set.GetString(2) == "Online"
                        ? Properties.Resources.iconOnline
                        : Properties.Resources.iconsOffline;

                    string lastMessage = m_set.GetString(3) ?? "";
                    string lastMessageSenderId = m_set.GetString(4);

                    if (lastMessageSenderId == UserID.ToString())
                    {
                        lastMessage = "You: " + lastMessage;
                    }

                    frmUserList user = new frmUserList
                    {
                        UsersID = m_set.GetString(0),
                        UsersName = m_set.GetString(1),
                        UsersLastMessage = lastMessage,
                        UserStatus = statusImage,
                    };

                    user.UserClicked += OnUserClicked;
                    userList.Add(user);
                    flowLayoutPanel1.Controls.Add(user);
                }
            }
            m_set.Close();
        }
        private void OnUserClicked(object sender, int clickedUserId)
        {
            _selectedUserId = clickedUserId;

            pnlNoMessage.Visible = false;
            pnlSlctdUserheader.Visible = true;
            pctStatus.Visible = true;
            pnlMessageArea.Visible = true;

            DataResultSet m_set = new DataResultSet();
            m_set.Query = "Select * from users where user_id = @clickedUserId";
            m_set.AddParameter("@clickedUserId", clickedUserId);
            if (m_set.Execute())
            {
                if (m_set.Read())
                {
                    txtSelectedUserName.Text = m_set.GetString(4);
                    txtSelectedUserName1.Text = m_set.GetString(4);
                    lblSelectedUserStatus.Text = m_set.GetString(8);
                    lblSelectedUserStatus1.Text = m_set.GetString(8);
                    if (m_set.GetString(8) == "Online")
                    {
                        crclStatus1.Visible = true;
                        crclStatus2.Visible = true;
                        pctClickedUserStatus.Image = Properties.Resources.iconOnline;
                    }
                    else
                    {
                        crclStatus1.Visible = false;
                        crclStatus2.Visible = false;
                        pctClickedUserStatus.Image = Properties.Resources.iconsOffline;
                    }
                }
            }
            m_set.Close();
            LoadChatMessages(clickedUserId);
        }

        private async Task LoadChatMessages(int clickedUserId)
        {
            int currentScrollPosition = pnlMessages.VerticalScroll.Value;
            pnlMessages.Controls.Clear();
            int currentTop = 0;

            DataResultSet m_set = new DataResultSet();
            m_set.Query = @"SELECT * FROM messages WHERE 
                (sender_id = @userId AND recipient_id = @currentUserId)
                OR (sender_id = @currentUserId AND recipient_id = @userId) 
                ORDER BY timestamp";
            m_set.AddParameter("@userId", clickedUserId);
            m_set.AddParameter("@currentUserId", UserID);

            if (m_set.Execute())
            {
                while (m_set.Read())
                {
                    bool isIncoming = m_set.GetInt(1) != UserID;
                    string messageContent = m_set.GetString(3);
                    Guna2Panel messagePanel;

                    if (isIncoming)
                    {
                        messagePanel = CreateIncomingMessagePanel(messageContent, m_set.GetDateTime(4).ToString("hh:mm tt"));
                        messagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                    }
                    else
                    {
                        messagePanel = CreateOutgoingMessagePanel(messageContent, m_set.GetDateTime(4).ToString("hh:mm tt"));
                        messagePanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                        messagePanel.Left = pnlMessages.ClientSize.Width - messagePanel.Width - 10;
                    }
                    messagePanel.Top = currentTop;
                    pnlMessages.Controls.Add(messagePanel);

                    currentTop += messagePanel.Height + 5;
                }
            }
            m_set.Close();

            UpdateScrollbar();
            ChatScroll.Value = ChatScroll.Maximum; 

            pnlMessages.PerformLayout();
        }

        private void UpdateScrollbar()
        {
            ChatScroll.Maximum = pnlMessages.VerticalScroll.Maximum;
            ChatScroll.LargeChange = pnlMessages.ClientSize.Height;
            ChatScroll.SmallChange = 10; // Adjust for faster/slower scroll speed
        }

        private void ChatScroll_Scroll(object sender, ScrollEventArgs e)
        {
            pnlMessages.VerticalScroll.Value = ChatScroll.Value;
            pnlMessages.PerformLayout();
        }

        private void BtnSendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (string.IsNullOrWhiteSpace(txtMessage.Text))
                return;

            //string messageText = txtMessage.Text;
            string messageText = txtMessage.Text.Replace(Environment.NewLine, "<br/>");
            DateTime timestamp = DateTime.Now;

            DataResultSet m_set = new DataResultSet();
            m_set.Query = "INSERT INTO messages (sender_id, recipient_id, content, timestamp) VALUES (@senderId, @recipientId, @message, @timestamp)";
            m_set.AddParameter("@senderId", UserID);
            m_set.AddParameter("@recipientId", _selectedUserId);
            m_set.AddParameter("@message", messageText);
            m_set.AddParameter("@timestamp", timestamp);

            try
            {
                if (m_set.Execute())
                {
                    txtMessage.Clear();

                    Panel outgoingControl = CreateOutgoingMessagePanel(messageText, timestamp.ToString("hh:mm tt"));

                    outgoingControl.Location = new Point(pnlMessages.ClientSize.Width - outgoingControl.Width - 10, pnlMessages.Controls.Count > 0 ? pnlMessages.Controls[pnlMessages.Controls.Count - 1].Bottom + 5 : 10);

                    pnlMessages.Controls.Add(outgoingControl);

                    // Scroll to the bottom to show the latest message
                    pnlMessages.VerticalScroll.Value = pnlMessages.VerticalScroll.Maximum;
                    pnlMessages.PerformLayout();
                    NewMessageReceived?.Invoke();
                }

                else
                {
                    MessageBox.Show("Failed to send message.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the message: {ex.Message}");
            }
            finally
            {
                m_set.Close();
            }
       
        }
        private Guna.UI2.WinForms.Guna2Panel CreateIncomingMessagePanel(string message, string timestamp)
        {
            Guna.UI2.WinForms.Guna2CirclePictureBox pctIncomingAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox
            {
                Image = Properties.Resources.icons8_male_user_100,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(30, 30),
                Margin = new Padding(10, 0, 10, 0),
                BackColor = Color.Transparent,
                UseTransparentBackground = true
            };
            Guna.UI2.WinForms.Guna2HtmlLabel lblIncomingMessage = new Guna.UI2.WinForms.Guna2HtmlLabel
            {
                Dock = DockStyle.Fill,
                Text = message,
                AutoSize = true,
                MaximumSize = new Size(230, 0),
                BackColor = Color.Transparent,
                ForeColor = ThemeManager.CurrentTheme == "dark" ? Color.White : Color.Black
            };

            Guna.UI2.WinForms.Guna2Panel pnlMessageBox = new Guna.UI2.WinForms.Guna2Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10),
                BackColor = Color.Transparent,
                FillColor = ThemeManager.CurrentTheme == "dark" ? Color.FromArgb(28, 28, 28) : Color.FromArgb(240, 240, 240),
                Margin = new Padding(5),
                BorderColor = Color.Transparent,
                UseTransparentBackground = true,
                BorderRadius = 10
            };

            pnlMessageBox.Controls.Add(lblIncomingMessage);

            Guna.UI2.WinForms.Guna2Panel pnlIncomingPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0),
                Margin = new Padding(5),
                BackColor = Color.Transparent,
                FillColor = Color.Transparent
            };

            pnlIncomingPanel.Controls.Add(pctIncomingAvatar);
            pnlIncomingPanel.Controls.Add(pnlMessageBox);

            pnlMessageBox.Location = new Point(pctIncomingAvatar.Width + 10, 0);

            return pnlIncomingPanel;
        }

        private Guna.UI2.WinForms.Guna2Panel CreateOutgoingMessagePanel(string message, string timestamp)
        {
            Guna.UI2.WinForms.Guna2Panel pnlOutgoingBox = new Guna.UI2.WinForms.Guna2Panel
            {

                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(10, 10, 10, 10),
                FillColor = ThemeManager.CurrentTheme == "dark" ? Color.FromArgb(45, 45, 48) : Color.LightGray,
                BackColor = Color.Transparent,
                Margin = new Padding(5, 5, 5, 5),
                //BorderColor = Color.Transparent, // Set border color to transparent if needed
                BorderRadius = 10,
                UseTransparentBackground = true
            };

            Guna.UI2.WinForms.Guna2HtmlLabel lblOutgoingMessage = new Guna.UI2.WinForms.Guna2HtmlLabel
            {
                Dock = DockStyle.Fill,
                Text = message,
                AutoSize = true,
                MaximumSize = new Size(230, 0),
                BackColor = Color.Transparent,
                ForeColor = ThemeManager.CurrentTheme == "dark" ? Color.White : Color.Black,

            };

            pnlOutgoingBox.Controls.Add(lblOutgoingMessage);

            return pnlOutgoingBox;
        }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            AutoResizeTextBox(txtMessage, pnlMessageArea);
        }


        private void AutoResizeTextBox(Guna.UI2.WinForms.Guna2TextBox textBox, Guna.UI2.WinForms.Guna2Panel panel)
        {
            int defaultHeight = 38;
            int maxWidth = textBox.Width;

            Size textSize = TextRenderer.MeasureText(textBox.Text, textBox.Font, new Size(maxWidth, int.MaxValue), TextFormatFlags.TextBoxControl | TextFormatFlags.WordBreak);

            int newHeight = textSize.Height + 10;

            if (textBox.Lines.Length > 1)
            {
                newHeight = Math.Max(defaultHeight + 10, newHeight);
            }
            else
            {
                newHeight = Math.Max(defaultHeight, newHeight);
            }

            int heightDifference = newHeight - textBox.Height;

            if (heightDifference != 0)
            {
                textBox.Height = newHeight;
                panel.Height += heightDifference;
                panel.Top -= heightDifference;
                textBox.Top -= heightDifference;
            }
            UpdateScrollbar();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                txtMessage.AppendText(Environment.NewLine);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                txtMessage.Clear();
                e.SuppressKeyPress = true;
            }
        }
    }
}
