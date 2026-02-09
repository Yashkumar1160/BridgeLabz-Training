using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.patient
{
    public class PatientUtilityImpl : IPatient
    {
        //UC-1.1->Register New Patient
        public void RegisterPatient()
        {
            try
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("DOB (yyyy-mm-dd): ");
                DateTime dob = DateTime.Parse(Console.ReadLine());

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Blood Group: ");
                string bloodGroup = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("Register_Patient", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@dob", dob);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@blood_group", bloodGroup);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Patient Registered Successfully");
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


        //UC-1.2->Update Patient Information
        public void UpdatePatient()
        {
            try
            {
                Console.Write("Patient ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("New Phone: ");
                string phone = Console.ReadLine();

                Console.Write("New Address: ");
                string address = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("Update_Patient_Details", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@patient_id", id);
                command.Parameters.AddWithValue("@phone", phone);
                command.Parameters.AddWithValue("@address", address);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Patient Updated Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Patient ID!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-1.3->Search Patient Records
        public void SearchPatient()
        {
            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Enter Patient ID: ");
                string patientId = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("SearchPatient", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@phone", phoneNumber);
                command.Parameters.AddWithValue("@patient_id", patientId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No Patient Found");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["patient_id"]} | {reader["name"]} | {reader["phone"]} | {reader["dob"]} | {reader["address"]} | {reader["blood_group"]}");
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


        //UC-1.4->View Patient History
        public void ViewPatientHistory()
        {
            try
            {
                Console.Write("Patient ID: ");
                int id = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("PatientVisitHistory", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@patient_id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No History Found");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["appointment_date"]} | {reader["doctor_name"]} | {reader["diagnosis"]} | {reader["notes"]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Patient ID!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

    }
}