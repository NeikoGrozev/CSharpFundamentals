namespace Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                string[] command = input
                    .Split(" <:> ");

                string name = command[0];
                string color = command[1];
                int physics = int.Parse(command[2]);

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<string, int>());
                    dict[name].Add(color, physics);
                }
                else
                {
                    if (!dict[name].ContainsKey(color))
                    {
                        dict[name].Add(color, physics);
                    }
                    else
                    {
                        if (dict[name][color] < physics)
                        {
                            dict[name][color] = physics;
                        }
                    }
                }
            }
            
            foreach (var item in dict.OrderByDescending(x => x.Value.Values.First()).ThenByDescending(x => x.Value.Count()))
            {
                foreach (var dwarf in item)
                {
                    Console.WriteLine($"({dwarf.Key}) {item.Key} <-> {dwarf.Value}");
                }
            }
        }
    }
}
