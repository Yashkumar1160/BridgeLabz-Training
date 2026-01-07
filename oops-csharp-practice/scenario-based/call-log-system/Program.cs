using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.call_log_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("WELCOME TO CUSTOMER CALL LOG MANAGER");

            //create object of CallLogManager class
            CallLogManager manager = new CallLogManager();

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. ADD CALL LOG");
                Console.WriteLine("2. SEARCH BY KEYWORD");
                Console.WriteLine("3. FILTER BY TIME");
                Console.WriteLine("4. VIEW ALL LOGS");
                Console.WriteLine("5. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //take phone number input
                        Console.Write("ENTER PHONE NUMBER: ");
                        string phoneNumber = Console.ReadLine();

                        //take message input
                        Console.Write("ENTER MESSAGE: ");
                        string message = Console.ReadLine();

                        //add call log 
                        manager.AddCallLog(new CustomerCallLog(phoneNumber,message,CallLogUtility.GetCurrentTime()));
                        Console.WriteLine("CALL LOG ADDED");
                        break;

                    case 2:
                        //take keyword input
                        Console.Write("ENTER KEYWORD: ");
                        string keyword = Console.ReadLine();

                        manager.SearchByKeyword(keyword);
                        break;

                    case 3:
                        //take starting hour
                        Console.Write("ENTER START HOURS: ");
                        int startHrs = Convert.ToInt32(Console.ReadLine());

                        //take ending hour
                        Console.Write("ENTER END HOURS: ");
                        int endHrs = Convert.ToInt32(Console.ReadLine());

                        DateTime startTime = DateTime.Now.AddHours(-startHrs);
                        DateTime endTime = DateTime.Now.AddHours(-endHrs);

                        manager.FilterByTime(startTime, endTime);
                        break;

                    case 4:
                        //view all call logs
                        manager.ViewAllLogs();
                        break;

                    case 5:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    //if user enters invalid choice
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }
}
