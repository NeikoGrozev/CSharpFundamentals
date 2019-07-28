namespace OnTheWayToAnnapurna
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] token = input
                    .Split("->");

                string command = token[0];
                string store = token[1];


                if (command == "Add")
                {
                    if (!dict.ContainsKey(store))
                    {
                        dict.Add(store, new List<string>());
                    }

                    string[] item = token[2]
                        .Split(",");

                    for (int i = 0; i < item.Length; i++)
                    {
                        dict[store].Add(item[i]);
                    }
                }
                else if (command == "Remove")
                {
                    if (dict.ContainsKey(store))
                    {
                        dict.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");

            foreach (var store in dict.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{store.Key}");

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
