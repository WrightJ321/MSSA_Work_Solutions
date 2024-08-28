using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_WrightJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] twoDMatrix =
            {
                new int [] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };
            RotateMatrix(twoDMatrix);
            PrintMatrix(twoDMatrix);


        }

        static void RotateMatrix(int[][] matrix)
        {
            int length = matrix.Length;
            for (int i = 0; i < length; i++)// i acts as the placeholder count , so first array would be 0 then 1 and 2 ,since there are 3 arrays within the jagged array(twoDMatrix)
            {
                for (int j = i; j < length ; j++)//j acts as the counter for the index of each  value within each of the 3 arrays
                {
                    int temp = matrix[i][j];// temp holds the actual element of each of the arrays data
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < length; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }
        public static void PrintMatrix(int[][] matrix)
        {
            int length = matrix.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
