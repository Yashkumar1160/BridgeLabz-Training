using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.visit_management
{
    public class VisitMenu
    {
        public static void DisplayMenu()
        {
            IVisit visit = new VisitUtilityImpl();
            
            while(true)
            {
                Console.WriteLine("\n----- VISIT MANAGEMENT -----");
                Console.WriteLine("1. Record Patient Visit");
                Console.WriteLine("2. View Patient Medical History");
                Console.WriteLine("3. Add Prescription");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        visit.RecordPatientVisit();
                        break;

                    case 2:
                        visit.ViewPatientMedicalHistory();
                        break;

                    case 3:
                        visit.AddPrescription();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}