using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class CarRace
    {
        static void Main()
        {
            List<double> collectionOfNumbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            double leftSum = 0;
            double rightSum = 0;

            for (int i = 0; i < collectionOfNumbers.Count / 2; i++)
            {
                if (collectionOfNumbers[i] == 0)
                {
                    leftSum *= 0.80;
                }

                leftSum += collectionOfNumbers[i];
            }

            for (int i = collectionOfNumbers.Count - 1; i > collectionOfNumbers.Count /2; i--)
            {
                if (collectionOfNumbers[i] == 0)
                {
                    rightSum *= 0.80;
                }

                rightSum += collectionOfNumbers[i];
            }

            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
