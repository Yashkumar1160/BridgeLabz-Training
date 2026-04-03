using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.cinema_time
{
    internal class MovieMenu
    {
        public static void Start()
        {
            Console.WriteLine("-----CINEMA TIME-----");

            MovieUtilityImpl movieUtility = new MovieUtilityImpl();

            while (true)
            {
                Console.WriteLine("\n1. ADD MOVIE");
                Console.WriteLine("2. SEARCH FOR A MOVIE");
                Console.WriteLine("3. DISPLAY ALL MOVIES");
                Console.WriteLine("4. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("ENTER MOVIE TITLE: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("ENTER MOVIE TIME (HH:MM): ");
                        string time = Console.ReadLine();

                        Movie movie = new Movie(title, time);

                        movieUtility.AddMovie(movie);

                        Console.WriteLine("MOVIE ADDED");
                        break;

                    case 2:
                        Console.WriteLine("ENTER MOVIE: ");
                        string keyword = Console.ReadLine();

                        movieUtility.SearchMovie(keyword);
                        break;

                    case 3:
                        movieUtility.DisplayAllMovies();
                        break;

                    case 4:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }
}
