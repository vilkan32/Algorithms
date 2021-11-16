using System;

namespace BinarySearch
{
    class Program
    {

        static void Main(string[] args)
        {
            // for this search it is important to have the arr arranged in asc order
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            var bs = new Binary();

            int result = bs.binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);          
        }
    }
}
