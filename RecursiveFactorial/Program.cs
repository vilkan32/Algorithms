using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact.CalcFact(int.Parse(Console.ReadLine())));
        }
    }

    public static class Fact
    {
        public static int CalcFact(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return n * CalcFact(n - 1);
            }
        }
    }
}
