using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _8._5_Most_Frequent_Character
{
    internal class Program
    {
        //Field declarations
        static string input;
        static string output;
        static int maxCount;
        static String most_common;

        static void Main(string[] args)
        {
            //Prompt for input
            Console.WriteLine("Please input your sentence:");
            input = Console.ReadLine().ToLower();
            //Initialize a winner character, and reset maxCount
            most_common = input[0].ToString();
            maxCount = 0;
            //Loop through the sentence, selecting each character
            for (int i = 0; i < input.Length; i++)
            {
                //Set the current character, reset the count of it
                char current = input[i];
                int count = 0;
                //If landed on a space, skip
                if (current == ' ')
                {
                    continue;
                }

                //if landed on a charater counted before, skip
                if (i > 0 && input.IndexOf(current) < i)
                {
                    continue;
                }
                //Count how many times the character appears in the sentence
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == current)
                    {
                        count++;
                    }
                }
                //If the current count is bigger than the maxCount, set the new 
                //winner character and update the maxCount variable
                if (count > maxCount)
                {
                    most_common = current.ToString();
                    maxCount = count;
                }
                //if there are multiple characters that appear the most, they need to be accounted for
                else if (count == maxCount)
                {
                    //most_common takes in additional values if it does grow
                    most_common += ", " + current.ToString();
                }

            }

            //Output the result
            if (most_common.Length > 1)
            {
                //if there was more than one value that appeared the most, we throw in and before the final letter and make it pretty
                char final = most_common[most_common.Length - 1];
                most_common = most_common.Substring(0, most_common.Length - 1);
                Console.WriteLine($"And the winners are: {most_common}and {final}. They each appeared {maxCount} times in your sentence!");
                Console.ReadLine();
            }
            else
            {
                //if only one max value, it's very neat and prints as expected
                Console.WriteLine($"And the winner is: {most_common}. It appeared {maxCount} times in your sentence!");
                Console.ReadLine();
            }
        }
    }
}
