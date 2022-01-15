using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueuesExercise
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

            Stack<int> stack = new Stack<int>();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < pops; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(contains))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);

                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }

        }
    }
}
