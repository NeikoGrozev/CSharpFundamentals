using System;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string typeVariable = Console.ReadLine();

            if (typeVariable == "int")
            {
                int firstDigit = int.Parse(Console.ReadLine());
                int secondDigit = int.Parse(Console.ReadLine());

                int result = GetMax(firstDigit, secondDigit);

                Console.WriteLine(result);
            }
            else if (typeVariable == "char")
            {
                char firstSymbol = char.Parse(Console.ReadLine());
                char secondSymbol = char.Parse(Console.ReadLine());

                char result = GetMax(firstSymbol, secondSymbol);

                Console.WriteLine(result);
            }
            else
            {
                string firstStr = Console.ReadLine();
                string secondStr = Console.ReadLine();

                string result = GetMax(firstStr, secondStr);

                Console.WriteLine(result);
            }
        }

        private static int GetMax(int firstDigit, int secondDigit)
        {
            if (firstDigit >= secondDigit)
            {
                return firstDigit;
            }
            else
            {

                return secondDigit;
            }
        }

        private static char GetMax(char firstSymbol, char secondSymbol)
        {
            if (firstSymbol >= secondSymbol)
            {
                return firstSymbol;
            }
            else
            {
                return secondSymbol;
            }
        }

        private static string GetMax(string firstStr, string secondStr)
        {
           
            if (firstStr.CompareTo(secondStr) >= 0)
            {
                return firstStr;
            }
            else
            {
                return secondStr;
            }
        }
    }
}
