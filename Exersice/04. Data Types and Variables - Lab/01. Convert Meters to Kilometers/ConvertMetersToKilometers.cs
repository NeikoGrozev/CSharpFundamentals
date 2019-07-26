using System;
class ConvertMetersToKilometers
{
    static void Main()
    {
        double meters = double.Parse(Console.ReadLine());

        double kilometers = meters / 1000;

        Console.WriteLine($"{kilometers:F2}");
    }
}

