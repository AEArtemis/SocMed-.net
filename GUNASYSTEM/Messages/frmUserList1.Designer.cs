
namespace GUNASYSTEM
{
    partial class frmUserList
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
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsersID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsersLastMessage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUsersName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pctUserStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pctUsersProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.guna2Button1);
            this.guna2Panel3.Controls.Add(this.pctUserStatus);
            this.guna2Panel3.Controls.Add(this.lblUsersID);
            this.guna2Panel3.Controls.Add(this.lblUsersLastMessage);
            this.guna2Panel3.Controls.Add(this.lblUsersName);
            this.guna2Panel3.Controls.Add(this.pctUsersProfile);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(253, 58);
            this.guna2Panel3.TabIndex = 2;
            this.guna2Panel3.Click += new System.EventHandler(this.frmUserList_Click);
            // 
            // lblUsersID
            // 
            this.lblUsersID.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersID.Location = new System.Drawing.Point(241, 10);
            this.lblUsersID.Name = "lblUsersID";
            this.lblUsersID.Size = new System.Drawing.Size(3, 2);
            this.lblUsersID.TabIndex = 8;
            this.lblUsersID.Text = null;
            this.lblUsersID.Visible = false;
            // 
            // lblUsersLastMessage
            // 
            this.lblUsersLastMessage.AutoSize = false;
            this.lblUsersLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersLastMessage.Location = new System.Drawing.Point(61, 30);
            this.lblUsersLastMessage.Name = "lblUsersLastMessage";
            this.lblUsersLastMessage.Size = new System.Drawing.Size(174, 15);
            this.lblUsersLastMessage.TabIndex = 7;
            this.lblUsersLastMessage.Text = " Hi Ace";
            // 
            // lblUsersName
            // 
            this.lblUsersName.BackColor = System.Drawing.Color.Transparent;
            this.lblUsersName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsersName.Location = new System.Drawing.Point(60, 10);
            this.lblUsersName.Name = "lblUsersName";
            this.lblUsersName.Size = new System.Drawing.Size(62, 19);
            this.lblUsersName.TabIndex = 6;
            this.lblUsersName.Text = "John Doe";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pctUserStatus
            // 
            this.pctUserStatus.Image = global::GUNASYSTEM.Properties.Resources.iconOnline;
            this.pctUserStatus.Location = new System.Drawing.Point(31, 35);
            this.pctUserStatus.Name = "pctUserStatus";
            this.pctUserStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctUserStatus.ShadowDecoration.Parent = this.pctUserStatus;
            this.pctUserStatus.Size = new System.Drawing.Size(20, 20);
            this.pctUserStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUserStatus.TabIndex = 9;
            this.pctUserStatus.TabStop = false;
            this.pctUserStatus.UseTransparentBackground = true;
            // 
            // pctUsersProfile
            // 
            this.pctUsersProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctUsersProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctUsersProfile.FillColor = System.Drawing.Color.Transparent;
            this.pctUsersProfile.Image = global::GUNASYSTEM.Properties.Resources.icons8_male_user_100;
            this.pctUsersProfile.Location = new System.Drawing.Point(0, 0);
            this.pctUsersProfile.Name = "pctUsersProfile";
            this.pctUsersProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctUsersProfile.ShadowDecoration.Parent = this.pctUsersProfile;
            this.pctUsersProfile.Size = new System.Drawing.Size(51, 58);
            this.pctUsersProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctUsersProfile.TabIndex = 5;
            this.pctUsersProfile.TabStop = false;
            this.pctUsersProfile.UseTransparentBackground = true;
            this.pctUsersProfile.Click += new System.EventHandler(this.pctUsersProfile_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(51, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(202, 58);
            this.guna2Button1.TabIndex = 10;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Name = "frmUserList";
            this.Size = new System.Drawing.Size(253, 58);
            this.Load += new System.EventHandler(this.frmUserList_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmUserList_MouseClick);
            this.MouseEnter += new System.EventHandler(this.frmUserList_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmUserList_MouseLeave);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUserStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsersProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsersID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsersLastMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUsersName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctUsersProfile;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctUserStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
