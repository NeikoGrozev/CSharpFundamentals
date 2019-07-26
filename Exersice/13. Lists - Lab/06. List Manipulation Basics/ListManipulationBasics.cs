using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class ListManipulationBasics
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = new string[3];
                command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", colection));
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        colection.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        colection.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        colection.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        colection.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
            }
        }
    }
}
