using System;
class ExactSumOfRealNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        decimal sum = 0;

        for (int i = 1; i <= number; i++)
        {
            decimal numberAdd = decimal.Parse(Console.ReadLine());

            sum += numberAdd;
        }

        Console.WriteLine(sum);
    }
}

