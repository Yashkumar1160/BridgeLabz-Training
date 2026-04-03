using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class WorkoutMenu
    {
        //method to start fitness tracker
        public static void Start()
        {
            Console.WriteLine("-------FITNESS TRACKER APP------");
            Console.WriteLine("WHAT WORKOUT YOU WANT TO DO TODAY");

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. CARDIO WORKOUT");
                Console.WriteLine("2. STRENGTH WORKOUT");
                Console.WriteLine("3. DISPLAY ALL USER PROFILES");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        CardioWorkoutMenu();
                        break;

                    case 2:
                        StrenghtWorkoutMenu();
                        break;

                    case 3:
                        WorkoutUtilityImpl.ViewAllUsers();
                        break;

                    case 4:
                        Console.WriteLine("EXIT SUCCESSFUL THANKYOU");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }

        public static void CardioWorkoutMenu()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\nSELECT CARDIO WORKOUT");
                Console.WriteLine("1. WALKING");
                Console.WriteLine("2. JOGGING");
                Console.WriteLine("3. RUNNING");
                Console.WriteLine("4. CYCLING");
                Console.WriteLine("5. SKIPPING ROPE");
                Console.WriteLine("6. EXIT");
                Console.Write("SELECT WORKOUT: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {

                    case 1:
                        //store workout name
                        string workoutName1 = "WALKING";

                        //create object 
                        CardioWorkout workout1 = new CardioWorkout(workoutName1);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName1, workout1.MetWalking);
                        break;

                    case 2:
                        //store workout name
                        string workoutName2 = "JOGGING";

                        //create object
                        CardioWorkout workout2 = new CardioWorkout(workoutName2);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName2, workout2.MetJogging);
                        break;

                    case 3:
                        //store workout name
                        string workoutName3 = "RUNNING";

                        //create object
                        CardioWorkout workout3 = new CardioWorkout(workoutName3);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName3, workout3.MetRunning);
                        break;

                    case 4:
                        //store workout name
                        string workoutName4 = "CYCLING";

                        //create object
                        CardioWorkout workout4 = new CardioWorkout(workoutName4);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName4, workout4.MetCycling);
                        break;

                    case 5:
                        //store workout name
                        string workoutName5 = "SKIPPING ROPE";

                        //create object 
                        CardioWorkout workout5 = new CardioWorkout(workoutName5);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName5, workout5.MetSkipping);
                        break;

                    case 6:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }

        public static void StrenghtWorkoutMenu()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\nSELECT STRENGTH WORKOUT");
                Console.WriteLine("1. LIGHT");
                Console.WriteLine("2. MODERATE");
                Console.WriteLine("3. HEAVY");
                Console.WriteLine("4. EXIT");
                Console.Write("SELECT WORKOUT: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //store workout name
                        string workoutName1 = "LIGHT STRENGTH";

                        //create object 
                        StrengthWorkout workout1 = new StrengthWorkout(workoutName1);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName1, workout1.MetLight);
                        break;

                    case 2:
                        //store workout name
                        string workoutName2 = "MODERATE STRENGTH";

                        //create object
                        StrengthWorkout workout2 = new StrengthWorkout(workoutName2);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName2, workout2.MetModerate);
                        break;

                    case 3:
                        //store workout name
                        string workoutName3 = "HEAVY STRENGTH";

                        //create object
                        StrengthWorkout workout3 = new StrengthWorkout(workoutName3);

                        //call SelectedWorkout method
                        WorkoutUtilityImpl.SelectedWorkout(workoutName3, workout3.MetHeavy);
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