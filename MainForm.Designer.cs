
namespace GWT_V2
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NavPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.signOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.profileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.reportBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exercisesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.trainingBtn = new Guna.UI2.WinForms.Guna2Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.training1 = new GWT_V2.Training();
            this.exercises1 = new GWT_V2.Exercises();
            this.reports1 = new GWT_V2.Reports();
            this.profile1 = new GWT_V2.Profile();
            this.panel1.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2CircleButton1);
            this.panel1.Controls.Add(this.guna2ImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 40);
            this.panel1.TabIndex = 2;
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
            this.guna2CircleButton1.Location = new System.Drawing.Point(1011, 7);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.TabIndex = 2;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::GWT_V2.Properties.Resources.closeBtn;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1054, 7);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Transparent;
            this.NavPanel.BorderRadius = 15;
            this.NavPanel.Controls.Add(this.signOutBtn);
            this.NavPanel.Controls.Add(this.profileBtn);
            this.NavPanel.Controls.Add(this.reportBtn);
            this.NavPanel.Controls.Add(this.exercisesBtn);
            this.NavPanel.Controls.Add(this.trainingBtn);
            this.NavPanel.Controls.Add(this.usernameLbl);
            this.NavPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.NavPanel.Location = new System.Drawing.Point(12, 8);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.ShadowDecoration.Parent = this.NavPanel;
            this.NavPanel.Size = new System.Drawing.Size(248, 554);
            this.NavPanel.TabIndex = 4;
            // 
            // signOutBtn
            // 
            this.signOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.BorderRadius = 10;
            this.signOutBtn.CheckedState.Parent = this.signOutBtn;
            this.signOutBtn.CustomImages.Parent = this.signOutBtn;
            this.signOutBtn.FillColor = System.Drawing.Color.Gray;
            this.signOutBtn.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.ForeColor = System.Drawing.Color.Black;
            this.signOutBtn.HoverState.Parent = this.signOutBtn;
            this.signOutBtn.Image = global::GWT_V2.Properties.Resources.Logout_Rounded_Left__1_;
            this.signOutBtn.Location = new System.Drawing.Point(12, 495);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.ShadowDecoration.Parent = this.signOutBtn;
            this.signOutBtn.Size = new System.Drawing.Size(120, 42);
            this.signOutBtn.TabIndex = 10;
            this.signOutBtn.Text = "Sign Out";
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.CheckedState.Parent = this.profileBtn;
            this.profileBtn.CustomImages.Parent = this.profileBtn;
            this.profileBtn.FillColor = System.Drawing.Color.Transparent;
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.HoverState.Parent = this.profileBtn;
            this.profileBtn.ImageOffset = new System.Drawing.Point(-7, 0);
            this.profileBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.profileBtn.Location = new System.Drawing.Point(0, 288);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.ShadowDecoration.Parent = this.profileBtn;
            this.profileBtn.Size = new System.Drawing.Size(248, 52);
            this.profileBtn.TabIndex = 3;
            this.profileBtn.Text = "PROFILE";
            this.profileBtn.TextOffset = new System.Drawing.Point(-7, 0);
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.CheckedState.Parent = this.reportBtn;
            this.reportBtn.CustomImages.Parent = this.reportBtn;
            this.reportBtn.FillColor = System.Drawing.Color.Transparent;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.HoverState.Parent = this.reportBtn;
            this.reportBtn.ImageOffset = new System.Drawing.Point(-7, 0);
            this.reportBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.reportBtn.Location = new System.Drawing.Point(0, 235);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.ShadowDecoration.Parent = this.reportBtn;
            this.reportBtn.Size = new System.Drawing.Size(248, 52);
            this.reportBtn.TabIndex = 2;
            this.reportBtn.Text = "REPORT";
            this.reportBtn.TextOffset = new System.Drawing.Point(-7, 0);
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // exercisesBtn
            // 
            this.exercisesBtn.CheckedState.Parent = this.exercisesBtn;
            this.exercisesBtn.CustomImages.Parent = this.exercisesBtn;
            this.exercisesBtn.FillColor = System.Drawing.Color.Transparent;
            this.exercisesBtn.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exercisesBtn.ForeColor = System.Drawing.Color.White;
            this.exercisesBtn.HoverState.Parent = this.exercisesBtn;
            this.exercisesBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.exercisesBtn.Location = new System.Drawing.Point(0, 182);
            this.exercisesBtn.Name = "exercisesBtn";
            this.exercisesBtn.ShadowDecoration.Parent = this.exercisesBtn;
            this.exercisesBtn.Size = new System.Drawing.Size(248, 52);
            this.exercisesBtn.TabIndex = 1;
            this.exercisesBtn.Text = "EXERCISES";
            this.exercisesBtn.Click += new System.EventHandler(this.exercisesBtn_Click);
            // 
            // trainingBtn
            // 
            this.trainingBtn.CheckedState.Parent = this.trainingBtn;
            this.trainingBtn.CustomImages.Parent = this.trainingBtn;
            this.trainingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.trainingBtn.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingBtn.ForeColor = System.Drawing.Color.White;
            this.trainingBtn.HoverState.Parent = this.trainingBtn;
            this.trainingBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.trainingBtn.Location = new System.Drawing.Point(0, 129);
            this.trainingBtn.Name = "trainingBtn";
            this.trainingBtn.ShadowDecoration.Parent = this.trainingBtn;
            this.trainingBtn.Size = new System.Drawing.Size(248, 52);
            this.trainingBtn.TabIndex = 0;
            this.trainingBtn.Text = "TRAINING";
            this.trainingBtn.Click += new System.EventHandler(this.trainingBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoEllipsis = true;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(21, 38);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(224, 45);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "ME";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.NavPanel);
            this.guna2Panel1.Controls.Add(this.training1);
            this.guna2Panel1.Controls.Add(this.exercises1);
            this.guna2Panel1.Controls.Add(this.reports1);
            this.guna2Panel1.Controls.Add(this.profile1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 43);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1102, 569);
            this.guna2Panel1.TabIndex = 6;
            // 
            // training1
            // 
            this.training1.AutoScroll = true;
            this.training1.BackColor = System.Drawing.Color.Transparent;
            this.training1.Location = new System.Drawing.Point(266, 8);
            this.training1.Name = "training1";
            this.training1.Size = new System.Drawing.Size(860, 554);
            this.training1.TabIndex = 5;
            // 
            // exercises1
            // 
            this.exercises1.AutoScroll = true;
            this.exercises1.BackColor = System.Drawing.Color.Transparent;
            this.exercises1.Location = new System.Drawing.Point(266, 8);
            this.exercises1.Name = "exercises1";
            this.exercises1.Size = new System.Drawing.Size(860, 554);
            this.exercises1.TabIndex = 6;
            this.exercises1.Load += new System.EventHandler(this.exercises1_Load);
            // 
            // reports1
            // 
            this.reports1.AutoScroll = true;
            this.reports1.BackColor = System.Drawing.Color.Transparent;
            this.reports1.Location = new System.Drawing.Point(266, 8);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(860, 554);
            this.reports1.TabIndex = 7;
            // 
            // profile1
            // 
            this.profile1.BackColor = System.Drawing.Color.Transparent;
            this.profile1.Location = new System.Drawing.Point(263, 8);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(860, 554);
            this.profile1.TabIndex = 8;
            this.profile1.user = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.NavPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel NavPanel;
        private Guna.UI2.WinForms.Guna2Button profileBtn;
        private Guna.UI2.WinForms.Guna2Button reportBtn;
        private Guna.UI2.WinForms.Guna2Button exercisesBtn;
        private Guna.UI2.WinForms.Guna2Button trainingBtn;
        private Training training1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Exercises exercises1;
        private Reports reports1;
        private Guna.UI2.WinForms.Guna2Button signOutBtn;
        public System.Windows.Forms.Label usernameLbl;
        private Profile profile1;
    }
}