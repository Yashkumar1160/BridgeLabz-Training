using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class CardioWorkout : Workout 
    {
        //storing different met values for different workouts
        double metWalking = 3.4;

        double metJogging = 7.0;
        
        double metRunning = 9.8;
        
        double metCycling = 8.0;
        
        double metSkipping = 12.0;

        //constructor
        public CardioWorkout(string workoutName) : base(workoutName) { }

        //getters for different fields
        public double MetWalking
        {
            get { return metWalking; } 
        }

        public double MetJogging
        {
            get { return metJogging; }
        }

        public double MetRunning
        {
            get { return metRunning; }
        }

        public double MetCycling
        {
            get { return metCycling; }
        }

        public double MetSkipping
        {
            get { return metSkipping; }
        }
    }
}
