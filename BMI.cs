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
    public partial class BMI : UserControl
    {
        public double bmi { get; set; }
        bool isInMeter = true, isInFeet = false, isInKg = true, isInLbs = false;
        double LbsDivider = 2.205, feetDivider = 3.281;
        public string bodyType { get; set; }
        public BMI()
        {
            InitializeComponent();
        }

        private void mBtn_Click(object sender, EventArgs e)
        {
            measureToggle(mBtn, ftBtn);
            isInFeet = false;
            isInMeter = true;
            ComputeBmi();
        }

        private void ftBtn_Click(object sender, EventArgs e)
        {
            measureToggle(ftBtn, mBtn);
            isInFeet = true;
            isInMeter = false;
            ComputeBmi();
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void kgBtn_Click(object sender, EventArgs e)
        {
            measureToggle(kgBtn, lbsBtn);
            isInKg = true;
            isInLbs = false;
            ComputeBmi();
        }

        private void lbsBtn_Click(object sender, EventArgs e)
        {
            measureToggle(lbsBtn, kgBtn);
            isInLbs = true;
            isInKg = false;
            ComputeBmi();
        }

        private void heightTxt_TextChanged(object sender, EventArgs e)
        {
            ComputeBmi();
        }

        private void weightTxt_TextChanged(object sender, EventArgs e)
        {
            ComputeBmi();
        }

        private void commentLbl_Click(object sender, EventArgs e)
        {

        }

        private void heightTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !heightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && heightTxt.SelectionStart == 0 && !heightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
        }

        private void weightTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.' && !weightTxt.Text.Contains("."))
            {
                return;
            }

            if (e.KeyChar == '-' && weightTxt.SelectionStart == 0 && !weightTxt.Text.Contains("-"))
            {
                return;
            }

            e.Handled = true;
        }

        private void measureToggle(Guna.UI2.WinForms.Guna2Button cont1, Guna.UI2.WinForms.Guna2Button cont2)
        {
            cont1.BringToFront();
            cont1.FillColor = Color.FromArgb(255, 226, 105, 114);
            cont1.BorderThickness = 1;
            cont2.SendToBack();
            cont2.FillColor = Color.FromArgb(255, 85, 44, 87);
            cont2.BorderThickness = 0;
        }

        private void ComputeBmi()
        {
            if (double.TryParse(weightTxt.Text, out double weight) && double.TryParse(heightTxt.Text, out double height))
            {
                if (isInLbs)
                {
                    weight = weight / LbsDivider;
                }
                if (isInFeet)
                {
                    height = height / feetDivider;
                }
                bmi = weight / (height * height);
                bmiDisplayPanel.Visible = true;
                if (bmi <= 0)
                {
                    bmiNumLbl.Text = "0";
                    commentLbl.Text = "Invalid Inputs";
                    bodyType = null;
                    bodyLbl.Text = "";
                }
                else if (bmi < 18.5)
                {
                    bmiNumLbl.Text = bmi.ToString("#.#");
                    commentLbl.Text = "Amazing! Want to be stronger?";
                    bodyLbl.Text = "Underweight";
                    bodyType = "Under Weight";
                    int x = (this.Width / 2) - (bodyLbl.Width / 2);
                    int y = bodyLbl.Location.Y;
                    bodyLbl.Location = new Point(x, y);
                }
                else if (bmi > 18.5 && bmi < 25)
                {
                    bmiNumLbl.Text = bmi.ToString("#.#");
                    commentLbl.Text = "You've a great shape! Keep it up.";
                    bodyLbl.Text = "Normal";
                    bodyType = "Normal";
                    int x = (this.Width / 2) - (bodyLbl.Width / 2);
                    int y = bodyLbl.Location.Y;
                    bodyLbl.Location = new Point(x, y);
                }
                else if (bmi > 25 && bmi < 50)
                {
                    bmiNumLbl.Text = bmi.ToString("#.#");
                    commentLbl.Text = "Marvelous! Want to lose some weight?";
                    bodyLbl.Text = "Overweight";
                    bodyType = "Over Weight";
                    int x = (this.Width / 2) - (bodyLbl.Width / 2);
                    int y = bodyLbl.Location.Y;
                    bodyLbl.Location = new Point(x, y);
                }
                else if (bmi > 50)
                {
                    bmiNumLbl.Text = "0";
                    commentLbl.Text = "Invalid Inputs";
                    bodyType = null;
                    bodyLbl.Text = "";
                }
            }

        }
    }
}
