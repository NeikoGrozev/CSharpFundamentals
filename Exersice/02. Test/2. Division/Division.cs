using System;

class Division
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int divisibleNumber = 0;

        if (number % 10 == 0)
        {
            divisibleNumber = 10;
        }
        else if (number % 7 == 0)
        {
            divisibleNumber = 7;
        }
        else if (number % 6 == 0)
        {
            divisibleNumber = 6;
        }
        else if (number % 3 == 0)
        {
            divisibleNumber = 3;
        }
        else if (number % 2 == 0)
        {
            divisibleNumber = 2;
        }

        if (divisibleNumber == 0)
        {
            Console.WriteLine("Not divisible");
        }
        else
        {
            Console.WriteLine($"The number is divisible by {divisibleNumber}");
        }
    }
}

