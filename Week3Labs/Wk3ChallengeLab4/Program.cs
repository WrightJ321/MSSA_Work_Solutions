using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3ChallengeLab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ABFCACDB";
            Console.WriteLine(s.Substring(0, 8));

            Console.WriteLine("Removing SubString ''AB''");

            string newStr = s.Replace("ABFCACDB","FCACDB");
            Console.WriteLine(newStr.Substring(0, 6));

            Console.WriteLine("Removing SubString ''CD''");

            string newStr2 = newStr.Replace("FCACDB", "FCAB");
            Console.WriteLine(newStr2.Substring(0, 4));

            Console.WriteLine("Removing 2nd SubString ''AB''");

            string newStr3 = newStr2.Replace("FCAB","FC");
            Console.WriteLine(newStr3.Substring(0,2));
            
            Console.WriteLine("Minimum Length of string: 2");




        }
       
    }
}
