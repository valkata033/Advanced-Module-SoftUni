using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string command = Console.ReadLine();

                if (command == "Play")
                {
                    queue.Dequeue();
                }

                else if (command.StartsWith("Add"))
                {
                    string addedSong = command.Substring(4);

                    if (!queue.Contains(addedSong))
                    {
                        queue.Enqueue(addedSong);
                    }
                    else
                    {
                        Console.WriteLine($"{addedSong} is already contained!");
                    }

                }

                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", queue));
                    
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
