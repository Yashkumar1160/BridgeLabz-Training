using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class SearchRecord
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";

            //employee name to search
            string searchName = "Raj";

            //flag to check if record is found
            bool found = false;

            //try block
            try
            {
                //StreamReader
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header
                    reader.ReadLine();

                    //variable to store line
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        //compare name
                        if (data[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Employee Found");
                            Console.WriteLine("Name       : " + data[1]);
                            Console.WriteLine("Department : " + data[2]);
                            Console.WriteLine("Salary     : " + data[3]);

                            found = true;
                            break;
                        }
                    }
                }

                //if record not found
                if (!found)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}