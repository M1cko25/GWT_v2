
namespace GWT_V2
{
    partial class Routine
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.RoutMainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SecondLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinuteLbl = new System.Windows.Forms.Label();
            this.HourLbl = new System.Windows.Forms.Label();
            this.routContentPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.nextSetBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExerciseName = new System.Windows.Forms.Label();
            this.setPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.exerciseGif = new Guna.UI2.WinForms.Guna2PictureBox();
            this.routineLbl = new System.Windows.Forms.Label();
            this.backBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.RoutMainPanel.SuspendLayout();
            this.routContentPanel.SuspendLayout();
            this.setPanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseGif)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.panel1.TabIndex = 4;
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
            // RoutMainPanel
            // 
            this.RoutMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.RoutMainPanel.Controls.Add(this.label3);
            this.RoutMainPanel.Controls.Add(this.SecondLbl);
            this.RoutMainPanel.Controls.Add(this.label5);
            this.RoutMainPanel.Controls.Add(this.MinuteLbl);
            this.RoutMainPanel.Controls.Add(this.HourLbl);
            this.RoutMainPanel.Controls.Add(this.routContentPanel);
            this.RoutMainPanel.Controls.Add(this.routineLbl);
            this.RoutMainPanel.Location = new System.Drawing.Point(0, 46);
            this.RoutMainPanel.Name = "RoutMainPanel";
            this.RoutMainPanel.ShadowDecoration.Parent = this.RoutMainPanel;
            this.RoutMainPanel.Size = new System.Drawing.Size(1098, 567);
            this.RoutMainPanel.TabIndex = 8;
            this.RoutMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoutMainPanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(989, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // SecondLbl
            // 
            this.SecondLbl.AutoSize = true;
            this.SecondLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondLbl.ForeColor = System.Drawing.Color.White;
            this.SecondLbl.Location = new System.Drawing.Point(1006, 37);
            this.SecondLbl.Name = "SecondLbl";
            this.SecondLbl.Size = new System.Drawing.Size(22, 17);
            this.SecondLbl.TabIndex = 16;
            this.SecondLbl.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(944, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = ":";
            // 
            // MinuteLbl
            // 
            this.MinuteLbl.AutoSize = true;
            this.MinuteLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteLbl.ForeColor = System.Drawing.Color.White;
            this.MinuteLbl.Location = new System.Drawing.Point(961, 37);
            this.MinuteLbl.Name = "MinuteLbl";
            this.MinuteLbl.Size = new System.Drawing.Size(22, 17);
            this.MinuteLbl.TabIndex = 11;
            this.MinuteLbl.Text = "00";
            // 
            // HourLbl
            // 
            this.HourLbl.AutoSize = true;
            this.HourLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourLbl.ForeColor = System.Drawing.Color.White;
            this.HourLbl.Location = new System.Drawing.Point(916, 37);
            this.HourLbl.Name = "HourLbl";
            this.HourLbl.Size = new System.Drawing.Size(22, 17);
            this.HourLbl.TabIndex = 10;
            this.HourLbl.Text = "00";
            // 
            // routContentPanel
            // 
            this.routContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.routContentPanel.BorderRadius = 20;
            this.routContentPanel.Controls.Add(this.nextSetBtn);
            this.routContentPanel.Controls.Add(this.ExerciseName);
            this.routContentPanel.Controls.Add(this.setPanel);
            this.routContentPanel.Controls.Add(this.exerciseGif);
            this.routContentPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.routContentPanel.Location = new System.Drawing.Point(25, 71);
            this.routContentPanel.Name = "routContentPanel";
            this.routContentPanel.ShadowDecoration.Parent = this.routContentPanel;
            this.routContentPanel.Size = new System.Drawing.Size(1054, 471);
            this.routContentPanel.TabIndex = 9;
            // 
            // nextSetBtn
            // 
            this.nextSetBtn.BorderRadius = 20;
            this.nextSetBtn.CheckedState.Parent = this.nextSetBtn;
            this.nextSetBtn.CustomImages.Parent = this.nextSetBtn;
            this.nextSetBtn.Enabled = false;
            this.nextSetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.nextSetBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextSetBtn.ForeColor = System.Drawing.Color.White;
            this.nextSetBtn.HoverState.Parent = this.nextSetBtn;
            this.nextSetBtn.Location = new System.Drawing.Point(636, 387);
            this.nextSetBtn.Name = "nextSetBtn";
            this.nextSetBtn.ShadowDecoration.Parent = this.nextSetBtn;
            this.nextSetBtn.Size = new System.Drawing.Size(238, 64);
            this.nextSetBtn.TabIndex = 4;
            this.nextSetBtn.Text = "NEXT";
            this.nextSetBtn.Click += new System.EventHandler(this.nextSetBtn_Click);
            // 
            // ExerciseName
            // 
            this.ExerciseName.AutoSize = true;
            this.ExerciseName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseName.ForeColor = System.Drawing.Color.Black;
            this.ExerciseName.Location = new System.Drawing.Point(87, 387);
            this.ExerciseName.Name = "ExerciseName";
            this.ExerciseName.Size = new System.Drawing.Size(331, 32);
            this.ExerciseName.TabIndex = 2;
            this.ExerciseName.Text = "Alternating Renegade Rows";
            // 
            // setPanel
            // 
            this.setPanel.Controls.Add(this.guna2Panel4);
            this.setPanel.Controls.Add(this.guna2Panel5);
            this.setPanel.Controls.Add(this.guna2Panel6);
            this.setPanel.Controls.Add(this.guna2Panel2);
            this.setPanel.Location = new System.Drawing.Point(513, 35);
            this.setPanel.Name = "setPanel";
            this.setPanel.ShadowDecoration.Parent = this.setPanel;
            this.setPanel.Size = new System.Drawing.Size(472, 330);
            this.setPanel.TabIndex = 1;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BorderRadius = 15;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel4.Location = new System.Drawing.Point(70, 92);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(330, 64);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BorderRadius = 15;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel5.Location = new System.Drawing.Point(70, 171);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(330, 64);
            this.guna2Panel5.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel6.Location = new System.Drawing.Point(70, 254);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(330, 64);
            this.guna2Panel6.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.Controls.Add(this.guna2CheckBox1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Location = new System.Drawing.Point(70, 13);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(330, 64);
            this.guna2Panel2.TabIndex = 0;
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 2;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CheckBox1.Location = new System.Drawing.Point(13, 7);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(306, 50);
            this.guna2CheckBox1.TabIndex = 0;
            this.guna2CheckBox1.Text = "Set 1 x 8 reps";
            this.guna2CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 2;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UseVisualStyleBackColor = true;
            // 
            // exerciseGif
            // 
            this.exerciseGif.Location = new System.Drawing.Point(35, 35);
            this.exerciseGif.Name = "exerciseGif";
            this.exerciseGif.ShadowDecoration.Parent = this.exerciseGif;
            this.exerciseGif.Size = new System.Drawing.Size(457, 318);
            this.exerciseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exerciseGif.TabIndex = 0;
            this.exerciseGif.TabStop = false;
            // 
            // routineLbl
            // 
            this.routineLbl.AutoSize = true;
            this.routineLbl.BackColor = System.Drawing.Color.Transparent;
            this.routineLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routineLbl.ForeColor = System.Drawing.Color.White;
            this.routineLbl.Location = new System.Drawing.Point(452, 15);
            this.routineLbl.Name = "routineLbl";
            this.routineLbl.Size = new System.Drawing.Size(254, 45);
            this.routineLbl.TabIndex = 4;
            this.routineLbl.Text = "ABS WORKOUT";
            // 
            // backBtn
            // 
            this.backBtn.CheckedState.Parent = this.backBtn;
            this.backBtn.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.backBtn.HoverState.Parent = this.backBtn;
            this.backBtn.Image = global::GWT_V2.Properties.Resources.mingcute_back_fill;
            this.backBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.backBtn.Location = new System.Drawing.Point(20, 60);
            this.backBtn.Name = "backBtn";
            this.backBtn.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.backBtn.PressedState.Parent = this.backBtn;
            this.backBtn.Size = new System.Drawing.Size(50, 50);
            this.backBtn.TabIndex = 5;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Routine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RoutMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Routine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Routine";
            this.panel1.ResumeLayout(false);
            this.RoutMainPanel.ResumeLayout(false);
            this.RoutMainPanel.PerformLayout();
            this.routContentPanel.ResumeLayout(false);
            this.routContentPanel.PerformLayout();
            this.setPanel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exerciseGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton backBtn;
        public Guna.UI2.WinForms.Guna2Panel RoutMainPanel;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label SecondLbl;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label MinuteLbl;
        public System.Windows.Forms.Label HourLbl;
        public Guna.UI2.WinForms.Guna2Panel routContentPanel;
        public System.Windows.Forms.Label ExerciseName;
        public Guna.UI2.WinForms.Guna2Panel setPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        public Guna.UI2.WinForms.Guna2PictureBox exerciseGif;
        public System.Windows.Forms.Label routineLbl;
        private Guna.UI2.WinForms.Guna2Button nextSetBtn;
        private System.Windows.Forms.Timer timer;
    }
}