using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class SpringSeason
    {
        public static void Main(string[] args)
        {
            //take integer values for variables day and month
            Console.WriteLine("Enter Month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Day");
            int day = Convert.ToInt32(Console.ReadLine());

            //create instance of class
            SpringSeason springSeason = new SpringSeason();

            //call the CheckSpringSeason() method
            bool checkSpring = springSeason.CheckSpringSeason(month, day);
            //display result
            Console.WriteLine(checkSpring);

        }
        //Method to check if the month and day is a spring season
        public bool CheckSpringSeason(int month, int day)
        {
            //check month and day if it is a spring season or not
            if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
