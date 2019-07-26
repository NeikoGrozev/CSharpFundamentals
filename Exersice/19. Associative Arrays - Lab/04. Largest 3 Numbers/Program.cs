namespace Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> collection = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int num = 0;

            if (collection.Count >= 3)
            {
                num = 3;
            }
            else
            {
                num = collection.Count;
            }

            collection = collection.OrderByDescending(x => x).ToList();

            for (int i = 0; i < num; i++)
            {
                Console.Write($"{collection[i]} ");
            }
        }
    }
}
