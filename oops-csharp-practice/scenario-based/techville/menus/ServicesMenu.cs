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
            //infinite loop until user exits
            while (true)
            {
                //M-7
                Console.WriteLine("1. Citizen Service Menu");
                //M-8
                Console.WriteLine("2. City Service Menu");
                Console.WriteLine("3. Exit");
                Console.Write("Enter Your Choice: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        ShowServicesMenu7();
                        break;

                    case 2:
                        ShowServicesMenu8();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        //M-7 Advanced Service Architecture
        public static void ShowServicesMenu7()
        {
            //initialize service with null
            Service service = null;

            //infinite loop until user exits
            while (true)
            {
                //display services menu
                Console.WriteLine("\n=== Module 7 Citizen Service Menu ===");
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

        //M-8 City Service Hierarchy
        public static void ShowServicesMenu8()
        {
            //initialize service with null
            Service service = null;

            //loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n=== Module 8: City Service Hierarchy ===");
                Console.WriteLine("1. Create Emergency Service");
                Console.WriteLine("2. Create Routine Service");
                Console.WriteLine("3. Register Service");
                Console.WriteLine("4. Cancel Service");
                Console.WriteLine("5. Check Status");
                Console.WriteLine("6. Book Service");
                Console.WriteLine("7. Book Service With Priority");
                Console.WriteLine("8. Display Service");
                Console.WriteLine("9. Compare Services");
                Console.WriteLine("0. Back");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //create emergency service
                    case 1:
                        service = new EmergencyService(5000);
                        Console.WriteLine("Emergency Service Created");
                        break;
                    //create routine service
                    case 2:
                        service = new RoutineService(2000);
                        Console.WriteLine("Routine Service Created");
                        break;
                    //register service
                    case 3:
                        if (service != null)
                        {
                            service.Register();
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //cancel service
                    case 4:
                        if (service != null)
                        {
                            service.Cancel();
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //check status
                    case 5:
                        if (service != null)
                        {
                            service.CheckStatus();
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //book service
                    case 6:
                        if (service != null)
                        {
                            Console.Write("Enter Citizen Name: ");
                            string name = Console.ReadLine();
                            service.BookService(name);
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //book service with priority
                    case 7:
                        if (service != null)
                        {
                            Console.Write("Enter Citizen Name: ");
                            string name2 = Console.ReadLine();
                            Console.Write("Enter Priority: ");
                            int priority = Convert.ToInt32(Console.ReadLine());
                            service.BookService(name2, priority);
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //display service
                    case 8:
                        if (service != null)
                        {
                            Console.WriteLine(service.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Create a service first");
                        }
                        break;
                    //compare services
                    case 9:
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
                    //return back
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