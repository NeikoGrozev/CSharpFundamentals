using System;

class Even_Number
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        while (number % 2 != 0)
        {
            Console.WriteLine("Please write an even number.");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The number is: {0}", Math.Abs(number));
    }
}

