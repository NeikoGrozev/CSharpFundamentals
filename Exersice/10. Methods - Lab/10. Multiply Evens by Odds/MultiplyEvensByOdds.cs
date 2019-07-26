using System;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int sumEven = GetSumOfEvenDigits(number);
            int sumOdd = GetSumOfOddDigits(number);
            GetMultipleOfEvenAndOdds(sumEven, sumOdd);
        }

        private static void GetMultipleOfEvenAndOdds(int sumEven, int sumOdd)
        {
            int result = sumEven * sumOdd;

            Console.WriteLine(result);
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    sumEven += digit;
                }
            }

            return sumEven;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
            }

            return sumOdd;
        }
    }
}


