using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class Employee
    {
        //properties
        public int Id;
        public string Name;
        public string Department;
        public string Email;
        public double Salary;

        //constructor
        public Employee(int id, string name, string dept, string email, double salary)
        {
            Id = id;
            Name = name;
            Department = dept;
            Email = email;
            Salary = salary;
        }
    }
}
