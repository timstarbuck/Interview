using System;
using System.Diagnostics;
using System.Linq;

namespace MiscQuestions
{
    static class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Even sum: {0}", numbers.Where(n => n % 2 == 0).Sum());
            ResetWatch(sw);

            var one = "this is really fun";
            var two = "that could be really fun";
            Console.WriteLine("Find last matching chars of '{0}' and '{1}' = '{2}'", one, two, matchLastSection(one, two));
            one = "this is really funzy";
            two = "that could be really fun";
            Console.WriteLine("Find last matching chars of '{0}' and '{1}' = '{2}'", one, two, matchLastSection(one, two));
            ResetWatch(sw);


#if DEBUG
            Console.ReadLine();
#endif

        }

        private static string matchLastSection(string one, string two)
        {
            var found = "";
            for(var i = one.Length -1; i > -1; i--)
            {
                if (two.EndsWith(one.Substring(i), StringComparison.InvariantCultureIgnoreCase))
                {
                    found = one.Substring(i);
                }
            }

            return found;
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
