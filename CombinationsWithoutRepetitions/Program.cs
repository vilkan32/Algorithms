using System;

namespace CombinationsWithoutRepetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var k = int.Parse(Console.ReadLine());

            var set = new int[n];

            var sequence = new int[k];

            Generate(set, sequence, 0, 1);

        }

        public static void Generate(int[] set, int[] seq, int index, int loopStart)
        {

            if (index == seq.Length)
            {

                Console.WriteLine(string.Join(" ", seq));
                return;
            }

            for (int i = loopStart; i <= set.Length; i++)
            {
                seq[index] = i;

                Generate(set, seq, index + 1, i + 1);

            }

        }

    }
}
