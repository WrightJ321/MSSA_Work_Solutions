using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "(){}[]";
            string t = "{}";
            string u = "[})(";
            string v = "[]{}";

            bool result = isValid(s);
            bool result2 = isValid(t);
            bool result3 = isValid(u);
            bool result4 = isValid(v);

            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
        public static bool isValid(string s)
        {
            Dictionary<char, char> validParen = new Dictionary<char, char>();
            validParen.Add('(', ')');
            validParen.Add('{', '}');
            validParen.Add('[', ']');

            Stack <char> myStack = new Stack<char>();
            foreach (char c in s)
            {
                if(validParen.ContainsKey(c))
                {
                    myStack.Push(c);
                }
                else
                {
                    if(myStack.Count == 0)
                    {
                        return false;
                    }
                    char topValue = myStack.Pop();
                    if(validParen[topValue] != c) 
                    {
                        return false; 
                    }

                }
            }
            return myStack.Count == 0;
        }
    }
}
