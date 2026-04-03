using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class AthleteRounds
    {
        public static void Main(string[] args)
        {
            //take user inputs for three sides of triangle
            Console.WriteLine("Enter distance of first side");
            double firstSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance of second side");
            double secondSide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance of third side");
            double thirdSide = Convert.ToDouble(Console.ReadLine());

            //create instance of class
            AthleteRounds athleteRounds = new AthleteRounds();

            //call CalculateTotalRounds() method
            double rounds = athleteRounds.CalculateTotalRounds(firstSide, secondSide, thirdSide);
            //display result
            Console.WriteLine("Total number of rounds : " + rounds);
        }
        //Method to calculate total number of rounds
        public double CalculateTotalRounds(double firstSide, double secondSide, double thirdSide)
        {
            //find perimeter of triangle
            double perimeter = firstSide + secondSide + thirdSide;
            //find total rounds
            double rounds = 5000 / perimeter;
            //return total rounds value
            return rounds;

        }
    }
}
