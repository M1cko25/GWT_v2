
namespace GWT_V2
{
    partial class Setup
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
            this.BtnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BtnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bmi1 = new GWT_V2.BMI();
            this.gender1 = new GWT_V2.Gender();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loading21 = new GWT_V2.loading2();
            this.areas1 = new GWT_V2.Areas();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 1;
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
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Transparent;
            this.BtnBack.CheckedState.Parent = this.BtnBack;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.HoverState.Parent = this.BtnBack;
            this.BtnBack.Image = global::GWT_V2.Properties.Resources.mingcute_back_fill;
            this.BtnBack.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.Location = new System.Drawing.Point(36, 550);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnBack.PressedState.Parent = this.BtnBack;
            this.BtnBack.Size = new System.Drawing.Size(48, 48);
            this.BtnBack.TabIndex = 14;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.CheckedState.Parent = this.BtnNext;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.HoverState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.HoverState.Parent = this.BtnNext;
            this.BtnNext.Image = global::GWT_V2.Properties.Resources.carbon_next_outline1;
            this.BtnNext.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.Location = new System.Drawing.Point(1031, 550);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.PressedState.ImageSize = new System.Drawing.Size(48, 48);
            this.BtnNext.PressedState.Parent = this.BtnNext;
            this.BtnNext.Size = new System.Drawing.Size(48, 48);
            this.BtnNext.TabIndex = 15;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bmi1
            // 
            this.bmi1.BackColor = System.Drawing.Color.Transparent;
            this.bmi1.bmi = 0D;
            this.bmi1.bodyType = null;
            this.bmi1.Location = new System.Drawing.Point(3, 38);
            this.bmi1.Name = "bmi1";
            this.bmi1.Size = new System.Drawing.Size(1099, 506);
            this.bmi1.TabIndex = 20;
            // 
            // gender1
            // 
            this.gender1.BackColor = System.Drawing.Color.Transparent;
            this.gender1.gender = null;
            this.gender1.Location = new System.Drawing.Point(0, 38);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(1102, 572);
            this.gender1.TabIndex = 22;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // loading21
            // 
            this.loading21.BackColor = System.Drawing.Color.Transparent;
            this.loading21.Location = new System.Drawing.Point(1105, 0);
            this.loading21.Name = "loading21";
            this.loading21.Size = new System.Drawing.Size(1102, 612);
            this.loading21.TabIndex = 23;
            // 
            // areas1
            // 
            this.areas1.BackColor = System.Drawing.Color.Transparent;
            this.areas1.Location = new System.Drawing.Point(0, 38);
            this.areas1.Name = "areas1";
            this.areas1.Size = new System.Drawing.Size(1099, 484);
            this.areas1.TabIndex = 24;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GWT_V2.Properties.Resources.blurred_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.gender1);
            this.Controls.Add(this.loading21);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.areas1);
            this.Controls.Add(this.bmi1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.Setup_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton BtnNext;
        private Guna.UI2.WinForms.Guna2ImageButton BtnBack;
        private System.Windows.Forms.Timer timer1;
        private BMI bmi1;
        private Gender gender1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private loading2 loading21;
        private Areas areas1;
    }
}