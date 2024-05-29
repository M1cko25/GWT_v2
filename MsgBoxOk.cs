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
    public partial class MsgBoxOk : Form
    {
        public MsgBoxOk()
        {
            InitializeComponent();
            this.guna2AnimateWindow1.SetAnimateWindow(this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MsgBoxOk_Load(object sender, EventArgs e)
        {

        }
    }
}
