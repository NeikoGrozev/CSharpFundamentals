namespace ContactList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                 .Split(" ")
                 .ToList();                       

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();                              

                switch (command[0])
                {
                    case "Add":
                        Add(collection, command[1], int.Parse(command[2]));
                        break;
                    case "Remove":
                        Remove(collection, int.Parse(command[1]));
                        break;
                    case "Export":
                        Export(collection, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                    case "Print":
                        Print(collection, command[1]);
                        return;
                }
            }
        }       

        private static void Add(List<string> collection, string contact, int index)
        {
            if (!collection.Contains(contact))
            {
                collection.Add(contact);
            }
            else
            {
                if (index >= 0 && index < collection.Count)
                {
                    collection.Insert(index, contact);
                }
            }
        }

        private static void Remove(List<string> collection, int index)
        {
            if (index >= 0 && index < collection.Count)
            {
                collection.RemoveAt(index);
            }
        }

        private static void Export(List<string> collection, int startIndex, int count)
        {
            int endIndex = -1;

            if (startIndex + count > collection.Count)
            {
                endIndex = collection.Count;
            }
            else
            {
                endIndex = startIndex + count;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                Console.Write($"{collection[i]} ");
            }

            Console.WriteLine();
        }

        private static void Print(List<string> collection, string normalOrReversed)
        {
            Console.Write("Contacts: ");
            if (normalOrReversed == "Normal")
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    Console.Write($"{collection[i]} ");
                }

                Console.WriteLine();
            }
            else if (normalOrReversed == "Reversed")
            {
                collection.Reverse();

                for (int i = 0; i < collection.Count; i++)
                {
                    Console.Write($"{collection[i]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
