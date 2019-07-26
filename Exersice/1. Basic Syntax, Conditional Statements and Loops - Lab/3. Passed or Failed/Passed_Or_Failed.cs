using System;

class Passed_Or_Failed
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());

        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");
        }
        else
        {
            Console.WriteLine("Failed!");
        }
    }
}

