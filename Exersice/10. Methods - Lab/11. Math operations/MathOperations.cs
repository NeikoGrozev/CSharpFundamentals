using System;

namespace MathOperations
{
    class MathOperations
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string typeOperator = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            Calculate(firstNumber, typeOperator, secondNumber);
        }

        private static void Calculate(int firstNumber, string typeOperator, int secondNumber)
        {
            int result = 0;

            switch (typeOperator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
