using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class GaussTrick
    {
        static void Main()
        {
            List<int> lineOfNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < lineOfNumber.Count / 2; i++)
            {
                lineOfNumber[i] += lineOfNumber[lineOfNumber.Count - 1 - i];                
            }

            if (lineOfNumber.Count % 2 == 0)
            {
                lineOfNumber.RemoveRange((lineOfNumber.Count / 2), lineOfNumber.Count / 2);
            }
            else
            {
                lineOfNumber.RemoveRange((lineOfNumber.Count / 2) + 1, lineOfNumber.Count / 2);
            }

            Console.WriteLine(string.Join(" ", lineOfNumber));
        }
    }
}
