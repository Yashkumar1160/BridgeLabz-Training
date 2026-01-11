using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class InsertionSort
    {
        public static void Main(string[] args)
        {
            //take input for number of employees 
            Console.Write("ENTER NUMBER OF EMPLOYEES: ");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            //create array to store id's
            int[] employeeId = new int[numberOfEmployees];

            //loop to take employee id
            for (int i = 0; i < numberOfEmployees; i++)
            {
                Console.Write("ENTER ID OF EMPLOYEE " + (i + 1) + " : ");
                employeeId[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call SortemployeeId method 
            SortEmployeeID(employeeId);

            //display sorted employee id array
            Console.WriteLine("SORTED IDs:");
            foreach (int id in employeeId)
                Console.Write(id + " ");
        }

        public static void SortEmployeeID(int[] employeeId)
        {
            //start loop from index 1
            for (int i = 1; i < employeeId.Length; i++)
            {
                //current element to be inserted into sorted part
                int curr = employeeId[i];

                //variable to store index of previous element
                int prev = i - 1;

                //shift elements of the sorted part that are greater than current   
                while (prev >= 0 && employeeId[prev] > curr)
                {
                    employeeId[prev + 1] = employeeId[prev];
                    prev--;
                }

                //place current element at correct position
                employeeId[prev + 1] = curr;

            }

        }
    }
}
