using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class RichestCustomer
    {
        public static void Main(string[] args)
        {
            //take number of customers
            Console.WriteLine("ENTER NUMBER OF CUSTOMERS:");
            int m=Convert.ToInt32(Console.ReadLine());

            //take number of banks
            Console.WriteLine("ENTER NUMBER OF BANKS:");
            int n=Convert.ToInt32(Console.ReadLine());

            //create accounts array to store balances
            int[,]accounts=new int[m,n];

            //take input for account balances
            Console.WriteLine("ENTER AMMOUNT");
            for(int i = 0; i < accounts.GetLength(0); i++)
            {
                for(int j=0; j < accounts.GetLength(1); j++)
                {
                    accounts[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }

            //initialize max variable with 0
            int max = 0;

            //calculate wealth
            for(int i=0;i< accounts.GetLength(0); i++)
            {
                int sum = 0;
                for(int j=0;j<accounts.GetLength(1); j++)
                {
                    sum += accounts[i, j];
                }
                if (sum > max)
                {
                    max= sum;
                }
            }

            Console.WriteLine("Richest Customer Wealth: " + max);
        }
    }
}
