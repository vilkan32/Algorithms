using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationsWithRepetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            var setLength = int.Parse(Console.ReadLine());

            var sequence = int.Parse(Console.ReadLine());

            var set = new int[setLength];

            GenerateCombinations(set, new int[sequence], setLength, 0, sequence);


        }


        public static void GenerateCombinations(int[] set,int[] sequenceOfElements, int setLength, int index, int sequence, int forLoopStart = 1)
        {

            if (index == sequence)
            {               
                   
                    Console.WriteLine(string.Join(" ", sequenceOfElements));
                    return;             
            }

            for (int i = forLoopStart; i <= setLength; i++)
            {
                sequenceOfElements[index] = i;

                GenerateCombinations(set, sequenceOfElements, setLength, index + 1, sequence, i);

            }

        }
    }
}
