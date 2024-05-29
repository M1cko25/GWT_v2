using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GWT_V2.Properties;
using MySql.Data.MySqlClient;

namespace GWT_V2
{
    public partial class MainForm : Form
    {
        public User user = new User();
        private string connstring = "Server=127.0.0.1;Database=gwt_db;username=root";
        BackExer backEx = new BackExer();
        ShoulderExer shoulderEx = new ShoulderExer();
        ArmExer armEx = new ArmExer();
        ChestExer chestEx = new ChestExer();
        AbsExer absEx = new AbsExer();
        ButtExer buttEx = new ButtExer();
        LegExer legEx = new LegExer();
        int[] indexes = { 0, 1, 2, 3, 4, 5 };
        public Random randNum = new Random();
        int x = 26;
        int y = 81;
        int addY = 325;
        public Form form { get; set; }
        public int workouttoday = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            usernameLbl.Text = user.Username;
            profile1.Hide();
            exercises1.Hide();
            reports1.Hide();
            training1.Show();
            y = 81;
            string setByGender = (user.Gender == "Male") ? "4" : "3";
            if (user.Back)
            {
                setWorkoutPanel( training1, "Back", setByGender, backEx.BackName[indexes[0]], backEx.BackName[indexes[1]], backEx.BackName[indexes[2]], backEx.BackReps[indexes[0]], backEx.BackReps[indexes[1]], backEx.BackReps[indexes[2]], Resources.muscleBackGWT);
            }
            if (user.Shoulder)
            {
                setWorkoutPanel( training1, "Shoulder", setByGender, shoulderEx.ShoulderName[indexes[0]], shoulderEx.ShoulderName[indexes[1]], shoulderEx.ShoulderName[indexes[2]], shoulderEx.ShoulderReps[indexes[0]], shoulderEx.ShoulderReps[indexes[1]], shoulderEx.ShoulderReps[indexes[2]], Resources.muscleShoulderGWT);
            }
            if (user.Arm)
            {
                setWorkoutPanel( training1, "Arm", setByGender, armEx.ArmName[indexes[0]], armEx.ArmName[indexes[1]], armEx.ArmName[indexes[2]], armEx.ArmReps[indexes[0]], armEx.ArmReps[indexes[1]], armEx.ArmReps[indexes[2]], Resources.muscleArmGWT);
            }
            if (user.Chest)
            {
                setWorkoutPanel( training1, "Chest", setByGender, chestEx.ChestName[indexes[0]], chestEx.ChestName[indexes[1]], chestEx.ChestName[indexes[2]], chestEx.ChestReps[indexes[0]], chestEx.ChestReps[indexes[1]], chestEx.ChestReps[indexes[2]], Resources.muscleChestGWT);
            }
            if (user.Abs)
            {
                setWorkoutPanel( training1, "Abs", setByGender, absEx.AbsName[indexes[0]], absEx.AbsName[indexes[1]], absEx.AbsName[indexes[2]], absEx.AbsName[indexes[0]], absEx.AbsReps[indexes[1]], absEx.AbsReps[indexes[2]], Resources.muscleAbsGWT);
            }
            if (user.Butt)
            {
                setWorkoutPanel( training1, "Butt", setByGender, buttEx.ButtName[indexes[0]], buttEx.ButtName[indexes[1]], buttEx.ButtName[indexes[2]], buttEx.ButtReps[indexes[0]], buttEx.ButtReps[indexes[1]], buttEx.ButtReps[indexes[2]], Resources.muscleButtGWT);
            }
            if (user.Leg)
            {
                setWorkoutPanel( training1, "Leg", setByGender, legEx.LegName[indexes[0]], legEx.LegName[indexes[1]], legEx.LegName[indexes[2]], legEx.LegReps[indexes[0]], legEx.LegReps[indexes[1]], legEx.LegReps[indexes[2]], Resources.muscleLegGWT);
            }
            if (user.FullBody)
            {
                setWorkoutPanel( training1, "Full Body", setByGender, backEx.BackName[indexes[0]], shoulderEx.ShoulderName[indexes[0]], armEx.ArmName[indexes[0]], backEx.BackReps[indexes[0]], shoulderEx.ShoulderReps[indexes[0]], armEx.ArmReps[indexes[0]], Resources.muscleFull);
            }
            profile1.user = user;
            profile1.userName.Text = user.Username;
            profile1.HeightNum.Text = user.Height.ToString();
            profile1.WeightNum.Text = user.Weight.ToString();
            profile1.BmiNum.Text = user.Bmi.ToString();
            profile1.BodyType.Text = user.BodyType;

        }
        private void setWorkoutPanel(UserControl training, string title, string setByGender, string exer1, string exer2, string exer3, string exer1reps, string exer2reps, string exer3reps, Image musclegroup)
        {
            WorkoutDisplay workout = new WorkoutDisplay();
            workout.workoutLbl.Text = title + " Workout";
            if (user.BodyType == "Under Weight")
            {
                workout.exerciseNum.Text = "5 Exercises";
            }
            else if (user.BodyType == "Normal" || user.BodyType == "Healthy")
            {
                workout.exerciseNum.Text = "6 Exercises";
            }
            else if (user.BodyType == "Over Weight")
            {
                workout.exerciseNum.Text = "7 Exercises";
            }
            workout.exer1Lbl.Text = exer1;
            workout.exer2Lbl.Text = exer2;
            workout.exer3Lbl.Text = exer3;
            workout.exer1Reps.Text = setByGender + " x " + exer1reps;
            workout.exer2Reps.Text = setByGender + " x " + exer2reps;
            workout.exer3Reps.Text = setByGender + " x " + exer3reps;
            workout.muscleDisplay.Image = musclegroup;
            workout.Location = new Point(x, y);
            workout.user = user;
            y += addY;
            training.Controls.Add(workout);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void exercisesBtn_Click(object sender, EventArgs e)
        {
            trainingBtn.FillColor = Color.Transparent;
            exercisesBtn.FillColor = Color.FromArgb(226, 105, 114);
            reportBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            training1.Hide();
            exercises1.Show();
            reports1.Hide();
            profile1.Hide();
        }

        private void trainingBtn_Click(object sender, EventArgs e)
        {
            exercisesBtn.FillColor = Color.Transparent;
            trainingBtn.FillColor = Color.FromArgb(226, 105, 114);
            reportBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            exercises1.Hide();
            training1.Show();
            profile1.Hide();
            reports1.Hide();
        }
        
        private void reportBtn_Click(object sender, EventArgs e)
        {
            exercisesBtn.FillColor = Color.Transparent;
            reportBtn.FillColor = Color.FromArgb(226, 105, 114);
            trainingBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.Transparent;
            exercises1.Hide();
            training1.Hide();
            profile1.Hide();
            reports1.Show();
            reports1.historyContent.Controls.Clear();
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();
            string qry = "SELECT * FROM `users` WHERE username = @user";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@user", user.Username);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MySqlConnection conn = new MySqlConnection(connstring);
                conn.Open();
                string qry2 = "SELECT * FROM `history` WHERE id = @id";
                MySqlCommand cmd2 = new MySqlCommand(qry2, conn);
                cmd2.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    HistoryControl hist = new HistoryControl();
                    hist.date.Text = reader2.GetString("date");
                    hist.workout.Text = reader2.GetString("workout");
                    hist.time.Text = reader2.GetString("time");
                    reports1.historyContent.Controls.Add(hist);
                }

                MySqlConnection conn2 = new MySqlConnection(connstring);
                conn2.Open();
                string qry3 = "SELECT * FROM `report` WHERE id = @id";
                MySqlCommand cmd3 = new MySqlCommand(qry3, conn2);
                cmd3.Parameters.AddWithValue("@id", reader.GetInt32("id"));
                MySqlDataReader reader3 = cmd3.ExecuteReader();
                if (reader3.Read())
                {
                    reports1.workoutTotal.Text = Convert.ToString(reader3.GetInt32("workout- number"));
                    reports1.minuteTotal.Text = Convert.ToString(reader3.GetInt32("minutes"));
                    reports1.daysTotal.Text = Convert.ToString(reader3.GetInt32("day"));
                    reports1.workToday.Text = Convert.ToString(workouttoday);
                }
            }
            
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            trainingBtn.FillColor = Color.Transparent;
            profileBtn.FillColor = Color.FromArgb(226, 105, 114);
            reportBtn.FillColor = Color.Transparent;
            exercisesBtn.FillColor = Color.Transparent;
            training1.Hide();
            profile1.Show();
            reports1.Hide();
            exercises1.Hide();
        }

        private void exercises1_Load(object sender, EventArgs e)
        {
            y = 81;

            string setByGender = (user.Gender == "Male") ? "4" : "3";
            setWorkoutPanel(exercises1, "Back", setByGender, backEx.BackName[indexes[0]], backEx.BackName[indexes[1]], backEx.BackName[indexes[2]], backEx.BackReps[indexes[0]], backEx.BackReps[indexes[1]], backEx.BackReps[indexes[2]], Resources.muscleBackGWT);
            setWorkoutPanel(exercises1, "Shoulder", setByGender, shoulderEx.ShoulderName[indexes[0]], shoulderEx.ShoulderName[indexes[1]], shoulderEx.ShoulderName[indexes[2]], shoulderEx.ShoulderReps[indexes[0]], shoulderEx.ShoulderReps[indexes[1]], shoulderEx.ShoulderReps[indexes[2]], Resources.muscleShoulderGWT);
            setWorkoutPanel(exercises1, "Arm", setByGender, armEx.ArmName[indexes[0]], armEx.ArmName[indexes[1]], armEx.ArmName[indexes[2]], armEx.ArmReps[indexes[0]], armEx.ArmReps[indexes[1]], armEx.ArmReps[indexes[2]], Resources.muscleArmGWT);
            setWorkoutPanel(exercises1, "Chest", setByGender, chestEx.ChestName[indexes[0]], chestEx.ChestName[indexes[1]], chestEx.ChestName[indexes[2]], chestEx.ChestReps[indexes[0]], chestEx.ChestReps[indexes[1]], chestEx.ChestReps[indexes[2]], Resources.muscleChestGWT);
            setWorkoutPanel(exercises1, "Abs", setByGender, absEx.AbsName[indexes[0]], absEx.AbsName[indexes[1]], absEx.AbsName[indexes[2]], absEx.AbsName[indexes[0]], absEx.AbsReps[indexes[1]], absEx.AbsReps[indexes[2]], Resources.muscleAbsGWT);
            setWorkoutPanel(exercises1, "Butt", setByGender, buttEx.ButtName[indexes[0]], buttEx.ButtName[indexes[1]], buttEx.ButtName[indexes[2]], buttEx.ButtReps[indexes[0]], buttEx.ButtReps[indexes[1]], buttEx.ButtReps[indexes[2]], Resources.muscleButtGWT);
            setWorkoutPanel(exercises1, "Leg", setByGender, legEx.LegName[indexes[0]], legEx.LegName[indexes[1]], legEx.LegName[indexes[2]], legEx.LegReps[indexes[0]], legEx.LegReps[indexes[1]], legEx.LegReps[indexes[2]], Resources.muscleLegGWT);
            setWorkoutPanel(exercises1, "Full Body", setByGender, backEx.BackName[indexes[0]], backEx.BackName[indexes[1]], backEx.BackName[indexes[2]], backEx.BackReps[indexes[0]], backEx.BackReps[indexes[1]], backEx.BackReps[indexes[2]], Resources.muscleFull);
        }

        private void profile1_Load(object sender, EventArgs e)
        {

        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Hide();
        }
    }
}
