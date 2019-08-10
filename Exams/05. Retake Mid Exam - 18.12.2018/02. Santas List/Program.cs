using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santas_List
{
    class Program
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split("&")
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command[0] == "Finished!")
                {
                    Console.WriteLine(string.Join(", ", collection));
                    break;
                }

                switch (command[0])
                {
                    case "Bad":
                        Bad(collection, command[1]);
                        break;
                    case "Good":
                        Good(collection, command[1]);
                        break;
                    case "Rename":
                        Rename(collection, command[1], command[2]);
                        break;
                    case "Rearrange":
                        Rearrange(collection, command[1]);
                        break;
                }
            }
        }               

        private static void Bad(List<string> collection, string name)
        {
            if (!collection.Contains(name))
            {
                collection.Insert(0, name);
            }
        }

        private static void Good(List<string> collection, string name)
        {
            if (collection.Contains(name))
            {
                int index = collection.IndexOf(name);
                collection.RemoveAt(index);
            }
        }

        private static void Rename(List<string> collection, string oldName, string newName)
        {
            if (collection.Contains(oldName))
            {
                int index = collection.IndexOf(oldName);
                collection[index] = newName;
            }
        }

        private static void Rearrange(List<string> collection, string name)
        {
            if (collection.Contains(name))
            {
                int index = collection.IndexOf(name);
                string temp = collection[index];
                collection.RemoveAt(index);
                collection.Add(temp);
            }
        }
    }
}
