using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ChallengeLab3
{
    internal class Program
    {
        public static int SumDigitinString(string input)
        {
            int sum = 0;
            // declare a int variable(sum) to 0 so it can be used to add to char 'c' in input
            foreach(char c in input)
            {
                if ((char.IsDigit)(c))
                    //lineabove is checking if each char in the string is a digit 
                {
                    sum += c - '0';
                    // line above is adding sum to each char if it is a digit.. the'0' is an ASQI Character and it represented as the number 48 and
                    // each other character after that increments by '1' so the '1' would be 49 and essentially '0' - '1' is 1 or 48-49 
                }
                
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name or phrase where each letter is seperated by a single integer.");
            string input = Console.ReadLine();
            int sum = SumDigitinString(input);
            Console.WriteLine($"the sum of those integers are: {sum}");
        }
    }
}
