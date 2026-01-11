using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class CountingSort
    {
        public static void Main()
        {
            //take input for number of students
            Console.Write("ENTER NUMBER OF STUDENTS: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //array to store student ages
            int[] ages = new int[numberOfStudents];

            //count array to store frequency of each age (0–18)
            int[] count = new int[19];

            //take input for ages and update count array
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("ENTER AGE OF STUDENT " + (i + 1) + " : ");
                int age = Convert.ToInt32(Console.ReadLine());
                
                //check age input
                if (age < 10 || age > 18)
                {
                    Console.WriteLine("INVALID AGE\n ENTER AGE BETWEEN 10 AND 18.");
                    i--; // retry current student
                    continue;
                }

                //store age
                ages[i] = age;
                
                //increase count
                count[age]++;
            }

            //display sorted ages
            Console.WriteLine("SORTED AGES:");

            //loop to print ages based on their frequency
            for (int age = 10; age <= 18; age++)
            {
                while (count[age] > 0)
                {
                    Console.Write(age + " ");
                    count[age]--;
                }
            }
        }
    }
}
