using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int pushes = input[0];
            int pops = input[1];
            int contains = input[2];

            Queue<int> queue = new Queue<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < pops; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(contains))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);

                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }

        }
    }
}
