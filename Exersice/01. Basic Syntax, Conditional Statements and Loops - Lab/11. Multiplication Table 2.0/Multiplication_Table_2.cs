using System;

class Multiplication_Table_2
{
    static void Main()
    {
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        if (number1 <= 10 && number2 <= 10)
        {
            for (int i = number2; i <= 10; i++)
            {
                Console.WriteLine($"{number1} X {i} = {number1 * i}");
            }
        }
        else
        {
            Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
        }
    }
}

