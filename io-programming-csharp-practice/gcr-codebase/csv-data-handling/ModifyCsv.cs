using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ModifyCsv
    {
        public static void Main()
        {
            //store input and output file paths
            string inputFile = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Employee.csv";
            string outputFile = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\UpdatedEmployees.csv";

            //try block
            try
            {
                //StreamReader
                using (StreamReader reader = new StreamReader(inputFile))

                //StreamWriter
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    //write header
                    writer.WriteLine(reader.ReadLine());

                    //variable to store line
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        //check IT department
                        if (data[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                        {
                            double salary = double.Parse(data[3]);
                            salary = salary + (salary * 0.10);
                            data[3] = salary.ToString();
                        }

                        //write updated record
                        writer.WriteLine(string.Join(",", data));
                    }
                }

                Console.WriteLine("Salary updated successfully");
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

