using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1_WrightJ
{
    internal class Program
    {
        static void SortExamScores(int[] scores)
        {
            int minScore = 0;
            int temp = 0;
            for (int i = 0; i < scores.Length - 1; i++)
            {
                minScore = i;
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minScore])//checks if j is smaller than a mininum score in array if so assigns that value to minscore
                    {
                        minScore = j;
                    }

                }
                if (minScore != i)
                {
                    temp = scores[i];
                    scores[i] = scores[minScore];
                    scores[minScore] = temp;
                }
            }
        }
        static string MergeString(string wordOne, string wordTwo)
        {
            int word1length = wordOne.Length;
            int word2length = wordTwo.Length;
            int maxlength = Math.Max(word2length, word1length);
            char[] wordMerge = new char[word1length + word2length];
            int index = 0;
            

            for (int i = 0; i < maxlength; i++)
            {
                if (i < word1length)
                {
                    wordMerge[index++] = wordOne[i];

                }
                if (i < word2length)
                {
                    wordMerge[index++] = wordTwo[i];
                }
            }
             return new string(wordMerge, 0, index);// this is an instacne of the string class that returns in this case a char array with a specified location
                  // and length since index is being incremented along the char array

        }

        static void Main(string[] args)
        {
            //7.1 assignment
            int[] examScores = { 77, 88, 85, 98, 100, 72, 84, 95 };
            SortExamScores(examScores);
            
            foreach (int score in examScores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine("end 7.1");
            Console.WriteLine();
            Console.WriteLine("Start 7.1.2");
            //7.1.2 assignment
            //example 1
            string wordOne = "abc";
            string wordTwo = "pqr";
            string result = MergeString(wordOne, wordTwo);
            Console.WriteLine(result);
            //
            //example 2
            string word1 = "ab";
            string word2 = "pqrs";
            string result2 = MergeString(word1, word2);
            Console.WriteLine(result2);
            //

            Console.ReadKey();
        }
    }
}
