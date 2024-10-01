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
        static char winner;
        static int maxCount;
        
        static void Main(string[] args)
        {
            //Prompt for input
            Console.WriteLine("Please input your sentence:");
            input = Console.ReadLine().ToLower();
            //Initialize a winner character, and reset maxCount
            winner = input[0];
            maxCount = 0;
            //Loop through the sentence, selecting each character
            for(int i = 0; i < input.Length; i++)
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
                    if(input[j] == current)
                    {
                        count++;
                    }
                }
                //If the current count is bigger than the maxCount, set the new 
                //winner character and update the maxCount variable
                if (count > maxCount)
                {
                    winner = current;
                    maxCount = count;
                }
                
            }

            //Output the result
            Console.WriteLine($"And the winner is: {winner}. It appeared {maxCount} times in your sentence!");
            Console.ReadLine();

        }
    }
}
