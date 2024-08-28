using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace Wk4Challenge2
{
    internal class Program
    {// Write a program in C# Sharp to count the frequency of each element of an array.
        //        Test Data :
        //Input the number of elements to be stored in the array :3
        //Input 3 elements in the array :
        //element - 0 : 25
        //element - 1 : 12
        //element - 2 : 43
        //Expected Output :
        //Frequency of all elements of array :
        //25 occurs 1 times
        //12 occurs 1 times
        //43 occurs 1 times

        //You may consider another array to store the frequencies.
        static void Main(string[] args)
        {
            int elements;
            int[] freqArray;
            
           
            

            Console.WriteLine("Enter the number of elements you want in your array: ");
            elements = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[elements];
            freqArray = new int[elements];
            Console.WriteLine("Input numbers for your array: ");
            InputArrayElements(userArray,freqArray, elements);


        }
        static void InputArrayElements(int[] userArray,int [] freqArray, int elements)
        {
            int count;
            int j;
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine($"Enter element {i}: ");
                userArray[i] = int.Parse(Console.ReadLine());
                freqArray[i] = -1;
             
            }
            
            for(int i = 0; i < elements; i++)
            {
                count = 1;
                for(j= i + 1;j < elements; j++)
                {
                    if (userArray[i] == userArray[j])
                    {
                        count++;
                        freqArray[j] = 0;
                    }
                }
                if (freqArray[i] != 0)
                {
                    freqArray[i] = count;
                }
            }
            Console.WriteLine("Duplicate numbers in array: ");
            for (int i = 0;i < elements; i++)
            {
                if (freqArray[i] != 0)
                {
                    Console.WriteLine($"Number {userArray[i]} occurs {freqArray[i]} times");
                }
            }

        }
       

    }
}
