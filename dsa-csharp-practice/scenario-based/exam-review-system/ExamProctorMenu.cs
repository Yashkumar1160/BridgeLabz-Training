using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class ExamProctorMenu
    {
        //proctor credentials
        static string proctorUsername = "proctorUsername";
        static string proctorPassword = "proctorPassword";

        //student credentials
        static string studentUsername = "studentUsername";
        static string studentPassword = "studentPassword";


        public static void DisplayMenu()
        {
            Console.WriteLine("--------ONLINE EXAM REVIEW SYSTEM---------");

            ExamProctorUtilityImpl utility=new ExamProctorUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. PROCTOR LOGIN");
                Console.WriteLine("2. STUDENT LOGIN");
                Console.WriteLine("3. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    case 1:
                        ProctorLogin(utility);
                        break;

                    case 2:
                        StudentLogin(utility);
                        break;

                    case 3:
                        Console.WriteLine("Exit Successful");
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
            }
        }


        //method for proctor login
        public static void ProctorLogin(ExamProctorUtilityImpl utility)
        {
            //take username
            Console.Write("ENTER USERNAME: ");
            string userName=Console.ReadLine();

            //take password
            Console.Write("ENTER PASSWORD: ");
            string password=Console.ReadLine();

            //check if username and password
            if (!userName.Equals(proctorUsername, StringComparison.OrdinalIgnoreCase) ||!password.Equals(proctorPassword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid Credentials");
                return;
            }

            //display menu
            Console.WriteLine("\n1. ADD QUESTIONS AND ANSWERS");
            Console.WriteLine("2. UPDATE ANSWERS");
            Console.WriteLine("3. SHOW QUESTIONS NAVIGATION");
            Console.WriteLine("4. EXIT");
            Console.Write("ENTER YOUR CHOICE: ");

            //take user's choice
            int choice=Convert.ToInt32(Console.ReadLine());

            //handle user's choice
            switch(choice)
            {
                //add question and answers
                case 1:
                    utility.AddQuestionsAndAnswers();
                    break;

                //update answer
                case 2:
                    utility.UpdateAnswers();
                    break;

                case 3:
                    utility.ShowQuestionsNavigation();
                    break;

                //return
                case 4:
                    return;

                //invalid choice
                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }

        }

        //method for student login
        public static void StudentLogin(ExamProctorUtilityImpl utility)
        {
            //take username
            Console.Write("ENTER USERNAME: ");
            string userName = Console.ReadLine();

            //take password
            Console.Write("ENTER PASSWORD: ");
            string password = Console.ReadLine();

            //check username and password
            if (!userName.Equals(studentUsername, StringComparison.OrdinalIgnoreCase) || !password.Equals(studentPassword, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid Credentials");
                return;
            }

            //take student name
            Console.Write("\nENTER STUDENT NAME: ");
            string name= Console.ReadLine();

            //take age
            Console.Write("ENTER AGE: ");
            int age= Convert.ToInt32(Console.ReadLine());
            
            //take roll number
            Console.Write("ENTER ROLL NUMBER: ");
            int rollNumber= Convert.ToInt32(Console.ReadLine());

            //create object
            Student student=new Student(rollNumber, name, age);

            //display menu
            Console.WriteLine("\n1. VISIT QUESTION");
            Console.WriteLine("2. UPDATE ANSWER");
            Console.WriteLine("3. GO BACK");
            Console.WriteLine("4. EVALUATE EXAM");
            Console.WriteLine("5. EXIT");
            Console.Write("ENTER YOUR CHOICE: ");

            //take user's choice
            int choice = Convert.ToInt32(Console.ReadLine());

            //handle user's choice
            switch (choice)
            {
                //visit question
                case 1:
                    utility.VisitQuestion();
                    break;

                //submit answer
                case 2:
                    utility.SubmitAnswer();
                    break;

                //go back
                case 3:
                    utility.GoBack();
                    break;

                //evaluate score
                case 4:
                    utility.EvaluateExam(student);
                    break;

                //return back
                case 5:
                    return;

                //invalid choice
                default:
                    Console.WriteLine("\nInvalid Choice");
                    break;
            }

        }
    }
}
