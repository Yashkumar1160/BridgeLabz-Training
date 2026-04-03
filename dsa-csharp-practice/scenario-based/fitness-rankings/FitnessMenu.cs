using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_rankings
{
    internal class FitnessMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("------FITTNESS RANKINGS------");

            //create object of FitnessUtilityImpl class
            FitnessUtilityImpl utility=new FitnessUtilityImpl();

            //generate random data
            utility.GenerateRandomData();

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. UPDATE PERSON STEPS");
                Console.WriteLine("2. DISPLAY TOTAL PERSON");
                Console.WriteLine("3. DISPLAY PESRON DATA");
                Console.WriteLine("4. DISPLAY PERSON DATA BY RANK");
                Console.WriteLine("5. SORT DATA BY STEPS");
                Console.WriteLine("6.EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //update person steps
                    case 1:
                        //take person name
                        Console.Write("\nENTER PERSON NAME: ");
                        string personName=Console.ReadLine();

                        //check if person exists in array
                        if (!utility.SearchPerson(personName))
                        {
                            Console.WriteLine("\nPERSON DOES NOT EXIST");
                            break;
                        }

                        //take new steps
                        Console.Write("ENTER NEW STEPS: ");
                        int steps=Convert.ToInt32(Console.ReadLine());

                        utility.UpdateData(personName, steps);
                        break;

                    //display total persons
                    case 2:
                        utility.DisplayTotalPerson();
                        break;


                    //display each person data
                    case 3:
                        utility.DisplayData();
                        break;

                    //display each person data by rank
                    case 4:
                        utility.DisplayByRank();
                        break;

                    //sort person data by steps
                    case 5:
                        utility.BubbleSort();
                        Console.WriteLine("\nSORTED SUCCESSFULLY");
                        break;

                    //exit
                    case 6:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;

                }
            }
        }
    }
}
