//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
//{
//    internal class FestivalLuckyDraw
//    {
//        //variable to store total winners
//        static int totalWinners = 0;

//        //array to store winners names
//        static string[] winners = new string[10];
//        public static void Main(string[] args)
//        {
//            //create object
//            FestivalLuckyDraw festivalLuckyDraw = new FestivalLuckyDraw();

//            //call the DisplayChoices method
//            DisplayChoices(festivalLuckyDraw);
//        }

//        //--------------DISPLAY CHOICES-------------------
//        //method to display different choices
//        public static void DisplayChoices(FestivalLuckyDraw festivalLuckyDraw)
//        {
//            //infinite loop until user exits
//            while (true)
//            {
//                //display choices
//                Console.WriteLine("DIWALI MELA LUCKY DRAW");
//                Console.WriteLine("1. START");
//                Console.WriteLine("2. EXIT");
//                Console.Write("ENTER YOUR CHOICE: ");

//                //take user's choice
//                int choice = Convert.ToInt32(Console.ReadLine());

//                //handle user's choice
//                switch (choice)
//                {
//                    case 1:
//                        festivalLuckyDraw.StartLuckyDraw();
//                        break;

//                    case 2:
//                        Console.WriteLine("THANKYOU");
//                        return;

//                    default:
//                        Console.WriteLine("INVALID CHOICE");
//                        break;
//                }

//            }
//        }

//        //-----------START LUCKY DRAW----------------
//        //method to start lucky draw
//        public void StartLuckyDraw()
//        {
//            //take number of visitors input
//            Console.Write("ENTER NUMBER OF VISITORS: ");

//            int visitors = Convert.ToInt32(Console.ReadLine());

//            //validate visitors
//            if (!Validate(visitors))
//            {
//                Console.WriteLine("INVALID NUMBER OF VISITORS");
//                return;
//            }

//            //loop for each visitor
//            for (int i = 1; i <= visitors; i++)
//            {
//                //take name input
//                Console.WriteLine($"ENTER NAME OF PERSON {i}:");

//                string name = Console.ReadLine();

//                //validate name
//                if (!ValidateName(name))
//                {
//                    Console.WriteLine("ENTER VALID NAME");
//                    continue;
//                }

//                //take number input
//                Console.WriteLine("DRAW A NUMBER: ");

//                int number = Convert.ToInt32(Console.ReadLine());

//                //validate number
//                if (!Validate(number))
//                {
//                    Console.WriteLine("INVALID NUMBER INPUT");
//                    continue;
//                }

//                //call the CheckLuckyNumber method
//                CheckLuckyNumber(number, name);
//            }

//            //call the DisplayWinners method
//            DisplayWinners();

//        }

//        //---------------VALIDATE NAME--------------
//        //method to validate name input
//        public bool ValidateName(string name)
//        {
//            //check for null or empty input
//            if (name == null || name == "")
//            {
//                return false;
//            }

//            //loop to check each character
//            foreach (char c in name)
//            {
//                if (!char.IsLetter(c) && c != ' ')
//                    return false;
//            }

//            return true;
//        }

//        //-------------VALIDATE------------------
//        //method to validate number input
//        public bool Validate(int number)
//        {
//            return number > 0;
//        }

//        //----------CHECK LUCKY NUMBER--------------
//        //method to check lucky number
//        public void CheckLuckyNumber(int number, string name)
//        {
//            //if number is divisible by 3 and 5 then user wins
//            if (number % 3 == 0 && number % 5 == 0)
//            {
//                Console.WriteLine("YOU WON");

//                //add winner name in array and update total winners
//                winners[totalWinners++] = name;
//            }
//            else
//            {
//                Console.WriteLine("BETTER LUCK NEXT TIME");
//            }
//        }

//        //-------------DISPLAY WINNERS---------------
//        //method to display all the winner names
//        public void DisplayWinners()
//        {
//            //check if any winner exists
//            if (totalWinners > 0)
//            {
//                Console.WriteLine("\nWINNERS ARE: ");

//                //loop to display all winners
//                for (int i = 0; i < totalWinners; i++)
//                {
//                    Console.WriteLine(winners[i]);
//                }
//            }
//            else
//            {
//                Console.WriteLine("NO WINNERS");
//            }


//        }
//    }
//}
