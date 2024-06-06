using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using GWT_V2.Properties;

namespace GWT_V2
{
    public partial class Profile : UserControl
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        public User user { get; set; }
        public double bmi, height, weight;
        public Profile()
        {
            InitializeComponent();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            if (!changePassPanel.Visible)
            {
                changePassPanel.Visible = true;
            } else
            {
                if (string.IsNullOrEmpty(currPassTxt.Text) && string.IsNullOrEmpty(newPassTxt.Text))
                {
                    changePassPanel.Visible = false;
                }
                else if (string.IsNullOrEmpty(currPassTxt.Text) || string.IsNullOrEmpty(newPassTxt.Text)) {
                    MsgBoxOk msg = new MsgBoxOk();
                    msg.label1.Text = "Please fill all the fields";
                    msg.ShowDialog();
                }
                else
                {
                    try
                    {
                        MySqlConnection con = new MySqlConnection(connstring);
                        con.Open();
                        string qry = "UPDATE `users` SET `password`= @pass WHERE username = @id AND password = @password";
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@id", user.Username);
                        cmd.Parameters.AddWithValue("@password", currPassTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", newPassTxt.Text.Trim());
                        int updateNum = cmd.ExecuteNonQuery();
                        if (updateNum > 0)
                        {
                            MsgBoxOk msg = new MsgBoxOk();
                            msg.label1.Text = "Password Successfully Updated";
                            msg.ShowDialog();
                            changePassPanel.Visible = false;
                            currPassTxt.Text = "";
                            newPassTxt.Text = "";
                        }
                        else
                        {
                            MsgBoxOk msg = new MsgBoxOk();
                            msg.label1.Text = "Wrong Current Password";
                            msg.ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (editAll.Checked)
            {
                userNameTxt.Text = userName.Text;
                heightTxt.Text = HeightNum.Text;
                weightTxt.Text = WeightNum.Text;
                userNameTxt.Visible = true;
                heightTxt.Visible = true;
                weightTxt.Visible = true;
                heightEdit.Checked = true;
                weightEdit.Checked = true;
                userEdit.Checked = true;
            }
            else
            {
                if (string.IsNullOrEmpty(userName.Text) && string.IsNullOrEmpty(heightTxt.Text) && string.IsNullOrEmpty(weightTxt.Text))
                {

                    userNameTxt.Text = userName.Text;
                    heightTxt.Text = HeightNum.Text;
                    weightTxt.Text = WeightNum.Text;
                    userNameTxt.Visible = false;
                    heightTxt.Visible = false;
                    weightTxt.Visible = false;
                    heightEdit.Checked = false;
                    weightEdit.Checked = false;
                    userEdit.Checked = false;
                }
                else
                {

                    height = Convert.ToDouble(heightTxt.Text);
                    weight = Convert.ToDouble(weightTxt.Text);
                    bmi = weight / (height * height);

                    if (bmi <= 5)
                    {
                        MsgBoxOk msg = new MsgBoxOk();
                        msg.label1.Text = "Invalid BMI!";
                        msg.ShowDialog();
                        editAll.Checked = true;
                        return;
                    }
                    else if (bmi < 18.5)
                    {
                        BodyType.Text = "Under Weight";
                    }
                    else if (bmi > 18.5 && bmi < 25)
                    {
                        BodyType.Text = "Normal";
                    }
                    else if (bmi > 25 && bmi < 50)
                    {
                        BodyType.Text = "Over Weight";
                    }
                    else
                    {
                        MsgBoxOk msg = new MsgBoxOk();
                        msg.label1.Text = "Invalid BMI!";
                        msg.ShowDialog();
                        editAll.Checked = true;
                        return;
                    }
                    BmiNum.Text = bmi.ToString("0.00");
                    userName.Text = userNameTxt.Text;
                    HeightNum.Text = heightTxt.Text;
                    WeightNum.Text = weightTxt.Text;
                   if (user.isLoggedIn)
                    {
                        MySqlConnection con = new MySqlConnection(connstring);
                        con.Open();
                        string qry = "UPDATE `users` SET `username`= @user,`height`= @height,`weight`= @weight,`body-type`= @bodyType,`bmi`= @bmi WHERE username = @id";
                        MySqlCommand cmd = new MySqlCommand(qry, con);
                        cmd.Parameters.AddWithValue("@id", user.Username);
                        cmd.Parameters.AddWithValue("@user", userNameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("@height", height);
                        cmd.Parameters.AddWithValue("@weight", weight);
                        cmd.Parameters.AddWithValue("@bodyType", BodyType.Text.Trim());
                        cmd.Parameters.AddWithValue("@bmi", Convert.ToDouble(BmiNum.Text));
                        cmd.ExecuteNonQuery();
                    }
                    userNameTxt.Visible = false;
                    heightTxt.Visible = false;
                    weightTxt.Visible = false;
                    user.Username = userNameTxt.Text;
                    user.Height = height;
                    user.Weight = weight;
                    user.Bmi = bmi;
                    user.BodyType = BodyType.Text;
                    heightEdit.Checked = false;
                    weightEdit.Checked = false;
                    userEdit.Checked = false;
                    MainForm main = (MainForm)this.FindForm();
                    main.user = user;
                }
            }
        }

        private void weightEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (weightEdit.Checked)
            {
                weightTxt.Visible = true;
                weightTxt.Text = WeightNum.Text;
            } else
            {
                height = Convert.ToDouble(HeightNum.Text.Trim());
                weight = Convert.ToDouble(weightTxt.Text.Trim());
                bmi = weight / (height * height);
                if (bmi <= 5)
                {
                    MsgBoxOk msg = new MsgBoxOk();
                    msg.label1.Text = "Invalid BMI!";
                    msg.ShowDialog();
                    return;
                }
                else if (bmi < 18.5)
                {
                    BodyType.Text = "Under Weight";
                }
                else if (bmi > 18.5 && bmi < 25)
                {
                    BodyType.Text = "Normal";
                }
                else if (bmi > 25 && bmi < 50)
                {
                    BodyType.Text = "Over Weight";
                }
                else
                {
                    MsgBoxOk msg = new MsgBoxOk();
                    msg.label1.Text = "Invalid BMI!";
                    msg.ShowDialog();
                    return;
                }
                if (user.isLoggedIn)
                {
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "UPDATE `users` SET `weight`= @weight WHERE username = @id";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@id", user.Username);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.ExecuteNonQuery();
                }
                user.Weight = weight;
                user.Bmi = bmi;
                user.BodyType = BodyType.Text;
                weightTxt.Visible = false;
                BmiNum.Text = bmi.ToString();
                WeightNum.Text = weightTxt.Text;
                MainForm main = (MainForm)this.FindForm();
                main.user.Weight = weight;
            }
        }

        private void heightEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (heightEdit.Checked)
            {
                heightTxt.Visible = true;
                heightTxt.Text = WeightNum.Text;
            } else
            {
                height = Convert.ToDouble(heightTxt.Text.Trim());
                weight = Convert.ToDouble(WeightNum.Text.Trim());
                bmi = weight / (height * height);
                if (bmi <= 5)
                {
                    MsgBoxOk msg = new MsgBoxOk();
                    msg.label1.Text = "Invalid BMI!";
                    msg.ShowDialog();
                    return;
                }
                else if (bmi < 18.5)
                {
                    BodyType.Text = "Under Weight";
                }
                else if (bmi > 18.5 && bmi < 25)
                {
                    BodyType.Text = "Normal";
                }
                else if (bmi > 25 && bmi < 50)
                {
                    BodyType.Text = "Over Weight";
                }
                else
                {
                    MsgBoxOk msg = new MsgBoxOk();
                    msg.label1.Text = "Invalid BMI!";
                    msg.ShowDialog();
                    return;
                }
                if (user.isLoggedIn)
                {
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "UPDATE `users` SET `height`= @height WHERE username = @id";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@id", user.Username);
                    cmd.Parameters.AddWithValue("@height", height);
                    cmd.ExecuteNonQuery();
                }
                user.Height = height;
                user.Bmi = bmi;
                user.BodyType = BodyType.Text;
                heightTxt.Visible = false;
                BmiNum.Text = bmi.ToString();
                HeightNum.Text = heightTxt.Text;
                MainForm main = (MainForm)this.FindForm();
                main.user.Height = height;
            }
        }

        private void userEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (userEdit.Checked)
            {
                userNameTxt.Visible = true;
                userNameTxt.Text = userName.Text;
            } else
            {
                if (user.isLoggedIn)
                {
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "UPDATE `users` SET `username`= @user WHERE username = @id";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@id", user.Username);
                    cmd.Parameters.AddWithValue("@user", userNameTxt.Text);
                    cmd.ExecuteNonQuery();
                }
                userNameTxt.Visible = false;
                userName.Text = userNameTxt.Text;
                user.Username = userNameTxt.Text;
                MainForm main = (MainForm)this.FindForm();
                main.usernameLbl.Text = userNameTxt.Text;
                main.user.Username = userNameTxt.Text;
            }
        }

        private void passEye_CheckedChanged(object sender, EventArgs e)
        {
            if (passEye.Checked)
            {
                currPassTxt.PasswordChar = '\0';
            } else
            {
                currPassTxt.PasswordChar = '•';
            }
        }

        private void conEye_CheckedChanged(object sender, EventArgs e)
        {
            if (conEye.Checked)
            {
                newPassTxt.PasswordChar = '\0';
            }
            else
            {
                newPassTxt.PasswordChar = '•';
            }
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
    }
}
