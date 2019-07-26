using System;
class CharsToString
{
    static void Main()
    {
        char firstSymbol = char.Parse(Console.ReadLine());
        char secondSymbol = char.Parse(Console.ReadLine());
        char thirdSymbol = char.Parse(Console.ReadLine());

        char[] line = { firstSymbol, secondSymbol, thirdSymbol };

        Console.WriteLine(string.Join("", line));
    }
}

