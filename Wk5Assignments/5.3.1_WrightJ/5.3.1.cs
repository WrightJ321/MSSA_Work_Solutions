using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5._3._1_WrightJ
{
    internal class Program
    {
        
        static bool CanPlantFlow(int[] flowerBed, int n)
        {
            int flowerCnt = 0;
            for(int i = 0; i < flowerBed.Length; i++)
            {
                if(flowerBed[i] == 0 && (i == 0 || flowerBed[i -1] == 0) && (i == flowerBed.Length - 1 || flowerBed[i +1] ==0))
                {
                    flowerBed[i] = 1;
                    flowerCnt++;
                    if(flowerCnt>= n)
                    {
                        return true;
                    }
                }
            }
            return flowerCnt >= n;
           
        }
        static void Main(string[] args)
        {
            int[] flowerBed = new int[] { 0, 1, 0, 0, 0, 1, 0, 0, 0, 1};
            Console.WriteLine("Welcome to Gardening school!");
            Console.WriteLine("To allow your flowers to grow efficiently, you must not plant them adjacently.");
            Console.WriteLine("Previously planted flowers are representated as 1's and empty spots are 0's");
            Console.WriteLine("Your flower bed : ");
            foreach (int i in flowerBed)
            {
                Console.WriteLine(i);
                
            }
            Console.WriteLine(" choose a number of flowers to plant so that they will grow efficiently: ");
            int userNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine(CanPlantFlow(flowerBed, userNum));
            
            Console.ReadKey();



        }
    }
}
