using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;

            List<int> numbers = new List<int>();

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = range[0]; i <= range[1]; i++)
            {
                numbers.Add(i);
            }

            string evenOdd = Console.ReadLine();

            if (evenOdd == "even")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => isEven(x))));
            }

            else if (evenOdd == "odd")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(x => !isEven(x))));
            }
        }
    }
}
