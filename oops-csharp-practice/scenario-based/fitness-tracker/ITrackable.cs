using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal interface ITrackable
    {
        //method to start workout
        DateTime StartWorkout();

        //method to end workout
        DateTime StopWorkout();

        //method to calculate burned calories
        double CalculateCalories(double metValue,TimeSpan duration,double weight);
    }
}
