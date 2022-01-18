using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] divNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int[] allNumbers = Enumerable.Range(1, n).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var number in divNumbers)
            {
                predicates.Add(x => x % number == 0);
            }

            foreach (var currNum in allNumbers)
            {
                bool isDiv = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(currNum))
                    {
                        isDiv = false;
                        break;
                    }
                }

                if (isDiv)
                {
                    Console.Write(currNum + " ");
                }
            }

        }
    }
}
