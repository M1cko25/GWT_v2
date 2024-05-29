using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWT_V2.Properties;
using System.Drawing;

namespace GWT_V2
{
    public class Workouts
    {
        
    }
    public class BackExer
    {
        public string[] BackName = { "Pull Ups", "Bent Over Rows", "Dead Hang", "Lat Pull Downs", "Seated Cable Rows", "One Arm Dumbbell Row",
            "Deadlift", "Alternate Renegade Row", "Farmers Walk", "Band Lat Pull Down", "Chest Supported Rows", "Barbell Dead Row" };
        public string[] BackReps = { "6", "12", "00:20 secs", "8", "12", "12", "4-8", "8-12", "00:30 secs", "12", "8", "12" };
        public Image[] BackImgs = { Resources.PullUpsimgGWT, Resources.BentOverRowsimgGWT, Resources.deadHangimgGWT, Resources.latPullDownimgGWT, Resources.seatedCableRowsimgGWT, Resources.oneArmDumbbellRowimgGWT,
        Resources.deadliftimgGWT, Resources.renegadeRowsimgGWT, Resources.farmersWalkimgGWT, Resources.bandLatPulldownimgGWT, Resources.chestBellRowimgGWT, Resources.barbellRowimgGWT };
        public Image[] BackGifs = { Resources.PullUpsgifGWT, Resources.BentOverRowsgifGWT, Resources.deadHanggifGWT, Resources.latPullDowngifGWT, Resources.seatedCableRowsgifGWT, Resources.oneArmDumbbellRowgifGWT,
        Resources.deadliftgifGWT, Resources.renegadeRowsgifGWT, Resources.farmersWalkgifGWT, Resources.bandLatPulldowngifGWT, Resources.chestBellRowgifGWT, Resources.barbellRowgifGWT };
    }
    public class ShoulderExer
    {
        public string[] ShoulderName = { "Dumbbell Shoulder Press", "Seated Barbell Shoulder Press", "Arm Circles", "Dumbbell Lateral Raise", "Side Arm Raise", "Cable Lateral Raise", "Machine Shoulder Press", "Overhead Press", "Dumbbell 4 Way Lateral Raise", "Seated Behind Neck Press", "Arnold Press", "Bent Over Lateral Raise" };
        public string[] ShoulderReps = { "8", "8", "20", "12", "12", "6", "8", "8", "8", "5", "8", "12" };
        public Image[] ShoulderImgs = { Resources.Dumbbell_Shoulder_PressimgGWT, Resources.Seated_Shoulder_PressimgGWT, Resources.armCirclesShouldersimgGWT, Resources.Dumbbell_Lateral_RaiseimgGWT, Resources.side_arm_raiseimgGWT, Resources.one_arm_Cable_Lateral_RaiseimgGWT,
            Resources.Machine_Shoulder_PressimgGWT, Resources.Overhead_PressimgGWT,Resources.Dumbbell_4_Ways_Lateral_RaiseimgGWT, Resources.Seated_Behind_the_Neck_PressimgGWT, Resources.ArnoldPressimgGWT, Resources.Bent_Over_Lateral_RaiseimgGWT };
        public Image[] ShoulderGifs = { Resources.Dumbbell_Shoulder_PressgifGWT, Resources.Seated_Shoulder_PressgifGWT, Resources.armCirclesShouldersgifGWT, Resources.Dumbbell_Lateral_RaisegifGWT, Resources.side_arm_raisegifGWT, Resources.one_arm_Cable_Lateral_RaisegifGWT,
            Resources.Machine_Shoulder_PressgifGWT, Resources.Overhead_PressgifGWT, Resources.Dumbbell_4_Ways_Lateral_RaisegifGWT, Resources.Seated_Behind_the_Neck_PressgifGWT, Resources.ArnoldPressgifGWT, Resources.Bent_Over_Lateral_RaisegifGWT };

    }

    public class ChestExer
    {
        public string[] ChestName = { "Incline Chest Fly Machine", "Bench Press", "Pec Deck Fly", "Dumbbell Pullover", "Low Cable Crossover", "High Cable Crossover", "Cable Upper Chest Crossover", "Incline Barbell Bench Press", "Dumbbell Fly", "Dumbbell Press", "Incline Dumbbell Fly", "Machine Fly" };
        public string[] ChestReps = { "12", "10", "10", "8", "8", "8", "8", "12", "10", "12", "10", "10" };
        public Image[] ChestImgs = { Resources.Incline_Chest_Fly_MachineimgGWT, Resources.Barbell_Bench_PressimgGWT, Resources.Pec_Deck_FlyimgGWT, Resources.Dumbbell_PulloverimgGWT, Resources.Low_Cable_CrossoverimgGWT, Resources.High_Cable_CrossoverimgGWT,
        Resources.Cable_Upper_Chest_CrossoversimgGWT, Resources.Incline_Barbell_Bench_PressimgGWT, Resources.Dumbbell_FlyimgGWT, Resources.Dumbbell_PressimgGWT, Resources.Incline_dumbbell_FlyimgGWT, Resources.Machine_FlyimgGWT };
        public Image[] ChestGifs = { Resources.Incline_Chest_Fly_MachinegifGWT, Resources.Barbell_Bench_PressgifGWT, Resources.Pec_Deck_FlygifGWT, Resources.Dumbbell_PullovergifGWT, Resources.Low_Cable_CrossovergifGWT, Resources.High_Cable_CrossovergifGWT,
        Resources.Cable_Upper_Chest_CrossoversgifGWT, Resources.Incline_Barbell_Bench_PressgifGWT, Resources.Dumbbell_FlygifGWT, Resources.Dumbbell_PressgifGWT, Resources.Incline_dumbbell_FlygifGWT, Resources.Machine_FlygifGWT };

    }

    public class AbsExer
    {
        public string[] AbsName = { "Medicine Ball Rotational Throw", "Dragon Flag", "Ab Coaster Machine", "Cross Crunch", "Standing Cable Crunch", "Seated Bench Leg Pull In", "Cross Body Mountain Climber", "Alternate Leg Raises", "Crunches", "Mountain Climber", "Bicycle Crunch", "Oblique Floor Crunches" };
        public string[] AbsReps = { "6", "5", "10", "20", "12", "12", "15", "26", "25", "20", "20", "15" };
        public Image[] AbsImgs = { Resources.Medicine_Ball_Rotational_ThrowimgGWT, Resources.Dragon_FlagimgGWT, Resources.Ab_Coaster_MachineimgGWT, Resources.Cross_CrunchimgGWT, Resources.Standing_Cable_CrunchimgGWT, Resources.Seated_Bench_Leg_Pull_inimgGWT,
        Resources.Cross_Body_Mountain_ClimberimgGWT, Resources.Alternate_Leg_RaisesimgGWT, Resources.CrunchimgGWT, Resources.Mountain_climberimgGWT, Resources.Bicycle_CrunchimgGWT, Resources.Oblique_Floor_CrunchesimgGWT };
        public Image[] AbsGifs = { Resources.Medicine_Ball_Rotational_ThrowgifGWT, Resources.Dragon_FlaggifGWT, Resources.Ab_Coaster_MachinegifGWT, Resources.Cross_CrunchgifGWT, Resources.Standing_Cable_CrunchgifGWT, Resources.Seated_Bench_Leg_Pull_ingifGWT,
        Resources.Cross_Body_Mountain_ClimbergifGWT, Resources.Alternate_Leg_RaisesgifGWT, Resources.CrunchgifGWT, Resources.Mountain_climbergifGWT, Resources.Bicycle_CrunchgifGWT, Resources.Oblique_Floor_CrunchesgifGWT };

    }

    public class LegExer
    {
        public string[] LegName = { "Dumbbell Goblet Squat", "Curtsy Lunge", "Standing Leg Circles", "Static Lunge", "Dumbbell Walking Lunge", "Dumbbell Squat", "Dumbbell Deadlift", "Dumbbell Sumo Deadlift", "Barbell Squat", "Leg Press", "Deadlift", "Leg Curl" };
        public string[] LegReps = { "10", "8", "8", "12", "12", "12", "8", "6", "10", "12", "6", "20" };
        public Image[] LegImgs = { Resources.Dumbbell_Goblet_SquatimgGWT, Resources.curtsy_lungeimgGWT, Resources.Standing_Leg_CirclesimgGWT, Resources.Static_LungeimgGWT, Resources.dumbbell_lungesimgGWT, Resources.Dumbbell_SquatimgGWT,
        Resources.dumbbell_deadliftsimgGWT, Resources.dumbbell_sumo_deadliftimgGWT, Resources.BARBELL_SQUATimgGWT, Resources.Leg_PressimgGWT, Resources.deadliftimgGWT, Resources.Leg_CurlimgGWT };
        public Image[] LegGifs = { Resources.Dumbbell_Goblet_SquatgifGWT, Resources.curtsy_lungegifGWT, Resources.Standing_Leg_CirclesgifGWT, Resources.Static_LungegifGWT, Resources.dumbbell_deadliftsimgGWT, Resources.Dumbbell_SquatgifGWT,
        Resources.dumbbell_deadliftsgifGWT, Resources.dumbbell_sumo_deadliftgifGWT, Resources.BARBELL_SQUATgifGWT, Resources.Leg_PressgifGWT, Resources.deadliftgifGWT, Resources.Leg_PressgifGWT };

    }

    public class ArmExer
    {
        public string[] ArmName = { "Medicine Ball Overhead Throw", "One Arm Triceps Pushdown", "Dumbbell KickBack", "One Arm Reverse Pushdown", "Pushdown", "Bench Dips", "Triceps Dips", "Cable Rope Overhead Triceps Extension", "Lever Triceps Dip", "Triceps Dips On Floor", "Wall Push Up", "Seated Dumbbell Triceps Extension" };
        public string[] ArmReps = { "6", "10", "12", "10", "15", "10", "12", "12", "10", "10", "50", "12" };
        public Image[] ArmImgs = { Resources.Medicine_Ball_Overhead_ThrowimgGWT, Resources.One_arm_triceps_pushdownimgGWT, Resources.Dumbbell_KickbackimgGWT, Resources.One_Arm_Reverse_Push_DownimgGWT, Resources.PushdownimgGWT, Resources.Bench_DipsimgGWT,
        Resources.Triceps_DipsimgGWT, Resources.Cable_Rope_Overhead_Triceps_ExtensionimgGWT, Resources.Lever_Overhand_Triceps_DipimgGWT, Resources.Triceps_dips_on_floorsimgGWT, Resources.Wall_Push_upsimgGWT, Resources.Seated_Dumbbell_Triceps_ExtensionimgGWT };
        public Image[] ArmGifs = { Resources.Medicine_Ball_Overhead_ThrowgifGWT, Resources.One_arm_triceps_pushdowngifGWT, Resources.Dumbbell_KickbackgifGWT, Resources.One_Arm_Reverse_Push_DowngifGWT, Resources.PushdowngifGWT, Resources.Bench_DipsgifGWT,
        Resources.Triceps_DipsgifGWT, Resources.Cable_Rope_Overhead_Triceps_ExtensiongifGWT, Resources.Lever_Overhand_Triceps_DipgifGWT, Resources.Triceps_dips_on_floorsgifGWT, Resources.Wall_Push_upsgifGWT, Resources.Seated_Dumbbell_Triceps_ExtensiongifGWT };

    }

    public class ButtExer
    {
        public string[] ButtName = { "Barbell Lateral Lunge", "Standing Hip Abduction", "Kettlebell Single Leg Deadlift", "Side Lying Clam", "Reverse Lunge Knee Lift", "Curtsy Squat", "Jump Squat", "Standing Hip Extension", "Bodyweight Hip Thrust", "Wall Sit", "KettleBell Swing", "Bodyweight Single Leg Deadlift" };
        public string[] ButtReps = { "10", "12", "12", "10", "10", "8", "12", "8", "20", "00:30 secs", "6", "8" };
        public Image[] ButtImgs = { Resources.Barbell_Lateral_LungeimgGWT, Resources.Standing_Hip_Abduction_1imgGWT, Resources.Kettlebell_Single_Leg_DeadliftimgGWT, Resources.Side_Lying_ClamimgGWT, Resources.Reverse_Lunge_KneeimgGWT, Resources.Curtsey_SquatimgGWT,
        Resources.Jump_SquatimgGWT, Resources.Standing_Hip_ExtensionimgGWT, Resources.bodyweight_hip_thrustimgGWT, Resources.Wall_SitimgGWT, Resources.Kettlebell_SwingsimgGWT, Resources.Bodyweight_Single_Leg_DeadliftimgGWT };
        public Image[] ButtGifs = { Resources.Barbell_Lateral_LungegifGWT, Resources.Standing_Hip_Abduction_1gifGWT, Resources.Kettlebell_Single_Leg_DeadliftgifGWT, Resources.Side_Lying_ClamgifGWT, Resources.Reverse_Lunge_KneegifGWT, Resources.Curtsey_SquatgifGWT,
        Resources.Jump_SquatgifGWT, Resources.Standing_Hip_ExtensiongifGWT, Resources.bodyweight_hip_thrustgifGWT, Resources.Wall_SitimgGWT, Resources.Kettlebell_SwingsgifGWT, Resources.Bodyweight_Single_Leg_DeadliftgifGWT };

    }

    
}
