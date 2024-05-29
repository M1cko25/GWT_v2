
namespace GWT_V2
{
    partial class Workout
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.demoPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.setReps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.demoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // demoPic
            // 
            this.demoPic.BackColor = System.Drawing.Color.Transparent;
            this.demoPic.Location = new System.Drawing.Point(24, 16);
            this.demoPic.Name = "demoPic";
            this.demoPic.ShadowDecoration.Parent = this.demoPic;
            this.demoPic.Size = new System.Drawing.Size(89, 61);
            this.demoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.demoPic.TabIndex = 0;
            this.demoPic.TabStop = false;
            // 
            // name
            // 
            this.name.AutoEllipsis = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(119, 16);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(343, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Reverse Crunch";
            // 
            // setReps
            // 
            this.setReps.AutoSize = true;
            this.setReps.BackColor = System.Drawing.Color.Transparent;
            this.setReps.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setReps.Location = new System.Drawing.Point(138, 49);
            this.setReps.Name = "setReps";
            this.setReps.Size = new System.Drawing.Size(100, 17);
            this.setReps.TabIndex = 2;
            this.setReps.Text = "4 sets x 12 reps";
            // 
            // Workout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.setReps);
            this.Controls.Add(this.name);
            this.Controls.Add(this.demoPic);
            this.Name = "Workout";
            this.Size = new System.Drawing.Size(484, 97);
            this.Load += new System.EventHandler(this.Workout_Load);
            this.Click += new System.EventHandler(this.Workout_Click);
            ((System.ComponentModel.ISupportInitialize)(this.demoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label setReps;
        public System.Windows.Forms.Label name;
        public Guna.UI2.WinForms.Guna2PictureBox demoPic;
    }
}
