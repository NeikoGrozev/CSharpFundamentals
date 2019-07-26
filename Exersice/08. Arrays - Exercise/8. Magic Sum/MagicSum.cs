using System;
using System.Linq;

class MagicSum
{
    static void Main()
    {
        int[] lineOfNumbers = Console.ReadLine()
        .Split()
        .Select(int.Parse)
        .ToArray();

        int returnSum = int.Parse(Console.ReadLine());

        for (int i = 0; i < lineOfNumbers.Length - 1; i++)
        {
            for (int j = i + 1; j < lineOfNumbers.Length; j++)
            {
                if (lineOfNumbers[i] + lineOfNumbers[j] == returnSum)
                {
                    Console.WriteLine($"{lineOfNumbers[i]} {lineOfNumbers[j]}");
                }
            }
        }
    }
}
