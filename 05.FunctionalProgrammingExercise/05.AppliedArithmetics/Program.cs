using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }

                return numbers;
            };

            Func<int[], int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }

                return numbers;
            };

            Func<int[], int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };

            Action<int[]> printNumbers = numbers => 
            Console.WriteLine(String.Join(" ", numbers));

            int[] inputNumbers = 
                Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    add(inputNumbers);
                }

                else if (command == "multiply")
                {
                    multiply(inputNumbers);
                }

                else if (command == "subtract")
                {
                    subtract(inputNumbers);
                }

                else if (command == "print")
                {
                    printNumbers(inputNumbers);
                }

                command = Console.ReadLine();
            }


        }
    }
}
