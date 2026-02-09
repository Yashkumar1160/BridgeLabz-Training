using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.specialty
{
    public class SpecialtyUtilityImpl : ISpecialty
    {
        //--Add Specialty
        public void AddSpecialty()
        {
            try
            {
                Console.Write("Specialty Name: ");
                string name = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("AddSpecialty", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@specialty_name", name);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Specialty Added Successfully");
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


        //--Update Specialty
        public void UpdateSpecialty()
        {
            try
            {
                Console.Write("Specialty ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("New Specialty Name: ");
                string name = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("UpdateSpecialty", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@specialty_id", id);
                command.Parameters.AddWithValue("@specialty_name", name);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Specialty Updated Successfully");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Specialty ID!");
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

        //--View All Specialty
        public void ViewAllSpecialties()
        {
            try
            {
                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("GetAllSpecialties", connection);

                command.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("---- SPECIALTIES ----");

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["specialty_id"]} | {reader["specialty_name"]}");
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

        //--Delete Specialty
        public void DeleteSpecialty()
        {
            try
            {
                Console.Write("Specialty ID: ");
                int id = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("DeleteSpecialty", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@specialty_id", id);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Specialty Deleted Successfully");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Specialty ID!");
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
    }
}