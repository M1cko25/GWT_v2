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

namespace GWT_V2
{
    public partial class Setup : Form
    {
        
        public MainForm main = new MainForm();
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        public string password { get; set; }
        public string username { get; set; }
        public bool isLoggedin = false;
        int back = 0, shoulder = 0, arm = 0, chest = 0, abs = 0, butt = 0, leg = 0, fullBody = 0;
        public Setup()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            main.user.Username = username;
            main.user.Password = password;
            loading21.Location = new Point(0, 0);
            loading21.Hide();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (areas1.Visible && !gender1.Visible)
            {
                if (!areas1.back && !areas1.shoulder && !areas1.arm && !areas1.chest && !areas1.abs && !areas1.butt && !areas1.leg && !areas1.fullBody )
                {
                    MsgBoxOk msgbox = new MsgBoxOk();
                    msgbox.label1.Text = "Please Provide Areas You Want To Focus";
                    msgbox.ShowDialog();
                } else
                {
                    areas1.Hide();
                    bmi1.Show();
                }
            } else
            {
                if (bmi1.heightTxt.Text == "0" || bmi1.weightTxt.Text == "0" || bmi1.heightTxt.Text == "" || bmi1.weightTxt.Text == "")
                {
                    MsgBoxOk msgbox = new MsgBoxOk();
                    msgbox.label1.Text = "Please Provide Valid Height or Weight";
                    msgbox.ShowDialog();
                } else if (bmi1.bmi <= 0 || bmi1.bmi >= 50)
                {
                    MsgBoxOk msgbox = new MsgBoxOk();
                    msgbox.label1.Text = "Please Provide Valid BMI";
                    msgbox.ShowDialog();
                } else
                {
                    main.user.Gender = gender1.gender;
                    main.user.Height = Convert.ToDouble(bmi1.heightTxt.Text);
                    main.user.Weight = Convert.ToDouble(bmi1.weightTxt.Text);
                    main.user.BodyType = bmi1.bodyType;
                    main.user.Bmi = bmi1.bmi;
                    main.user.Back = areas1.back;
                    main.user.Shoulder = areas1.shoulder;
                    main.user.Arm = areas1.arm;
                    main.user.Chest = areas1.chest;
                    main.user.Abs = areas1.abs;
                    main.user.Butt = areas1.butt;
                    main.user.Leg = areas1.leg;
                    main.user.FullBody = areas1.fullBody;
                    if (areas1.back)
                    {
                        back = 1;
                    }
                    if (areas1.shoulder)
                    {
                        shoulder = 1;
                    }
                    if (areas1.arm)
                    {
                        arm = 1;
                    }
                    if (areas1.chest)
                    {
                        chest = 1;
                    }
                    if (areas1.abs)
                    {
                        abs = 1;
                    }
                    if (areas1.butt)
                    {
                        butt = 1;
                    }
                    if (areas1.leg)
                    {
                        leg = 1;
                    }
                    if (areas1.fullBody)
                    {
                        fullBody = 1;
                    }

                    if (isLoggedin)
                    {
                        try
                        {
                            MySqlConnection con = new MySqlConnection(connstring);
                            con.Open();
                            string qry = "INSERT INTO `users`(`id`, `username`, `gender`, `height`, `weight`, `body-type`, `bmi`, `password`) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                            MySqlCommand cmd = new MySqlCommand(qry, con);
                            cmd.Parameters.AddWithValue("param1", null);
                            cmd.Parameters.AddWithValue("param2", username);
                            cmd.Parameters.AddWithValue("param3", gender1.gender);
                            cmd.Parameters.AddWithValue("param4", Convert.ToDouble(bmi1.heightTxt.Text));
                            cmd.Parameters.AddWithValue("param5", Convert.ToDouble(bmi1.weightTxt.Text));
                            cmd.Parameters.AddWithValue("param6", bmi1.bodyType);
                            cmd.Parameters.AddWithValue("param7", bmi1.bmi);
                            cmd.Parameters.AddWithValue("param8", password);
                            cmd.ExecuteNonQuery();

                            string qry2 = "INSERT INTO `areasfocused`(`userId`, `back`, `shoulder`, `arm`, `chest`, `abs`, `butt`, `leg`, `full body`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            MySqlCommand cmd2 = new MySqlCommand(qry2, con);
                            cmd2.Parameters.AddWithValue("param1", null);
                            cmd2.Parameters.AddWithValue("param2", back);
                            cmd2.Parameters.AddWithValue("param3", shoulder);
                            cmd2.Parameters.AddWithValue("param4", arm);
                            cmd2.Parameters.AddWithValue("param5", chest);
                            cmd2.Parameters.AddWithValue("param6", abs);
                            cmd2.Parameters.AddWithValue("param7", butt);
                            cmd2.Parameters.AddWithValue("param8", leg);
                            cmd2.Parameters.AddWithValue("param9", fullBody);
                            cmd2.ExecuteNonQuery();
                            loading21.Show();
                            timer1.Start();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    } else
                    {
                        main.Show();
                        this.Close();
                    }
                }
                
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (areas1.Visible)
            {
                gender1.Show();
            }
            else if (bmi1.Visible)
            {
                bmi1.Hide();
                areas1.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            main.Show();
            timer1.Stop();
        }
    }
} 