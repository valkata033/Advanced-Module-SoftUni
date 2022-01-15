using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>();

            int[] orders = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            foreach (var order in orders)
            {
                queue.Enqueue(order);
            }

            int maxOrder = 0;

            while (queue.Count > 0 && quantity > 0)
            {
                int currOrder = queue.Peek();

                if (currOrder > maxOrder)
                {
                    maxOrder = currOrder;
                }

                if (quantity - currOrder >= 0)
                {
                    quantity -= currOrder;
                    queue.Dequeue();
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(maxOrder);

            if (queue.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }

            else
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
