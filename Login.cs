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
using System.Security.Cryptography;

namespace GWT_V2
{
    public partial class Login : Form
    {
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        
        public MainForm main = new MainForm();
        public Login()
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
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userTxt.Text.Trim();
            string pass = passTxt.Text.Trim();
            
            if (string.IsNullOrEmpty(userTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                MessageBox.Show("All fields should be filled");
            }
            else
            {
                try
                {
                    int id = 1;
                    MySqlConnection conn = new MySqlConnection(connstring);
                    conn.Open();

                    string qry = "SELECT * FROM `users` WHERE username = @username and password = @pass";
                    MySqlCommand cmd = new MySqlCommand(qry, conn);
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@pass", HashPassword(pass));
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader.Read())
                    {
                        timer1.Start();
                        loading11.Show();
                        main.user.Username = user;
                        main.user.Gender = reader.GetString("gender");
                        main.user.Height = reader.GetDouble("height");
                        main.user.Weight = reader.GetDouble("weight");
                        main.user.BodyType = reader.GetString("body-type");
                        main.user.Bmi = reader.GetDouble("bmi");
                        main.user.Password = reader.GetString("password");
                        id = reader.GetInt32("id");
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                    }

                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry2 = "SELECT * FROM `areasfocused` WHERE userId = @Id";
                    MySqlCommand cmd2 = new MySqlCommand(qry2, con);
                    cmd2.Parameters.AddWithValue("@Id", id);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        main.user.Back = (reader2.GetInt32("back") == 1) ? true : false;
                        main.user.Shoulder = (reader2.GetInt32("shoulder") == 1) ? true : false;
                        main.user.Arm = (reader2.GetInt32("arm") == 1) ? true : false;
                        main.user.Chest = (reader2.GetInt32("chest") == 1) ? true : false;
                        main.user.Abs = (reader2.GetInt32("abs") == 1) ? true : false;
                        main.user.Butt = (reader2.GetInt32("butt") == 1) ? true : false;
                        main.user.Leg = (reader2.GetInt32("leg") == 1) ? true : false;
                        main.user.FullBody = (reader2.GetInt32("full body") == 1) ? true : false;
                    }
                    main.user.isLoggedIn = true;
                    main.form = this;
                }
                catch (MySqlException ex)
                {

                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Contact administrator.");
                            break;
                        case 1042:
                            MessageBox.Show("Can't connect To server");
                            break;
                        default:
                            MessageBox.Show($"MySQL error number: {ex.Number}. Message: {ex.Message}");
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            loading11.Location = new Point(0, 0);
            loading11.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading11.Hide();
            main.Show();
            this.Hide();
            timer1.Stop();
        }

        private void userTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                passTxt.Focus();
            }
        }

        private void passTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                loginBtn_Click(sender, e);
            }
        }

        private void passEye_CheckedChanged(object sender, EventArgs e)
        {
            if(passEye.Checked)
            {
                passTxt.PasswordChar = '\0';
            } else
            {
                passTxt.PasswordChar = '•';
            }
        }
    }
}
