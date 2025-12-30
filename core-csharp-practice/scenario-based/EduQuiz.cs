using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EDUQUIZ 30-12-2025 

namespace BridgeLabzTraining.scenario_based
{
    internal class EduQuiz
    {
        public static void Main(string[] args)
        {
            //string array to store correct answers
            string[] correctAnswers = { "A", "C", "D", "B", "B", "A", "C", "C", "A", "B" };

            //create instance of class
            EduQuiz quiz = new EduQuiz();
            
            quiz.CheckChoice(correctAnswers);
        }

        //-------------------------CHECK CHOICE--------------------------
        //method to check users choice
        public void CheckChoice(string[] correctAnswers)
        {
            //flag to check if quiz started or not
            bool quizStart = false;

            //array to store student answers
            string[] studentAnswer = new string[correctAnswers.Length];

            //infinite loop to display choices again 
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. Start Quiz");
                Console.WriteLine("2. Calculate Score");
                Console.WriteLine("3. Feedback");
                Console.WriteLine("4. Show Result");
                Console.WriteLine("5. Exit");
                Console.WriteLine("ENTER YOUR CHOICE:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        studentAnswer = StartQuiz(correctAnswers);
                        quizStart = true;
                        break;

                    //if user enters 2
                    case 2:
                        if (!quizStart)
                        {
                            Console.WriteLine("Please start quiz first");
                        }
                        else
                        {
                            Console.WriteLine("\nTOTAL SCORE: " + CalculateScore(correctAnswers, studentAnswer));
                        }
                        break;

                    //if user enters 3
                    case 3:
                        if (!quizStart)
                        {
                            Console.WriteLine("Please start quiz first");
                        }
                        else
                        {
                            GetFeedback(correctAnswers, studentAnswer);

                        }
                        break;

                    //if user enters 4
                    case 4:
                        if (!quizStart)
                        {
                            Console.WriteLine("Please start quiz first");
                        }
                        else
                        {
                            Console.WriteLine($"\nPercentage: {CalculatePercentage(correctAnswers, studentAnswer)}");
                        }
                        break;

                    //if user enters 5
                    case 5:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;

                    //if user enters an invalid input
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            }
        }

        //-------------------------START QUIZ-----------------------------
        //method to start the quiz
        public string[] StartQuiz(string[] correctAnswers)
        {
            //create array to store students answers
            string[] studentAnswers = new string[correctAnswers.Length];

            //loop to take user input answers
            for (int i = 0; i < correctAnswers.Length; i++)
            {
                Console.WriteLine($"ENTER ANSWER FOR QUESTION {i + 1} (A | B | C | D)");

                //variable to store answer
                string answer = Console.ReadLine();

                //loop to check for valid answer input
                while (CheckValidInput(answer) == false)
                {
                    Console.WriteLine("ENTER VALID ANSWER");

                    answer = Console.ReadLine();
                }

                //convert answer to uppercase
                answer = answer.ToUpper();

                studentAnswers[i] = answer;
            }
            return studentAnswers;
        }

        //---------------CHECK INPUT ANSWER------------------------
        //method to check if input answer is valid
        public bool CheckValidInput(string answer)
        {
            //convert answer to uppercase
            answer = answer.ToUpper();

            //if answer is valid return true
            if (answer == "A" || answer == "B" || answer == "C" || answer == "D")
            {
                return true;
            }

            //if answer is invalid return false
            return false;
        }

        //-----------------------CALCULATE SCORE-----------------------
        //method to calculate score
        public int CalculateScore(string[] correctAnswers, string[] studentAnswers)
        {
            //variable to store total correct answers
            int correct = 0;

            for (int i = 0; i < studentAnswers.Length; i++)
            {
                //if both answers are same 
                if (string.Equals(correctAnswers[i], studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    //update correct
                    correct++;
                }
            }

            return correct;
        }

        //--------------------FEEDBACK------------------
        //method to give feedback
        public void GetFeedback(string[] correctAnswers, string[] studentAnswers)
        {
            //loop through studentAnswers array
            for (int i = 0; i < studentAnswers.Length; i++)
            {
                //if answers in both array are same
                if (string.Equals(correctAnswers[i], studentAnswers[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\nQUESTION {i + 1} -> CORRECT ANSWER");
                }
                //if answers in both array are different
                else
                {
                    Console.WriteLine($"\nQUESTION {i + 1} -> INCORRECT ANSWER");
                }
            }
        }

        //-----------------CALCULATE PERCENTAGE-----------------
        //method to find percentage and display result
        public float CalculatePercentage(string[] correctAnswers, string[] studentAnswers)
        {
            //passing percentage 
            float passingPercentage = 33;
            //call CalculateScore method 
            int totalScore = CalculateScore(correctAnswers, studentAnswers);

            //calculate percentage
            float percentage = (totalScore * 100f) / correctAnswers.Length;

            //if percentage is more than or equal to 33, student passed 
            if (percentage >= passingPercentage)
            {
                Console.WriteLine("PASS");
            }
            //if percentage is less than 33, student failed 
            else
            {
                Console.WriteLine("FAIL");
            }

            return percentage;
        }
    }
}
