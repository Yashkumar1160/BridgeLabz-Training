using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.patient
{
    public class PatientMenu
    {
        public static void DisplayMenu()
        {
            IPatient patient = new PatientUtilityImpl();

            while (true)
            {
                Console.WriteLine("\n--- Patient Management ---");
                Console.WriteLine("1. Register Patient");
                Console.WriteLine("2. Update Patient");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. View Patient History");
                Console.WriteLine("5. Exit");

                Console.Write("Choice: ");
                string input = Console.ReadLine();
                int choice = int.Parse(input);


                switch (choice)
                {
                    case 1: patient.RegisterPatient(); break;
                    case 2: patient.UpdatePatient(); break;
                    case 3: patient.SearchPatient(); break;
                    case 4: patient.ViewPatientHistory(); break;
                    case 5: return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }
    }
}
