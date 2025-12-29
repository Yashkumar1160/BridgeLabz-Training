using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace BridgeLabzTraining.scenario_based
{
    internal class StudentsScores
    {
        public static void Main(string[] args)
        {
            //take input scores
            int[] scores = TakeInputs();

            //start score analyzer 
            CheckChoice(scores);

        }

        //-----------------------------------------CHECK SCORE------------------------------------

        //Method to check input score validity
        public static bool CheckScore(int score)
        {
            return score >= 0 ? true : false;
        }


        //------------------------------------------TAKE INPUTS------------------------------------

        //Method to take input students scores and store it in array
        public static int[] TakeInputs()
        {
            //take number of students
            Console.WriteLine("ENTER NUMBER OF STUDENTS: ");

            int n = Convert.ToInt32(Console.ReadLine());

            //if user enters number less than or equal to 0
            if (n <= 0)
            {
                Console.WriteLine("Number of students must be greater than 0");
                return TakeInputs();
            }

            //create array of size n
            int[] scores = new int[n];

            //take input scores
            Console.WriteLine("ENTER SCORES: ");

            for (int i = 0; i < n; i++)
            {
                int score = Convert.ToInt32(Console.ReadLine());

                //check if the input is valid
                while (!CheckScore(score))
                {
                    Console.WriteLine("Invalid Input");

                    score = Convert.ToInt32(Console.ReadLine());
                }

                scores[i] = score;
            }

            return scores;

        }

        //------------------------------------------CHECK CHOICE------------------------------------

        //Method to display and handle users choices
        public static void CheckChoice(int[] scores)
        {
            while (true)
            {

                //display choices to users
                Console.WriteLine("1. Find average score");
                Console.WriteLine("2. Find highest and lowest scores");
                Console.WriteLine("3. Display scores above average");
                Console.WriteLine("4. Exit");

                //take user input choice
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //if choice is 1 then call FindAverage method
                        float average = FindAverage(scores);
                        Console.WriteLine("Average is : " + average);
                        break;

                    case 2:
                        //if choice is 2 then call FindHighest and FindLowest method
                        int highestScore = FindHighest(scores);
                        int lowestScore = FindLowest(scores);
                        Console.WriteLine($"Highest score: {highestScore} Lowest score: {lowestScore}");
                        break;

                    case 3:
                        //if choice is 3 then call ScoresAboveAverage method
                        Console.WriteLine("Scores above average: ");
                        ScoresAboveAverage(scores);
                        break;

                    case 4:
                        //if choice is 4 then display message and return
                        Console.WriteLine("Exit Successful");
                        return;

                    default:
                        //if the input choice is invalid
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }


        //------------------------------------------FIND AVERAGE------------------------------------

        //Method to find average score
        public static float FindAverage(int[] scores)
        {
            //initialize total variable to 0
            int total = 0;

            //loop through scores array and calculate total sum
            for (int i = 0; i < scores.Length; i++)
            {
                total += scores[i];
            }

            //calculate average
            float average = (float)total / scores.Length;

            //return average
            return average;
        }


        //------------------------------------------FIND HIGHEST------------------------------------

        //Method to find highest score
        public static int FindHighest(int[] scores)
        {
            //assume maximum score
            int max = scores[0];

            //loop through scores array
            for (int i = 1; i < scores.Length; i++)
            {
                //if score greater than previous is encountered
                if (scores[i] > max)
                {
                    //update max
                    max = scores[i];
                }
            }

            //return max
            return max;
        }

        //------------------------------------------FIND LOWEST------------------------------------

        //Method to find lowest score
        public static int FindLowest(int[] scores)
        {
            //assume minimum score
            int min = scores[0];

            //loop through scores array
            for (int i = 1; i < scores.Length; i++)
            {
                //if score less than current minimum is encountered
                if (scores[i] < min)
                {
                    //update min
                    min = scores[i];
                }
            }

            //return min
            return min;
        }

        //------------------------------------------SCORES ABOVE AVERAGE------------------------------------

        //Method to display scores above average
        public static void ScoresAboveAverage(int[] scores)
        {
            //call FindAverage method to calculate average
            float average = FindAverage(scores);

            //loop through scores array
            for (int i = 0; i < scores.Length; i++)
            {
                //if score greater than average is found then display it 
                if (scores[i] > average)
                {
                    Console.Write(scores[i] + " ");
                }
            }
            Console.WriteLine();
        }

    }
}
