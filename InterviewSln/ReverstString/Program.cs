﻿using System;
using System.Linq;

namespace ReverseString
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] aString = { "a", "b", "c", "d", "e" };
            Console.WriteLine(String.Join(", ", aString));

            Reverse1(aString);
            Console.WriteLine(String.Join(", ", aString));

            Reverse2(ref aString);
            Console.WriteLine(String.Join(", ", aString));

            Reverse3(aString);
            Console.WriteLine(String.Join(", ", aString));

            Console.WriteLine(Reverse4("abcdefg"));

            Console.WriteLine(Reverse5("abcdefg"));

#if DEBUG
            Console.ReadLine();
#endif

        }

        private static void Reverse1(string[] aString)
        {
            // this method does not use any temporary variables but will only work with single characters
            for (int i = 0; i < aString.Length / 2; i++)
            {
                aString[i] += aString[aString.Length - 1 - i];   // append last character to first string element
                aString[aString.Length - 1 - i] = "" + aString[i][0];  // replace last character with first string element
                aString[i] = "" + aString[i][1]; //make the first element the second character (was the last element)
            }
        }

        private static void Reverse2(ref string[] aString)
        {
            aString = (from a in aString orderby a select a).ToArray();
        }

        private static void Reverse3(string[] aString)
        {
            string temp;
            for (int i = 0; i < aString.Length/2; i++)
            {
                temp = aString[i];
                aString[i] = aString[aString.Length - i - 1];
                aString[aString.Length - i - 1] = temp;
            }
        }

        private static string Reverse4(string test)
        {
            if (test == null || test.Length <= 1)
            {
                return test;
            }
            return Reverse4(test.Substring(1)) + test[0];
        }

        public static string Reverse5(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }

}
