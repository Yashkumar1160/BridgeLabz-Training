using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class WriteEmployeeDetails
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";

            //try block
            try
            {
                //StreamWriter
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    //write header row
                    writer.WriteLine("ID,Name,Department,Salary");

                    //write employee records
                    writer.WriteLine("101,Raj,IT,50000");
                    writer.WriteLine("102,Pooja,HR,45000");
                    writer.WriteLine("103,Aman,Finance,55000");
                    writer.WriteLine("104,Neha,Marketing,48000");
                    writer.WriteLine("105,Kunal,Sales,52000");
                }

                Console.WriteLine("Employee CSV file created successfully!");
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
