using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_streams
{
    //employee class
    class Employee
    {
        //attributes
        public int empId { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public double salary { get; set; }
    }

    internal class Serialization
    {
        public static void Main(string[] args)
        {
            //file path to store employee data
            string filePath = "C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\collections-csharp-practice\\gcr-codebase\\csharp-streams\\EmployeeData.txt";

            //try block
            try
            {
                //list to store employees
                List<Employee> employees = new List<Employee>();

                //add employee details
                employees.Add(new Employee { empId = 1, name = "Yash", department = "CSE", salary = 50000 });
                employees.Add(new Employee { empId = 2, name = "Prashant", department = "HR", salary = 45000 });
                employees.Add(new Employee { empId = 3, name = "Harsh", department = "Finance", salary = 50000 });

                //serialize employee list into json string
                string jsonData = JsonSerializer.Serialize(employees);

                //write serialized data into file
                File.WriteAllText(filePath, jsonData);

                Console.WriteLine("\nEmployee data saved successfully");

                //read data back from file
                string readData = File.ReadAllText(filePath);

                //deserialize json data into employee list
                List<Employee> employeeList = JsonSerializer.Deserialize<List<Employee>>(readData);

                Console.WriteLine("\nEmployee Details:");

                //display employee details
                foreach (Employee emp in employeeList)
                {
                    Console.WriteLine(emp.empId + " " + emp.name + " " + emp.department + " " + emp.salary);
                }
            }
            //catch IOException
            catch (IOException ex)
            {
                Console.WriteLine("\nIOException occurred: " + ex.Message);
            }
            //catch other exception
            catch (Exception ex)
            {
                Console.WriteLine("\nError: " + ex.Message);
            }
        }
    }
}
