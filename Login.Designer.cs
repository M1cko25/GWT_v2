
namespace GWT_V2
{
    partial class Login
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
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.loginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loading11 = new GWT_V2.Loading1();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.guna2CircleButton1);
            this.panel.Controls.Add(this.closeBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(500, 40);
            this.panel.TabIndex = 14;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = global::GWT_V2.Properties.Resources.minimizeRed;
            this.guna2CircleButton1.Location = new System.Drawing.Point(411, 8);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.CheckedState.Parent = this.closeBtn;
            this.closeBtn.HoverState.Parent = this.closeBtn;
            this.closeBtn.Image = global::GWT_V2.Properties.Resources.closeBtn;
            this.closeBtn.Location = new System.Drawing.Point(452, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.Parent = this.closeBtn;
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BorderRadius = 11;
            this.loginBtn.CheckedState.Parent = this.loginBtn;
            this.loginBtn.CustomImages.Parent = this.loginBtn;
            this.loginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.HoverState.Parent = this.loginBtn;
            this.loginBtn.Location = new System.Drawing.Point(128, 368);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.ShadowDecoration.Parent = this.loginBtn;
            this.loginBtn.Size = new System.Drawing.Size(231, 45);
            this.loginBtn.TabIndex = 28;
            this.loginBtn.Text = "Log In";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.signUpLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.signUpLink.LinkColor = System.Drawing.Color.White;
            this.signUpLink.Location = new System.Drawing.Point(176, 302);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(126, 13);
            this.signUpLink.TabIndex = 27;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Don\'t Have An Account?";
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.ForeColor = System.Drawing.Color.White;
            this.passLbl.Location = new System.Drawing.Point(128, 226);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 15);
            this.passLbl.TabIndex = 26;
            this.passLbl.Text = "ENTER PASSWORD";
            // 
            // passTxt
            // 
            this.passTxt.BorderRadius = 10;
            this.passTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTxt.DefaultText = "";
            this.passTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.DisabledState.Parent = this.passTxt;
            this.passTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.FocusedState.Parent = this.passTxt;
            this.passTxt.ForeColor = System.Drawing.Color.Black;
            this.passTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTxt.HoverState.Parent = this.passTxt;
            this.passTxt.Location = new System.Drawing.Point(128, 247);
            this.passTxt.Name = "passTxt";
            this.passTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passTxt.PasswordChar = '•';
            this.passTxt.PlaceholderText = "";
            this.passTxt.SelectedText = "";
            this.passTxt.ShadowDecoration.Parent = this.passTxt;
            this.passTxt.Size = new System.Drawing.Size(231, 35);
            this.passTxt.TabIndex = 25;
            this.passTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTxt_KeyDown);
            // 
            // UserLbl
            // 
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(130, 147);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(104, 15);
            this.UserLbl.TabIndex = 24;
            this.UserLbl.Text = "ENTER USERNAME";
            // 
            // userTxt
            // 
            this.userTxt.BorderRadius = 10;
            this.userTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userTxt.DefaultText = "";
            this.userTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.DisabledState.Parent = this.userTxt;
            this.userTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTxt.FocusedState.Parent = this.userTxt;
            this.userTxt.ForeColor = System.Drawing.Color.Black;
            this.userTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.userTxt.HoverState.Parent = this.userTxt;
            this.userTxt.Location = new System.Drawing.Point(128, 168);
            this.userTxt.Name = "userTxt";
            this.userTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.userTxt.PlaceholderText = "";
            this.userTxt.SelectedText = "";
            this.userTxt.ShadowDecoration.Parent = this.userTxt;
            this.userTxt.Size = new System.Drawing.Size(231, 35);
            this.userTxt.TabIndex = 23;
            this.userTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userTxt_KeyDown);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(128, 72);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(233, 34);
            this.Header.TabIndex = 31;
            this.Header.Text = "OPEN AN ACCOUNT";
            this.Header.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passEye
            // 
            this.passEye.CheckedState.Image = global::GWT_V2.Properties.Resources.eye_open;
            this.passEye.CheckedState.Parent = this.passEye;
            this.passEye.HoverState.Parent = this.passEye;
            this.passEye.Image = global::GWT_V2.Properties.Resources.eye_closed;
            this.passEye.Location = new System.Drawing.Point(365, 254);
            this.passEye.Name = "passEye";
            this.passEye.PressedState.Parent = this.passEye;
            this.passEye.Size = new System.Drawing.Size(27, 23);
            this.passEye.TabIndex = 30;
            this.passEye.CheckedChanged += new System.EventHandler(this.passEye_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loading11
            // 
            this.loading11.BackColor = System.Drawing.Color.Transparent;
            this.loading11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loading11.Location = new System.Drawing.Point(502, 0);
            this.loading11.Name = "loading11";
            this.loading11.Size = new System.Drawing.Size(500, 474);
            this.loading11.TabIndex = 32;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(500, 474);
            this.Controls.Add(this.loading11);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.passEye);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.signUpLink);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Header;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passEye;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private System.Windows.Forms.LinkLabel signUpLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserLbl;
        private Guna.UI2.WinForms.Guna2TextBox userTxt;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Loading1 loading11;
        private System.Windows.Forms.Timer timer1;
    }
}

