using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace GWT_V2
{
    public partial class SignUp : Form
    {
        public Setup setup = new Setup();
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        public SignUp()
        {
            InitializeComponent();
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            string user = userTxt.Text.Trim();
            string pass = passTxt.Text.Trim();
            string hashPass = HashPassword(pass);

            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text) || string.IsNullOrEmpty(ConPassTxt.Text))
            {
                MessageBox.Show("All fields should be filled");
            }
            else if (userTxt.Text.Length < 4)
            {
                MessageBox.Show("Username must be atleast 4 characters");
            }
            else if (userTxt.Text.Length > 16)
            {
                MessageBox.Show("Username must under 16 characters");
            }
            else if (passTxt.Text.Length < 8)
            {
                MessageBox.Show("Password must be atleast 8 characters");
            }
            else if (pass != ConPassTxt.Text.Trim())
            {
                MessageBox.Show("Passwords Doesn't match");
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "SELECT * FROM `users` WHERE username = @user";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@user", userTxt.Text.Trim());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Username is Already Been Taken");
                    } else
                    {
                        setup.username = user;
                        setup.password = hashPass;
                        loading11.Show();
                        timer1.Start();
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading11.Hide();
            setup.isLoggedin = true;
            setup.main.form = this;
            setup.Show();
            this.Hide();
            timer1.Stop();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            loading11.Location = new Point(0, 0);
            loading11.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void passEye_CheckedChanged(object sender, EventArgs e)
        {
            if (passEye.Checked)
            {
                passTxt.PasswordChar = '\0';
            }
            else
            {
                passTxt.PasswordChar = '•';
            }
        }

        private void conEye_CheckedChanged(object sender, EventArgs e)
        {
            if (conEye.Checked)
            {
                ConPassTxt.PasswordChar = '\0';
            }
            else
            {
                ConPassTxt.PasswordChar = '•';
            }
        }
    }
}
