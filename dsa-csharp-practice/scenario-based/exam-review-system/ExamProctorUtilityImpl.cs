using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class ExamProctorUtilityImpl : IExamProctor
    {
        //stack for questions tracking
        NavigationStack navigationStack=new NavigationStack();

        //dictionary to store correct answers
        AnswerDictionary correctAnswers=new AnswerDictionary();

        //dictionary to store answers by student
        AnswerDictionary studentAnswers=new AnswerDictionary();



        //method to add questions and correct answers
        public void AddQuestionsAndAnswers()
        {
            Console.WriteLine("\nADD 10 QUESTIONS AND ANSWERS");

            //loop to take questions and answers
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"\nENTER QUESTION NUMBER: ");
                int question = Convert.ToInt32(Console.ReadLine());

                Console.Write("ENTER CORRECT ANSWER: ");
                string answer = Console.ReadLine();

                correctAnswers.AddAnswer(question, answer);
            }

            Console.WriteLine("\nAll 10 Questions & Answers Added Successfully");
        }



        //method to update correct answer
        public void UpdateAnswers()
        {
            //take question number
            Console.Write("ENTER QUESTION NUMBER TO UPDATE: ");
            int question = Convert.ToInt32(Console.ReadLine());

            //take new answer
            Console.Write("ENTER NEW ANSWER: ");
            string newAnswer = Console.ReadLine();

            //update answer
            if (correctAnswers.Update(question, newAnswer))
            {
                Console.WriteLine("\nAnswer Updated Successfully");
            }
            else
            {
                Console.WriteLine("\nQuestion Not Found");
            }
        }




        //method to visit question
        public void VisitQuestion()
        {
            //take question number
            Console.Write("\nENTER QUESTION NUMBER TO VISIT: ");
            int question = Convert.ToInt32(Console.ReadLine());

            //push question in stack
            navigationStack.Push(question);
            Console.WriteLine($"Visited Question {question}");
        }



        //method to submit or update answer
        public void SubmitAnswer()
        {
            //if stack is empty
            if (navigationStack.IsEmpty())
            {
                Console.WriteLine("No Question Visited Yet");
                return;
            }

            //current question
            int currentQuestion = navigationStack.Peek();

            //take answer
            Console.Write($"ENTER ANSWER FOR QUESTION {currentQuestion}: ");
            string answer = Console.ReadLine();

            //u[date answer
            if (!studentAnswers.Update(currentQuestion, answer))
            {
                studentAnswers.AddAnswer(currentQuestion, answer);
            }

            Console.WriteLine("Answer Saved Successfully");
        }



        //method to display navigation stack
        public void ShowQuestionsNavigation()
        {
            navigationStack.DisplayNavigation();
        }


        //method to go back to previous question
        public void GoBack()
        {
            //if stack is empty
            if (navigationStack.IsEmpty())
            {
                Console.WriteLine("No previous question to go back");
                return;
            }

            //variable to store removed question
            int removedQuestion = navigationStack.Pop();
            Console.WriteLine($"Went back from Question {removedQuestion}");

            if (!navigationStack.IsEmpty())
            {
                Console.WriteLine($"Current Question: {navigationStack.Peek()}");
            }
            else
            {
                Console.WriteLine("No active question now");
            }
        }


        //method to evaluate exam and find score
        public void EvaluateExam(Student student)
        {
            int score = 0;

            //store head node in temp variable
            DictionaryNode temp = correctAnswers.GetHead();

            //traverse dictionary 
            while (temp != null)
            {
                string studentAnswer = studentAnswers.Get(temp.question);

                //if answer is correct
                if (studentAnswer != null &&studentAnswer.Equals(temp.answer, StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
                //update temp
                temp = temp.Next;
            }

            Console.WriteLine(student);
            Console.WriteLine($"Total Score: {score}");
        }

    }
}
