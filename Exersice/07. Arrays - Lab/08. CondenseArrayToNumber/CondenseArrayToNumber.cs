using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[] currentArray = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {

            for (int j = 0; j < currentArray.Length - i - 1; j++)
            {
                currentArray[j] = arr[j] + arr[j + 1];
                arr[j] = currentArray[j];
            }
        }

        Console.WriteLine(arr[0]);

    }
}

