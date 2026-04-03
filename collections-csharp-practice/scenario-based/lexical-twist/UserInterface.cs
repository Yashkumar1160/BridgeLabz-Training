using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.lexical_twist
{
    internal class UserInterface
    {
        public static void DisplayMenu()
        {
            //create object
            ILexicalTwist util = new LexicalTwistUtilityImpl();

            //take first word
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();

            //take second word
            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            //call ProcessWords method
            util.ProcessWords(word1, word2);
        }
    }
}
