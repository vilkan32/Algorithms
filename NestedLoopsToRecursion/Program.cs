using System;
using System.Collections.Generic;

namespace NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sequence = new int[n];

            PrintSequence(n, sequence, 0);
        }


        public static void PrintSequence(int n, int[] sequence, int index)
        {

            if(index == n)
            {
                Console.WriteLine(string.Join(" ", sequence));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                sequence[index] = i;

                PrintSequence(n, sequence, index + 1);

            }

        }

    }
}
