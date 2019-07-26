using System;

class TriangleOfNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
        }
    }
}

