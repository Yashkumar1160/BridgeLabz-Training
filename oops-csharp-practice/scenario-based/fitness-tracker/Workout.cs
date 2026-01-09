using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal abstract class Workout
    {
        //variable to store workout name
        private string workoutName;

  
        //getter and setter for workoutName
        public string WorkoutName
        {
            get { return workoutName; } 
            set { workoutName = value; }
        }

        //constructor
        public Workout(string workoutName)
        {
            WorkoutName = workoutName;
        }
    }
}
