using System;
using System.Linq;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            Random randomWord = new Random();

            for (int positionOne = 0; positionOne < text.Length; positionOne++)
            {
                int positionTwo = randomWord.Next(text.Length);

                string temp = text[positionOne];
                text[positionOne] = text[positionTwo];
                text[positionTwo] = temp;
            }

                Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}
