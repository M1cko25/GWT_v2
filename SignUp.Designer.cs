
namespace GWT_V2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SignUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.ConLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ConPassTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.passLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.passTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.conEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.passEye = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.loading11 = new GWT_V2.Loading1();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.panel.TabIndex = 15;
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
            // SignUpBtn
            // 
            this.SignUpBtn.BorderRadius = 11;
            this.SignUpBtn.CheckedState.Parent = this.SignUpBtn;
            this.SignUpBtn.CustomImages.Parent = this.SignUpBtn;
            this.SignUpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.HoverState.Parent = this.SignUpBtn;
            this.SignUpBtn.Location = new System.Drawing.Point(130, 394);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.ShadowDecoration.Parent = this.SignUpBtn;
            this.SignUpBtn.Size = new System.Drawing.Size(231, 45);
            this.SignUpBtn.TabIndex = 23;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.loginLink.LinkColor = System.Drawing.Color.White;
            this.loginLink.Location = new System.Drawing.Point(180, 331);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(136, 13);
            this.loginLink.TabIndex = 22;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Already Have An Account?";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // ConLbl
            // 
            this.ConLbl.BackColor = System.Drawing.Color.Transparent;
            this.ConLbl.ForeColor = System.Drawing.Color.White;
            this.ConLbl.Location = new System.Drawing.Point(128, 261);
            this.ConLbl.Name = "ConLbl";
            this.ConLbl.Size = new System.Drawing.Size(118, 15);
            this.ConLbl.TabIndex = 21;
            this.ConLbl.Text = "CONFIRM PASSWORD";
            // 
            // ConPassTxt
            // 
            this.ConPassTxt.BorderRadius = 10;
            this.ConPassTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConPassTxt.DefaultText = "";
            this.ConPassTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConPassTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConPassTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConPassTxt.DisabledState.Parent = this.ConPassTxt;
            this.ConPassTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConPassTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConPassTxt.FocusedState.Parent = this.ConPassTxt;
            this.ConPassTxt.ForeColor = System.Drawing.Color.Black;
            this.ConPassTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ConPassTxt.HoverState.Parent = this.ConPassTxt;
            this.ConPassTxt.Location = new System.Drawing.Point(130, 282);
            this.ConPassTxt.Name = "ConPassTxt";
            this.ConPassTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ConPassTxt.PasswordChar = '•';
            this.ConPassTxt.PlaceholderText = "";
            this.ConPassTxt.SelectedText = "";
            this.ConPassTxt.ShadowDecoration.Parent = this.ConPassTxt;
            this.ConPassTxt.Size = new System.Drawing.Size(231, 35);
            this.ConPassTxt.TabIndex = 20;
            // 
            // passLbl
            // 
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.ForeColor = System.Drawing.Color.White;
            this.passLbl.Location = new System.Drawing.Point(130, 190);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(106, 15);
            this.passLbl.TabIndex = 19;
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
            this.passTxt.Location = new System.Drawing.Point(130, 211);
            this.passTxt.Name = "passTxt";
            this.passTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.passTxt.PasswordChar = '•';
            this.passTxt.PlaceholderText = "";
            this.passTxt.SelectedText = "";
            this.passTxt.ShadowDecoration.Parent = this.passTxt;
            this.passTxt.Size = new System.Drawing.Size(231, 35);
            this.passTxt.TabIndex = 18;
            // 
            // UserLbl
            // 
            this.UserLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.ForeColor = System.Drawing.Color.White;
            this.UserLbl.Location = new System.Drawing.Point(132, 119);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(104, 15);
            this.UserLbl.TabIndex = 17;
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
            this.userTxt.Location = new System.Drawing.Point(130, 140);
            this.userTxt.Name = "userTxt";
            this.userTxt.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.userTxt.PasswordChar = '\0';
            this.userTxt.PlaceholderText = "";
            this.userTxt.SelectedText = "";
            this.userTxt.ShadowDecoration.Parent = this.userTxt;
            this.userTxt.Size = new System.Drawing.Size(231, 35);
            this.userTxt.TabIndex = 16;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Transparent;
            this.Header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(129, 58);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(237, 34);
            this.Header.TabIndex = 27;
            this.Header.Text = "MAKE AN ACCOUNT";
            this.Header.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conEye
            // 
            this.conEye.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("conEye.CheckedState.Image")));
            this.conEye.CheckedState.Parent = this.conEye;
            this.conEye.HoverState.Parent = this.conEye;
            this.conEye.Image = global::GWT_V2.Properties.Resources.eye_closed;
            this.conEye.Location = new System.Drawing.Point(379, 288);
            this.conEye.Name = "conEye";
            this.conEye.PressedState.Parent = this.conEye;
            this.conEye.Size = new System.Drawing.Size(27, 23);
            this.conEye.TabIndex = 26;
            this.conEye.CheckedChanged += new System.EventHandler(this.conEye_CheckedChanged);
            // 
            // passEye
            // 
            this.passEye.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("passEye.CheckedState.Image")));
            this.passEye.CheckedState.Parent = this.passEye;
            this.passEye.HoverState.Parent = this.passEye;
            this.passEye.Image = global::GWT_V2.Properties.Resources.eye_closed;
            this.passEye.Location = new System.Drawing.Point(379, 216);
            this.passEye.Name = "passEye";
            this.passEye.PressedState.Parent = this.passEye;
            this.passEye.Size = new System.Drawing.Size(27, 23);
            this.passEye.TabIndex = 25;
            this.passEye.CheckedChanged += new System.EventHandler(this.passEye_CheckedChanged);
            // 
            // loading11
            // 
            this.loading11.BackColor = System.Drawing.Color.Transparent;
            this.loading11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loading11.Location = new System.Drawing.Point(502, 0);
            this.loading11.Name = "loading11";
            this.loading11.Size = new System.Drawing.Size(500, 474);
            this.loading11.TabIndex = 28;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(21, 434);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 20);
            this.linkLabel1.TabIndex = 34;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Skip";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(500, 474);
            this.Controls.Add(this.loading11);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.conEye);
            this.Controls.Add(this.passEye);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.ConLbl);
            this.Controls.Add(this.ConPassTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.linkLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Header;
        private Guna.UI2.WinForms.Guna2ImageCheckBox conEye;
        private Guna.UI2.WinForms.Guna2ImageCheckBox passEye;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private System.Windows.Forms.LinkLabel loginLink;
        private Guna.UI2.WinForms.Guna2HtmlLabel ConLbl;
        private Guna.UI2.WinForms.Guna2TextBox ConPassTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel passLbl;
        private Guna.UI2.WinForms.Guna2TextBox passTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel UserLbl;
        private Guna.UI2.WinForms.Guna2TextBox userTxt;
        private Loading1 loading11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}