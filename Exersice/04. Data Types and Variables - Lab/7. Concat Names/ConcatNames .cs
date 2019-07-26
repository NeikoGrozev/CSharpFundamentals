using System;
class ConcatNames
{
    static void Main()
    {
        string firstSymbol = Console.ReadLine();
        string secondSymbol = Console.ReadLine();
        string thirdSymbol = Console.ReadLine();

        string[] line = { firstSymbol, thirdSymbol, secondSymbol };

        Console.WriteLine(string.Join("", line));
    }
}

