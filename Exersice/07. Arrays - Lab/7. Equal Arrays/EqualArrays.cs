using System;
using System.Linq;

class EqualArrays
{
    static void Main()
    {
        int[] arrayOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] arrayTwo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int sum = 0;
        int counterEquals = 0;
        int index = 0;

        for (int i = 0; i < arrayOne.Length; i++)
        {
            if (arrayOne[i] == arrayTwo[i])
            {
                counterEquals++;
                sum += arrayOne[i];
            }
            else
            {
                index = i;
                break;
            }
        }

        if (counterEquals == arrayOne.Length)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        }
    }
}

