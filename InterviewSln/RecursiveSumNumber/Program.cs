using System;
using System.Diagnostics;

namespace RecursiveSumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursively calculate the sum of digits in a number 
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int num = 123;
            Console.Write(SumDigits(num));

#if DEBUG
            Console.ReadLine();
#endif
        }

        private static int SumDigits(int num, int position = 0)
        {
            var strNum = num.ToString();
            if (position >= strNum.Length)
            {
                return 0;
            }
            var thisDigit = strNum.Substring(position, 1);
            return  int.Parse(thisDigit) + SumDigits(num, position + 1);
        }

        private static void ResetWatch(Stopwatch sw)
        {
            sw.Stop();
            Console.WriteLine(" Elapsed {0} ticks", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
        }
    }
}
