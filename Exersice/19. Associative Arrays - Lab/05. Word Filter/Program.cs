namespace WordFilter
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

            List<string> newCollection = collection.Where(x => x.Length % 2 == 0).ToList();

            foreach (var item in newCollection)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
