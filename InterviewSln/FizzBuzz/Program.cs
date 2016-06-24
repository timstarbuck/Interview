using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var index = 1; index <= 100; index++)
            {
                var isThree = (index % 3) == 0;
                var isFive = (index % 5) == 0;
                if ((isThree) && (isFive))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (isFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(index);
                }
            }

#if DEBUG
            Console.ReadLine();
#endif

        }
    }
}
