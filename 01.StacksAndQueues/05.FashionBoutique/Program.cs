using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothesValue);

            int rack = 1;
            int sumClothes = 0;

            while (stack.Count > 0)
            {
                int currElement = stack.Pop();

                if (sumClothes + currElement <= capacityOfRack)     
                {
                    sumClothes += currElement;                  
                }

                else
                {
                    sumClothes = currElement;
                    rack++;
                }
            }

            Console.WriteLine(rack);
        }
    }
}
