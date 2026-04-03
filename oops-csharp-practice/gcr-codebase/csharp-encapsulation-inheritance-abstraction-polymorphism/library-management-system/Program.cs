using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            //create object of LibraryManager class
            LibraryManager manager = new LibraryManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. Add Book");
                Console.WriteLine("2. Add Magazine");
                Console.WriteLine("3. Add DVD");
                Console.WriteLine("4. Display All Items");
                Console.WriteLine("5. Reserve Item");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //take item details
                        Console.Write("Item ID: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Title: ");
                        string title1 = Console.ReadLine();

                        Console.Write("Author: ");
                        string author1 = Console.ReadLine();

                        //create object of BookImpl class
                        BookImpl book = new BookImpl(id1, title1, author1);

                        //add book
                        manager.AddItem(book);

                        Console.WriteLine("Book Added!");
                        break;

                    case 2:
                        //take item details
                        Console.Write("Item ID: ");
                        int id2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Title: ");
                        string title2 = Console.ReadLine();

                        Console.Write("Author: ");
                        string author2 = Console.ReadLine();

                        //create object of MagazineImpl class
                        MagazineImpl magazine = new MagazineImpl(id2, title2, author2);

                        //add magazine
                        manager.AddItem(magazine);

                        Console.WriteLine("Magazine Added!");
                        break;

                    case 3:
                        //take item details
                        Console.Write("Item ID: ");
                        int id3 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Title: ");
                        string title3 = Console.ReadLine();

                        Console.Write("Author: ");
                        string author3 = Console.ReadLine();

                        //create object of DvdImpl class
                        DvdImpl dvd = new DvdImpl(id3, title3, author3);

                        //add dvd
                        manager.AddItem(dvd);

                        Console.WriteLine("DVD Added!");
                        break;

                    case 4:
                        Console.WriteLine("\nItem Details: ");
                        manager.DisplayAllItems();
                        break;

                    case 5:
                        //take item id
                        Console.Write("Enter Item ID to Reserve: ");
                        int resId = Convert.ToInt32(Console.ReadLine());

                        //take borrower name
                        Console.Write("Enter Borrower Name: ");
                        string borrower = Console.ReadLine();

                        //call ReserveItem method
                        if (manager.ReserveItem(resId, borrower))
                        {
                            Console.WriteLine("Item Reserved Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Item not found or cannot be reserved!");
                        }

                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
            }
        }
    }
}
