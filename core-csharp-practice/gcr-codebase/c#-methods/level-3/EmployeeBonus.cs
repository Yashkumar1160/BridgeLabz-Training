using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class EmployeeBonus
    {
        //Method to generate employee data
        public static int[,] GenerateEmployeeData(int employees)
        {
            //create array to store salary and years of service
            int[,] data = new int[employees, 2];
            //create object of Random class
            Random random = new Random();
            for (int i = 0; i < employees; i++)
            {
                //generate salary
                data[i, 0] = random.Next(10000, 100000);
                //generate years of service
                data[i, 1] = random.Next(1, 11);
            }
            return data;
        }
        //Method to calculate bonus and salary
        public static double[,] CalculateBonusAndSalary(int[,] data)
        {
            //number of employees
            int employees = data.GetLength(0);
            //array to store bonus and new salary
            double[,] result = new double[employees, 2];

            for (int i = 0; i < employees; i++)
            {
                int salary = data[i, 0];
                int service = data[i, 1];

                double bonus;
                //bonus calculation
                if (service > 5)
                {
                    bonus = salary * 0.05;
                }
                else
                {
                    bonus = salary * 0.02;
                }
                //store bonus
                result[i, 0] = bonus;
                //store new salary
                result[i, 1] = salary + bonus;

            }
            return result;
        }
        //Method to display data
        public static void DisplayResult(int[,] data, double[,] result)
        {
            //initialize totalOldSalary, totalBonus and totalNewSalary variables to 0
            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;

            Console.WriteLine("\nEmp\tOldSalary\tYears\tBonus\t\tNewSalary");
            Console.WriteLine();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.WriteLine(
                 (i + 1) + "\t" +
                 data[i, 0] + "\t\t" +
                 data[i, 1] + "\t" +
                 result[i, 0] + "\t\t" +
                 result[i, 1]
             );
                //add old salary
                totalOldSalary += data[i, 0];
                //add bonus
                totalBonus += result[i, 0];
                //add new salary
                totalNewSalary += result[i, 1];
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL\t" + totalOldSalary + "\t\t\t" + totalBonus + "\t\t" + totalNewSalary);

        }
        //Main Method
        public static void Main(string[] args)
        {
            int employees = 10;
            //generate salary and years of service data
            int[,] employeeData = GenerateEmployeeData(employees);
            //calculate bonus and new salary
            double[,] bonusData = CalculateBonusAndSalary(employeeData);

            //display result
            DisplayResult(employeeData, bonusData);
        }

    }
}
