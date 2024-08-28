using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome Validater");
            Console.WriteLine("Please type a word to validate:");
            string word = Console.ReadLine();
            Console.WriteLine(IsValid(word));
            Console.WriteLine($"{word} is a Palindrome");
        }
        static bool IsValid(string word)
        {
            if(word.Length <= 1)// checking to see if users input is a valid word, which it wll be until its checked by the second if statement 
            {
                return true;
            }
            else
            {
                if (word[0] != word[word.Length-1])// this condition checks whether the character at index 0 is the same of the length of the users word minus 1 which gives the last letter of the word
                    // this is how it works, if radar is used then the length of the string would be 5
                    // since the length starts at 0 it would make sense to compare the index at 0 with the word[length -1] since the second 'r' is at index 4.
                    // if the the first letter and last letter do not match then it returns false
                {
                    Console.WriteLine($"{word} is not a Palindrome");
                    return false;
                }
                else//if the first and last letter do match then the program moves on to the else statement which compare the letters between the first and last letter 
                {
                    return IsValid(word.Substring(1, word.Length - 2));
                }
            }
           
        }
    }
}
