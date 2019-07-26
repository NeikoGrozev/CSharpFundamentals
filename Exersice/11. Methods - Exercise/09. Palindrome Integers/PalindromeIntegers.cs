using System;

namespace PalindromeIntegers
{
    class PalindromeIntegers
    {
        static void Main()
        {
            string number = string.Empty;

            while ((number = Console.ReadLine()) != "END")
            {
                FindPalindrome(number);
            }
        }

        private static void FindPalindrome(string number)
        {
            bool palindrome = true;

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (!(number[i] == number[number.Length - i - 1]))
                {
                    palindrome = false;
                }
            }

            if (palindrome)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
