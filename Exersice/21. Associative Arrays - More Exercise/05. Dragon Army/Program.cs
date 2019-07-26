namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, Dragon>> dict = new Dictionary<string, Dictionary<string, Dragon>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ");

                string type = command[0];
                string name = command[1];
                int demage = command[2] == "null" ? 45 : int.Parse(command[2]);
                int health = command[3] =="null" ? 250 : int.Parse(command[3]);
                int armor = command[4] == "null" ? 10 : int.Parse(command[4]);
                Dragon dragon = new Dragon() { Demage = demage, Health = health, Armor = armor };

                if (!dict.ContainsKey(type))
                {
                    dict.Add(type, new Dictionary<string, Dragon>());
                    dict[type].Add(name, dragon);
                }
                else
                {
                    if (!dict[type].ContainsKey(name))
                    {
                        dict[type].Add(name, dragon);
                    }
                    else
                    {
                        dict[type][name] = dragon;
                    }
                }                
            }

            foreach (var type in dict)
            {
                double demageAverage = type.Value.Select(x => x.Value.Demage).Average();
                double healthAverage = type.Value.Select(x => x.Value.Health).Average();
                double armorAverage = type.Value.Select(x => x.Value.Armor).Average();

                Console.WriteLine($"{type.Key}::({demageAverage:F2}/{healthAverage:F2}/{armorAverage:F2})");

                foreach (var name in type.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value.Demage}, " +
                        $"health: {name.Value.Health}, armor: {name.Value.Armor}");
                }
            }
        }
    }

    class Dragon
    {
        public int Demage { get; set; } 
        public int Health { get; set; } 
        public int Armor { get; set; } 
    }
}
