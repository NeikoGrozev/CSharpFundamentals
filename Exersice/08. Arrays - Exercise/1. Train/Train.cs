using System;
class Train
{
    static void Main()
    {
        int numberOfLine = int.Parse(Console.ReadLine());

        int[] arr = new int[numberOfLine];
        int sum = 0;

        for (int i = 0; i < numberOfLine; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());

            sum += arr[i];
        }

        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(sum);
    }
}

