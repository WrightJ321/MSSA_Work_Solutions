using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._2_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());

            int sum = SumofDigits(userNum);
            Console.WriteLine($"The sum of digits in your number : {sum}");
        }
        public static int SumofDigits(int num)
        {
            int sum = 0;
            while(num != 0)
            {//the sum starts at 0 as seen from the declaration of sum in line 21, everytime the while loop starts its saying since num has a value other than zero
             //then sum is going to add the remainder of result of the users number divided by 10 so example 1234 % 10 is 123.4 so 4 will be added to sum of 0  
                sum += num % 10;
                // the num just keeps iterating through the num inputted by user as it gets divided by 10 each time resulting in the total sum of all digits in the original input number
                num /= 10;

            }
            return sum;
        }
    }
}
