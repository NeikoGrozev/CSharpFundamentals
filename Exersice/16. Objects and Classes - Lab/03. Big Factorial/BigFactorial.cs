using System;
using System.Numerics;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
