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
    public partial class Training : UserControl
    {
        
        
        public bool Back = false, Shoulder = false, Arm = false, Chest = false, Abs = false, Butt = false, Leg = false, FullBody = false;
        public Training()
        {
            InitializeComponent();
        }

        private void Training_Load(object sender, EventArgs e)
        {

        }
    }
}
