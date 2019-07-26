using System;
class PrintPartOfASCIITable
{
    static void Main()
    {
        int firstSymbol = int.Parse(Console.ReadLine());
        int LastSymbol = int.Parse(Console.ReadLine());

        for (int i = firstSymbol; i <= LastSymbol; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}

