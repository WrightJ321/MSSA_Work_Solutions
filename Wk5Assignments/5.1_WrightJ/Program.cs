using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome validater");
            Console.WriteLine("Please enter a number: ");
            int userNum = int.Parse(Console.ReadLine());
            int storeNum = userNum;
            int reverseNum = 0;
            int remainder;

            
            while (storeNum!= 0)
            {//remainder variable retrieves the last number since for example usernum is 1221 so 1221 % 10 = 122.1 so remainder stores that remainder of 1
             
                remainder = storeNum % 10;
                //the storeNum variable takes the userNum which is now 122
                storeNum = storeNum / 10;
                //reverseNum = 0 and 10*0= 0 then add the remainder which is 1 and so on, the storeNum goes back through the loop until reverseNum is equal to or not equal to userNum.
                reverseNum = reverseNum * 10 + remainder;

            }
            if (reverseNum == userNum)
            {
                Console.WriteLine("Your number is a Palindrome");

            }
            else
            {
                Console.WriteLine("Your number is NOT a Palindrome");
            }
            Console.ReadLine();






















            //another way
            //int[] number = new int[3] {1,2,1};

            //bool isValidPal = true;
            ////by using number.length / 2, avoid unneccessary comparisons so that only the first and last integer of the array are compared
            //for (int i = 0; i < number.Length /2; i++)
            //{
            //    if (number[i] != number[number.Length -1 -i])
            //    {
            //        isValidPal = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isValidPal);
        }
    }
}
