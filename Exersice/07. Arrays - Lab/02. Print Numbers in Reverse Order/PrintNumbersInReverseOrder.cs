using System;

class PrintNumbersInReverseOrder
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int[] lineOfNumbers = new int[num];

        for (int i = num - 1; i >= 0; i--)
        {
            lineOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        
        Console.WriteLine(string.Join(" ", lineOfNumbers));
    }
}

