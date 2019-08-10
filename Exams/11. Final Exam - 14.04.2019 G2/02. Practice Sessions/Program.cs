namespace PracticeSessions
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

                List<string> token = input
                    .Split("->")
                    .ToList();

                string command = token[0];

                if (command == "Add")
                {
                    string road = token[1];
                    string racer = token[2];

                    if (!dict.ContainsKey(road))
                    {
                        dict.Add(road, new List<string>());
                    }

                    dict[road].Add(racer);
                }
                else if (command == "Move")
                {
                    string currentRoad = token[1];
                    string racer = token[2];
                    string nextRoad = token[3];

                    if (dict[currentRoad].Contains(racer))
                    {
                        dict[currentRoad].Remove(racer);
                        dict[nextRoad].Add(racer);
                    }
                }
                else if (command == "Close")
                {
                    string road = token[1];

                    dict.Remove(road);
                }
            }

            Console.WriteLine("Practice sessions:");

            foreach (var road in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{road.Key}");

                foreach (var racer in road.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}
