using System;
using System.Linq;

class ZigZagArrays
{
    static void Main()
    {
        int numberOfLine = int.Parse(Console.ReadLine());

        int[] arr1 = new int[numberOfLine];
        int[] arr2 = new int[numberOfLine];

        for (int i = 0; i < numberOfLine; i++)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();                

            if (i % 2 == 0)
            {
                arr1[i] = numbers[0];                
                arr2[i] = numbers[1];                   
            }
            else
            {
                arr1[i] = numbers[1];
                arr2[i] = numbers[0];                   
            }
        }

        Console.Write(string.Join(" ", arr1));
        Console.WriteLine();
        Console.Write(string.Join(" ", arr2));
    }
}
