using System;

class SumDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while (number != 0)
        {
            int lastDigit = number % 10;
            number /= 10;

            sum += lastDigit;
        }

        Console.WriteLine(sum);
    }
}

