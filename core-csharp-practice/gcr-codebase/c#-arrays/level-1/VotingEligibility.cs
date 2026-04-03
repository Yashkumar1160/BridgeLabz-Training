using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class VotingEligibility
    {
        public static void Main(string[] args)
        {
            //define an array of size 10
            int[] studentsAge = new int[10];

            //take user inputs for students age

            for (int i = 0; i < studentsAge.Length; i++)
            {
                Console.WriteLine("Enter number:");
                studentsAge[i] = Convert.ToInt32(Console.ReadLine());
            }

            //check if age is valid or not
            for (int i = 0; i < studentsAge.Length; i++)
            {
                if (studentsAge[i] < 0)
                {   //if student age is a negative number
                    Console.WriteLine("Invalid Age");
                }
                else if (studentsAge[i] >= 18)
                {   //if student age is greater than or equal to 18
                    Console.WriteLine("The student with age " + studentsAge[i] + " can vote.");
                }
                else
                {
                    //if student age is less than 18
                    Console.WriteLine("The student with age " + studentsAge[i] + " cannot vote.");
                }
            }

        }
    }
}
