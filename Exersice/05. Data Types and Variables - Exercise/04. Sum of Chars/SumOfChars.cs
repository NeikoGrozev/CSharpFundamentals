using System;
class Program
{
    static void Main()
    {
        int numbersOfLine = int.Parse(Console.ReadLine());

        int sumOfChar = 0;

        for (int i = 1; i <= numbersOfLine; i++)
        {
            char symbol = char.Parse(Console.ReadLine());

            sumOfChar += symbol;
        }

        Console.WriteLine($"The sum equals: {sumOfChar}");
    }
}

