using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();

            int[] arr = new int[] { 1, 4, 5, 9, 12, 15, 24, 99, 456, 500 };
            Console.WriteLine(String.Join(",", arr));
            Console.WriteLine("Loop");
            sw.Start();
            Console.Write("Index of 9 = {0} ", FindArrayIndex(arr, 9));
            ResetWatch(sw);
            Console.Write("Index of 15 = {0} ", FindArrayIndex(arr, 15));
            ResetWatch(sw);
            Console.WriteLine("Recursive");
            Console.Write("Index of 9 = {0} ", binarySearch(arr, 0, arr.Length, 9));
            ResetWatch(sw);
            Console.Write("Index of 15 = {0} ", binarySearch(arr, 0, arr.Length, 15));
            ResetWatch(sw);

            #if DEBUG
            Console.ReadLine();
            #endif

        }


        private static void ResetWatch(Stopwatch sw)
        {
            sw.Stop();
            Console.WriteLine(" Elapsed {0} ticks", sw.ElapsedTicks);
            sw.Reset();
            sw.Start();
        }

        private static int binarySearch(int[] array, int left, int right, int key)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;

            if (array[mid] == key)
            {
                return mid;
            }

            if (array[mid] > key)
            {
                return binarySearch(array, left, mid - 1, key);
            }

            return binarySearch(array, mid + 1, right, key);
        }


        private static int FindArrayIndex(int[] arr, int valueToFind)
        {
            int min = 0;
            int high = arr.Length - 1;
            int mid;

            while (min <= high)
            {
                mid = min + (int)Math.Floor((high - min) / 2.0);

                if (valueToFind < arr[mid])
                {
                    high = mid - 1;
                }
                else if (valueToFind > arr[mid])
                {
                    min = mid + 1;
                } else 
                {
                    return mid;
                }

            }
            return -1; // not found
        }

    }
}
