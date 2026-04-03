using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class InvoiceGenerator
    {
        //array to store tasks
        static string[] tasks = new string[50];

        static int totalTasks = 0;
        
        public static void Main(string[] args)
        {
            DisplayChoices();
        }

        //----------------DISPLAY CHOICES----------------
        //method to display choices
        public static void DisplayChoices()
        {
            while (true)
            {
                Console.WriteLine("\n1. ENTER INVOICE STRING");
                Console.WriteLine("\n2. VIEW INVOICE");
                Console.WriteLine("\n3. CALCULATE TOTAL AMOUNT");
                Console.WriteLine("\n4. EXIT");
                Console.Write("\nENTER YOUR CHOICE: ");

                //take input choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddInvoice();
                        break;

                    case 2:
                        ViewInvoice();
                        break;

                    case 3:
                        DisplayTotal();
                        break;

                    case 4:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }

        //----------------ADD INVOICE----------------------
        //method to add invoice
        public static void AddInvoice()
        {
            //take task input
            Console.WriteLine("\nENTER TASK:");
            string task=Console.ReadLine();

            //call ParseInvoice method to split task string into individual tasks 
            string[]newTasks=ParseInvoice(task);

            //loop through each task and add it to tasks array
            foreach(string t in newTasks){

                //remove extra spaces
                tasks[totalTasks] = t.Trim();
                
                totalTasks++;
            }

            Console.WriteLine("\nTASKS ADDED SUCCESSFULLY");
        }

        //----------------VIEW INVOICE---------------------
        //method to display all tasks
        public static void ViewInvoice()
        {
            Console.WriteLine("\nINVOICE DETAIL");

            //loop through all tasks 
            for (int i = 0; i < totalTasks; i++)
            {
                Console.WriteLine(tasks[i]);
            }
        }

        //--------------DISPLAY TOTAL-------------------
        //calculate and display total amount
        public static void DisplayTotal()
        {
            //get total amount
            int total = GetTotalAmount(tasks,totalTasks);

            Console.WriteLine($"\nTOTAL AMOUNT: {total} INR");
        }

        //-------------------PARSE INVOICE--------------
        public static string[] ParseInvoice(string task)
        {
            return task.Split(',');
        }

        //-----------------GET TOTAL AMOUNT--------------
        //Calculate sum of all task amounts 
        public static int GetTotalAmount(string[] tasks, int totalTasks)
        {
            //initialize total variable with 0
            int total = 0;

            for(int i = 0;i < totalTasks;i++)
            {
                //split taks into name and amount
                string[]splitTask=tasks[i].Split('-');

                //extract amount 
                string amountSplit = splitTask[1].Replace("INR","").Trim();

                //convert to integer and add to total
                total += int.Parse(amountSplit);
            }

            return total;
        }
    }
}
