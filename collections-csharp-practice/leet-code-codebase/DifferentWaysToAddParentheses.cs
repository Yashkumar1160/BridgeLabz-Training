using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.leet_code_codebase
{
    internal class DifferentWaysToAddParentheses
    {
        public static void Main()
        {
            //take input from user
            Console.Write("Enter expression: ");
            string expression = Console.ReadLine();

            //call method to compute all results
            List<int> results = ComputeWays(expression);

            //display all possible results
            Console.WriteLine("Possible results:");
            foreach (int value in results)
            {
                Console.Write(value + " ");
            }
        }

        //method to compute different possible results
        static List<int> ComputeWays(string expression)
        {
            //list to store results
            List<int> result = new List<int>();

            //loop through expression
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                //check if current character is an operator
                if (ch == '+' || ch == '-' || ch == '*')
                {
                    //split left part
                    string leftPart = expression.Substring(0, i);

                    //split right part
                    string rightPart = expression.Substring(i + 1);

                    //recursive call for left part
                    List<int> leftResults = ComputeWays(leftPart);

                    //recursive call for right part
                    List<int> rightResults = ComputeWays(rightPart);

                    //combine left and right results
                    foreach (int left in leftResults)
                    {
                        foreach (int right in rightResults)
                        {
                            //perform operation based on operator
                            if (ch == '+')
                                result.Add(left + right);
                            else if (ch == '-')
                                result.Add(left - right);
                            else
                                result.Add(left * right);
                        }
                    }
                }
            }

            //if no operator found
            if (result.Count == 0)
            {
                //convert string to integer and add to result
                result.Add(int.Parse(expression));
            }

            //return all computed results
            return result;
        }
    }
}
