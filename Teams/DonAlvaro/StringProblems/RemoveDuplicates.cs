using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Program
{   // Input: Hello hello aB Ab ---> Out:  Hello aB   returns first occurrences of the duplicates with Cases retain intact.
    // Input: Sam went went to to to his business -->  Out: Sam went to his business. ///words that have substring match are not included.
    // Bob and Andy --> Bob and Andy,  not Bob and y
    class RegexRemoveDuplicates 
    {   
        static string[] ReturnExceptFirstOfStringArray(string[] input)
        {
            string[] output = new string[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                output[i - 1] = input[i];
            }
            return output;
        }
        static void main(string[] args)
        {
            string inputSentence;
            StringBuilder inputSentenceSB;
            Regex rg = new Regex(@"\b(\w+)(?:\W+\1\b)+");
            MatchCollection matchedWords;

            char userAnswer = 'y';

            do
            {

                Console.Write("Enter a Sentence: ");
                inputSentence = Console.ReadLine();

                inputSentenceSB = new StringBuilder(inputSentence, inputSentence.Length);

                matchedWords = rg.Matches(inputSentence.ToLower());

                for (int i = 0; i < matchedWords.Count; i++)
                {
                    string firstOccurence = matchedWords[i].ToString().Split(' ')[0];
                    string[] toBeReplaced = ReturnExceptFirstOfStringArray(matchedWords[i].ToString().Split(' '));
                    string stringToBeReplaced = string.Join(' ', toBeReplaced);
                    int indexOfSecondOccurrence = inputSentence.ToLower().IndexOf(firstOccurence, inputSentence.ToLower().IndexOf(firstOccurence) + 1, StringComparison.OrdinalIgnoreCase);
                    inputSentenceSB = inputSentenceSB.Replace(inputSentence.Substring(indexOfSecondOccurrence, stringToBeReplaced.Length), new string(' ', stringToBeReplaced.Length), indexOfSecondOccurrence, stringToBeReplaced.Length);

                }
                string outputSentence = string.Join(' ', inputSentenceSB.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries));

                Console.WriteLine(outputSentence);

                Console.Write("Try Again (y/n):");
                userAnswer = Console.ReadLine()[0];

            } while (userAnswer == 'y');

        }

    }

}