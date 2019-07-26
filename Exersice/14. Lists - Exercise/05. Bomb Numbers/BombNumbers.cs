using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main()
        {
            List<int> colection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < colection.Count; i++)
            {
                if (colection[i] == command[0])
                {
                    int firstIndex = i - command[1];

                    if (firstIndex < 0)
                    {
                        firstIndex = 0;
                    }

                    int endIndex = i + command[1];

                    if (endIndex >= colection.Count)
                    {
                        endIndex = colection.Count - 1;
                    }

                    for (int j = firstIndex; j <= endIndex; j++)
                    {
                        colection[j] = 0;
                    }
                }
            }

            int sum = 0;
            for (int i = 0; i < colection.Count; i++)
            {
                sum += colection[i];
            }

            Console.WriteLine(sum);
        }
    }
}
