using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class SearchTarget
    {
        public static void Main(string[] args)
        {
            //take number of rows
            Console.Write("ENTER ROWS: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            //take number of columns
            Console.Write("ENTER COLUMNS: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            //create matrix 
            int[,] matrix = new int[rows, cols];

            //take number inputs
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("ENTER NUMBER: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //take target element
            Console.Write("ENTER TARGET: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //call SearchForTarget method
            SearchForTarget(matrix, target, rows, cols);
        }

        //method to search for target element
        public static void SearchForTarget(int[,] matrix, int target, int rows, int cols)
        {
            //starting index
            int low = 0;

            //ending index
            int high = rows * cols - 1;

            //binary search loop
            while (low <= high)
            {
                //calculate mid index
                int mid = (low + high) / 2;

                //row index
                int i = mid / cols;

                //column index
                int j = mid % cols;

                //get value 
                int value = matrix[i, j];

                //if target is found
                if (value == target)
                {
                    Console.WriteLine("TARGET FOUND");
                    return;
                }
                //if target is greater then search right half
                else if (value < target)
                {
                    low = mid + 1;
                }
                //if target is smaller then search left half
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("TARGET NOT FOUND");
        }
    }
}
