using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ChLab1
{
    internal class Program
    {  

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Palindrome validater");
            Console.WriteLine("Enter a word that you want validated");
            string userInput = Console.ReadLine();
            
            bool isPalindrome = IsPalindrome(userInput);
            if (isPalindrome)
            {
                Console.WriteLine($"{userInput} is a Palindrome");
                
            }
            else
            {
                Console.WriteLine($"{userInput} is not a Palindrome");
            }

        
        }
        static bool IsPalindrome(string answer)
        {
            answer = answer.Replace(" ", "").ToLower();
            int left = 0;
            int right = answer.Length - 1;
            while (left < right)
            {
                if (answer[left] != answer[right])
                { 
                    return false;



                }
                left++;
                right--;


            }
            return true;
        }
    }
}

