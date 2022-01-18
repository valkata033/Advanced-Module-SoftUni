using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = 
                Console.ReadLine().Split().Select(int.Parse).ToArray();

            int division = int.Parse(Console.ReadLine());

            Func<int, int, bool> isDivisible = (n, m) => n % m == 0;

            int[] result = input.Where(x => !isDivisible(x, division))
                .Reverse()
                .ToArray();


            Console.WriteLine(String.Join(" ", result));
        }
    }
}
