using System;

namespace CharactersInRange
{
    class CharactersInRange
    {
        static void Main()
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            PrintRangeOfSymbols(startSymbol, endSymbol);
        }

        private static void PrintRangeOfSymbols(char startSymbol, char endSymbol)
        {
            if ((int)startSymbol < (int)endSymbol)
            {
                for (int i = startSymbol + 1; i < endSymbol; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = endSymbol + 1; i < startSymbol; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
