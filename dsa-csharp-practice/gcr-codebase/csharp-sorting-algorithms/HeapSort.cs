using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class HeapSort
    {
        public static void Main()
        {
            //take input for number of applicants
            Console.Write("ENTER NUMBER OF APPLICANTS: ");
            int numberOfApplicants = Convert.ToInt32(Console.ReadLine());

            //array to store expected salaries
            int[] salaries = new int[numberOfApplicants];

            //loop to take salary inputs
            for (int i = 0; i < numberOfApplicants; i++)
            {
                Console.Write("ENTER EXPECTED SALARY " + (i + 1) + " : ");
                salaries[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call HeapSorting method
            HeapSorting(salaries);

            //display sorted salaries
            Console.WriteLine("SORTED SALARIES:");
            foreach (int s in salaries)
                Console.Write(s + " ");
        }

        //method to sort array
        public static void HeapSorting(int[] salaries)
        {
            //variable to store array length
            int n = salaries.Length;

            //build Max Heap from the array
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(salaries, n, i);

            //extract elements from heap one by one
            for (int i = n - 1; i > 0; i--)
            {
                //move largest element to the end
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;

                //reheapify the reduced heap
                Heapify(salaries, i, 0);
            }
        }

        //method to maintain Max Heap property
        public static void Heapify(int[] salaries, int n, int i)
        {
            //assume current index is the largest
            int largest = i;

            //left and right child indices
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            //check if left child is larger than root
            if (left < n && salaries[left] > salaries[largest])
                largest = left;

            //check if right child is larger than largest so far
            if (right < n && salaries[right] > salaries[largest])
                largest = right;

            //if largest is not root then swap and continue heapifying
            if (largest != i)
            {
                int temp = salaries[i];
                salaries[i] = salaries[largest];
                salaries[largest] = temp;

                //recursively heapify the affected subtree
                Heapify(salaries, n, largest);
            }
        }
    }
}
