using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class NavigationStack
    {
        //top of stack
        StackNode top;

        //method to push question to stack
        public void Push(int questionNumber)
        {
            StackNode node=new StackNode(questionNumber);

            node.Next = top;
            top=node;

        }

        //method to pop question
        public int Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nNo Questions Visited Yet");
                return -1;
            }

            int question = top.questionNumber;

            top = top.Next;
            return question;
        }

        //method to check if stack is empty
        public bool IsEmpty()
        {
            return top == null;
        }

        //method to see top question
        public int Peek()
        {
            if (top == null) 
                return -1;

            return top.questionNumber;
        }

        //method to display question navigation
        public void DisplayNavigation()
        {
            if (top == null)
            {
                Console.WriteLine("\nNavigation Not Available");
                return;
            }

            Console.WriteLine("\nQuestions Navigation:");

            StackNode temp = top;
            while (temp != null)
            {
                Console.WriteLine("Question " + temp.questionNumber);
                temp = temp.Next;
            }
        }
    }
}
