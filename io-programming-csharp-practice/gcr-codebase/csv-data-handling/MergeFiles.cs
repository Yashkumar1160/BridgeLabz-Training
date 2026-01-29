using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class MergeFiles
    {
        public static void Main()
        {
            //store file paths
            string students1 = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Student1.csv";
            string students2 = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Student2.csv";
            string mergedRecord = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\MergedRecord.csv";

            //dictionary to store first csv data
            Dictionary<int, string[]> studentData = new Dictionary<int, string[]>();

            //try block
            try
            {
                //StreamReader for first csv file
                using (StreamReader reader1 = new StreamReader(students1))
                {
                    //skip header row
                    reader1.ReadLine();

                    //variable to store each line
                    string line;

                    //loop to read each row
                    while ((line = reader1.ReadLine()) != null)
                    {
                        //split csv line
                        string[] data = line.Split(',');

                        //store data using ID as key
                        studentData[int.Parse(data[0])] = data;
                    }
                }

                //StreamReader and StreamWriter
                using (StreamReader reader2 = new StreamReader(students2))
                using (StreamWriter writer = new StreamWriter(mergedRecord))
                {
                    //write header row
                    writer.WriteLine("ID,Name,Age,Marks,Grade");

                    //skip header row
                    reader2.ReadLine();

                    //variable to store each line
                    string line;

                    //read each row from second csv
                    while ((line = reader2.ReadLine()) != null)
                    {
                        //split csv line
                        string[] data2 = line.Split(',');

                        int id = int.Parse(data2[0]);

                        //check if id exists in first csv
                        if (studentData.ContainsKey(id))
                        {
                            string[] data1 = studentData[id];

                            //write merged data
                            writer.WriteLine(
                                data1[0] + "," +
                                data1[1] + "," +
                                data1[2] + "," +
                                data2[1] + "," +
                                data2[2]
                            );
                        }
                    }
                }

                Console.WriteLine("CSV files merged");
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
