using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class SelectionSort
    {
        public static void Main(string[] args)
        {
            //take input for number of Students 
            Console.Write("ENTER NUMBER OF STUDENTS: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //create array to store scores
            int[] scores = new int[numberOfStudents];

            //loop to take score inputs
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("ENTER SCORE OF STUDENT " + (i + 1) + " : ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call SortScores method 
            SortScores(scores);

            //display sorted scores array
            Console.WriteLine("SORTED SCORES:");
            foreach (int score in scores)
                Console.Write(score + " ");
        }

        //method to sort array using selection sort
        public static void SortScores(int[] scores)
        {
            //traverse through scores array except last element
            for (int i = 0; i < scores.Length - 1; i++)
            {
                //assume current index as minimum value
                int min = i;

                //loop to find minimumm element in remaining array
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[min])
                    {
                        min = j;
                    }
                }

                //swap the found minimum element with first unsorted element 
                int temp = scores[min];
                scores[min] = scores[i];
                scores[i] = temp;
            }
        }
    }
}
