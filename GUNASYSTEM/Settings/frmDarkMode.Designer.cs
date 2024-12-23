
namespace GUNASYSTEM.Settings
{
    partial class frmDarkMode
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctMoon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pctSun = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.tgleTheme = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSun)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pctMoon);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.pctSun);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.tgleTheme);
            this.guna2Panel1.Location = new System.Drawing.Point(59, 90);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(591, 66);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(59, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(103, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Dark Mode";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(10, 29);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(469, 19);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Adjust the appearance of Facebook to reduce glare and give your eyes a break.";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(10, 9);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(71, 19);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Dark Mode";
            // 
            // pctMoon
            // 
            this.pctMoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctMoon.BackColor = System.Drawing.Color.Transparent;
            this.pctMoon.Image = global::GUNASYSTEM.Properties.Resources.iconMoonOff;
            this.pctMoon.Location = new System.Drawing.Point(564, 28);
            this.pctMoon.Name = "pctMoon";
            this.pctMoon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctMoon.ShadowDecoration.Parent = this.pctMoon;
            this.pctMoon.Size = new System.Drawing.Size(20, 20);
            this.pctMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMoon.TabIndex = 12;
            this.pctMoon.TabStop = false;
            this.pctMoon.UseTransparentBackground = true;
            // 
            // pctSun
            // 
            this.pctSun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSun.BackColor = System.Drawing.Color.Transparent;
            this.pctSun.Image = global::GUNASYSTEM.Properties.Resources.iconSunOn;
            this.pctSun.Location = new System.Drawing.Point(497, 28);
            this.pctSun.Name = "pctSun";
            this.pctSun.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctSun.ShadowDecoration.Parent = this.pctSun;
            this.pctSun.Size = new System.Drawing.Size(20, 20);
            this.pctSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctSun.TabIndex = 10;
            this.pctSun.TabStop = false;
            this.pctSun.UseTransparentBackground = true;
            // 
            // tgleTheme
            // 
            this.tgleTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tgleTheme.Animated = true;
            this.tgleTheme.AutoRoundedCorners = true;
            this.tgleTheme.BackColor = System.Drawing.Color.Transparent;
            this.tgleTheme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgleTheme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tgleTheme.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgleTheme.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tgleTheme.CheckedState.Parent = this.tgleTheme;
            this.tgleTheme.Location = new System.Drawing.Point(523, 28);
            this.tgleTheme.Name = "tgleTheme";
            this.tgleTheme.ShadowDecoration.Parent = this.tgleTheme;
            this.tgleTheme.Size = new System.Drawing.Size(35, 20);
            this.tgleTheme.TabIndex = 11;
            this.tgleTheme.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgleTheme.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tgleTheme.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tgleTheme.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tgleTheme.UncheckedState.Parent = this.tgleTheme;
            this.tgleTheme.UseTransparentBackground = true;
            this.tgleTheme.CheckedChanged += new System.EventHandler(this.tgleTheme_CheckedChanged);
            // 
            // frmDarkMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(710, 602);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDarkMode";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDarkMode_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctMoon;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctSun;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tgleTheme;
    }
}