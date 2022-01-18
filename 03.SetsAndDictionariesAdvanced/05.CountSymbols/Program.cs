using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in chars)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }

                dict[item]++;
            }

            foreach (var (key, value) in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{key}: {value} time/s");
            }
        }
    }
}
