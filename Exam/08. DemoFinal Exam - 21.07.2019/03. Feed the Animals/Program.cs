namespace FeedTheAnimals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, int> animals = new Dictionary<string, int>();
            Dictionary<string, int> areas = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Last Info")
                {
                    break;
                }

                string[] token = input
                    .Split(":");

                string command = token[0];
                string name = token[1];
                string area = token[3];

                if (command == "Add")
                {
                    int dailyFoodLimit = int.Parse(token[2]);

                    if (!animals.ContainsKey(name))
                    {
                        animals.Add(name, 0);

                        if (!areas.ContainsKey(area))
                        {
                            areas.Add(area, 0);
                        }

                        areas[area]++;
                    }

                    animals[name] += dailyFoodLimit;
                }
                else if (command == "Feed")
                {
                    int food = int.Parse(token[2]);

                    if (animals.ContainsKey(name) && areas.ContainsKey(area))
                    {
                        animals[name] -= food;

                        if (animals[name] <= 0)
                        {
                            Console.WriteLine($"{name} was successfully fed");
                            animals.Remove(name);
                            areas[area]--;
                        }
                    }
                }
            }

            Console.WriteLine("Animals:");

            foreach (var animal in animals.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");

            foreach (var area in areas.OrderByDescending(x => x.Value))
            {
                if (area.Value > 0)
                {
                    Console.WriteLine($"{area.Key} : {area.Value}");
                }
            }
        }
    }
}
