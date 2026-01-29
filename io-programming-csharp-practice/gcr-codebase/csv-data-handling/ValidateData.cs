using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class ValidateData
    {
        public static void Main()
        {
            //store file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\StudentsEmails.csv";

            //email regex pattern
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

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

                    //read each row
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        //store email and phone number
                        string email = data[2];
                        string phone = data[3];

                        //validate email
                        bool isEmailValid = Regex.IsMatch(email, emailPattern);

                        //validate phone number length
                        bool isPhoneValid = phone.Length == 10 && long.TryParse(phone, out _);

                        //display invalid rows
                        if (!isEmailValid || !isPhoneValid)
                        {
                            Console.WriteLine("Invalid Row Found:");
                            Console.WriteLine(line);
                        }
                    }
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
