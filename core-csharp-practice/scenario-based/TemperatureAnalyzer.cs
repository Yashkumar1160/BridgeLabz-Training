using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenario_based
{
    internal class TemperatureAnalyzer
    {
        public static void Main(string[] args)
        {
            //create 2D array to store temperatures
            int rows = 7;
            int cols = 24;

            //take input temperatures using TakeInput method
            float[,] temperatures = TakeInput(rows, cols);

            //call method to check users choice and start temperature analyzer
            CheckChoice(temperatures);
        }

        //------------------------------------------CHECK CHOICE--------------------------------

        //Method to analyze user's choice
        public static void CheckChoice(float[,] temperatures)
        {
            //infinite loop to display choices 
            while (true)
            {
                //display choices
                Console.WriteLine("1. Find Hottest and Coldest Day");
                Console.WriteLine("2. Find Average Temperature per day");
                Console.WriteLine("3. Exit");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //call methods based on choice
                switch (choice)
                {
                    case 1:
                        //call FindHottestDay and FindColdestDay methods
                        FindHottestDay(temperatures);
                        FindColdestDay(temperatures);
                        break;

                    case 2:
                        //call FindAverage method
                        FindAverage(temperatures);
                        break;

                    case 3:
                        //if choice is equal to 3 then break the loop and exit
                        Console.WriteLine("Exit Successful");
                        return;

                    default:
                        //if invalid input is encountered then allow user to try again
                        Console.WriteLine("Invalid Input Please Retry");
                        break;
                }
            }
        }

        //----------------------------------------CHECK INPUTS--------------------------------

        //Method to check temperature input
        public static bool CheckTemperature(float temp)
        {
            //temperature range
            float highest = 60;
            float lowest = -60;

            return temp >= lowest && temp <= highest;
        }

        //---------------------------------------TAKE INPUTS--------------------------------

        //Method to take temperature inputs 
        public static float[,] TakeInput(int rows, int cols)
        {
            //create 2D array to store temperatures
            float[,] temperatures = new float[rows, cols];

            Console.WriteLine("Temperature Range : -60 to + 60");
            //loop to take inputs

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("Enter temperature values for Day " + (i + 1));

                for (int j = 0; j < cols; j++)
                {
                    float temp = float.Parse(Console.ReadLine());
                    //check temperature input range

                    while (!CheckTemperature(temp))
                    {   //if not valid then retake input
                        Console.WriteLine("Invalid Temperature Input. Please try again");
                        temp = float.Parse(Console.ReadLine());
                    }

                    temperatures[i, j] = temp;
                }
            }
            //return temperatures array
            return temperatures;
        }

        //-----------------------------------------FIND HOTTEST DAY-----------------------------------

        //Method to find hottest day
        public static void FindHottestDay(float[,] temperatures)
        {
            //assume hottest day and hottest temp value
            int hottestDay = 0;
            float hottestTemp = float.MinValue;

            //loop through each day's temperature
            for (int i = 0; i < temperatures.GetLength(0); i++)
            {
                float totalTemp = 0;

                for (int j = 0; j < temperatures.GetLength(1); j++)
                {
                    //add temperatures of particular day
                    totalTemp += temperatures[i, j];
                }

                //check if the current temperature sum is greater than hottest temperature
                if (totalTemp > hottestTemp)
                {
                    //update variables
                    hottestTemp = totalTemp;
                    hottestDay = i;
                }
            }

            Console.WriteLine("Hottest Day : " + (hottestDay + 1));
        }

        //---------------------------------------------FIND COLDEST DAY-------------------------------------

        //Method to find coldest day
        public static void FindColdestDay(float[,] temperatures)
        {
            //assume coldest day and coldest temperature value 
            int coldestDay = 0;
            float coldestTemp = float.MaxValue;

            //loop through each day's temperature
            for (int i = 0; i < temperatures.GetLength(0); i++)
            {
                float totalTemp = 0;

                for (int j = 0; j < temperatures.GetLength(1); j++)
                {   //add temperatures of particular day
                    totalTemp += temperatures[i, j];
                }

                //check if current temperature sum is less than coldest temperature
                if (totalTemp < coldestTemp)
                {
                    //update variables
                    coldestTemp = totalTemp;
                    coldestDay = i;
                }
            }
            Console.WriteLine("Coldest Day : " + (coldestDay + 1));
        }

        //----------------------------------------------FIND AVERAGE----------------------------------------

        //Method to find average temperature of each day
        public static void FindAverage(float[,] temperatures)
        {
            //loop through each day's temperature
            for (int i = 0; i < temperatures.GetLength(0); i++)
            {
                //initialize totalTemp and averageTemp variables with 0
                float totalTemp = 0;
                float averageTemp = 0;

                for (int j = 0; j < temperatures.GetLength(1); j++)
                {
                    totalTemp += temperatures[i, j];
                }

                //calculate average temperature
                averageTemp = totalTemp / temperatures.GetLength(1);
                Console.WriteLine($"Average temperature for day {i + 1} is {averageTemp}");
            }
        }
    }
}
