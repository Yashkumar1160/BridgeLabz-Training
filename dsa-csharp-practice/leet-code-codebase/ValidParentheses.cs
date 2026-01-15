using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase
{
    internal class ValidParentheses
    {
        public static void Main(string[] args)
        {
            //take parentheses
            Console.WriteLine("ENTER PARENTHESES: ");
            string parentheses = Console.ReadLine();

            //display result
            Console.WriteLine(CheckParentheses(parentheses));
        }

        //method to vaildate parentheses
        public static bool CheckParentheses(string parentheses)
        {
            //create stack to store opening parentheses
            Stack<char> st = new Stack<char>();

            //loop through parentheses string
            for (int i = 0; i < parentheses.Length; i++)
            {
                //take current character
                char currentChar = parentheses[i];

                //if open bracket is found
                if (currentChar == '(' || currentChar == '{' || currentChar == '[')
                {
                    //push in stack
                    st.Push(currentChar);
                }
                //if closing bracket is found
                else
                {
                    //check if stack is empty
                    if (st.Count() == 0)
                    {
                        return false;
                    }

                    //pop top element from stack
                    char topChar = st.Pop();

                    //check if the popped bracket matches the current closing bracket
                    if ((currentChar == ')' && topChar != '(') ||
                        (currentChar == '}' && topChar != '{') ||
                        (currentChar == ']' && topChar != '['))
                    {
                        return false;
                    }
                }
            }

            //if stack is empty then parentheses is valid
            return st.Count() == 0;
        }
    }
}
