using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class MatrixOperations
    {
        //Method to create random matrix
        public static int[,] CreateMatrix(int rows, int columns)
        {
            //create matrix
            int[,] matrix = new int[rows, columns];
            //create object of Random class
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            return matrix;
        }
        //Method to display matrix
        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //Method for matrix addition
        public static int[,] AddTwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        //Method for matrix subtraction
        public static int[,] SubtractTwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }
        //Method for  matrix multiplication
        public static int[,] MultiplyTwoMatrix(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }
        //Method for matrix transpose
        public static int[,] Transpose(int[,] matrix)
        {
            //get number of rows and columns
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            //create array to store transpose
            int[,] transpose = new int[columns, rows];
            //transpose the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            return transpose;
        }
        //Method to find determinant of 2x2 matrix
        public static int FindDeterminant2X2(int[,] matrix)
        {
            //calculate determinant
            int determinant = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
            return determinant;
        }
        //Method to find the determinant of 3x3 matrix
        public static int FindDeterminant3X3(int[,] matrix)
        {
            //calculate determinant
            int determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            return determinant;
        }
        //Method to find inverse of 2x2 matrix 
        public static double[,] FindInverseOf2X2(int[,] matrix)
        {
            double determinant = FindDeterminant2X2(matrix);
            double[,] inverse = new double[2, 2];

            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = matrix[0, 1] / determinant;
            inverse[1, 0] = matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;

            return inverse;

        }
        //Method to find inverse of 3x3 matrix
        public static double[,] FindInverse3X3(int[,] matrix)
        {
            double determinant = FindDeterminant3X3(matrix);
            double[,] inverse = new double[3, 3];

            inverse[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / determinant;
            inverse[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / determinant;
            inverse[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / determinant;
            inverse[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / determinant;
            inverse[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / determinant;
            inverse[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / determinant;
            inverse[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / determinant;
            inverse[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / determinant;
            inverse[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / determinant;

            return inverse;
        }
        public static void Main(string[] args)
        {
            int[,] matrix1 = CreateMatrix(2, 2);
            int[,] matrix2 = CreateMatrix(2, 2);

            Console.WriteLine("First Matrix: ");
            DisplayMatrix(matrix1);

            Console.WriteLine("Second Matrix: ");
            DisplayMatrix(matrix2);

            Console.WriteLine("Addition");
            DisplayMatrix(AddTwoMatrix(matrix1, matrix2));

            Console.WriteLine("Subtraction");
            DisplayMatrix(SubtractTwoMatrix(matrix1, matrix2));

            Console.WriteLine("Multiplication");
            DisplayMatrix(MultiplyTwoMatrix(matrix1, matrix2));

            Console.WriteLine("Transpose of matrix 1 :");
            DisplayMatrix(Transpose(matrix1));

            Console.WriteLine("Determinant of matrix 1 : " + FindDeterminant2X2(matrix1));

            Console.WriteLine("Inverse of matrix 1 : ");
            double[,] inverse = FindInverseOf2X2(matrix1);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(Math.Round(inverse[i, j], 2) + "\t");
                }
                Console.WriteLine();
            }

        }

    }
}
