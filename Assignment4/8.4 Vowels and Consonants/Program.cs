using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _8._4_Vowels_and_Consonants
{
    internal class Program
    {
        //Fields for the class
        static string input;
        static int countOfVowels;
        static int countOfConsonants;
        static HashSet<char> vowels;
        static HashSet<char> consonants;

        static void Main(string[] args)
        {
            //reset the counter values
            countOfConsonants = 0;
            countOfVowels = 0;
            //Declare the sets of vowels and consonants to look for
            vowels = new HashSet<char> { 'a' ,'e','o','i','u'};
            consonants = new HashSet<char> { 'q', 'w', 'r', 't', 
                'y', 'p', 's', 'd','f','g','h','j','k','l','z','x','c','v'
            ,'b','n','m'};
            //Ask for input
            Console.WriteLine("Please provide a sentence:");
            input = Console.ReadLine().ToLower();
            //Count vowels
            countVowels(input);
            //Count consonants
            countConsonants(input);
            //Output result
            Console.WriteLine($"Your sentence contains {countOfConsonants} consonants and {countOfVowels} vowels");
            Console.ReadLine();




        }

        /// <summary>
        /// Method to count vowels in a sentence
        /// </summary>
        /// <param name="input"> Sentence</param>
        static public void countVowels(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    countOfVowels++;
                }
            }
            
        }
        /// <summary>
        /// Method to count consonants in a sentence
        /// </summary>
        /// <param name="input">Sentence</param>
        static public void countConsonants(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                if (consonants.Contains(input[i]))
                {
                    countOfConsonants++;
                }
            }
        }
    }
}
