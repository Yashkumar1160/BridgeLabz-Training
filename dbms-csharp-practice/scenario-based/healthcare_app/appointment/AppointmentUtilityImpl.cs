using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.dbconnection;


namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.appointment
{
    public class AppointmentUtilityImpl : IAppointment
    {
        //UC-3.1->Book New Appointment
        public void BookAppointment()
        {
            //try block
            try
            {
                //take patient id 
                Console.Write("Patient ID: ");
                int patientId = int.Parse(Console.ReadLine());

                //take doctor id
                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                //take appointment date
                Console.Write("Appointment Date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                //take appointment time
                Console.Write("Appointment Time (HH:mm): ");
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());

                //connect to database
                using SqlConnection connection = DBConnect.Connect();
                //store sql command
                using SqlCommand command = new SqlCommand("BookAppointment", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@patient_id", patientId);
                command.Parameters.AddWithValue("@doctor_id", doctorId);
                command.Parameters.AddWithValue("@appointment_date", date);
                command.Parameters.AddWithValue("@appointment_time", time);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Appointment Booked Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //UC-3.2->Check Doctor Availability
        public void CheckDoctorAvailability()
        {
            try
            {
                Console.Write("Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                Console.Write("Date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("CheckDoctorAvailability", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@doctor_id", doctorId);
                command.Parameters.AddWithValue("@appointment_date", date);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No booked slots for this date");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["appointment_time"]} | Booked: {reader["booked_count"]}");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //UC-3.3->Cancel Appointment
        public void CancelAppointment()
        {
            try
            {
                Console.Write("Appointment ID: ");
                int appointmentId = int.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("CancelAppointment", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@appointment_id", appointmentId);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Appointment Cancelled");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        //UC-3.4->Reschedule Appointment
        public void RescheduleAppointment()
        {
            try
            {
                Console.Write("Appointment ID: ");
                int appointmentId = int.Parse(Console.ReadLine());

                Console.Write("New Doctor ID: ");
                int doctorId = int.Parse(Console.ReadLine());

                Console.Write("New Date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("New Time (HH:mm): ");
                TimeSpan time = TimeSpan.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("RescheduleAppointment", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@appointment_id", appointmentId);
                command.Parameters.AddWithValue("@new_doctor_id", doctorId);
                command.Parameters.AddWithValue("@new_date", date);
                command.Parameters.AddWithValue("@new_time", time);

                connection.Open();
                command.ExecuteNonQuery();

                Console.WriteLine("Appointment Rescheduled Successfully");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        //UC-3.5->View Daily Appointment Schedule        
        public void ViewDailyAppointments()
        {
            try
            {
                Console.Write("Date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                using SqlConnection connection = DBConnect.Connect();
                using SqlCommand command = new SqlCommand("ViewDailyAppointments", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@appointment_date", date);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {
                    Console.WriteLine("No Appointments Found");
                    return;
                }

                while (reader.Read())
                {
                    Console.WriteLine(
                        $"{reader["appointment_time"]} | {reader["patient_name"]} | {reader["doctor_name"]} | {reader["status"]}"
                    );
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Database Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}