using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userInteger = Int32.Parse(Console.ReadLine());
            PrintNums_Tail(userInteger);
            Console.ReadKey();
        }
        static void PrintNums_Tail(int num)
        {
            if(num > 1)
            {
                int n = num - 1;
                Console.WriteLine(n);
                PrintNums_Tail(num - 1);
            }
        }
    }
}
