using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputIntegers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputIntegers[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                
                if (action == "swap")
                {
                    int firstRow = int.Parse(commandArgs[1]);
                    int firstCol = int.Parse(commandArgs[2]);
                    int secondRow = int.Parse(commandArgs[3]);
                    int secondCol = int.Parse(commandArgs[4]);

                    if (firstRow >= 0 && firstRow < matrix.GetLength(0) &&
                        firstCol >= 0 && firstCol < matrix.GetLength(1) &&
                        secondRow >= 0 && secondRow < matrix.GetLength(0) &&
                        secondCol >= 0 && secondCol < matrix.GetLength(1))
                    {
                        int firstMatrixRow = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = firstMatrixRow;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


                command = Console.ReadLine();
            }

        }
    }
}
