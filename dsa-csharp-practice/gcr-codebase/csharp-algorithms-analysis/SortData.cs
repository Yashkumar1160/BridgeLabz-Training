using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_algorithms_analysis
{
    internal class SortData
    {
        public static void Main(string[] args)
        {
            //take array size
            Console.Write("ENTER SIZE OF ARRAY: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store numbers 
            int[] numbers = new int[size];
            int[] numbers2 = new int[size];
            int[] numbers3 = new int[size];

            //loop to take number inputs
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = numbers2[i] = numbers3[i] = Convert.ToInt32(Console.ReadLine());
            }

            //using bubble sort
            Console.WriteLine("\nBUBBLE SORT RESULT: ");

            //using data time to analyze algorithms
            DateTime bubbleStart = DateTime.Now;
            BubbleSort(numbers);
            DateTime bubbleEnd = DateTime.Now;

            Console.WriteLine("Bubble Sort Time: " + (bubbleEnd - bubbleStart).TotalMilliseconds + " ms");

            //display result after sorting
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            //using merge sort
            Console.WriteLine("\nMERGE SORT RESULT: ");

            DateTime mergeStart = DateTime.Now;
            MergeSorting(numbers2, 0, numbers2.Length - 1);
            DateTime mergeEnd = DateTime.Now;

            Console.WriteLine("Merge Sort Time: " + (mergeEnd - mergeStart).TotalMilliseconds + " ms");

            //display result after sorting
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.Write(numbers2[i] + " ");
            }

            //using quick sort
            Console.WriteLine("\nQUICK SORT RESULT: ");

            DateTime quickStart = DateTime.Now;
            QuickSorting(numbers3, 0, numbers3.Length - 1);
            DateTime quickEnd = DateTime.Now;

            Console.WriteLine("Quick Sort Time: " + (quickEnd - quickStart).TotalMilliseconds + " ms");

            //display result after sorting
            for (int i = 0; i < numbers3.Length; i++)
            {
                Console.Write(numbers3[i] + " ");
            }
        }

        //method to sort array using bubble sort
        public static void BubbleSort(int[] numbers)
        {
            //variable to store array length
            int n = numbers.Length;

            //loop runs till n-1
            for (int i = 0; i < n - 1; i++)
            {
                //loop to compare adjacent elements
                for (int j = 0; j < n - 1 - i; j++)
                {
                    //if current element is greater than the next element then swap them
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }


        }


        //method to sort array using merge sort
        public static void MergeSorting(int[] numbers2, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            int mid = startIndex + (endIndex - startIndex) / 2;
            MergeSorting(numbers2, startIndex, mid);

            MergeSorting(numbers2, mid + 1, endIndex);

            Merge(numbers2, startIndex, endIndex, mid);


        }

        public static void Merge(int[] numbers2, int startIndex, int endIndex, int mid)
        {
            int[] temp = new int[endIndex - startIndex + 1];

            //left part iterator
            int i = startIndex;

            //right part iterator
            int j = mid + 1;

            //iterator for temp array
            int k = 0;

            while (i <= mid && j <= endIndex)
            {
                if (numbers2[i] < numbers2[j])
                {
                    temp[k] = numbers2[i];
                    i++;

                }
                else
                {
                    temp[k] = numbers2[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                //if elements are present in left part
                temp[k++] = numbers2[i++];
            }
            while (j <= endIndex)
            {
                //if elements are present in right part
                temp[k++] = numbers2[j++];
            }
            for (k = 0, i = startIndex; k < temp.Length; i++, k++)
            {
                numbers2[i] = temp[k];
            }
        }


        //method to sort array using quick sort
        public static void QuickSorting(int[] numbers3, int startIndex, int endIndex)
        {
            //base condition (if array has one or no elements)
            if (startIndex >= endIndex)
            {
                return;
            }
            //partition the array and get pivot index
            int pidx = Partition(numbers3, startIndex, endIndex);

            //left partition
            QuickSorting(numbers3, startIndex, pidx - 1);

            //right partition
            QuickSorting(numbers3, pidx + 1, endIndex);


        }

        //method for partition 
        public static int Partition(int[] numbers3, int startIndex, int endIndex)
        {
            //select last element as pivot
            int pivot = numbers3[endIndex];

            //to make place for the elements smaller than pivot
            int i = startIndex - 1;

            //traverse the array and compare with pivot
            for (int j = startIndex; j < endIndex; j++)
            {
                //if current element is less than or equal to pivot
                if (numbers3[j] <= pivot)
                {
                    //increment index and swap elements
                    i++;

                    int element = numbers3[j];

                    numbers3[j] = numbers3[i];

                    numbers3[i] = element;
                }
            }

            //place pivot at correct position
            i++;
            int temp = pivot;
            numbers3[endIndex] = numbers3[i];
            numbers3[i] = temp;

            //return pivot index
            return i;

        }
    }
}
