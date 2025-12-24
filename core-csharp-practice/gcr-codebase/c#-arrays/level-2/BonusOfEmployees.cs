using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class BonusOfEmployees
    {
        public static void Main(string[] args)
        {
            int numberOfEmployees = 10;

            //define double array to store salary
            double[] salary = new double[numberOfEmployees];
            //define double array to store years of service
            double[] yearsOfService = new double[numberOfEmployees];
            //define double array to store bonus
            double[] bonus = new double[numberOfEmployees];
            //define double array to store new salary
            double[] newSalary = new double[numberOfEmployees];

            //define variables to save total bonus, total old salary and new salary
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            //take user inputs
            for (int i = 0; i < numberOfEmployees; i++)
            {   //take details of employee and add it to respective arrays
                Console.WriteLine("Enter details of employee " + (i + 1));
                Console.WriteLine("Enter salary:");
                salary[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter years of service:");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

                //check input values
                if (salary[i] <= 0 || yearsOfService[i] < 0)
                {
                    Console.WriteLine("Invalid input. Enter again");
                    i--;
                    continue;
                }

            }
            //calculate bonus and new salary
            for (int i = 0; i < numberOfEmployees; i++)
            {
                if (yearsOfService[i] > 5)
                {   //if years of service is greater than 5 then 5%
                    bonus[i] = salary[i] * 5 / 100;
                }
                else
                {   //if years of service is less than 5 then 2%
                    bonus[i] = salary[i] * 2 / 100;
                }
                //find new Salary and store it in array
                newSalary[i] = salary[i] + bonus[i];
                //calculate total bonus
                totalBonus += bonus[i];
                //calculate total old salary
                totalOldSalary += salary[i];
                //calculate total new salary
                totalNewSalary += newSalary[i];
            }
            //Output
            Console.WriteLine("Total Bonus: " + totalBonus);
            Console.WriteLine("Total Old Salary: " + totalOldSalary);
            Console.WriteLine("Total New Salary: " + totalNewSalary);

        }
    }
}
