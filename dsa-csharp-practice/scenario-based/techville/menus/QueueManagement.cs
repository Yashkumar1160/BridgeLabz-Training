using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.services;
using techville.modules;

namespace techville.menus
{
    public class QueueManagement
    {
        public static void ShowMenu(CitizenServices citizenServices)
        {

            while (true)
            {
                Console.WriteLine("\n====== Queue Management ======");
                Console.WriteLine("1. Show Array FIFO Queue");
                Console.WriteLine("2. Add Emergency Request");
                Console.WriteLine("3. Show Emergency Queue");
                Console.WriteLine("4. Undo Profile Update");
                Console.WriteLine("5. Show Circular Queue");
                Console.WriteLine("6. Back to Main Menu");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        citizenServices.ShowArrayQueue();
                        break;

                    case 2:
                        Console.Write("Enter Citizen Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Priority (1-10): ");
                        int priority = int.Parse(Console.ReadLine());

                        Citizen citizen = citizenServices.FindCitizenByName(name);
                        if (citizen != null)
                            citizenServices.AddEmergencyRequest(citizen, priority);
                        else
                            Console.WriteLine("Citizen Not Found");
                        break;

                    case 3:
                        citizenServices.ShowEmergencyQueue();
                        break;

                    case 4:
                        citizenServices.UndoProfile();
                        break;

                    case 5:
                        citizenServices.ShowCircularQueue();
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