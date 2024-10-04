using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3_Sentence_Capitalizer
{
    internal class Program
    {
        //Static fields used in the methods
        static bool isDone;
        static string input;
        static string[] words;
        static string output;
        static char first;
        static string confirm;
        static void Main(string[] args)
        {
            //Boolean for the do-while loop
            isDone = false;
            
            //Do-while loop to confirm whether the user is done or not
            do
            {
                //reset output
                output = "";
                //Prompt for user input
                Console.WriteLine("Please input the sentence you want capitalized:");
                input =  Console.ReadLine();
                //Call the method
                wordToCaps(input);
                //Output the result
                Console.WriteLine(output);
                //Prompt whether user wants to continue
                Console.WriteLine("Would you like to convert another sentence? Reply yes to continue");
                confirm = Console.ReadLine();
                if (confirm.ToLower() == "yes")
                {
                    //Continue the loop
                    isDone = false;
                }
                else
                {
                    //End the loop and close the app
                    isDone = true;
                }
            } while (!isDone);
        }

        /// <summary>
        /// This method splits the input string into words, and capitalizes 
        /// every first letter of every word.
        /// </summary>
        /// <param name="input"> The input string</param>
        /// <returns>Output string</returns>
        static public string wordToCaps(string input)
        {
            words = input.Split(' ');
            foreach (string word in words)
            {
                first = word[0];
                output += char.ToUpper(first) + word.Substring(1) + " ";
            }
            return output;
        }
    }
}
