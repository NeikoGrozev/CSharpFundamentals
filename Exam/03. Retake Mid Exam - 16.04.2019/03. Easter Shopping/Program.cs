using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        private const int V = 2;

        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split()
                .ToList();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split();

                switch (commands[0])
                {
                    case "Include":
                        Include(collection, commands[1]);
                        break;
                    case "Visit":
                        Visit(collection, commands[1], int.Parse(commands[2]));
                        break;
                    case "Prefer":
                        Prefer(collection, int.Parse(commands[1]), int.Parse(commands[2]));
                        break;
                    case "Place":
                        Place(collection, commands[1], int.Parse(commands[2]));
                        break;
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", collection));
        }        

        private static void Include(List<string> collection, string shop)
        {
            collection.Add(shop);
        }

        private static void Visit(List<string> collection, string firstOrLast, int numberOfShop)
        {
            if (collection.Count >= numberOfShop)
            {
                if (firstOrLast == "first")
                {
                    collection.RemoveRange(0, numberOfShop);
                }
                else if (firstOrLast == "last")
                {
                    collection.RemoveRange(collection.Count - numberOfShop, numberOfShop);
                }
            }            
        }

        private static void Prefer(List<string> collection, int indexOne, int indexTwo)
        {
            bool isHaveIndexOne = collection.Count - 1 >= indexOne;
            bool isHaveIndexTwo = collection.Count - 1 >= indexTwo;

            if (isHaveIndexOne && isHaveIndexTwo)
            {
                string temp = collection[indexOne];
                collection[indexOne] = collection[indexTwo];
                collection[indexTwo] = temp;
            }
        }

        private static void Place(List<string> collection, string shop, int index)
        {
            if (collection.Count - 2 >= index)
            {
                collection.Insert(index + 1, shop);
            }
        }
    }
}
