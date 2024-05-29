
namespace GWT_V2
{
    partial class HistoryControl
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
            this.date = new System.Windows.Forms.Label();
            this.workout = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(3, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(145, 62);
            this.date.TabIndex = 1;
            this.date.Text = "24 minutes, 45 seconds";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // workout
            // 
            this.workout.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workout.Location = new System.Drawing.Point(144, 0);
            this.workout.Name = "workout";
            this.workout.Size = new System.Drawing.Size(456, 62);
            this.workout.TabIndex = 2;
            this.workout.Text = "24 minutes, 45 seconds";
            this.workout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(606, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(133, 62);
            this.time.TabIndex = 3;
            this.time.Text = "24 minutes, 45 seconds";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.time);
            this.Controls.Add(this.workout);
            this.Controls.Add(this.date);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(754, 62);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label date;
        public System.Windows.Forms.Label workout;
        public System.Windows.Forms.Label time;
    }
}
