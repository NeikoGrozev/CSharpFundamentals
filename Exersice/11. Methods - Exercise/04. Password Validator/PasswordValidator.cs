using System;

namespace PasswordValidator
{
    class PasswordValidator
    {
        static void Main()
        {
            string str = Console.ReadLine();

            CheckPassword(str);
        }

        private static void CheckPassword(string str)
        {
            bool currectNumbersOfSymbols = true;
            bool currectRangeOfSumbol = true;
            bool currectNumberOfDigit = true;
            int counterDigit = 0;

            if (!(str.Length >= 6 && str.Length <= 10))
            {
                currectNumbersOfSymbols = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (!(str[i] >= 48 && str[i] <= 90 || str[i] >= 97 && str[i] <= 122))
                {
                    currectRangeOfSumbol = false;
                }

                if ((str[i] >= 48 && str[i] <= 57))
                {
                   
                    counterDigit++;
                }
            }

            if (currectRangeOfSumbol == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (counterDigit < 2)
            {
                currectNumberOfDigit = false;
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (currectNumbersOfSymbols && currectRangeOfSumbol && currectNumberOfDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
