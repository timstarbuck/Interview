using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers up to 1000");
            for (int i = 1; i <= 1000; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }

            #if DEBUG
            Console.ReadLine();
            #endif
        }


        public static bool isPrime(int number)
        {
            int boundary = (int)Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

    }
}
