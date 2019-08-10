using System;
using System.Collections.Generic;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main()
        {
            List<int> houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            int lastPosition = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Merry Xmas!")
                {
                    break;
                }

                string[] token = command.Split(" ");

                if (token[0] == "Jump")
                {
                    int length = int.Parse(token[1]);                    

                    if (lastPosition + length <= houses.Count - 1)
                    {
                        if (houses[lastPosition + length] != 0)
                        {
                            houses[lastPosition + length] -= 2;
                            lastPosition = lastPosition + length;
                        }
                        else
                        {
                            lastPosition = lastPosition + length;
                            Console.WriteLine($"House {lastPosition} will have a Merry Christmas.");
                        }
                    }
                    else if (lastPosition + length > houses.Count - 1)
                    {
                        int index = (lastPosition + length) % houses.Count;

                        if (houses[index] != 0)
                        {
                            houses[index] -= 2;
                            lastPosition = index;
                        }
                        else
                        {
                            lastPosition = index;
                            Console.WriteLine($"House {lastPosition} will have a Merry Christmas.");
                        }
                    }               
                     
                }
            }

            Console.WriteLine($"Santa's last position was {lastPosition}.");

            int count = 0;

            foreach (var house in houses)
            {
                if (house == 0)
                {
                    count++;
                }
            }

            if (count == houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {houses.Count - count} houses.");
            }
        }
    }
}
