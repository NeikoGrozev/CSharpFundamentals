using System;
class SortNumbers
{
    static void Main()
    {
        int[] num = new int[3];

        for (int i = 0; i < 3; i++)
        {
            int input = int.Parse(Console.ReadLine());

            num[i] = input;

            Array.Sort(num);
            Array.Reverse(num);
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(num[i]);
        }
    }
}

