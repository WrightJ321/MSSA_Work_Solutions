using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 4, 1, 2, 1, 2 };
            Dictionary<int, int> duplicates = new Dictionary<int, int>();
            foreach (int num in nums)// the loop cycles through the array and inputs the keys as each element value since there are no prior keys added to the dict.
            {
                if (duplicates.ContainsKey(num))//this first condition statement is checking is 4 is already in the dictionary which it is not.  
                {
                    duplicates[num]++;
                }
                else
                {
                    duplicates[num] = 1;// since 4 is not a key it is incremented like : < 4: 1> and the key "4" is now given a value of 1 and so on with the rest of the array elements.
                }

            }

            foreach (var pair in duplicates)// this loop cycles through the duplicates Dict.
            {
                if (pair.Value == 1)//if statement checking if any of the key/value pairs have a value of one.. meaning there are no other keys with a value higher than 1 
                {
                    Console.WriteLine($"Non Duplicate: {pair.Key}");
                }
            }





        }
    }


}

