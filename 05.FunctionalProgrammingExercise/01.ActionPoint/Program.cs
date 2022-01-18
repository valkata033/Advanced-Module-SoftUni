using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printCollection = input =>
                Console.WriteLine(String.Join(Environment.NewLine, input));

            string[] input = Console.ReadLine().Split();

            printCollection(input);

        }
    }
}
