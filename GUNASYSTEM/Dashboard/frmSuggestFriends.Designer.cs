
namespace GUNASYSTEM.Dashboard
{
    partial class frmSuggestFriends
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddFriend = new Guna.UI2.WinForms.Guna2Button();
            this.lblSuggested = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctUsersAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblFullname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblUserID);
            this.guna2Panel1.Controls.Add(this.btnAddFriend);
            this.guna2Panel1.Controls.Add(this.lblSuggested);
            this.guna2Panel1.Controls.Add(this.pctUsersAvatar);
            this.guna2Panel1.Controls.Add(this.lblFullname);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(278, 46);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblUserID
            // 
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Location = new System.Drawing.Point(264, 3);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(11, 15);
            this.lblUserID.TabIndex = 31;
            this.lblUserID.Text = "id";
            this.lblUserID.Visible = false;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFriend.CheckedState.Parent = this.btnAddFriend;
            this.btnAddFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFriend.CustomImages.Parent = this.btnAddFriend;
            this.btnAddFriend.FillColor = System.Drawing.Color.Transparent;
            this.btnAddFriend.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFriend.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddFriend.HoverState.Parent = this.btnAddFriend;
            this.btnAddFriend.Location = new System.Drawing.Point(224, 13);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.PressedColor = System.Drawing.Color.Transparent;
            this.btnAddFriend.ShadowDecoration.Parent = this.btnAddFriend;
            this.btnAddFriend.Size = new System.Drawing.Size(51, 19);
            this.btnAddFriend.TabIndex = 30;
            this.btnAddFriend.Text = "Follow";
            this.btnAddFriend.UseTransparentBackground = true;
            // 
            // lblSuggested
            // 
            this.lblSuggested.AutoSize = false;
            this.lblSuggested.AutoSizeHeightOnly = true;
            this.lblSuggested.BackColor = System.Drawing.Color.Transparent;
            this.lblSuggested.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggested.Location = new System.Drawing.Point(52, 25);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Size = new System.Drawing.Size(114, 16);
            this.lblSuggested.TabIndex = 29;
            this.lblSuggested.Text = "Suggested for you";
            this.lblSuggested.Visible = false;
            // 
            // pctUsersAvatar
            // 
            this.pctUsersAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pctUsersAvatar.Image = global::GUNASYSTEM.Properties.Resources.icons8_male_user_100;
            this.pctUsersAvatar.Location = new System.Drawing.Point(1, 0);
            this.pctUsersAvatar.Name = "pctUsersAvatar";
            this.pctUsersAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctUsersAvatar.ShadowDecoration.Parent = this.pctUsersAvatar;
            this.pctUsersAvatar.Size = new System.Drawing.Size(46, 45);
            this.pctUsersAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUsersAvatar.TabIndex = 28;
            this.pctUsersAvatar.TabStop = false;
            this.pctUsersAvatar.UseTransparentBackground = true;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = false;
            this.lblFullname.AutoSizeHeightOnly = true;
            this.lblFullname.BackColor = System.Drawing.Color.Transparent;
            this.lblFullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(52, 7);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(176, 18);
            this.lblFullname.TabIndex = 27;
            this.lblFullname.Text = "Full Name";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmSuggestFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmSuggestFriends";
            this.Size = new System.Drawing.Size(278, 46);
            this.Load += new System.EventHandler(this.frmSuggestFriends_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddFriend;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSuggested;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctUsersAvatar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFullname;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUserID;
    }
}
