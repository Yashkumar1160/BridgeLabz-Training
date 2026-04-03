using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class WorkoutUtilityImpl : ITrackable 
    {
        //array to store all user profiles
        static UserProfile[] users = new UserProfile[100];
        
        //variable to store total users count
        static int totalUsers=0;

        //create object of WorkoutUtilityImpl class
        static WorkoutUtilityImpl workoutUtilityImpl=new WorkoutUtilityImpl();

        //method to select workout and start and end workout
        public static void SelectedWorkout(string workoutName,double metValue)
        {
            //add user
            UserProfile user=AddUser();

            //initial start and end time
            DateTime startTime=DateTime.MinValue;

            DateTime endTime=DateTime.MinValue;

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("1. START WORKOUT");
                Console.WriteLine("2. END WORKOUT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int userChoice = Convert.ToInt32(Console.ReadLine());

                //if user starts workout
                if(userChoice == 1)
                {
                    startTime = workoutUtilityImpl.StartWorkout();
                    Console.WriteLine("WORKOUT STARTED AT: "+startTime);
                }
                //if user ends workout
                else if(userChoice == 2)
                {
                    //check if workout started
                    if (startTime==DateTime.MinValue)
                    {
                        Console.WriteLine("START WORKOUT FIRST");
                        continue;
                    }
                    endTime= workoutUtilityImpl.StopWorkout();
                    Console.WriteLine("WORKOUT ENDED AT: "+endTime);
                    break;

                }
                //if user enters invalid option
                else
                {
                    Console.WriteLine("INVALID CHOICE");
                }
            }

            //find the difference between start and end time
            TimeSpan duration=endTime-startTime;

            //calculate total calories burned
            double caloriesBurned = workoutUtilityImpl.CalculateCalories(metValue,duration,user.Weight);

            DisplayDetails(caloriesBurned,user,workoutName,startTime,endTime,duration);
        }   


        //method to display user and workout details
        public static void DisplayDetails(double caloriesBurned,UserProfile user,string workoutName,DateTime startTime,DateTime endTime,TimeSpan duration)
        {
            //display user details
            Console.WriteLine(user);
         
            Console.WriteLine("WORKOUT: " + workoutName);
            
            Console.WriteLine("START TIME: " + startTime);
            
            Console.WriteLine("END TIME: " + endTime);
            
            Console.WriteLine("DURATION (minutes): " + duration.TotalMinutes);
            
            Console.WriteLine("CALORIES BURNED: " + caloriesBurned);
        }

        //implementation method to start workout time
        public DateTime StartWorkout()
        {
            return DateTime.Now;
        }

        //implementation method to end workout time
        public DateTime StopWorkout()
        {
            return DateTime.Now;
        }

        //implementation of method to calculate calories burned
        public double CalculateCalories(double metValue, TimeSpan duration,double weight)
        {
            return metValue * (duration.TotalMinutes/60) * weight;
        }

        //method to add user profile
        public static UserProfile AddUser()
        {
            //take name
            Console.Write("ENTER NAME: ");
            string name=Console.ReadLine();

            //take age
            Console.Write("ENTER AGE: ");
            int age=Convert.ToInt32(Console.ReadLine());    

            //take gender
            Console.Write("ENTER GENDER: ");
            string gender=Console.ReadLine();

            //take height
            Console.Write("ENTER HEIGHT: ");
            double height=Convert.ToDouble(Console.ReadLine());

            //take weight
            Console.Write("ENTER WEIGHT: ");
            double weight=Convert.ToDouble(Console.ReadLine());

            //create object of UserProfile class
            UserProfile user = new UserProfile(name,age,gender,height,weight);

            //add user to array
            users[totalUsers]=user;

            //update total users
            totalUsers++;

            return user;
        }

        //method to view all user
        public static void ViewAllUsers()
        {
            if (totalUsers == 0)
            {
                Console.WriteLine("NO USER ADDED YET");
                return;
            }

            for(int i=0;i<totalUsers;i++)
            {
                Console.WriteLine(users[i]);
            }
        }
    }
}
