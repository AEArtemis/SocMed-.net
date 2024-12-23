
namespace GUNASYSTEM
{
    partial class frmLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlAppHeader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnAppMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseApp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.bgPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tgleShowPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlAppHeader.SuspendLayout();
            this.bgPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnlAppHeader;
            // 
            // pnlAppHeader
            // 
            this.pnlAppHeader.Controls.Add(this.btnAppMinimize);
            this.pnlAppHeader.Controls.Add(this.btnCloseApp);
            this.pnlAppHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAppHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(62)))), ((int)(((byte)(94)))));
            this.pnlAppHeader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(75)))), ((int)(((byte)(95)))));
            this.pnlAppHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlAppHeader.Name = "pnlAppHeader";
            this.pnlAppHeader.ShadowDecoration.Parent = this.pnlAppHeader;
            this.pnlAppHeader.Size = new System.Drawing.Size(713, 34);
            this.pnlAppHeader.TabIndex = 4;
            // 
            // btnAppMinimize
            // 
            this.btnAppMinimize.Animated = true;
            this.btnAppMinimize.CheckedState.Parent = this.btnAppMinimize;
            this.btnAppMinimize.CustomImages.Parent = this.btnAppMinimize;
            this.btnAppMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.btnAppMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMinimize.ForeColor = System.Drawing.Color.White;
            this.btnAppMinimize.HoverState.Parent = this.btnAppMinimize;
            this.btnAppMinimize.Image = global::GUNASYSTEM.Properties.Resources.icons8_dash_90;
            this.btnAppMinimize.ImageSize = new System.Drawing.Size(8, 8);
            this.btnAppMinimize.Location = new System.Drawing.Point(653, 5);
            this.btnAppMinimize.Name = "btnAppMinimize";
            this.btnAppMinimize.ShadowDecoration.Parent = this.btnAppMinimize;
            this.btnAppMinimize.Size = new System.Drawing.Size(25, 27);
            this.btnAppMinimize.TabIndex = 10;
            this.btnAppMinimize.Click += new System.EventHandler(this.btnAppMinimize_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Animated = true;
            this.btnCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.CheckedState.Parent = this.btnCloseApp;
            this.btnCloseApp.CustomImages.Parent = this.btnCloseApp;
            this.btnCloseApp.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.HoverState.Parent = this.btnCloseApp;
            this.btnCloseApp.Image = global::GUNASYSTEM.Properties.Resources.icons8_close_90;
            this.btnCloseApp.ImageSize = new System.Drawing.Size(10, 10);
            this.btnCloseApp.Location = new System.Drawing.Point(684, 5);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.ShadowDecoration.Parent = this.btnCloseApp;
            this.btnCloseApp.Size = new System.Drawing.Size(25, 27);
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // bgPanel
            // 
            this.bgPanel.BackgroundImage = global::GUNASYSTEM.Properties.Resources.Free_Vector___Gradient_mountain_landscape;
            this.bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgPanel.Controls.Add(this.pnlAppHeader);
            this.bgPanel.Controls.Add(this.guna2Panel3);
            this.bgPanel.Controls.Add(this.guna2ShadowPanel1);
            this.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgPanel.Location = new System.Drawing.Point(0, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.ShadowDecoration.Parent = this.bgPanel;
            this.bgPanel.Size = new System.Drawing.Size(713, 556);
            this.bgPanel.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 518);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(713, 38);
            this.guna2Panel3.TabIndex = 3;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2CircleButton1);
            this.guna2ShadowPanel1.Controls.Add(this.tgleShowPass);
            this.guna2ShadowPanel1.Controls.Add(this.btnLogin);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassword);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.txtUsername);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(209, 58);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 15;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(287, 429);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(84, 333);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(65, 14);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Show Password";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(124, 169);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(37, 37);
            this.guna2CircleButton1.TabIndex = 6;
            this.guna2CircleButton1.UseTransparentBackground = true;
            // 
            // tgleShowPass
            // 
            this.tgleShowPass.Animated = true;
            this.tgleShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgleShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgleShowPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgleShowPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgleShowPass.CheckedState.Parent = this.tgleShowPass;
            this.tgleShowPass.Location = new System.Drawing.Point(43, 330);
            this.tgleShowPass.Name = "tgleShowPass";
            this.tgleShowPass.ShadowDecoration.Parent = this.tgleShowPass;
            this.tgleShowPass.Size = new System.Drawing.Size(35, 20);
            this.tgleShowPass.TabIndex = 5;
            this.tgleShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgleShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgleShowPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgleShowPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgleShowPass.UncheckedState.Parent = this.tgleShowPass;
            this.tgleShowPass.CheckedChanged += new System.EventHandler(this.tgleShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.AutoRoundedCorners = true;
            this.btnLogin.BorderRadius = 17;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(94, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(105, 37);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderRadius = 17;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(43, 288);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(200, 36);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackgroundImage = global::GUNASYSTEM.Properties.Resources.Free_Vector___Gradient_mountain_landscape;
            this.guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel2.Location = new System.Drawing.Point(15, 9);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(257, 182);
            this.guna2Panel2.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(106, 206);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(69, 19);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "User Login";
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BorderRadius = 17;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(48)))), ((int)(((byte)(62)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(43, 246);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(200, 36);
            this.txtUsername.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 556);
            this.Controls.Add(this.bgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAppHeader.ResumeLayout(false);
            this.bgPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel bgPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlAppHeader;
        private Guna.UI2.WinForms.Guna2Button btnAppMinimize;
        private Guna.UI2.WinForms.Guna2Button btnCloseApp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgleShowPass;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        public Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

