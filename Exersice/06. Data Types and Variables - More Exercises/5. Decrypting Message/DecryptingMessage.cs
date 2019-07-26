using System;

class DecryptingMessage
{
    static void Main()
    {
        int nextKey = int.Parse(Console.ReadLine());
        int numbersOfLine = int.Parse(Console.ReadLine());

        char symbol = '\0';
        char[] message = new char[20];
        int newSymbol = 0;

        for (int i = 0; i < numbersOfLine; i++)
        {
            symbol = char.Parse(Console.ReadLine());

            newSymbol = symbol + nextKey;
            char intToChar = (char)newSymbol;


            message[i] = intToChar;

        }

        Console.WriteLine(String.Join("", message));
    }
}

