using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class SeizeTheFire
    {
        static void Main()
        {
            string[] fireCollections = Console.ReadLine()
                .Split(new char[] { '=', '#', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int water = int.Parse(Console.ReadLine());
            List<int> fires = new List<int>();

            for (int i = 0; i < fireCollections.Length; i += 2)
            {
                int currentFire = int.Parse(fireCollections[i + 1]);

                if (fireCollections[i] == "Low" && currentFire >= 1 && currentFire <= 50)
                {
                    if (water >= currentFire)
                    {
                        fires.Add(currentFire);
                        water -= currentFire;
                    }
                }
                else if (fireCollections[i] == "Medium" && currentFire >= 51 && currentFire <= 80)
                {
                    if (water >= currentFire)
                    {
                        fires.Add(currentFire);
                        water -= currentFire;

                    }
                }
                else if (fireCollections[i] == "High" && currentFire >= 81 && currentFire <= 125)
                {
                    if (water >= currentFire)
                    {
                        fires.Add(currentFire);
                        water -= currentFire;

                    }
                }
            }

            int totalFire = fires.Sum();
            double effort = totalFire * 0.25;

            Console.WriteLine("Cells:");

            for (int i = 0; i < fires.Count; i++)
            {
                Console.WriteLine($"- {fires[i]}");
            }

            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
