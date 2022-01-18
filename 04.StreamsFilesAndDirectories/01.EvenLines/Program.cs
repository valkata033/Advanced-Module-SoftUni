using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] wordLines = File.ReadAllLines("words.txt");
            string[] textLines = File.ReadAllLines("text.txt");

            foreach (var item in wordLines)
            {
                if (!wordsCount.ContainsKey(item))
                {
                    wordsCount.Add(item, 0);
                }

            }

            foreach (var line in textLines)
            {
                //I was quick to ...

                foreach (var item in wordsCount)
                {
                    if (line.Contains(item.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordsCount[item.Key]++;
                    }
                }
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
                File.AppendAllText("actualResult.txt", result);
            }
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i]
                    .Count(symbol => char.IsLetter(symbol));

                int punctuationCount = lines[i]
                    .Count(symbol => char.IsPunctuation(symbol));

                File.AppendAllText(@"..\..\..\output.txt", $"Line {i + 1}: {lines[i]} ({lettersCount}) ({punctuationCount}){Environment.NewLine}");
            }
        }

        private static void EvenLines()
        {
            StreamReader streamReader = new StreamReader("text.txt");
            string[] symbols = new[] { "-", ",", ".", "!", "?" };

            bool isEven = true;

            while (true)
            {
                string result = streamReader.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (!isEven)
                {
                    isEven = true;
                    continue;
                }

                foreach (var symbol in symbols)
                {
                    result = result.Replace(symbol, "@");
                }

                Console.WriteLine(String.Join(" ", result.Split().Reverse()));

                isEven = false;
            }
        }
    }
}
