using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (name, length) => name.Length <= length;

            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split()
                .Where(x => func(x, length))
                .ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
