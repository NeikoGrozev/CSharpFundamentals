using System;
class dividerrogram
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourtNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;
        int divider = sum / thirdNumber;
        int multiply = divider * fourtNumber;

        Console.WriteLine(multiply);
    }
}

