using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace GWT_V2
{
    public partial class Routine : Form
    {
        private MainForm Main;
        private Form viewform;
        BackExer backEx = new BackExer();
        ShoulderExer shoulderEx = new ShoulderExer();
        ArmExer armEx = new ArmExer();
        ChestExer chestEx = new ChestExer();
        AbsExer absEx = new AbsExer();
        ButtExer buttEx = new ButtExer();
        LegExer legEx = new LegExer();
        public int[] indexes = { 0, 1, 2, 3, 4, 5, 6 };
        public User user { get; set; }
        int TimeMs, TimeS, TimeM, TimeH;
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        DateTime date = DateTime.Today;

        public Routine(MainForm main, Form viewf)
        {
            InitializeComponent();
            Main = main;
            viewform = viewf;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RoutMainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MsgBoxYN msgBox = new MsgBoxYN();
            msgBox.label1.Text = "Your Routine is Not Finished Yet, Do you Want To Quit?";
            msgBox.ShowDialog();
            if (msgBox.Yes)
            {
                this.Close();
                viewform.Show();
            }
        }

        public void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isAllChecked = true;
            foreach (Control cont in setPanel.Controls)
            {
                if (cont is routineCheck check)
                {
                    var checkboxes = check.Controls.OfType<Guna2CheckBox>();
                    if (checkboxes.Any(cb => !cb.Checked))
                    {
                        isAllChecked = false;
                        break;
                    }
                }
            }
            nextSetBtn.Enabled = isAllChecked;
        }
        int workoutNum = 1;
        int workoutLim = 6;
        private void nextSetBtn_Click(object sender, EventArgs e)
        {
            if (user.BodyType == "Underweight" || user.BodyType == "Under Weight")
            {
                workoutLim = 5;
            } else if (user.BodyType == "Over Weight")
            {
                workoutLim = 7;
            }
            if (routineLbl.Text == "Full Body Workout")
            {
                if (workoutNum == 1)
                {
                    updateNextSet(shoulderEx.ShoulderGifs[indexes[workoutNum]], shoulderEx.ShoulderName[indexes[workoutNum]], shoulderEx.ShoulderReps[indexes[workoutNum]]);
                }
                
                else if (workoutNum == 2)
                {
                    updateNextSet(armEx.ArmGifs[indexes[workoutNum]], armEx.ArmName[indexes[workoutNum]], armEx.ArmReps[indexes[workoutNum]]);
                }
                else if (workoutNum == 3)
                {
                    updateNextSet(chestEx.ChestGifs[indexes[workoutNum]], chestEx.ChestName[indexes[workoutNum]], chestEx.ChestReps[indexes[workoutNum]]);
                }
                else if(workoutNum == 4)
                {
                    updateNextSet(absEx.AbsGifs[indexes[workoutNum]], absEx.AbsName[indexes[workoutNum]], absEx.AbsReps[indexes[workoutNum]]);
                }
                else if (workoutNum == 5)
                {
                    updateNextSet(buttEx.ButtGifs[indexes[workoutNum]], buttEx.ButtName[indexes[workoutNum]], buttEx.ButtReps[indexes[workoutNum]]);
                }
                else if (workoutNum == 6)
                {
                    updateNextSet(legEx.LegGifs[indexes[workoutNum]], legEx.LegName[indexes[workoutNum]], legEx.LegReps[indexes[workoutNum]]);
                    nextSetBtn.Text = "FINISH";
                } else
                {
                    MsgBoxOk msgbox = new MsgBoxOk();
                    timer.Enabled = false;
                    string[] dateS = Convert.ToString(date).Split(' ');
                    string time = "";
                    string seconds = TimeS.ToString() + " seconds";
                    string minutes = TimeM.ToString() + " Minutes and " + TimeS.ToString() + " seconds";
                    string hours = TimeH.ToString() + " Hours, " + TimeM.ToString() + " Minutes, and " + TimeS.ToString() + " seconds";
                    msgbox.label1.Text = "Congratulations! You Finished Your Workout Routine";
                    if (HourLbl.Text == "00" && MinuteLbl.Text == "00")
                    {
                        msgbox.label2.Text = "Your Time is " + seconds;
                        time = seconds;
                    }
                    else if (HourLbl.Text == "00")
                    {
                        msgbox.label2.Text = "Your Time is " + minutes;
                        time = minutes;
                    }
                    else
                    {
                        msgbox.label2.Text = "Your Time is " + hours;
                        time = hours;
                    }
                    msgbox.ShowDialog();
                    Main.workouttoday++;
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "SELECT * FROM `users` WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MySqlConnection conn = new MySqlConnection(connstring);
                        conn.Open();
                        string qry2 = "INSERT INTO `history`(`id`, `date`, `workout`, `time`) VALUES (?, ?, ?, ?)";
                        MySqlCommand cmd2 = new MySqlCommand(qry2, conn);
                        cmd2.Parameters.AddWithValue("param1", reader.GetInt32("id"));
                        cmd2.Parameters.AddWithValue("param2", dateS[0]);
                        cmd2.Parameters.AddWithValue("param3", routineLbl.Text);
                        cmd2.Parameters.AddWithValue("param4", time);
                        cmd2.ExecuteNonQuery();

                        MySqlConnection connect = new MySqlConnection(connstring);
                        connect.Open();
                        string query = "SELECT * FROM `report` WHERE id = @id";
                        MySqlCommand comd = new MySqlCommand(query, connect);
                        comd.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                        MySqlDataReader read = comd.ExecuteReader();
                        if (read.Read())
                        {
                            int workoutNum = read.GetInt32("workout- number");
                            workoutNum++;
                            int minute = read.GetInt32("minutes");
                            if (TimeM > 0)
                            {
                                minute += TimeM;
                            }
                            string date = read.GetString("date");
                            int days = read.GetInt32("day");
                            if (date != Convert.ToString(dateS[0]))
                            {
                                days++;
                            }
                            MySqlConnection conn2 = new MySqlConnection(connstring);
                            conn2.Open();
                            string qry3 = "UPDATE `report`SET `workout- number`= @workoutNum,`minutes`= @min,`day`= @day,`date`= @date WHERE id = @id";
                            MySqlCommand cmd3 = new MySqlCommand(qry3, conn2);
                            cmd3.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                            cmd3.Parameters.AddWithValue("@workoutNum", workoutNum);
                            cmd3.Parameters.AddWithValue("@min", minute);
                            cmd3.Parameters.AddWithValue("@day", days);
                            cmd3.Parameters.AddWithValue("@date", dateS[0]);
                            cmd3.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlConnection conn2 = new MySqlConnection(connstring);
                            conn2.Open();
                            string qry3 = "INSERT INTO `report`(`id`, `workout- number`, `minutes`, `day`, `date`) VALUES (?, ?, ?, ?, ?)";
                            MySqlCommand cmd3 = new MySqlCommand(qry3, conn2);
                            cmd3.Parameters.AddWithValue("param1", reader.GetInt32("id"));
                            cmd3.Parameters.AddWithValue("param2", 1);
                            cmd3.Parameters.AddWithValue("param3", TimeM);
                            cmd3.Parameters.AddWithValue("param4", 1);
                            cmd3.Parameters.AddWithValue("param5", dateS[0]);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    Main.Show();
                    viewform.Close();
                    this.Close();
                }
                workoutNum++;
            }
            else if (workoutNum < workoutLim -1)
            {
                if (routineLbl.Text == "Back Workout")
                {
                    updateNextSet(backEx.BackGifs[indexes[workoutNum]], backEx.BackName[indexes[workoutNum]], backEx.BackReps[indexes[workoutNum]]);
                } else if (routineLbl.Text == "Shoulder Workout")
                {
                    updateNextSet(shoulderEx.ShoulderGifs[indexes[workoutNum]], shoulderEx.ShoulderName[indexes[workoutNum]], shoulderEx.ShoulderReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Arm Workout")
                {
                    updateNextSet(armEx.ArmGifs[indexes[workoutNum]], armEx.ArmName[indexes[workoutNum]], armEx.ArmReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Chest Workout")
                {
                    updateNextSet(chestEx.ChestGifs[indexes[workoutNum]], chestEx.ChestName[indexes[workoutNum]], chestEx.ChestReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Abs Workout")
                {
                    updateNextSet(absEx.AbsGifs[indexes[workoutNum]], absEx.AbsName[indexes[workoutNum]], absEx.AbsReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Butt Workout")
                {
                    updateNextSet(buttEx.ButtGifs[indexes[workoutNum]], buttEx.ButtName[indexes[workoutNum]], buttEx.ButtReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Leg Workout")
                {
                    updateNextSet(legEx.LegGifs[indexes[workoutNum]], legEx.LegName[indexes[workoutNum]], legEx.LegReps[indexes[workoutNum]]);
                } 
                workoutNum++;
            } else if (workoutNum == workoutLim - 1)
            {
                if (routineLbl.Text == "Back Workout")
                {
                    updateNextSet(backEx.BackGifs[indexes[workoutNum]], backEx.BackName[indexes[workoutNum]], backEx.BackReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Shoulder Workout")
                {
                    updateNextSet(shoulderEx.ShoulderGifs[indexes[workoutNum]], shoulderEx.ShoulderName[indexes[workoutNum]], shoulderEx.ShoulderReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Arm Workout")
                {
                    updateNextSet(armEx.ArmGifs[indexes[workoutNum]], armEx.ArmName[indexes[workoutNum]], armEx.ArmReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Chest Workout")
                {
                    updateNextSet(chestEx.ChestGifs[indexes[workoutNum]], chestEx.ChestName[indexes[workoutNum]], chestEx.ChestReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Abs Workout")
                {
                    updateNextSet(absEx.AbsGifs[indexes[workoutNum]], absEx.AbsName[indexes[workoutNum]], absEx.AbsReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Butt Workout")
                {
                    updateNextSet(buttEx.ButtGifs[indexes[workoutNum]], buttEx.ButtName[indexes[workoutNum]], buttEx.ButtReps[indexes[workoutNum]]);
                }
                else if (routineLbl.Text == "Leg Workout")
                {
                    updateNextSet(legEx.LegGifs[indexes[workoutNum]], legEx.LegName[indexes[workoutNum]], legEx.LegReps[indexes[workoutNum]]);
                }
                nextSetBtn.Text = "FINISH";
                workoutNum++;
            }
            else
            {
                MsgBoxOk msgbox = new MsgBoxOk();
                timer.Enabled = false;
                string[] dateS = Convert.ToString(date).Split(' ');
                string time = "";
                string seconds = TimeS.ToString() + " seconds";
                string minutes = TimeM.ToString() + " Minutes and " + TimeS.ToString() + " seconds";
                string hours = TimeH.ToString() + " Hours, " + TimeM.ToString() + " Minutes, and " + TimeS.ToString() + " seconds";
                msgbox.label1.Text = "Congratulations! You Finished Your Workout Routine";
                if (HourLbl.Text == "00" && MinuteLbl.Text == "00")
                {
                    msgbox.label2.Text = "Your Time is " + seconds;
                    time = seconds;
                } else if (HourLbl.Text == "00")
                {
                    msgbox.label2.Text = "Your Time is " + minutes;
                    time = minutes;
                } else
                {
                    msgbox.label2.Text = "Your Time is " + hours;
                    time = hours;
                }
                msgbox.ShowDialog();
                Main.workouttoday++;
                if (Main.user.isLoggedIn)
                {
                    MySqlConnection con = new MySqlConnection(connstring);
                    con.Open();
                    string qry = "SELECT * FROM `users` WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MySqlConnection conn = new MySqlConnection(connstring);
                        conn.Open();
                        string qry2 = "INSERT INTO `history`(`id`, `date`, `workout`, `time`) VALUES (?, ?, ?, ?)";
                        MySqlCommand cmd2 = new MySqlCommand(qry2, conn);
                        cmd2.Parameters.AddWithValue("param1", reader.GetInt32("id"));
                        cmd2.Parameters.AddWithValue("param2", dateS[0]);
                        cmd2.Parameters.AddWithValue("param3", routineLbl.Text);
                        cmd2.Parameters.AddWithValue("param4", time);
                        cmd2.ExecuteNonQuery();

                        MySqlConnection connect = new MySqlConnection(connstring);
                        connect.Open();
                        string query = "SELECT * FROM `report` WHERE id = @id";
                        MySqlCommand comd = new MySqlCommand(query, connect);
                        comd.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                        MySqlDataReader read = comd.ExecuteReader();
                        if (read.Read())
                        {
                            int workoutNum = read.GetInt32("workout- number");
                            workoutNum++;
                            int minute = read.GetInt32("minutes");
                            if (TimeM > 0)
                            {
                                minute += TimeM;
                            }
                            string date = read.GetString("date");
                            int days = read.GetInt32("day");
                            if (date != Convert.ToString(dateS[0]))
                            {
                                days++;
                            }
                            MySqlConnection conn2 = new MySqlConnection(connstring);
                            conn2.Open();
                            string qry3 = "UPDATE `report`SET `workout- number`= @workoutNum,`minutes`= @min,`day`= @day,`date`= @date WHERE id = @id";
                            MySqlCommand cmd3 = new MySqlCommand(qry3, conn2);
                            cmd3.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                            cmd3.Parameters.AddWithValue("@workoutNum", workoutNum);
                            cmd3.Parameters.AddWithValue("@min", minute);
                            cmd3.Parameters.AddWithValue("@day", days);
                            cmd3.Parameters.AddWithValue("@date", dateS[0]);
                            cmd3.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlConnection conn2 = new MySqlConnection(connstring);
                            conn2.Open();
                            string qry3 = "INSERT INTO `report`(`id`, `workout- number`, `minutes`, `day`, `date`) VALUES (?, ?, ?, ?, ?)";
                            MySqlCommand cmd3 = new MySqlCommand(qry3, conn2);
                            cmd3.Parameters.AddWithValue("param1", reader.GetInt32("id"));
                            cmd3.Parameters.AddWithValue("param2", 1);
                            cmd3.Parameters.AddWithValue("param3", TimeM);
                            cmd3.Parameters.AddWithValue("param4", 1);
                            cmd3.Parameters.AddWithValue("param5", dateS[0]);
                            cmd3.ExecuteNonQuery();
                        }


                    }
                }
                Main.Show();
                viewform.Close();
                this.Close();
            }
        }

        private void updateNextSet(Image gif, string name, string reps)
        {
            exerciseGif.Image = gif;
            ExerciseName.Text = name;
            foreach (routineCheck rout in setPanel.Controls)
            {
                if (reps.Contains("secs") || reps.Contains("mins"))
                {
                    rout.checkbox.Text = "1 Set x " + reps;
                }
                else
                {
                    rout.checkbox.Text = "1 Set x " + reps + " reps";
                }
                rout.checkbox.Checked = false;
            }
        }
        private void timeTo0()
        {
            TimeMs = 0;
            TimeS = 0;
            TimeM = 0;
            TimeH = 0;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeMs++;
            if (TimeMs >= 100)
            {
                TimeMs = 0;
                TimeS++;
                if (TimeS < 10)
                {
                    SecondLbl.Text = "0" + Convert.ToString(TimeS);
                }
                else
                {
                    SecondLbl.Text = Convert.ToString(TimeS);
                }
                if (TimeS >= 59)
                {
                    TimeS = 0;
                    TimeM++;
                    if (TimeM < 10)
                    {
                        MinuteLbl.Text = "0" + Convert.ToString(TimeM);
                    }
                    else
                    {
                        MinuteLbl.Text = Convert.ToString(TimeM);
                    }
                    if (TimeM >= 59)
                    {
                        TimeM = 0;
                        TimeH++;
                        if (TimeH < 10)
                        {
                            HourLbl.Text = "0" + Convert.ToString(TimeH);
                        }
                        else
                        {
                            HourLbl.Text = Convert.ToString(TimeH);
                        }
                    }
                }
            }
        }
    }
}
