using System;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure.Draw(int.Parse(Console.ReadLine()));
        }
    }

    public static class Figure
    {
        public static void Draw(int n)
        {

            if(n <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));
            Draw(n - 1);
            Console.WriteLine(new string('#', n));

        }
    }
}
