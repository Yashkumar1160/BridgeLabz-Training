using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;
using techville.services;
namespace techville.menus
{
    public class ServicesMenu
    {
        public static void ShowServicesMenu()
        {
            //initialize service with null
            Service service = null; 

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n=== TechVille Services Menu ===");
                Console.WriteLine("1. Create Healthcare Service");
                Console.WriteLine("2. Create Premium Healthcare Service");
                Console.WriteLine("3. Create Education Service");
                Console.WriteLine("4. Create Emergency Service");
                Console.WriteLine("5. Create Routine Service");
                Console.WriteLine("6. Register Service");
                Console.WriteLine("7. Cancel Service");
                Console.WriteLine("8. Use Service");
                Console.WriteLine("9. Check Status");
                Console.WriteLine("10. Book Service");
                Console.WriteLine("11. Book Service With Priority");
                Console.WriteLine("12. Display Service Details");
                Console.WriteLine("13. Show Total Services Created");
                Console.WriteLine("14. Compare With Emergency Service");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        service = ServiceFactory.CreateService("healthcare");
                        Console.WriteLine("Healthcare Service Created");
                        break;

                    case 2:
                        service = ServiceFactory.CreateService("premium");
                        Console.WriteLine("Premium Healthcare Service Created");
                        break;

                    case 3:
                        service = ServiceFactory.CreateService("education");
                        Console.WriteLine("Education Service Created");
                        break;

                    case 4:
                        service = ServiceFactory.CreateService("emergency");
                        Console.WriteLine("Emergency Service Created");
                        break;

                    case 5:
                        service = ServiceFactory.CreateService("routine");
                        Console.WriteLine("Routine Service Created");
                        break;

                    case 6:
                        if (service != null)
                        {
                            service.Register();                            
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");                            
                        }
                        break;

                    case 7:
                        if (service != null)
                        {
                            service.Cancel();                            
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");                            
                        }
                        break;

                    case 8:
                        if (service != null)
                        {
                            service.UseService();                            
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");                            
                        }
                        break;

                    case 9:
                        if (service != null)
                        {
                            service.CheckStatus();                            
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");                            
                        }
                        break;

                    case 10:
                        if (service != null)
                        {
                            Console.Write("Enter Citizen Name: ");
                            string name = Console.ReadLine();
                            service.BookService(name);
                        }
                        else
                            Console.WriteLine("Create a service first");
                        break;

                    case 11:
                        if (service != null)
                        {
                            Console.Write("Enter Citizen Name: ");
                            string name2 = Console.ReadLine();
                            Console.Write("Enter Priority: ");
                            int priority = Convert.ToInt32(Console.ReadLine());
                            service.BookService(name2, priority);
                        }
                        else
                            Console.WriteLine("Create a service first");
                        break;

                    case 12:
                        if (service != null)
                        {
                            service.DisplayServiceDetails();
                            if (service is PremiumHealthcareService)
                            {
                                Console.WriteLine("This is a Premium Healthcare Service.");                                
                            }
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");                            
                        }
                        break;

                    case 13:
                        Service.ShowTotalServices();
                        break;

                    case 14:
                        if (service != null)
                        {
                            Service other = new EmergencyService(5000);
                            Console.WriteLine("Equals Result: " + service.Equals(other));
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}