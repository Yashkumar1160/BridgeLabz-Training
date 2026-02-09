using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.patient;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.doctor;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.appointment;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.visit_management;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.billing;
using BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.specialty;



namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app
{
    public class HealthCareMain
    {
        public static void Main()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("===== HEALTH CLINIC APP =====");
                Console.WriteLine("1. Patient Management");
                Console.WriteLine("2. Doctor Management");
                Console.WriteLine("3. Appointment Management");
                Console.WriteLine("4. Visit Management");
                Console.WriteLine("5. Billing Management");
                Console.WriteLine("6. Specialty Management");
                Console.WriteLine("7. Exit");
                Console.Write("Enter Choice: ");

                //take user's choice
                string input = Console.ReadLine();
                int choice = int.Parse(input);

                //handle user's choice
                switch (choice)
                {
                    //display patient management menu
                    case 1:
                        PatientMenu.DisplayMenu();
                        break;

                    //display doctor management menu
                    case 2:
                        DoctorMenu.DisplayMenu();
                        break;
                    
                    //display appointment management menu
                    case 3:
                        AppointmentMenu.DisplayMenu();
                        break;
                    
                    //display Visit management menu
                    case 4:
                        VisitMenu.DisplayMenu();
                        break;
                    
                    //display billing management menu
                    case 5:
                        BillingMenu.DisplayMenu();
                        break;
                    
                    //display specialty management menu
                    case 6:
                        SpecialtyMenu.DisplayMenu();
                        break;
                    
                    //exit
                    case 7:
                    Console.WriteLine("Exit Successful");
                        return;

                    default:
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        }
    }
}