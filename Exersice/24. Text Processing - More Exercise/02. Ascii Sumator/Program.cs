namespace _AsciiSumator
{
using System;

    class Program
    {
        static void Main()
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char finishSymbol = char.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > startSymbol && str[i] < finishSymbol)
                {
                    sum += str[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
