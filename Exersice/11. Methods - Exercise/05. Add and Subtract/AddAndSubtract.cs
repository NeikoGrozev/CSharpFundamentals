using System;

namespace AddAndSubtract
{
    class AddAndSubtract
    {
        static void Main()
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());

            int result = AddTwoDigit(firstDigit, secondDigit);
            SubtractTwoDigit(result, thirdDigit);
        }


        private static int AddTwoDigit(int firstDigit, int secondDigit)
        {
            int result = firstDigit + secondDigit;

            return result;
        }
        private static void SubtractTwoDigit(int result, int thirdDigit)
        {
            int resultSubtract = result - thirdDigit;

            Console.WriteLine(resultSubtract);
        }
    }
}
