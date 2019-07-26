using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class TheFinalQuest
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                 .Split()
                 .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "Stop")
                {
                    Console.WriteLine(string.Join(" ", collection));
                    break;
                }

                switch (command[0])
                {
                    case "Delete":
                        Delete(collection, int.Parse(command[1]));
                        break;
                    case "Swap":
                        Swap(collection, command[1], command[2]);
                        break;
                    case "Put":
                        Put(collection, command[1], int.Parse(command[2]));
                        break;
                    case "Sort":
                        Sort(collection);
                        break;
                    case "Replace":
                        Replase(collection, command[1], command[2]);
                        break;
                }
            }
        }

        private static void Delete(List<string> collection, int index)
        {
            if (index >= -1 && index < collection.Count - 1)
            {
                collection.RemoveAt(index + 1);
            }
        }

        private static void Swap(List<string> collection, string word1, string word2)
        {
            bool isWordOne = collection.Contains(word1);
            bool isWordTwo = collection.Contains(word2);

            if (isWordOne && isWordTwo)
            {
                int indexOne = collection.IndexOf(word1);
                int indexTwo = collection.IndexOf(word2);

                string temp = collection[indexOne];
                collection[indexOne] = collection[indexTwo];
                collection[indexTwo] = temp;
            }
        }

        private static void Put(List<string> collection, string word, int index)
        {
            if (index > 0 && index <= collection.Count + 1)
            {
                collection.Insert(index - 1, word);
            }
        }

        private static void Sort(List<string> collection)
        {
            collection.Sort();
            collection.Reverse();
        }

        private static void Replase(List<string> collection, string word1, string word2)
        {
            if (collection.Contains(word2))
            {
                int index = collection.IndexOf(word2);
                collection[index] = word1;
            }
        }
    }
}
