using System;
using System.Linq;

class ProgArrayRotationram
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int numbarOfRotion = int.Parse(Console.ReadLine());

        numbarOfRotion %= arr.Length;

        for (int i = 1; i <= numbarOfRotion; i++)
        {
            int temp = arr[0];

            for (int j = 0; j < arr.Length - 1; j++)
            {
                arr[j] = arr[j + 1];
            }

            arr[arr.Length - 1] = temp;
        }

        Console.WriteLine(string.Join(" ", arr));
    }
}

