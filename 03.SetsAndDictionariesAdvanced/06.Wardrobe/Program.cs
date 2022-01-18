using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] inputArgs = input[1].Split(",");

                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in inputArgs)
                {
                    if (!dict[color].ContainsKey(item))
                    {
                        dict[color].Add(item, 0);
                    }

                    dict[color][item]++;
                }
            }

            string[] targetClothe = Console.ReadLine().Split();

            foreach (var color in dict)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var (clothe, value) in color.Value)
                {
                    if (clothe == targetClothe[1] && color.Key == targetClothe[0])
                    {
                        Console.WriteLine($"* {clothe} - {value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {value}");
                    }
                }
            }

        }
    }
}
