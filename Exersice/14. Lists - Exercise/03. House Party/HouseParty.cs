using System;
using System.Collections.Generic;

namespace HouseParty
{
    class HouseParty
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> listOfGuest = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command.Length == 3)
                {
                    if (listOfGuest.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        listOfGuest.Add(command[0]);
                    }
                }
                else if (command.Length == 4)
                {
                    if (listOfGuest.Contains(command[0]))
                    {
                        listOfGuest.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
            }

            foreach (var guest in listOfGuest)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
