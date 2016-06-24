using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("4! = {0}", ComputeFactorial(4));
                ResetWatch(sw);
                Console.Write("4! = {0} (loop)", ComputeFactorialLoop(4));
                ResetWatch(sw);
                Console.Write("100! = {0}", ComputeFactorial(100));
                ResetWatch(sw);
                Console.Write("100! = {0} (loop)", ComputeFactorialLoop(100));
                ResetWatch(sw);
                Console.WriteLine();
            }
#if DEBUG
            Console.ReadLine();
#endif

        }

        static double ComputeFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            } else
            {
                return n * ComputeFactorial(n - 1);
            }
        }

        static double ComputeFactorialLoop(int n)
        {
            double answer = 1;
            while (n > 1)
            {
                answer = n * answer;
                n--;
            }
            return answer;
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
