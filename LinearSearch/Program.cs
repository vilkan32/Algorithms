using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40, 1230, 123, 44, 12355, 12, 12300, 42123, 543453, 1235434,540, 120 };
            int length = arr.Length - 1;
            int x = 4;
            var linear = new Linear();

            // Function call
            int result = linear.linearSearch(arr, x, length);
            if (result == -1)
                Console.WriteLine(
                    "Element is not present in array");
            else
                Console.WriteLine("Element is present at index "
                                  + result);
        }
    }
}
