using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;


namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.doctor
{
    public class DoctorUtilityImpl : IDoctor
    {
        //UC-2.1->Add Doctor Profile
        public void AddDoctor()
        {
            try
            {
                Console.Write("Doctor Name: ");
                string name = Console.ReadLine();

                Console.Write("Specialty ID: ");
                int specialtyId = int.Parse(Console.ReadLine());

                Console.Write("Contact: ");
                string contact = Console.ReadLine();

                Console.Write("Consultation Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("AddDoctor", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@specialty_id", specialtyId);
                command.Parameters.AddWithValue("@contact", contact);
                command.Parameters.AddWithValue("@consultation_fee", fee);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Doctor Added Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number/fee format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //UC-2.2->Assign/Update Doctor Specialty
        public void UpdateDoctorSpecialty()
        {
            try
            {
                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                Console.Write("New Specialty ID: ");
                int specialtyId = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("UpdateDoctorSpecialty", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@specialty_id", specialtyId);
                command.Parameters.AddWithValue("@doctor_id", doctorId);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Doctor Specialty Updated");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid ID format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-2.3->View Doctors by Specialty
        public void ViewDoctorsBySpecialty()
        {
            try
            {
                Console.Write("Specialty Name: ");
                string specialty = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("GetDoctorsBySpecialty", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@specialty_name", specialty);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No Doctors Found");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["doctor_id"]} | {reader["name"]} | {reader["contact"]}");
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

        //UC-2.4->Deactivate Doctor Profile
        public void DeactivateDoctor()
        {
            try
            {
                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("DeactivateDoctor", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@doctor_id", doctorId);

                connection.Open();
                int totalRows = command.ExecuteNonQuery();

                if (totalRows == 0)
                    Console.WriteLine("Doctor Not Found");
                else
                    Console.WriteLine("Doctor Deactivated");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Doctor ID format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}