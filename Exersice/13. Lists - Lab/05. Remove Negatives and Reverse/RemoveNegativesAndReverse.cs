using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {


        static void Main()
        {
            List<int> positiveNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < positiveNumbers.Count; i++)
            {
                int counter = 0;

                if (positiveNumbers[i] <= 0)
                {
                    positiveNumbers.RemoveAt(i);
                    i -= 1;
                    counter++;

                    if (counter == positiveNumbers.Count)
                    {
                        Console.WriteLine("empty");
                        return;
                    }
                }
            }

            positiveNumbers.Reverse();

            Console.WriteLine(string.Join(" ", positiveNumbers));
        }
    }
}
