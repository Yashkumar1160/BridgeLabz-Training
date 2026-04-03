using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class NumberGuessingGame
    {
        public static void Main(string[] args)
        {
            //tell user to think about a number
            Console.WriteLine("Think of a number between 1 and 100");
            //start number guessing game
            StartGame();
        }
        //method to start number guessing game
        public static void StartGame()
        {   //high and low range
            int low = 1;
            int high = 100;
            //string to collect feedback on every guess
            string feedback;
            //loop until number is guessed correctly
            while (true)
            {
                //generate a number guess
                int guess = GuessNumber(low, high);
                //display guess and ask user to give feedback
                Console.WriteLine("Is your number : " + guess);
                Console.WriteLine("High/Low/Correct");
                feedback = Console.ReadLine().ToLower();

                if (feedback == "high")
                {   //if guess is too high
                    high = guess - 1;
                }
                else if (feedback == "low")
                {   //if guess is too low
                    low = guess + 1;
                }
                else
                {   //if guess is correct
                    Console.WriteLine("Computer guessed correct number");
                    break;
                }
            }
        }
        //method to guess number
        public static int GuessNumber(int low, int high)
        {
            return (low + high) / 2;
        }
    }
}
