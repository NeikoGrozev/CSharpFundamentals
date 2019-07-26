using System;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        char[] text = input
                .ToCharArray();

        Array.Reverse(text);

        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
        }


    }
}

