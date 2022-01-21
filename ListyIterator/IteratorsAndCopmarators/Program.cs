using System;
using System.Linq;

namespace IteratorsAndCopmarators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListyIterator<string> listy = null;

            string command = Console.ReadLine();

            while (command != "END")
            {
                var input = command.Split();

                if (input[0] == "Create")
                {
                    listy = new ListyIterator<string>(input.Skip(1).ToArray());
                }

                else if (input[0] == "HasNext")
                {
                    Console.WriteLine(listy.HasNext());
                }

                else if (input[0] == "Move")
                {
                    Console.WriteLine(listy.Move());
                }

                else if (input[0] == "Print")
                {
                    listy.Print();
                }

                else if (input[0] == "PrintAll")
                {
                    listy.PrintAll();
                }

                command = Console.ReadLine();
            }
        }
    }
}
