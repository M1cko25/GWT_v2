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

namespace GWT_V2
{
    public partial class WorkoutDisplay : UserControl
    {
        BackExer backEx = new BackExer();
        ShoulderExer shoulderEx = new ShoulderExer();
        ArmExer armEx = new ArmExer();
        ChestExer chestEx = new ChestExer();
        AbsExer absEx = new AbsExer();
        ButtExer buttEx = new ButtExer();
        LegExer legEx = new LegExer();
        
        public User user { get; set; }
        public WorkoutDisplay()
        {
            InitializeComponent();
        }

        private void viewAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (workoutLbl.Text == "Back Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleBackGWT;
                view.workoutLbl.Text = "Back Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, backEx.BackImgs[i], backEx.BackName[i], setByGender, backEx.BackReps[i]);
                    }
                } else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, backEx.BackImgs[i], backEx.BackName[i], setByGender, backEx.BackReps[i]);
                    }
                } else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, backEx.BackImgs[i], backEx.BackName[i], setByGender, backEx.BackReps[i]);
                    }
                }
                    view.Show();
            } 
            else if (workoutLbl.Text == "Shoulder Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleShoulderGWT;
                view.workoutLbl.Text = "Shoulder Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, shoulderEx.ShoulderImgs[i], shoulderEx.ShoulderName[i], setByGender, shoulderEx.ShoulderReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, shoulderEx.ShoulderImgs[i], shoulderEx.ShoulderName[i], setByGender, shoulderEx.ShoulderReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, shoulderEx.ShoulderImgs[i], shoulderEx.ShoulderName[i], setByGender, shoulderEx.ShoulderReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Arm Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleArmGWT;
                view.workoutLbl.Text = "Arm Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, armEx.ArmImgs[i], armEx.ArmName[i], setByGender, armEx.ArmReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, armEx.ArmImgs[i], armEx.ArmName[i], setByGender, armEx.ArmReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, armEx.ArmImgs[i], armEx.ArmName[i], setByGender, armEx.ArmReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Chest Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleChestGWT;
                view.workoutLbl.Text = "Chest Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, chestEx.ChestImgs[i], chestEx.ChestName[i], setByGender, chestEx.ChestReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, chestEx.ChestImgs[i], chestEx.ChestName[i], setByGender, chestEx.ChestReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, chestEx.ChestImgs[i], chestEx.ChestName[i], setByGender, chestEx.ChestReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Abs Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleAbsGWT;
                view.workoutLbl.Text = "Abs Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, absEx.AbsImgs[i], absEx.AbsName[i], setByGender, absEx.AbsReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, absEx.AbsImgs[i], absEx.AbsName[i], setByGender, absEx.AbsReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, absEx.AbsImgs[i], absEx.AbsName[i], setByGender, absEx.AbsReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Butt Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleButtGWT;
                view.workoutLbl.Text = "Butt Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, buttEx.ButtImgs[i], buttEx.ButtName[i], setByGender, buttEx.ButtReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, buttEx.ButtImgs[i], buttEx.ButtName[i], setByGender, buttEx.ButtReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, buttEx.ButtImgs[i], buttEx.ButtName[i], setByGender, buttEx.ButtReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Leg Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleLegGWT;
                view.workoutLbl.Text = "Leg Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                if (user.BodyType == "Under Weight" || user.BodyType == "Underweight")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        showView(view, legEx.LegImgs[i], legEx.LegName[i], setByGender, legEx.LegReps[i]);
                    }
                }
                else if (user.BodyType == "Normal")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        showView(view, legEx.LegImgs[i], legEx.LegName[i], setByGender, legEx.LegReps[i]);
                    }
                }
                else if (user.BodyType == "Over Weight")
                {
                    for (int i = 0; i < 7; i++)
                    {
                        showView(view, legEx.LegImgs[i], legEx.LegName[i], setByGender, legEx.LegReps[i]);
                    }
                }
                view.Show();
            }
            else if (workoutLbl.Text == "Full Body Workout")
            {
                MainForm main = (MainForm)this.FindForm();
                main.Hide();
                WorkoutView view = new WorkoutView(main);
                view.MuscleDiagram.Image = Resources.muscleFull;
                view.workoutLbl.Text = "Full Body Workout";
                view.workoutlists.Controls.Clear();
                string setByGender = (user.Gender == "Male") ? "4" : "3";
                showView(view, backEx.BackImgs[0], backEx.BackName[0], setByGender, backEx.BackReps[0]);
                showView(view, shoulderEx.ShoulderImgs[0], shoulderEx.ShoulderName[0], setByGender, shoulderEx.ShoulderReps[0]);
                showView(view, armEx.ArmImgs[0], armEx.ArmName[0], setByGender, armEx.ArmReps[0]);
                showView(view, chestEx.ChestImgs[0], chestEx.ChestName[0], setByGender, chestEx.ChestReps[0]);
                showView(view, absEx.AbsImgs[0], absEx.AbsName[0], setByGender, absEx.AbsReps[0]);
                showView(view, buttEx.ButtImgs[0], buttEx.ButtName[0], setByGender, buttEx.ButtReps[0]);
                showView(view, legEx.LegImgs[0], legEx.LegName[0], setByGender, legEx.LegReps[0]);
                view.Show();
            }
        }

        public void showView(WorkoutView view, Image demoPic, string name, string sets, string reps)
        {
            Workout exercise = new Workout();
            exercise.demoPic.Image = demoPic;
            exercise.name.Text = name;
            if (reps.Contains("secs") || reps.Contains("mins"))
            {
                exercise.setReps.Text = sets + " sets x " + reps;
            } else
            {
                exercise.setReps.Text = sets + " sets x " + reps + " reps";
            }
            view.user = user;
            view.workoutlists.Controls.Add(exercise);
        }
    }
}