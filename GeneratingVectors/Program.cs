using System;
using System.Linq;

namespace GeneratingVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var vector = new int[input];

            Vector.Generate(vector, 0);
        }
    }

    public static class Vector
    {
        public static void Generate(int[] vector, int index)
        {
            if(index > vector.Length - 1)
            {
                Console.WriteLine(string.Join("", vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Generate(vector, index + 1);
                
            }
        }
    }
}
