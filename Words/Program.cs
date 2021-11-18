using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Words
{
   
    class Program
    {

        public static int counter = 0;

       
        static void Main(string[] args)
        {
            var str = Console.ReadLine().OrderBy(x => x).ToArray();
            int n = str.Length;

            bool noRepetition = IsValid(str);
            if (noRepetition)
            {
                int result = CalculateFactorial(str.Length);
                Console.WriteLine(result);
                return;
            }

            permute(str, 0, n - 1);
            Console.WriteLine(counter);
        }

        private static int CalculateFactorial(int count)
        {
            int factorial = 1;
            for (int i = 2; i <= count; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static void permute(char[] chars,
                               int start, int end)
        {

            bool match = true;
            char prev = ' ';
            foreach (var aChar in chars)
            {
                if (prev == aChar)
                {
                    match = false;
                    break;
                }
                prev = aChar;
            }
          

            if (match)
            {
                counter++;
            }

            if (start >= end)
            {
                return;
            }
            else
            {
                for (int left = end - 1; left >= start; left--)
                {
                    for (int right = left + 1; right <= end; right++)
                    {
                        if (chars[left] != chars[right])
                        {
                            char temp = chars[left];
                            chars[left] = chars[right];
                            chars[right] = temp;
                            permute(chars, left + 1, end);
                        }
                    }
                    char firstElement = chars[left];
                    Array.Copy(chars, left + 1, chars, left, end - left);
                    chars[end] = firstElement;
                }
            }
        }


        private static bool IsValid(char[] word)
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == word[i - 1])
                {
                    return false;
                }
            }
            
            return true;
        }
      
    }       

}

