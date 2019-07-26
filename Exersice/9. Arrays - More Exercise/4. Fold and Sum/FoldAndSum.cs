using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] lineOfNumbers = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        int part = lineOfNumbers.Length / 4;

        int[] newLineOfNumbers = new int[lineOfNumbers.Length / 2];
        int counter = 0;

        for (int i = part - 1; i >= 0; i--)
        {
            newLineOfNumbers[counter] = lineOfNumbers[i];
            counter++;
        }

        for (int i = lineOfNumbers.Length - 1; i >= 3 * part; i--)
        {
            newLineOfNumbers[counter] = lineOfNumbers[i];
            counter++;
        }

        for (int i = 0; i < 2* part; i++)
        {
            newLineOfNumbers[i] += lineOfNumbers[part + i];
        }
        Console.WriteLine(string.Join(" ", newLineOfNumbers));
    }
}

