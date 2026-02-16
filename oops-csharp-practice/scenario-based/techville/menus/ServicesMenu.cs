using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;
using techville.services;
namespace techville.menus
{
    //M-7 Advanced Service Architecture
    public class ServicesMenu
    {

        public static void ShowServicesMenu()
        {
            //initialize service with null
            Service service = null;

            //infinite loop until user exits
            while (true)
            {
                //display services menu
                Console.WriteLine("\n=== Citizen Service Menu ===");
                Console.WriteLine("1. Create Healthcare Service");
                Console.WriteLine("2. Create Premium Healthcare Service");
                Console.WriteLine("3. Create Education Service");
                Console.WriteLine("4. Use Service");
                Console.WriteLine("5. Display Service Details");
                Console.WriteLine("6. Show Total Services Created");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());


                //handle user's choice
                switch (choice)
                {
                    //create healthcare service
                    case 1:
                        service = ServiceFactory.CreateService("healthcare");
                        Console.WriteLine("Healthcare Service Created");
                        break;

                    //create premium healthcare service
                    case 2:
                        service = ServiceFactory.CreateService("premium");
                        Console.WriteLine("Premium Healthcare Service Created");
                        break;

                    //create education service
                    case 3:
                        service = ServiceFactory.CreateService("education");
                        Console.WriteLine("Education Service Created");
                        break;

                    //use service
                    case 4:
                        if (service != null)
                        {
                            service.UseService();
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;

                    //display service details
                    case 5:
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

                    //show total services
                    case 6:
                        Service.ShowTotalServices();
                        break;

                    //back to main menu
                    case 0:
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}