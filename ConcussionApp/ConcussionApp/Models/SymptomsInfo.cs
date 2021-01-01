using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ConcussionApp.Models
{
    public class SymptomsInfo

    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime Date { get; set; }
        public double HeadacheValue { get; set; }
        public double HeadPressureVal { get; set; }
        public double NeckPainVal { get; set; }
        public double NauseaVal { get; set; }
        public double DizzinessVal { get; set; }
        public double BlurryVisVal { get; set; }
        public double BalanceVal { get; set; }
        public double LightSenseVal { get; set; }
        public double NoiseSenseVal { get; set; }
        public double SlowVal { get; set; }
        public double FogFeelVal { get; set; }
        public double FeelRightVal { get; set; }
        public double ConcentrateVal { get; set; }
        public double RememberVal { get; set; }
        public double FatigueVal { get; set; }
        public double ConfusionVal { get; set; }
        public double DrowsinessVal { get; set; }
        public double FallAsleepVal { get; set; }
        public double MoreEmotionVal { get; set; }
        public double IrritabilityVal { get; set; }
        public double SadnessVal { get; set; }
        public double NervousVal { get; set; }
        public double SleepMoreVal { get; set; }
        public double SleepLessVal { get; set; }
        public double SleepSoundVal { get; set; }
        public double RingEarVal { get; set; }
        public double NumbnessVal { get; set; }
        public double SymptomScore { get; set; }


      
    }
}
