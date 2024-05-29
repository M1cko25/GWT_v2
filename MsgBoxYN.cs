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
    public partial class MsgBoxYN : Form
    {
        public bool Yes = false, No = false;
        public MsgBoxYN()
        {
            InitializeComponent();
            guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Yes = true;
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            No = true;
            this.Close();
        }

        private void MsgBoxYN_Load(object sender, EventArgs e)
        {

        }
    }
}
