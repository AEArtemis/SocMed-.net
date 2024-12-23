
namespace GUNASYSTEM.Dashboard
{
    partial class frmUserThreads
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblThreadCaption = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsersID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlThreadContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShare = new Guna.UI2.WinForms.Guna2Button();
            this.btnComments = new Guna.UI2.WinForms.Guna2Button();
            this.btnReact = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCommentCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblShareCount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pctReaction = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pctThreadImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblUsersName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctPrivacySetting = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblThreadDuration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctUsersAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlContainer.SuspendLayout();
            this.pnlThreadContainer.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThreadImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrivacySetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lblThreadCaption);
            this.pnlContainer.Controls.Add(this.lblUsersID);
            this.pnlContainer.Controls.Add(this.pnlThreadContainer);
            this.pnlContainer.Controls.Add(this.lblUsersName);
            this.pnlContainer.Controls.Add(this.pctPrivacySetting);
            this.pnlContainer.Controls.Add(this.lblThreadDuration);
            this.pnlContainer.Controls.Add(this.pctUsersAvatar);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.ShadowDecoration.Parent = this.pnlContainer;
            this.pnlContainer.Size = new System.Drawing.Size(556, 479);
            this.pnlContainer.TabIndex = 0;
            // 
            // lblThreadCaption
            // 
            this.lblThreadCaption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThreadCaption.AutoSize = false;
            this.lblThreadCaption.AutoSizeHeightOnly = true;
            this.lblThreadCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblThreadCaption.Location = new System.Drawing.Point(12, 56);
            this.lblThreadCaption.Name = "lblThreadCaption";
            this.lblThreadCaption.Size = new System.Drawing.Size(531, 14);
            this.lblThreadCaption.TabIndex = 30;
            this.lblThreadCaption.Text = "test";
            // 
            // lblUsersID
            // 
            this.lblUsersID.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersID.Location = new System.Drawing.Point(501, 8);
            this.lblUsersID.Name = "lblUsersID";
            this.lblUsersID.Size = new System.Drawing.Size(39, 15);
            this.lblUsersID.TabIndex = 29;
            this.lblUsersID.Text = "User ID";
            this.lblUsersID.Visible = false;
            // 
            // pnlThreadContainer
            // 
            this.pnlThreadContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThreadContainer.AutoSize = true;
            this.pnlThreadContainer.Controls.Add(this.guna2Panel3);
            this.pnlThreadContainer.Controls.Add(this.pctThreadImage);
            this.pnlThreadContainer.Location = new System.Drawing.Point(0, 70);
            this.pnlThreadContainer.Name = "pnlThreadContainer";
            this.pnlThreadContainer.ShadowDecoration.Parent = this.pnlThreadContainer;
            this.pnlThreadContainer.Size = new System.Drawing.Size(556, 406);
            this.pnlThreadContainer.TabIndex = 28;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel3.Controls.Add(this.btnShare);
            this.guna2Panel3.Controls.Add(this.btnComments);
            this.guna2Panel3.Controls.Add(this.btnReact);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Location = new System.Drawing.Point(12, 317);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(531, 71);
            this.guna2Panel3.TabIndex = 18;
            // 
            // btnShare
            // 
            this.btnShare.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShare.Animated = true;
            this.btnShare.CheckedState.Parent = this.btnShare;
            this.btnShare.CustomImages.Parent = this.btnShare;
            this.btnShare.FillColor = System.Drawing.Color.Transparent;
            this.btnShare.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShare.ForeColor = System.Drawing.Color.Black;
            this.btnShare.HoverState.Parent = this.btnShare;
            this.btnShare.Image = global::GUNASYSTEM.Properties.Resources.iconShare;
            this.btnShare.Location = new System.Drawing.Point(371, 30);
            this.btnShare.Name = "btnShare";
            this.btnShare.ShadowDecoration.Parent = this.btnShare;
            this.btnShare.Size = new System.Drawing.Size(157, 38);
            this.btnShare.TabIndex = 3;
            this.btnShare.Text = "Share";
            // 
            // btnComments
            // 
            this.btnComments.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComments.Animated = true;
            this.btnComments.CheckedState.Parent = this.btnComments;
            this.btnComments.CustomImages.Parent = this.btnComments;
            this.btnComments.FillColor = System.Drawing.Color.Transparent;
            this.btnComments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComments.ForeColor = System.Drawing.Color.Black;
            this.btnComments.HoverState.Parent = this.btnComments;
            this.btnComments.Image = global::GUNASYSTEM.Properties.Resources.iconComments;
            this.btnComments.Location = new System.Drawing.Point(194, 30);
            this.btnComments.Name = "btnComments";
            this.btnComments.ShadowDecoration.Parent = this.btnComments;
            this.btnComments.Size = new System.Drawing.Size(171, 38);
            this.btnComments.TabIndex = 2;
            this.btnComments.Text = "Comment";
            // 
            // btnReact
            // 
            this.btnReact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnReact.Animated = true;
            this.btnReact.CheckedState.Parent = this.btnReact;
            this.btnReact.CustomImages.Parent = this.btnReact;
            this.btnReact.FillColor = System.Drawing.Color.Transparent;
            this.btnReact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReact.ForeColor = System.Drawing.Color.Black;
            this.btnReact.HoverState.Parent = this.btnReact;
            this.btnReact.Image = global::GUNASYSTEM.Properties.Resources.iconLike;
            this.btnReact.Location = new System.Drawing.Point(4, 30);
            this.btnReact.Name = "btnReact";
            this.btnReact.ShadowDecoration.Parent = this.btnReact;
            this.btnReact.Size = new System.Drawing.Size(184, 38);
            this.btnReact.TabIndex = 1;
            this.btnReact.Text = "Like";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.lblCommentCount);
            this.guna2Panel4.Controls.Add(this.lblShareCount);
            this.guna2Panel4.Controls.Add(this.guna2CirclePictureBox4);
            this.guna2Panel4.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel4.Controls.Add(this.pctReaction);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(531, 29);
            this.guna2Panel4.TabIndex = 0;
            // 
            // lblCommentCount
            // 
            this.lblCommentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommentCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentCount.Location = new System.Drawing.Point(446, 7);
            this.lblCommentCount.Name = "lblCommentCount";
            this.lblCommentCount.Size = new System.Drawing.Size(9, 15);
            this.lblCommentCount.TabIndex = 21;
            this.lblCommentCount.Text = "1";
            // 
            // lblShareCount
            // 
            this.lblShareCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShareCount.BackColor = System.Drawing.Color.Transparent;
            this.lblShareCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShareCount.Location = new System.Drawing.Point(493, 7);
            this.lblShareCount.Name = "lblShareCount";
            this.lblShareCount.Size = new System.Drawing.Size(9, 15);
            this.lblShareCount.TabIndex = 20;
            this.lblShareCount.Text = "1";
            // 
            // guna2CirclePictureBox4
            // 
            this.guna2CirclePictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox4.Image = global::GUNASYSTEM.Properties.Resources.iconShare;
            this.guna2CirclePictureBox4.Location = new System.Drawing.Point(508, 3);
            this.guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            this.guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox4.ShadowDecoration.Parent = this.guna2CirclePictureBox4;
            this.guna2CirclePictureBox4.Size = new System.Drawing.Size(20, 23);
            this.guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox4.TabIndex = 19;
            this.guna2CirclePictureBox4.TabStop = false;
            this.guna2CirclePictureBox4.UseTransparentBackground = true;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::GUNASYSTEM.Properties.Resources.iconComments;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(461, 3);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(18, 23);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 18;
            this.guna2CirclePictureBox2.TabStop = false;
            this.guna2CirclePictureBox2.UseTransparentBackground = true;
            // 
            // pctReaction
            // 
            this.pctReaction.BackColor = System.Drawing.Color.Transparent;
            this.pctReaction.Image = global::GUNASYSTEM.Properties.Resources.icons8_tongue_out;
            this.pctReaction.Location = new System.Drawing.Point(4, 3);
            this.pctReaction.Name = "pctReaction";
            this.pctReaction.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctReaction.ShadowDecoration.Parent = this.pctReaction;
            this.pctReaction.Size = new System.Drawing.Size(23, 23);
            this.pctReaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctReaction.TabIndex = 17;
            this.pctReaction.TabStop = false;
            this.pctReaction.UseTransparentBackground = true;
            this.pctReaction.Visible = false;
            // 
            // pctThreadImage
            // 
            this.pctThreadImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pctThreadImage.BorderRadius = 15;
            this.pctThreadImage.Image = global::GUNASYSTEM.Properties.Resources.gamebo_wallpaper;
            this.pctThreadImage.Location = new System.Drawing.Point(12, 4);
            this.pctThreadImage.Name = "pctThreadImage";
            this.pctThreadImage.ShadowDecoration.Parent = this.pctThreadImage;
            this.pctThreadImage.Size = new System.Drawing.Size(531, 301);
            this.pctThreadImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctThreadImage.TabIndex = 17;
            this.pctThreadImage.TabStop = false;
            // 
            // lblUsersName
            // 
            this.lblUsersName.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersName.Location = new System.Drawing.Point(63, 8);
            this.lblUsersName.Name = "lblUsersName";
            this.lblUsersName.Size = new System.Drawing.Size(112, 19);
            this.lblUsersName.TabIndex = 26;
            this.lblUsersName.Text = "guna2HtmlLabel3";
            // 
            // pctPrivacySetting
            // 
            this.pctPrivacySetting.BackColor = System.Drawing.Color.Transparent;
            this.pctPrivacySetting.Image = global::GUNASYSTEM.Properties.Resources.iconLanguages;
            this.pctPrivacySetting.Location = new System.Drawing.Point(122, 29);
            this.pctPrivacySetting.Name = "pctPrivacySetting";
            this.pctPrivacySetting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctPrivacySetting.ShadowDecoration.Parent = this.pctPrivacySetting;
            this.pctPrivacySetting.Size = new System.Drawing.Size(22, 15);
            this.pctPrivacySetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPrivacySetting.TabIndex = 25;
            this.pctPrivacySetting.TabStop = false;
            this.pctPrivacySetting.UseTransparentBackground = true;
            // 
            // lblThreadDuration
            // 
            this.lblThreadDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblThreadDuration.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreadDuration.Location = new System.Drawing.Point(63, 29);
            this.lblThreadDuration.Name = "lblThreadDuration";
            this.lblThreadDuration.Size = new System.Drawing.Size(53, 15);
            this.lblThreadDuration.TabIndex = 24;
            this.lblThreadDuration.Text = "a day ago";
            // 
            // pctUsersAvatar
            // 
            this.pctUsersAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pctUsersAvatar.Image = global::GUNASYSTEM.Properties.Resources.icons8_male_user_100;
            this.pctUsersAvatar.Location = new System.Drawing.Point(12, 5);
            this.pctUsersAvatar.Name = "pctUsersAvatar";
            this.pctUsersAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctUsersAvatar.ShadowDecoration.Parent = this.pctUsersAvatar;
            this.pctUsersAvatar.Size = new System.Drawing.Size(46, 45);
            this.pctUsersAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUsersAvatar.TabIndex = 23;
            this.pctUsersAvatar.TabStop = false;
            this.pctUsersAvatar.UseTransparentBackground = true;
            // 
            // frmUserThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "frmUserThreads";
            this.Size = new System.Drawing.Size(556, 479);
            this.Load += new System.EventHandler(this.frmUserThreads_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlThreadContainer.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctReaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctThreadImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrivacySetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlThreadContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnShare;
        private Guna.UI2.WinForms.Guna2Button btnComments;
        private Guna.UI2.WinForms.Guna2Button btnReact;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCommentCount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShareCount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctReaction;
        private Guna.UI2.WinForms.Guna2PictureBox pctThreadImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsersName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctPrivacySetting;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblThreadDuration;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctUsersAvatar;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsersID;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblThreadCaption;
    }
}
