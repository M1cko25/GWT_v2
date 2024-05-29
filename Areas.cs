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
    public partial class Areas : UserControl
    {
        public bool back = false, shoulder = false, arm = false, chest = false, abs = false, butt = false, leg = false, fullBody = false;
        public Areas()
        {
            InitializeComponent();
        }
        private void absBtn_Click(object sender, EventArgs e)
        {
            if (abs == false)
            {
                abs = true;
            }
            else
            {
                abs = false;
            }
            btntoggle(absBtn);
        }

        private void buttBtn_Click(object sender, EventArgs e)
        {
            if (butt == false)
            {
                butt = true;
            }
            else
            {
                butt = false;
            }
            btntoggle(buttBtn);
        }

        private void legBtn_Click(object sender, EventArgs e)
        {
            if (leg == false)
            {
                leg = true;
            }
            else
            {
                leg = false;
            }
            btntoggle(legBtn);
        }

        private void fullBodyBtn_Click(object sender, EventArgs e)
        {
            if (fullBody == false)
            {
                fullBody = true;
            }
            else
            {
                fullBody = false;
            }
            btntoggle(fullBodyBtn);
        }

        private void chestBtn_Click(object sender, EventArgs e)
        {
            if (chest == false)
            {
                chest = true;
            }
            else
            {
                chest = false;
            }
            btntoggle(chestBtn);
        }

        private void armBtn_Click(object sender, EventArgs e)
        {
            if (arm == false)
            {
                arm = true;
            }
            else
            {
                arm = false;
            }
            btntoggle(armBtn);
        }

        private void shouderBtn_Click(object sender, EventArgs e)
        {
            if (shoulder == false)
            {
                shoulder = true;
            }
            else
            {
                shoulder = false;
            }
            btntoggle(shouderBtn);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (back == false)
            {
                back = true;
            }
            else
            {
                back = false;
            }
            btntoggle(backBtn);
        }

        private void Areas_Load(object sender, EventArgs e)
        {

        }
        private void btntoggle(Guna.UI2.WinForms.Guna2Button btn)
        {
            Color checkedColor = Color.FromArgb(255, 226, 105, 114);
            Color uncheckedColor = Color.FromArgb(255, 85, 44, 87);
            if (btn.FillColor == uncheckedColor)
            {
                btn.FillColor = checkedColor;
            }
            else
            {
                btn.FillColor = uncheckedColor;
            }
            
        }
        
    }
}
