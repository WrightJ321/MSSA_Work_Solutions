using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._2_WrightJ
{
    internal class Program
    {
        static int stepCounter(int n)
        {
            if(n <= 1)
            {
                return 1;// this is saying if the number of steps chosen is less than or equal to one then return 1 because it would jsut take 1 step to climb 1 step(its a validation)
            }
            int[] steps = new int[n+1];// need to add 1 to n so that all 4 values 1-4 are present in array, so array length becomes [5]
            steps[0] = 1;
            steps[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                steps[i] = steps[i-1] + steps[i-2];
            }
            return steps[n];

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steps in a staircase: ");
            int steps = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine($"Number of distinct ways to climb the staircase : {stepCounter(steps)}");
        }
    }
}
