using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class EncryptAndDecrypt
    {
        public static void Main()
        {
            //csv file path
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csv-data-handling\\Encrypted.csv";

            //list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Amit", "IT", "amit@gmail.com", 50000),
                new Employee(2, "Riya", "HR", "riya@gmail.com", 45000),
                new Employee(3, "Rohan", "IT", "rohan@gmail.com", 60000)
            };

            //write encrypted data to csv
            WriteEncryptedCsv(filePath, employees);

            Console.WriteLine("Encrypted CSV written successfully.\n");

            //read and decrypt csv data
            ReadDecryptedCsv(filePath);
        }

        //method to write encrypted csv
        static void WriteEncryptedCsv(string path, List<Employee> employees)
        {
            //StreamWriter to write csv
            using (StreamWriter writer = new StreamWriter(path))
            {
                //write header row
                writer.WriteLine("Id,Name,Department,Email,Salary");

                //loop through employees
                foreach (Employee emp in employees)
                {
                    //encrypt email
                    string encryptedEmail = Encrypt(emp.Email);

                    //encrypt salary
                    string encryptedSalary = Encrypt(emp.Salary.ToString());

                    //write encrypted data
                    writer.WriteLine($"{emp.Id},{emp.Name},{emp.Department},{encryptedEmail},{encryptedSalary}");
                }
            }
        }

        //method to read and decrypt csv
        static void ReadDecryptedCsv(string path)
        {
            //StreamReader to read csv
            using (StreamReader reader = new StreamReader(path))
            {
                //skip header row
                reader.ReadLine();

                //variable to store line
                string line;

                //read each row
                while ((line = reader.ReadLine()) != null)
                {
                    //split csv row
                    string[] data = line.Split(',');

                    //decrypt email
                    string decryptedEmail = Decrypt(data[3]);

                    //decrypt salary
                    string decryptedSalary = Decrypt(data[4]);

                    //print decrypted data
                    Console.WriteLine("ID: " + data[0]);
                    Console.WriteLine("Name: " + data[1]);
                    Console.WriteLine("Department: " + data[2]);
                    Console.WriteLine("Email: " + decryptedEmail);
                    Console.WriteLine("Salary: " + decryptedSalary);
                    Console.WriteLine("---------------------------");
                }
            }
        }

        //method to encrypt data using base64
        static string Encrypt(string plainText)
        {
            //convert text to bytes
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);

            //convert bytes to base64 string
            return Convert.ToBase64String(bytes);
        }

        //method to decrypt base64 data
        static string Decrypt(string encryptedText)
        {
            //convert base64 string to bytes
            byte[] bytes = Convert.FromBase64String(encryptedText);

            //convert bytes to string
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
