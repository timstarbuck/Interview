using System;
using System.Diagnostics;

namespace Fibonacci
{
    static class Program
    {
        static void Main(string[] args)
        {
            int count = 15;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(fibonacci(i));
            }
            ResetWatch(sw);
            fibonacci2(count);
            ResetWatch(sw);
#if DEBUG
            Console.ReadLine();
#endif

        }

        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        private static void fibonacci2(int number)
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.WriteLine(n1);
            Console.WriteLine(n2); //printing 0 and 1    
            for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
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
