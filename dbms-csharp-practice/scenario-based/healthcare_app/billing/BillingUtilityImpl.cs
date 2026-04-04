using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.billing
{
    public class BillingUtilityImpl : IBilling
    {
        //UC-5.1 Generate Bill
        public void GenerateBill()
        {
            try
            {
                Console.Write("Enter Visit ID: ");
                int visitId = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("GenerateBillForVisit", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@visit_id", visitId);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Bill Generated Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Visit ID format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-5.2 Record Payment
        public void RecordPayment()
        {
            try
            {
                Console.Write("Enter Bill ID: ");
                int billId = int.Parse(Console.ReadLine());

                Console.Write("Payment Mode (Cash/Card/UPI): ");
                string mode = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("RecordPayment", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@bill_id", billId);
                command.Parameters.AddWithValue("@payment_mode", mode);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Payment Recorded Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Bill ID format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-5.3 View Outstanding Bills
        public void ViewOutstandingBills()
        {
            try
            {
                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("ViewOutstandingBills", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No Outstanding Bills");
                    return;
                }

                Console.WriteLine("Patient | Total Due | Bills Count");

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["patient_name"]} | {reader["outstanding_amount"]} | {reader["total_bills"]}"
                    );
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-5.4 Revenue Report
        public void GenerateRevenueReport()
        {
            try
            {
                Console.Write("From Date (yyyy-mm-dd): ");
                DateTime from = DateTime.Parse(Console.ReadLine());

                Console.Write("To Date (yyyy-mm-dd): ");
                DateTime to = DateTime.Parse(Console.ReadLine());

                Console.Write("Minimum Revenue: ");
                decimal minRevenue = decimal.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("GenerateRevenueReport", connection);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@from_date", from);
                command.Parameters.AddWithValue("@to_date", to);
                command.Parameters.AddWithValue("@min_revenue", minRevenue);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("Doctor | Specialty | Revenue");

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["doctor_name"]} | {reader["specialty_name"]} | {reader["total_revenue"]}"
                    );
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}