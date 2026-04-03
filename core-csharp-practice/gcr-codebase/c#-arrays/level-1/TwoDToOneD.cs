using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class TwoDToOneD
    {
        public static void Main(string[] args)
        {
            //take inputs for rows and columns
            Console.WriteLine("Enter number of Rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Columns:");
            int columns = Convert.ToInt32(Console.ReadLine());
            //create 2D array
            int[,] matrix = new int[rows, columns];

            //take user inputs
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Enter Number:");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //create 1D array
            int[] array = new int[rows * columns];
            //initialize index to 0
            int index = 0;
            //loop to copy all elements of 2D array to 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index++] = matrix[i, j];
                }
            }

            Console.WriteLine("Array Elements are:");
            for (int i = 0; i < array.Length; i++)
            {   //Display 1D array elements
                Console.Write(array[i] + " ");
            }
        }
    }
}
