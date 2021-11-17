using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = new List<int>();
            Reverse(arr, arr.Count - 1, ref result);
           

            Console.WriteLine(string.Join(" ", result));
        }


        public static void Reverse(List<int> arr, int index, ref List<int> set)
        {

            if(index < 0)
            {
                return;
            }

            set.Add(arr[index]);

            Reverse(arr, index - 1,ref set);
            

        }
    }
}
