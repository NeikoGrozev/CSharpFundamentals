using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            List<double> lineOfNumber = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < lineOfNumber.Count - 1; i++)
            {
                if (lineOfNumber[i] == lineOfNumber[i + 1])
                {
                    lineOfNumber[i] += lineOfNumber[i + 1];

                    lineOfNumber.RemoveAt(i + 1);
                    i = -1;
                }                
            }
            
            Console.WriteLine(string.Join(" ", lineOfNumber));
        }
    }
}
