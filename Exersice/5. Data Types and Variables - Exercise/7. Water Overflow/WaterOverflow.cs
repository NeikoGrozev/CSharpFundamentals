using System;
class Program
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());

        int sumOfLiters = 0;

        for (int i = 1; i <= numberOfLines; i++)
        {
            int liters = int.Parse(Console.ReadLine());

            if (sumOfLiters + liters <= 255)
            {
                sumOfLiters += liters;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(sumOfLiters);
    }
}

