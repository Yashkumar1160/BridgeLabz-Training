using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class FindDuplicates
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\StudentsDuplicates.csv";

            //HashSet to store unique IDs
            HashSet<int> ids = new HashSet<int>();

            //List to store duplicate records
            List<string> duplicateRecords = new List<string>();

            //try block
            try
            {
                //StreamReader to read CSV file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header row
                    reader.ReadLine();

                    //variable to store each line
                    string line;

                    //loop to read file line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split CSV line
                        string[] data = line.Split(',');

                        //parse ID column
                        int id = int.Parse(data[0]);

                        //check if ID already exists
                        if (ids.Contains(id))
                        {
                            //add duplicate record to list
                            duplicateRecords.Add(line);
                        }
                        else
                        {
                            //add ID to HashSet
                            ids.Add(id);
                        }
                    }
                }

                //display duplicate records
                Console.WriteLine("Duplicate Records:");
                foreach (string record in duplicateRecords)
                {
                    Console.WriteLine(record);
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
