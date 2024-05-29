
namespace GWT_V2
{
    partial class Gender
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
            this.femaleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.maleBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.femaleLbl = new System.Windows.Forms.Label();
            this.maleLbl = new System.Windows.Forms.Label();
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // femaleBtn
            // 
            this.femaleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.CheckedState.Parent = this.femaleBtn;
            this.femaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.HoverState.Parent = this.femaleBtn;
            this.femaleBtn.Image = global::GWT_V2.Properties.Resources.femaleGWT;
            this.femaleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.Location = new System.Drawing.Point(647, 153);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.PressedState.ImageSize = new System.Drawing.Size(260, 419);
            this.femaleBtn.PressedState.Parent = this.femaleBtn;
            this.femaleBtn.Size = new System.Drawing.Size(260, 419);
            this.femaleBtn.TabIndex = 11;
            this.femaleBtn.Click += new System.EventHandler(this.femaleBtn_Click);
            // 
            // maleBtn
            // 
            this.maleBtn.CheckedState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.CheckedState.Parent = this.maleBtn;
            this.maleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleBtn.HoverState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.HoverState.Parent = this.maleBtn;
            this.maleBtn.Image = global::GWT_V2.Properties.Resources.maleGWT;
            this.maleBtn.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.Location = new System.Drawing.Point(196, 153);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.PressedState.ImageSize = new System.Drawing.Size(260, 419);
            this.maleBtn.PressedState.Parent = this.maleBtn;
            this.maleBtn.Size = new System.Drawing.Size(260, 419);
            this.maleBtn.TabIndex = 10;
            this.maleBtn.Click += new System.EventHandler(this.maleBtn_Click);
            // 
            // femaleLbl
            // 
            this.femaleLbl.AutoSize = true;
            this.femaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleLbl.ForeColor = System.Drawing.Color.White;
            this.femaleLbl.Location = new System.Drawing.Point(730, 125);
            this.femaleLbl.Name = "femaleLbl";
            this.femaleLbl.Size = new System.Drawing.Size(103, 25);
            this.femaleLbl.TabIndex = 9;
            this.femaleLbl.Text = "FEMALE";
            // 
            // maleLbl
            // 
            this.maleLbl.AutoSize = true;
            this.maleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleLbl.ForeColor = System.Drawing.Color.White;
            this.maleLbl.Location = new System.Drawing.Point(267, 125);
            this.maleLbl.Name = "maleLbl";
            this.maleLbl.Size = new System.Drawing.Size(74, 25);
            this.maleLbl.TabIndex = 8;
            this.maleLbl.Text = "MALE";
            // 
            // headerLbl
            // 
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(300, 40);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(504, 46);
            this.headerLbl.TabIndex = 7;
            this.headerLbl.Text = "WHAT IS YOUR GENDER?";
            this.headerLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Gender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.femaleBtn);
            this.Controls.Add(this.maleBtn);
            this.Controls.Add(this.femaleLbl);
            this.Controls.Add(this.maleLbl);
            this.Controls.Add(this.headerLbl);
            this.Name = "Gender";
            this.Size = new System.Drawing.Size(1102, 572);
            this.Load += new System.EventHandler(this.Gender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton femaleBtn;
        private Guna.UI2.WinForms.Guna2ImageButton maleBtn;
        private System.Windows.Forms.Label femaleLbl;
        private System.Windows.Forms.Label maleLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
