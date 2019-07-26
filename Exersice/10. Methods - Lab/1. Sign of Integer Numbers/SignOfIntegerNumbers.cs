using System;

class SignOfIntegerNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string sing = ResultOfNumber(number);

        Console.WriteLine($"The number {number} is {sing}.");
    }

    private static string ResultOfNumber(int number)
    {
        string result = string.Empty;

        if (number > 0)
        {
            result = "positive";
        }
        else if (number < 0)
        {
            result = "negative";
        }
        else
        {
            result = "zero";
        }
        return result;
    }
}
