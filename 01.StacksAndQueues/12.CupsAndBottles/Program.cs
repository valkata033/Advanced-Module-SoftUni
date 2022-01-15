using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedLiters = 0;
            int currCup = 0;
            bool isNewOne = true;

            while (cups.Any() && bottles.Any())
            {
                if (isNewOne)
                {
                    currCup = cups.Peek();
                    isNewOne = false;
                }

                int currBottle = bottles.Pop();

                if (currCup - currBottle <= 0)
                {
                    wastedLiters += currCup - currBottle;
                    cups.Dequeue();
                    isNewOne = true;
                }

                else
                {
                    currCup -= currBottle;
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
            }

            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLiters * -1}");
        }
    }
}
