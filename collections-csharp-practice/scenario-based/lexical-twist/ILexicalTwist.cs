using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.lexical_twist
{
    internal interface ILexicalTwist
    {
        //method to process two words based on rules
        void ProcessWords(string word1, string word2);

        //method to validate a single word 
        bool ValidateWord(string word);

        //method to check if the second word is the reverse of the first word
        bool IsReversed(string word1, string word2);

        //method to transform a reversed word
        string TransformReversedWord(string word);

        //method to combine two words and convert to uppercase
        string CombineWordsUppercase(string word1, string word2);

        //method to count vowels in a word
        int CountVowels(string word);

        //method to count consonants in a word
        int CountConsonants(string word);

        //method to get first 2 distinct vowels from a word
        string GetFirstTwoVowels(string word);

        //method to get first 2 distinct consonants from a word
        string GetFirstTwoConsonants(string word);
    }
}
