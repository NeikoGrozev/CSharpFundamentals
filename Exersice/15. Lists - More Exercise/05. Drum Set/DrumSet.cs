using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class DrumSet
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            if (budget < 0)
            {
                budget = 0.00;
            }

            if (budget > 10000)
            {
                budget = 10000.00;
            }
            List<int> drums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < drums.Count; i++)
            {
                if (drums[i] < 1)
                {
                    drums[i] = 1;
                }

                if (drums[i] > 1000)
                {
                    drums[i] = 1000;
                }
            }

            List<int> tempDrums = new List<int>();

            tempDrums.AddRange(drums);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Hit it again, Gabsy!")
                {
                    Console.WriteLine(string.Join(" ", tempDrums));
                    Console.WriteLine($"Gabsy has {budget:F2}lv.");
                    break;
                }

                int num = int.Parse(command);

                if (num < 0)
                {
                    num = 0;
                }

                if (num > 1000)
                {
                    num = 1000;
                }

                for (int i = 0; i < tempDrums.Count; i++)
                {
                    if (tempDrums[i] > num)
                    {
                        tempDrums[i] -= num;
                    }
                    else
                    {
                        if (budget >= drums[i] * 3)
                        {
                            tempDrums[i] = drums[i];
                            budget -= drums[i] * 3;
                        }
                        else
                        {
                            tempDrums.RemoveAt(i);
                            drums.RemoveAt(i);
                            i--;
                        }
                    }                    
                }
            }
        }
    }
}
