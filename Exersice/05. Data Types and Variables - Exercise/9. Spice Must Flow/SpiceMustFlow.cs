using System;

class Program
{
    static void Main()
    {
        long spice = int.Parse(Console.ReadLine());

        long currentSpice = spice;
        long spiceSum = 0;
        int numbersOfDays = 0;

        while (spice >= 100)
        {
            numbersOfDays++;
            currentSpice -= 26;
            spiceSum += currentSpice;
            spice -= 10;
            currentSpice = spice;
        }

        if (spiceSum >= 26)
        {
            spiceSum -= 26;
        }

        Console.WriteLine(numbersOfDays);
        Console.WriteLine(spiceSum);
    }
}
