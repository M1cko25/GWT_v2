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
    public partial class WorkoutView : Form
    {
        private MainForm _main;
        int[] indexes = { 0, 1, 2, 3, 4, 5, 6 };
        Random randNum = new Random();
        public User user = new User();
        BackExer backEx = new BackExer();
        ShoulderExer shoulderEx = new ShoulderExer();
        ArmExer armEx = new ArmExer();
        ChestExer chestEx = new ChestExer();
        AbsExer absEx = new AbsExer();
        ButtExer buttEx = new ButtExer();
        LegExer legEx = new LegExer();
        public WorkoutView(MainForm main)
        {
            InitializeComponent();
            _main = main;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            _main.Show();
            this.Close();
        }

        private void WorkoutView_Load(object sender, EventArgs e)
        {
            
            
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            int setByGender = (user.Gender == "Male") ? 4 : 3;
            Routine routine = new Routine(_main, this);
            routine.routineLbl.Text = workoutLbl.Text;
            routine.setPanel.Controls.Clear();
            routine.user = user;
            routine.indexes = indexes;
            
            if (workoutLbl.Text == "Back Workout") {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, backEx.BackGifs[indexes[0]], backEx.BackName[indexes[0]], backEx.BackReps[indexes[0]]);
            } else if (workoutLbl.Text == "Shoulder Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, shoulderEx.ShoulderGifs[indexes[0]], shoulderEx.ShoulderName[indexes[0]], shoulderEx.ShoulderReps[indexes[0]]);
            }
            else if (workoutLbl.Text == "Arm Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, armEx.ArmGifs[indexes[0]], armEx.ArmName[indexes[0]], armEx.ArmReps[indexes[0]]);
            }
            else if (workoutLbl.Text == "Chest Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, chestEx.ChestGifs[indexes[0]], chestEx.ChestName[indexes[0]], chestEx.ChestReps[indexes[0]]);
            }
            else if (workoutLbl.Text == "Abs Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, absEx.AbsGifs[indexes[0]], absEx.AbsName[indexes[0]], absEx.AbsReps[indexes[0]]);
            }
            else if (workoutLbl.Text == "Butt Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, buttEx.ButtGifs[indexes[0]], buttEx.ButtName[indexes[0]], buttEx.ButtReps[indexes[0]]);
            }
            else if (workoutLbl.Text == "Leg Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, legEx.LegGifs[indexes[0]], legEx.LegName[indexes[0]], legEx.LegReps[indexes[0]]);
            } else if (workoutLbl.Text == "Full Body Workout")
            {
                int y = 13;
                int addY = 79;
                makeRoutine(routine, y, setByGender, addY, backEx.BackGifs[indexes[0]], backEx.BackName[indexes[0]], backEx.BackReps[indexes[0]]);
            }
                this.Hide();
            routine.Show();
        }
        private void makeRoutine(Routine routine, int y, int set, int addY, Image gif, string name, string reps)
        {
            routine.exerciseGif.Image = gif;
            routine.ExerciseName.Text = name;
            int x = ((routine.exerciseGif.Location.X + routine.exerciseGif.Width) / 2) - (routine.ExerciseName.Width / 2);
            int y2 = routine.ExerciseName.Location.Y;
            routine.ExerciseName.Location = new Point(x, y2);
            for (int i = 0; i < set; i++)
            {
                routineCheck checkbox = new routineCheck();
                if (reps.Contains("secs") || reps.Contains("mins"))
                {
                    checkbox.checkbox.Text = "1 Set x " + reps;
                }
                else
                {
                    checkbox.checkbox.Text = "1 Set x " + reps + " reps";
                }
                checkbox.Location = new Point(70, y);
                checkbox.checkbox.CheckedChanged += new System.EventHandler(routine.checkbox_CheckedChanged);
                y += addY;
                routine.setPanel.Controls.Add(checkbox);
            }
        }

        private void regenBtn_Click(object sender, EventArgs e)
        {
            indexes = RandomIndexer(0, 11, 7);
            string setByGender = (user.Gender == "Male") ? "4" : "3";
            int exerNum = 6;
            if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
            {
                exerNum = 5;
            }
            else if (user.BodyType == "Over Weight")
            {
                exerNum = 7;
            }
                workoutlists.Controls.Clear();
            
            if (workoutLbl.Text == "Back Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(backEx.BackImgs[indexes[i]], backEx.BackName[indexes[i]], setByGender, backEx.BackReps[indexes[i]]);
                }
            } else if (workoutLbl.Text == "Shoulder Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(shoulderEx.ShoulderImgs[indexes[i]], shoulderEx.ShoulderName[indexes[i]], setByGender, shoulderEx.ShoulderReps[indexes[i]]);
                }
            }
            else if (workoutLbl.Text == "Arm Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(armEx.ArmImgs[indexes[i]], armEx.ArmName[indexes[i]], setByGender, armEx.ArmReps[indexes[i]]);
                }
            }
            else if (workoutLbl.Text == "Chest Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(chestEx.ChestImgs[indexes[i]], chestEx.ChestName[indexes[i]], setByGender, chestEx.ChestReps[indexes[i]]);
                }
            }
            else if (workoutLbl.Text == "Abs Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(absEx.AbsImgs[indexes[i]], absEx.AbsName[indexes[i]], setByGender, absEx.AbsReps[indexes[i]]);
                }
            }
            else if (workoutLbl.Text == "Butt Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(buttEx.ButtImgs[indexes[i]], buttEx.ButtName[indexes[i]], setByGender, buttEx.ButtReps[indexes[i]]);
                }
            }
            else if (workoutLbl.Text == "Leg Workout")
            {
                for (int i = 0; i < exerNum; i++)
                {
                    showView(legEx.LegImgs[indexes[i]], legEx.LegName[indexes[i]], setByGender, legEx.LegReps[indexes[i]]);
                }
            } else if (workoutLbl.Text == "Full Body Workout")
            {
                showView(backEx.BackImgs[indexes[0]], backEx.BackName[indexes[0]], setByGender, backEx.BackReps[indexes[0]]);
                showView(shoulderEx.ShoulderImgs[indexes[0]], shoulderEx.ShoulderName[indexes[0]], setByGender, shoulderEx.ShoulderReps[indexes[0]]);
                showView(armEx.ArmImgs[indexes[0]], armEx.ArmName[indexes[0]], setByGender, armEx.ArmReps[indexes[0]]);
                showView(chestEx.ChestImgs[indexes[0]], chestEx.ChestName[indexes[0]], setByGender, chestEx.ChestReps[indexes[0]]);
                showView(absEx.AbsImgs[indexes[0]], absEx.AbsName[indexes[0]], setByGender, absEx.AbsReps[indexes[0]]);
                showView(buttEx.ButtImgs[indexes[0]], buttEx.ButtName[indexes[0]], setByGender, buttEx.ButtReps[indexes[0]]);
                showView(legEx.LegImgs[indexes[0]], legEx.LegName[indexes[0]], setByGender, legEx.LegReps[indexes[0]]);
            }
        }
        public void showView(Image demoPic, string name, string sets, string reps)
        {
            Workout exercise = new Workout();
            exercise.demoPic.Image = demoPic;
            exercise.name.Text = name;
            if (reps.Contains("secs") || reps.Contains("mins"))
            {
                exercise.setReps.Text = sets + " sets x " + reps;
            }
            else
            {
                exercise.setReps.Text = sets + " sets x " + reps + " reps";
            }
            workoutlists.Controls.Add(exercise);
        }
        private int[] RandomIndexer(int min, int max, int count)
        {
            HashSet<int> index = new HashSet<int>();

            while (index.Count < count)
            {
                int number = randNum.Next(min, max + 1);
                index.Add(number);
            }
            return index.ToArray();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
