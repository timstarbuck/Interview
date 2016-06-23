using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aString = { "a", "b", "c", "d", "e" };
            Console.WriteLine(String.Join(", ", aString));

            for (int i = 0; i < aString.Length / 2; i++)
            {
                aString[i] += aString[aString.Length - 1 - i];   // append last character to first string element
                aString[aString.Length - 1 - i] = "" + aString[i][0];  // replace last character with first string element
                aString[i] = "" + aString[i][1]; //make the first element the second character (was the last element)
            }

            Console.WriteLine(String.Join(", ", aString));

            #if DEBUG
            Console.ReadLine();
            #endif

        }
    }
}
