using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class SortCsvRecords
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Students.csv";

            //list to store student records
            List<string[]> students = new List<string[]>();

            //try block
            try
            {
                //StreamReader to read csv file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    //skip header row
                    reader.ReadLine();

                    //variable to store each line
                    string line;

                    //loop to read remaining lines
                    while ((line = reader.ReadLine()) != null)
                    {
                        //split csv line and store in list
                        students.Add(line.Split(','));
                    }
                }

                //bubble sort logic based on marks
                for (int i = 0; i < students.Count - 1; i++)
                {
                    //inner loop for comparison
                    for (int j = 0; j < students.Count - 1 - i; j++)
                    {
                        //convert marks from string to integer
                        int marks1 = int.Parse(students[j][3]);
                        int marks2 = int.Parse(students[j + 1][3]);

                        //swap if current marks is less than next marks
                        if (marks1 < marks2)
                        {
                            //temporary variable to hold data
                            string[] temp = students[j];

                            //swap records
                            students[j] = students[j + 1];
                            students[j + 1] = temp;
                        }
                    }
                }

                //display sorted student records
                Console.WriteLine("Students sorted by marks:");

                //loop to print sorted list
                foreach (var student in students)
                {
                    Console.WriteLine("ID    : " + student[0]);
                    Console.WriteLine("Name  : " + student[1]);
                    Console.WriteLine("Marks : " + student[3]);
                    Console.WriteLine("-------------------------");
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
