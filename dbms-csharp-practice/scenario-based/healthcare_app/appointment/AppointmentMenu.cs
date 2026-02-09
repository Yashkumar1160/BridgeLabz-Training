    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.appointment
    {
        public class AppointmentMenu
        {
            public static void DisplayMenu()
            {
                //create object
                AppointmentUtilityImpl appointment = new AppointmentUtilityImpl();

                //infinite loop until user exits
                while (true)
                {
                    //display menu
                    Console.WriteLine("\n----- APPOINTMENT MENU -----");
                    Console.WriteLine("1. Book Appointment");
                    Console.WriteLine("2. Check Doctor Availability");
                    Console.WriteLine("3. Cancel Appointment");
                    Console.WriteLine("4. Reschedule Appointment");
                    Console.WriteLine("5. View Daily Appointments");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter Choice: ");

                    //take user's choice
                    string input = Console.ReadLine();
                    int choice = int.Parse(input);


                    //handle user's choice
                    switch (choice)
                    {
                        
                        case 1:
                            appointment.BookAppointment();
                            break;

                        case 2:
                            appointment.CheckDoctorAvailability();
                            break;

                        case 3:
                            appointment.CancelAppointment();
                            break;

                        case 4:
                            appointment.RescheduleAppointment();
                            break;

                        case 5:
                            appointment.ViewDailyAppointments();
                            break;

                        case 6:
                            return;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }
            }
        }
    }