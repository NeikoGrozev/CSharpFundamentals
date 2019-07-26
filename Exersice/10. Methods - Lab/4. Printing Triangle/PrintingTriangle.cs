using System;
class PrintingTriangle
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        PrintTriangle(number);
    }

    private static void PrintTriangle(int number)
    {

        for (int i = 1; i<= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }

        for (int i = number - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}

