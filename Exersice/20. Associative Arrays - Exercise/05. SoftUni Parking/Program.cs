namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] cheked = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (cheked[0] == "register")
                {
                    string name = cheked[1];
                    string regNumber = cheked[2];

                    if (!parking.ContainsKey(name))
                    {
                        parking.Add(name, regNumber);
                        Console.WriteLine($"{name} registered {regNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {regNumber}");
                    }
                }
                else if (cheked[0] == "unregister")
                {
                    string name = cheked[1];

                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parking.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }

            foreach (var driver in parking)
            {
                Console.WriteLine($"{driver.Key} => {driver.Value}");
            }
        }
    }
}
