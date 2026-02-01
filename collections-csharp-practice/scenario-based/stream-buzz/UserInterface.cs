using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.stream_buzz
{
    public class UserInterface
    {
        public static void DisplayMenu()
        {
            //create utility object
            IStreamBuzz util = new StreamBuzzUtilityImpl();

            while (true)
            {
                //display menu
                Console.WriteLine("\n1. Register Creator");
                Console.WriteLine("2. Show Top Posts");
                Console.WriteLine("3. Calculate Average Likes");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice:");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //register creator
                    case 1:
                        CreatorStats creator = new CreatorStats();

                        Console.WriteLine("Enter Creator Name:");
                        creator.CreatorName = Console.ReadLine();

                        //array to store weekly likes
                        creator.WeeklyLikes = new double[4];

                        Console.WriteLine("Enter weekly likes(Week 1 to 4):");
                        for (int i = 0; i < 4; i++)
                        {
                            creator.WeeklyLikes[i] = double.Parse(Console.ReadLine());
                        }

                        //register creator
                        util.RegisterCreator(creator);

                        Console.WriteLine("Creator registered successfully");
                        break;

                    //show top posts
                    case 2:
                        Console.WriteLine("Enter like threshold:");
                        double threshold = double.Parse(Console.ReadLine());

                        Dictionary<string, int> result =
                            util.GetTopPostCounts(CreatorStats.EngagementBoard, threshold);

                        //check empty result
                        if (result.Count == 0)
                        {
                            Console.WriteLine("No top-performing posts this week");
                        }
                        else
                        {
                            //print result
                            foreach (var item in result)
                            {
                                Console.WriteLine(item.Key + " - " + item.Value);
                            }
                        }
                        break;

                    //calculate average likes
                    case 3:
                        double avg = util.CalculateAverageLikes();
                        Console.WriteLine("Overall average weekly likes: " + avg);
                        break;

                    //exit
                    case 4:
                        Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
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
