using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ChallengeLab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 6;
            int[] userArray = new int[arraySize];
            int target = 10;

            Console.WriteLine($"Your target number is : {target}");
            Console.WriteLine("Enter 6 integers in your array that have at least two integers that equal target number");
            Console.WriteLine();

            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array:");
            Console.Write("[");
            foreach (int num in userArray)
            {
                Console.Write($"{num}");
            }
            Console.Write("]");

            Console.WriteLine(TwoSum(userArray,target));

        }
        public static int[] TwoSum(int[] userArray, int target)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[i] + userArray[j] == target)
                    {
                        Console.WriteLine($"Sum of [{i},{j}] = {target}");
                    }
                   
                }
            }
            return new int[0];

        }

    }
}



    
            //int target = 10;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == target)
            //        {
            //            Console.WriteLine($"Sum of [{i},{j}] = {target}");
            //        }
            //        else if (numbers[i] + numbers[j] != target)
            //        {
            //            Console.WriteLine($"None of the indices are equal to {target}");
            //        }
            //    }

            //}
      