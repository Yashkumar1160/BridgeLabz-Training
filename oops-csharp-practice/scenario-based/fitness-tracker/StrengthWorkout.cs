using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class StrengthWorkout : Workout 
    {
        //storing different met values for different workouts
        double metLight = 3.0;

        double metModerate = 5.0;
        
        double metHeavy = 6.0;
        public StrengthWorkout(string workoutName) : base(workoutName) { }


        //getters for different fields
        public double MetLight
        {
            get {  return metLight; } 
        }

        public double MetModerate
        {
            get { return metModerate; }
        }

        public double MetHeavy
        {
            get { return metHeavy; }
        }

    }
}
