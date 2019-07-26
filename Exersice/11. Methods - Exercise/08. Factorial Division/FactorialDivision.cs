using System;

namespace FactorialDivision
{
    class FactorialDivision
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double resultFirstNumberFactorial = GetFactorial(firstNumber);
            double resultSecondNumberFactorial = GetFactorial(secondNumber);

            PrintResult(resultFirstNumberFactorial, resultSecondNumberFactorial);
        }

        private static double GetFactorial(int number)
        {
            long sumFactorial = 1;

            for (int i = 2; i <= number; i++)
            {
                sumFactorial *= i;
            }

            return sumFactorial;
        }
        private static void PrintResult(double resultFirstNumberFactorial, double resultSecondNumberFactorial)
        {
            double result = resultFirstNumberFactorial / resultSecondNumberFactorial;
            
            Console.WriteLine($"{result:F2}");
        }
    }
}
