namespace OddOccurrences
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
                .Select(x => x.ToLower())
                .ToList();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in collection)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
