using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandInfo = command.Split();

                Predicate<string> predicate = 
                    GetPredicate(commandInfo[1], commandInfo[2]);

                if (commandInfo[0] == "Remove")
                {
                    names.RemoveAll(predicate);
                }

                else if (commandInfo[0] == "Double")
                {
                    List<string> doubledNames = names.FindAll(predicate);

                    if (doubledNames.Any())
                    {
                        int index = names.FindIndex(predicate);
                        names.InsertRange(index, doubledNames);
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }

            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static Predicate<string> GetPredicate(string commandInfo, string param)
        {
            if (commandInfo == "StartstWith")
            {
                return x => x.StartsWith(param);
            }

            if (commandInfo == "EndsWith")
            {
                return x => x.EndsWith(param);
            }

            int length = int.Parse(param);
            return x => x.Length == length;
        }
    }
}
