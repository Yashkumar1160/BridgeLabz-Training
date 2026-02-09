using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.visit_management
{
    public class VisitUtilityImpl : IVisit
    {
        //--UC-4.1->Record Patient Visit
        public void RecordPatientVisit()
        {
            try
            {
                Console.Write("Appointment ID: ");
                int appointmentId = int.Parse(Console.ReadLine());

                Console.Write("Patient ID: ");
                int patientId = int.Parse(Console.ReadLine());

                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                Console.Write("Diagnosis: ");
                string diagnosis = Console.ReadLine();

                Console.Write("Notes: ");
                string notes = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("RecordPatientVisit", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@appointment_id", appointmentId);
                command.Parameters.AddWithValue("@patient_id", patientId);
                command.Parameters.AddWithValue("@doctor_id", doctorId);
                command.Parameters.AddWithValue("@diagnosis", diagnosis);
                command.Parameters.AddWithValue("@notes", notes);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Visit recorded successfully");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid numeric input!");
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


        //--UC-4.2->View Patient Medical History
        public void ViewPatientMedicalHistory()
        {
            try
            {
                Console.Write("Patient ID: ");
                int patientId = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("ViewPatientMedicalHistory", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@patient_id", patientId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("\n--- Medical History ---");

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["appointment_date"]} | {reader["doctor_name"]} | {reader["diagnosis"]} | {reader["medicine_name"]} | {reader["dosage"]} | {reader["duration"]}"
                    );
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Patient ID!");
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


        //--UC-4.3->Add Prescription Details
        public void AddPrescription()
        {
            try
            {
                Console.Write("Visit ID: ");
                int visitId = int.Parse(Console.ReadLine());

                Console.Write("Medicine Name: ");
                string medicine = Console.ReadLine();

                Console.Write("Dosage: ");
                string dosage = Console.ReadLine();

                Console.Write("Duration: ");
                string duration = Console.ReadLine();

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("AddPrescription", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@visit_id", visitId);
                command.Parameters.AddWithValue("@medicine_name", medicine);
                command.Parameters.AddWithValue("@dosage", dosage);
                command.Parameters.AddWithValue("@duration", duration);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Prescription added successfully");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Visit ID!");
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