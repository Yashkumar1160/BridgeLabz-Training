using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.specialty
{
    public class SpecialtyMenu
    {
        public static void DisplayMenu()
        {
            ISpecialty specialty = new SpecialtyUtilityImpl();

            while(true)
            {
                Console.WriteLine("\n----- SPECIALTY MANAGEMENT -----");
                Console.WriteLine("1. Add Specialty");
                Console.WriteLine("2. Update Specialty");
                Console.WriteLine("3. View All Specialties");
                Console.WriteLine("4. Delete Specialty");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        specialty.AddSpecialty();
                        break;

                    case 2:
                        specialty.UpdateSpecialty();
                        break;

                    case 3:
                        specialty.ViewAllSpecialties();
                        break;

                    case 4:
                        specialty.DeleteSpecialty();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
        }
    }
}