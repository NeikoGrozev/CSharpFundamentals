using System;

class PrintAndSum
{
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.WriteLine("Sum: {0}", sum);
    }
}

