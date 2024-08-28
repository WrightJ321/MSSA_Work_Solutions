using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int userNum = Int32.Parse(Console.ReadLine());
            PrintNum_Head(userNum);
            Console.ReadKey();
        }
        static void PrintNum_Head(int num)
        {
            if(num > 1)
            {
                PrintNum_Head(num - 1);
                int n = num - 1;
                Console.WriteLine(n);
            }
            
        }
    }
}
