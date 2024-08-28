using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");

            string userInput = Console.ReadLine();
            string[] words = userInput.Split(' ');//takes away the spaces in a string and makes it into an array of just words.
            string lastWord = words[words.Length - 1];

            Console.WriteLine($"The last word in {userInput} is {lastWord} with a length of {lastWord.Length}. ");
            Console.ReadLine();

            ////string s = "How are you, Kangaroo";

            //Console.WriteLine(s);
            ///*Console.WriteLine(s.Length);*///21 chars

            //Console.WriteLine($"The last word is {s.Substring(13)} with length {s.Length-13}");
        }
    }
}
