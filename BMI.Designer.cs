﻿
namespace GWT_V2
{
    partial class BMI
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
            this.bmiDisplayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.commentLbl = new System.Windows.Forms.Label();
            this.bmiNumLbl = new System.Windows.Forms.Label();
            this.BmiPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.kgBtn = new Guna.UI2.WinForms.Guna2Button();
            this.lbsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.mBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ftBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weightTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.heightTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.headerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bodyLbl = new System.Windows.Forms.Label();
            this.bmiDisplayPanel.SuspendLayout();
            this.BmiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bmiDisplayPanel
            // 
            this.bmiDisplayPanel.BorderRadius = 20;
            this.bmiDisplayPanel.Controls.Add(this.commentLbl);
            this.bmiDisplayPanel.Controls.Add(this.bmiNumLbl);
            this.bmiDisplayPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.bmiDisplayPanel.Location = new System.Drawing.Point(428, 375);
            this.bmiDisplayPanel.Name = "bmiDisplayPanel";
            this.bmiDisplayPanel.ShadowDecoration.Parent = this.bmiDisplayPanel;
            this.bmiDisplayPanel.Size = new System.Drawing.Size(264, 97);
            this.bmiDisplayPanel.TabIndex = 35;
            this.bmiDisplayPanel.Visible = false;
            // 
            // commentLbl
            // 
            this.commentLbl.BackColor = System.Drawing.Color.Transparent;
            this.commentLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLbl.ForeColor = System.Drawing.Color.White;
            this.commentLbl.Location = new System.Drawing.Point(101, 0);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(163, 104);
            this.commentLbl.TabIndex = 1;
            this.commentLbl.Text = "You\'ve Got a great shape";
            this.commentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.commentLbl.Click += new System.EventHandler(this.commentLbl_Click);
            // 
            // bmiNumLbl
            // 
            this.bmiNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.bmiNumLbl.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiNumLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.bmiNumLbl.Location = new System.Drawing.Point(3, 0);
            this.bmiNumLbl.Name = "bmiNumLbl";
            this.bmiNumLbl.Size = new System.Drawing.Size(92, 97);
            this.bmiNumLbl.TabIndex = 0;
            this.bmiNumLbl.Text = "22";
            this.bmiNumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BmiPanel
            // 
            this.BmiPanel.BackColor = System.Drawing.Color.Transparent;
            this.BmiPanel.BorderRadius = 15;
            this.BmiPanel.Controls.Add(this.label3);
            this.BmiPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BmiPanel.Location = new System.Drawing.Point(460, 324);
            this.BmiPanel.Name = "BmiPanel";
            this.BmiPanel.ShadowDecoration.Parent = this.BmiPanel;
            this.BmiPanel.Size = new System.Drawing.Size(201, 32);
            this.BmiPanel.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "YOUR CURRENT BMI";
            // 
            // kgBtn
            // 
            this.kgBtn.BackColor = System.Drawing.Color.Transparent;
            this.kgBtn.BorderColor = System.Drawing.Color.White;
            this.kgBtn.BorderRadius = 12;
            this.kgBtn.BorderThickness = 1;
            this.kgBtn.CheckedState.Parent = this.kgBtn;
            this.kgBtn.CustomImages.Parent = this.kgBtn;
            this.kgBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.kgBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kgBtn.ForeColor = System.Drawing.Color.White;
            this.kgBtn.HoverState.Parent = this.kgBtn;
            this.kgBtn.Location = new System.Drawing.Point(675, 268);
            this.kgBtn.Name = "kgBtn";
            this.kgBtn.ShadowDecoration.Parent = this.kgBtn;
            this.kgBtn.Size = new System.Drawing.Size(47, 26);
            this.kgBtn.TabIndex = 32;
            this.kgBtn.Text = "kg";
            this.kgBtn.UseTransparentBackground = true;
            this.kgBtn.Click += new System.EventHandler(this.kgBtn_Click);
            // 
            // lbsBtn
            // 
            this.lbsBtn.BackColor = System.Drawing.Color.Transparent;
            this.lbsBtn.BorderColor = System.Drawing.Color.White;
            this.lbsBtn.BorderRadius = 12;
            this.lbsBtn.CheckedState.Parent = this.lbsBtn;
            this.lbsBtn.CustomImages.Parent = this.lbsBtn;
            this.lbsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.lbsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbsBtn.ForeColor = System.Drawing.Color.White;
            this.lbsBtn.HoverState.Parent = this.lbsBtn;
            this.lbsBtn.Location = new System.Drawing.Point(710, 268);
            this.lbsBtn.Name = "lbsBtn";
            this.lbsBtn.ShadowDecoration.Parent = this.lbsBtn;
            this.lbsBtn.Size = new System.Drawing.Size(47, 26);
            this.lbsBtn.TabIndex = 33;
            this.lbsBtn.Text = "lbs";
            this.lbsBtn.UseTransparentBackground = true;
            this.lbsBtn.Click += new System.EventHandler(this.lbsBtn_Click);
            // 
            // mBtn
            // 
            this.mBtn.BackColor = System.Drawing.Color.Transparent;
            this.mBtn.BorderColor = System.Drawing.Color.White;
            this.mBtn.BorderRadius = 12;
            this.mBtn.BorderThickness = 1;
            this.mBtn.CheckedState.Parent = this.mBtn;
            this.mBtn.CustomImages.Parent = this.mBtn;
            this.mBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(105)))), ((int)(((byte)(114)))));
            this.mBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mBtn.ForeColor = System.Drawing.Color.White;
            this.mBtn.HoverState.Parent = this.mBtn;
            this.mBtn.Location = new System.Drawing.Point(345, 268);
            this.mBtn.Name = "mBtn";
            this.mBtn.ShadowDecoration.Parent = this.mBtn;
            this.mBtn.Size = new System.Drawing.Size(47, 26);
            this.mBtn.TabIndex = 30;
            this.mBtn.Text = "m";
            this.mBtn.UseTransparentBackground = true;
            this.mBtn.Click += new System.EventHandler(this.mBtn_Click);
            // 
            // ftBtn
            // 
            this.ftBtn.BackColor = System.Drawing.Color.Transparent;
            this.ftBtn.BorderColor = System.Drawing.Color.White;
            this.ftBtn.BorderRadius = 12;
            this.ftBtn.CheckedState.Parent = this.ftBtn;
            this.ftBtn.CustomImages.Parent = this.ftBtn;
            this.ftBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(44)))), ((int)(((byte)(87)))));
            this.ftBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ftBtn.ForeColor = System.Drawing.Color.White;
            this.ftBtn.HoverState.Parent = this.ftBtn;
            this.ftBtn.Location = new System.Drawing.Point(380, 268);
            this.ftBtn.Name = "ftBtn";
            this.ftBtn.ShadowDecoration.Parent = this.ftBtn;
            this.ftBtn.Size = new System.Drawing.Size(47, 26);
            this.ftBtn.TabIndex = 31;
            this.ftBtn.Text = "ft";
            this.ftBtn.UseTransparentBackground = true;
            this.ftBtn.Click += new System.EventHandler(this.ftBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(641, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "WEIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "HEIGHT";
            // 
            // weightTxt
            // 
            this.weightTxt.BorderRadius = 10;
            this.weightTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weightTxt.DefaultText = "0";
            this.weightTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.weightTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.weightTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightTxt.DisabledState.Parent = this.weightTxt;
            this.weightTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.weightTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightTxt.FocusedState.Parent = this.weightTxt;
            this.weightTxt.ForeColor = System.Drawing.Color.Black;
            this.weightTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.weightTxt.HoverState.Parent = this.weightTxt;
            this.weightTxt.Location = new System.Drawing.Point(635, 200);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.PasswordChar = '\0';
            this.weightTxt.PlaceholderText = "";
            this.weightTxt.SelectedText = "";
            this.weightTxt.SelectionStart = 1;
            this.weightTxt.ShadowDecoration.Parent = this.weightTxt;
            this.weightTxt.Size = new System.Drawing.Size(167, 51);
            this.weightTxt.TabIndex = 27;
            this.weightTxt.TextChanged += new System.EventHandler(this.weightTxt_TextChanged);
            this.weightTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTxt_KeyPress);
            // 
            // heightTxt
            // 
            this.heightTxt.BorderRadius = 10;
            this.heightTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.heightTxt.DefaultText = "0";
            this.heightTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.heightTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.heightTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.heightTxt.DisabledState.Parent = this.heightTxt;
            this.heightTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.heightTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.heightTxt.FocusedState.Parent = this.heightTxt;
            this.heightTxt.ForeColor = System.Drawing.Color.Black;
            this.heightTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.heightTxt.HoverState.Parent = this.heightTxt;
            this.heightTxt.Location = new System.Drawing.Point(314, 200);
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.PasswordChar = '\0';
            this.heightTxt.PlaceholderText = "";
            this.heightTxt.SelectedText = "";
            this.heightTxt.SelectionStart = 1;
            this.heightTxt.ShadowDecoration.Parent = this.heightTxt;
            this.heightTxt.Size = new System.Drawing.Size(167, 51);
            this.heightTxt.TabIndex = 26;
            this.heightTxt.TextChanged += new System.EventHandler(this.heightTxt_TextChanged);
            this.heightTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTxt_KeyPress);
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = false;
            this.headerLbl.BackColor = System.Drawing.Color.Transparent;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.Color.White;
            this.headerLbl.Location = new System.Drawing.Point(338, 28);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(454, 93);
            this.headerLbl.TabIndex = 25;
            this.headerLbl.Text = "WHAT’S YOUR HEIGHT AND WEIGHT?";
            this.headerLbl.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bodyLbl
            // 
            this.bodyLbl.AutoSize = true;
            this.bodyLbl.BackColor = System.Drawing.Color.Transparent;
            this.bodyLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bodyLbl.Location = new System.Drawing.Point(530, 479);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.Size = new System.Drawing.Size(0, 17);
            this.bodyLbl.TabIndex = 36;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bodyLbl);
            this.Controls.Add(this.bmiDisplayPanel);
            this.Controls.Add(this.BmiPanel);
            this.Controls.Add(this.kgBtn);
            this.Controls.Add(this.lbsBtn);
            this.Controls.Add(this.mBtn);
            this.Controls.Add(this.ftBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weightTxt);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.headerLbl);
            this.Name = "BMI";
            this.Size = new System.Drawing.Size(1099, 506);
            this.Load += new System.EventHandler(this.BMI_Load);
            this.bmiDisplayPanel.ResumeLayout(false);
            this.BmiPanel.ResumeLayout(false);
            this.BmiPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel bmiDisplayPanel;
        private System.Windows.Forms.Label commentLbl;
        private System.Windows.Forms.Label bmiNumLbl;
        public Guna.UI2.WinForms.Guna2Panel BmiPanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button kgBtn;
        private Guna.UI2.WinForms.Guna2Button lbsBtn;
        private Guna.UI2.WinForms.Guna2Button mBtn;
        private Guna.UI2.WinForms.Guna2Button ftBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox weightTxt;
        public Guna.UI2.WinForms.Guna2TextBox heightTxt;
        private Guna.UI2.WinForms.Guna2HtmlLabel headerLbl;
        private System.Windows.Forms.Label bodyLbl;
    }
}
