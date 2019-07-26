namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            Dictionary<string, int> junk = new Dictionary<string, int>();
            string name = string.Empty;

            while (true)
            {
                List<string> collection = Console.ReadLine()
                               .Split(" ")
                               .Select(x => x.ToLower())
                               .ToList();

                bool isTrue = false;

                for (int i = 1; i < collection.Count; i += 2)
                {
                    if (collection[i] == "shards" || collection[i] == "fragments" || collection[i] == "motes")
                    {
                        materials[collection[i]] += int.Parse(collection[i - 1]);
                                               
                        foreach (var item in materials)
                        {
                            if (item.Value >= 250)
                            {
                                name = item.Key;
                                isTrue = true;
                                break;
                            }
                        }

                        if (isTrue)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(collection[i]))
                        {
                            junk[collection[i]] += int.Parse(collection[i - 1]);
                        }
                        else
                        {
                            junk.Add(collection[i], int.Parse(collection[i - 1]));
                        }
                    }
                }

                if (isTrue)
                {
                    break;
                }
            }

            switch (name)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
            }

            materials[name] -= 250;

            materials.OrderByDescending(x => x.Value);


            foreach (var item in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
