using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Reflection;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.lexical_twist
{
    internal class LexicalTwistUtilityImpl : ILexicalTwist
    {
        //method to process two words based on rules
        public void ProcessWords(string word1, string word2)
        {
            //Validate both words
            //reflection: get method info
            MethodInfo method = this.GetType().GetMethod("ValidateWord");

            //check if annotation is present
            if (method != null && method.GetCustomAttribute<SingleWordOnlyAttribute>() != null)
            {
                if (!ValidateWord(word1))
                {
                    Console.WriteLine($"{word1} is an invalid word");
                    return;
                }

                if (!ValidateWord(word2))
                {
                    Console.WriteLine($"{word2} is an invalid word");
                    return;
                }
            }


            //check if second word is reverse of first
            if (IsReversed(word1, word2))
            {
                string transformed = TransformReversedWord(word1);
                Console.WriteLine(transformed);
            }
            else
            {
                string combined = CombineWordsUppercase(word1, word2);
                int vowels = CountVowels(combined);
                int consonants = CountConsonants(combined);

                if (vowels > consonants)
                    Console.WriteLine(GetFirstTwoVowels(combined));
                else if (consonants > vowels)
                    Console.WriteLine(GetFirstTwoConsonants(combined));
                else
                    Console.WriteLine("Vowels and consonants are equal");
            }
        }

        //method to validate a single word 
        [SingleWordOnly]
        public bool ValidateWord(string word)
        {
            return Regex.IsMatch(word, @"^[A-Za-z]+$");
        }

        //method to check if the second word is the reverse of the first word
        public bool IsReversed(string word1, string word2)
        {
            return string.Equals(word2, new string(word1.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);
        }

        //method to transform a reversed word
        public string TransformReversedWord(string word)
        {
            string reversed = new string(word.Reverse().ToArray()).ToLower();
            return Regex.Replace(reversed, "[aeiou]", "@");
        }

        //method to combine two words and convert to uppercase
        public string CombineWordsUppercase(string word1, string word2)
        {
            return (word1 + word2).ToUpper();
        }

        //method to count vowels in a word

        public int CountVowels(string word)
        {
            return word.Count(c => "AEIOU".Contains(c));
        }

        //method to count consonants in a word
        public int CountConsonants(string word)
        {
            return word.Count(c => char.IsLetter(c) && !"AEIOU".Contains(c));
        }

        //method to get first 2 distinct vowels from a word
        public string GetFirstTwoVowels(string word)
        {
            return new string(word.Where(c => "AEIOU".Contains(c)).Distinct().Take(2).ToArray());
        }

        //method to get first 2 distinct consonants from a word
        public string GetFirstTwoConsonants(string word)
        {
            return new string(word.Where(c => char.IsLetter(c) && !"AEIOU".Contains(c)).Distinct().Take(2).ToArray());
        }
    }
}
