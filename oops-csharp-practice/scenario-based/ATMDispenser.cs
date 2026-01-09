using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class ATMDispenser
    {
        //method to find the dispenses
        public static void dispenser(int amount, int[]notes)
        { 
            //loop through notes array
            for(int i=0;i<notes.Length; i++)
            {
                //if amount is greater than note
                if(amount>=notes[i])
                {
                    //find number of notes
                    int numberOfNote = amount / notes[i];

                    //update amount
                    amount %= notes[i];

                    //display note and number of notes 
                    Console.WriteLine($"{notes[i]} : {numberOfNote}");
                }
            }

            //if exact change is not possible
            if (amount != 0)
            {
                Console.WriteLine("EXACT CHANGE NOT POSSIBLE");

                Console.WriteLine("REMAINING AMOUNT: " + amount);
            }
        }

        //main method
        public static void Main(string[] args)
        {
            //notes array with all notes
            int[]notes ={ 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            //notes array without 500 note
            int[] notes2 = { 200, 100 ,50, 20, 10, 5, 2, 1 };
            
            //notes array without 2 and 1 rupee
            int[] notes3 = { 500, 200, 100, 50, 20, 10, 5 };

            //first scenario
            Console.WriteLine("SCENARIO 1 (WITH 500 NOTE)");
            dispenser(880,notes);

            //second scenario
            Console.WriteLine("\nSCENARIO 2 (WITHOUT 500 NOTE)");
            dispenser(880,notes2);

            //third scenario
            Console.WriteLine("\nSCENARIO 3 (EXACT CHANGE NOT POSSIBLE)");
            dispenser(2,notes3);

        }
    }
}
