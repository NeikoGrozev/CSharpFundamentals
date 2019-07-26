using System;

class Sum_Of_Odd_Numbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int counter = 0;
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            if (counter == num)
            {
                break;
            }

            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                sum += i;
                counter++;
            }
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}

