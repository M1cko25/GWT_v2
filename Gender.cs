using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWT_V2
{
    public partial class Gender : UserControl
    {
        private int yOffset = 20;
        public string gender { get; set; }
        public Gender()
        {
            InitializeComponent();
        }

        private void maleBtn_Click(object sender, EventArgs e)
        {
            gender = "Male";
            this.Hide();
        }

        private void femaleBtn_Click(object sender, EventArgs e)
        {
            gender = "Female";
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yOffset = Math.Max(0, yOffset - 2);

            maleBtn.ImageOffset = new Point(0, yOffset);
            femaleBtn.ImageOffset = new Point(0, yOffset);

            if (yOffset == 0)
            {
                timer1.Stop();
            }
        }

        private void Gender_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
