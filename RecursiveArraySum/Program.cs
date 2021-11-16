using System;
using System.Linq;

namespace RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var index = input.Length - 1;

            Console.WriteLine(Recursion.ArrSum(input, index));
        }
    }

    static class Recursion
    {
        public static int ArrSum(int[] arr, int index)
        {

            if (index < 0)
            {
                return 0;
            }
            else
            {
                int currentIndexElement = arr[index];
               
                return currentIndexElement + ArrSum(arr, index - 1);
            }
           
            
        }
    }
}
