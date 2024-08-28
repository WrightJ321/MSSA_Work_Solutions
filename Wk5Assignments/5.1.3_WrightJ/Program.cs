using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._3_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Assignment 5.1 task 3!");
            Console.WriteLine("We re going to decide if your given array contains any duplicates if so it will return true otherwise false.");
            Console.WriteLine("Please enter how many numbers you would like your array to contain");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Next");

            int[] userArray = new int[size];
            int[] duplArray = userArray;
            for (int i = 0;i < size;i++)
            {
                Console.Write($"Enter your element {i +1}: ");
                userArray[i] = int.Parse(Console.ReadLine());
            }
            bool hasDuplicates = IsDuplicate(userArray);
            Console.WriteLine($"{hasDuplicates} Your array has duplicates");
            
            Console.ReadLine();

        }

        private static bool IsDuplicate(int[] array)
        {
            for(int i = 0; i < array.Length;i++)
            {//second for loop itirates through the elements at the index after i in sequence so that the first for loop with [i] is checking for a number while the second loop with [j] is checking for numbers after [i]...
             // so that is avoids any redundant duplicates.. reference(int j = i + 1)... basically j is checking i's number value to see if j's value is the same.
                for(int j = i + 1; j < array.Length;j++)
                {
                    if(array[i] == array[j])
                    {
                        return true;
                    }
                   
                }
            }
            return false;
            
           

        }

    }
}
