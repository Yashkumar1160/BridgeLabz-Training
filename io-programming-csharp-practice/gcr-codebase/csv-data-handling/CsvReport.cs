using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class CsvReport
    {
        public static void Main()
        {
            //database connection string
            string connectionString ="Server=localhost;Database=CompanyDB;Trusted_Connection=True;";

            //csv file path
            string csvFilePath = "C:\\CSV\\EmployeeReport.csv";

            //sql query to fetch employee data
            string query = "SELECT EmployeeId, Name, Department, Salary FROM Employees";

            //try block
            try
            {
                //create sql connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //open database connection
                    connection.Open();

                    //create sql command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        //execute reader to read data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            //create StreamWriter to write csv file
                            using (StreamWriter writer = new StreamWriter(csvFilePath))
                            {
                                //write csv header
                                writer.WriteLine("Employee ID,Name,Department,Salary");

                                //loop through database records
                                while (reader.Read())
                                {
                                    //read each column value
                                    int id = reader.GetInt32(0);
                                    string name = reader.GetString(1);
                                    string department = reader.GetString(2);
                                    int salary = reader.GetInt32(3);

                                    //write record to csv file
                                    writer.WriteLine($"{id},{name},{department},{salary}");
                                }
                            }
                        }
                    }
                }

                //success message
                Console.WriteLine("CSV report generated successfully.");
            }
            //catch block
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
