using System;
class ReversedChars
{
    static void Main()
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        char secondSymbol = char.Parse(Console.ReadLine());
        char thirdSymbol = char.Parse(Console.ReadLine());

        char[] line = { thirdSymbol, secondSymbol, firstSymbol };

        Console.WriteLine(string.Join(" ", line));
    }
}

