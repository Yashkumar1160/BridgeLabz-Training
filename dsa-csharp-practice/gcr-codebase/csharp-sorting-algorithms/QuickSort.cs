using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class QuickSort
    {
        public static void Main(string[] args)
        {
            //take input for number of Products 
            Console.Write("ENTER NUMBER OF PRODUCTS: ");
            int numberOfProducts = Convert.ToInt32(Console.ReadLine());

            //create array to store product prices
            int[] productPrices = new int[numberOfProducts];

            //loop to take input for product prices 
            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.Write("ENTER PRICE OF PRODUCT  " + (i + 1) + " : ");
                productPrices[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call QuickSorting method 
            QuickSorting(productPrices, 0, productPrices.Length - 1);

            //display sorted prices 
            Console.WriteLine("SORTED PRODUCT PRICES:");

            foreach (int price in productPrices)
                Console.Write(price + " ");
        }

        //recursive quick sort method
        public static void QuickSorting(int[] productPrices, int startIndex, int endIndex)
        {
            //base condition (if array has one or no elements)
            if (startIndex >= endIndex)
            {
                return;
            }
            //partition the array and get pivot index
            int pidx = Partition(productPrices, startIndex, endIndex);

            //left partition
            QuickSorting(productPrices, startIndex, pidx - 1);

            //right partition
            QuickSorting(productPrices, pidx + 1, endIndex);
        }

        //method for partition 
        public static int Partition(int[] productPrices, int startIndex, int endIndex)
        {
            //select last element as pivot
            int pivot = productPrices[endIndex];

            //to make place for the elements smaller than pivot
            int i = startIndex - 1;

            //traverse the array and compare with pivot
            for (int j = startIndex; j < endIndex; j++)
            {
                //if current element is less than or equal to pivot
                if (productPrices[j] <= pivot)
                {
                    //increment index and swap elements
                    i++;

                    int element = productPrices[j];

                    productPrices[j] = productPrices[i];

                    productPrices[i] = element;
                }
            }

            //place pivot at correct position
            i++;
            int temp = pivot;
            productPrices[endIndex] = productPrices[i];
            productPrices[i] = temp;

            //return pivot index
            return i;

        }
    }
}
