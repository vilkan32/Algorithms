using System;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 22, 9, 33, 21, 50, 41, 60 };
            int n = arr.Length;
          
            Console.Write("Length of lis is " + LIS.lis(arr, n)
                          + "\n");
        }
    }
}
