using System;

class StrongNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int copyNumber = number;

        int currentNumber = 0;
        int factorialSum = 0;

        while (copyNumber != 0)
        {
            currentNumber = copyNumber % 10;
            copyNumber /= 10;

            int factorial = 1;

            for (int i = 1; i <= currentNumber; i++)
            {
                factorial *= i;
            }

            factorialSum += factorial;
        }

        if (number == factorialSum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
