using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class MergeSort
    {
        public static void Main(string[] args)
        {
            //take input for number of books 
            Console.Write("ENTER NUMBER OF BOOKS: ");
            int numberOfbooks = Convert.ToInt32(Console.ReadLine());

            //create array to store prices
            int[] bookPrices = new int[numberOfbooks];

            //loop to take input for book prices 
            for (int i = 0; i < numberOfbooks; i++)
            {
                Console.Write("ENTER PRICE OF BOOK  " + (i + 1) + " : ");
                bookPrices[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call MergeSorting method 
            MergeSorting(bookPrices, 0, bookPrices.Length - 1);

            //display sorted book prices
            Console.WriteLine("SORTED BOOK PRICES:");

            foreach (int price in bookPrices)
                Console.Write(price + " ");
        }

        public static void MergeSorting(int[] bookPrices, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }
            int mid = startIndex + (endIndex - startIndex) / 2;
            MergeSorting(bookPrices, startIndex, mid);

            MergeSorting(bookPrices, mid + 1, endIndex);
            
            Merge(bookPrices, startIndex, endIndex, mid);
        }

        public static void Merge(int[] bookPrices, int startIndex, int endIndex, int mid)
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
                if (bookPrices[i] < bookPrices[j])
                {
                    temp[k] = bookPrices[i];
                    i++;

                }
                else
                {
                    temp[k] = bookPrices[j];
                    j++;
                }
                k++;
            }
            while (i <= mid)
            {
                //if elements are present in left part
                temp[k++] = bookPrices[i++];
            }
            while (j <= endIndex)
            {
                //if elements are present in right part
                temp[k++] = bookPrices[j++];
            }
            for (k = 0, i = startIndex; k < temp.Length; i++, k++)
            {
                bookPrices[i] = temp[k];
            }
        }
    }
}
