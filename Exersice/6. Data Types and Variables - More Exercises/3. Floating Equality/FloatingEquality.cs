using System;
class FloatingEquality
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());

        double eps = 0.000001;

        double floatingEquality = Math.Abs(numberA - numberB);

        if (floatingEquality < eps)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

