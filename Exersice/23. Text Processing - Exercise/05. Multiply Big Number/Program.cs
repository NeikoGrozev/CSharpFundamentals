namespace MultiplyBigNumber
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            BigInteger firstNumber = BigInteger.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            BigInteger multiplySum = 0;

            for (int i = 0; i < secondNumber; i++)
            {
                multiplySum += firstNumber;
            }

            Console.WriteLine(multiplySum);
        }
    }
}
