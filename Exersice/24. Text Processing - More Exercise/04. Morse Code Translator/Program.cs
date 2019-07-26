namespace MorseCodeTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string[] morseCode = Console.ReadLine()
                .Split("|")
                .Select(x => x.Trim())
                .ToArray();

            StringBuilder decryptedMorseCode = new StringBuilder();

            for (int i = 0; i < morseCode.Length; i++)
            {
                string[] word = morseCode[i]
                    .Split(" ");

                foreach (var letter in word)
                {
                    char symbol = MorseCodeTranslator(letter);
                    decryptedMorseCode.Append(symbol);
                }

                decryptedMorseCode.Append(" ");
            }

            Console.WriteLine(string.Join("", decryptedMorseCode.ToString().ToUpper()));
        }

        private static char MorseCodeTranslator(string letter)
        {
            Dictionary<string, char> dict = new Dictionary<string, char>()
            {
                {".-", 'a'},
                {"-...", 'b'},
                {"-.-.", 'c'},
                {"-..", 'd'},
                {".", 'e'},
                {"..-.", 'f'},
                {"--.", 'g'},
                {"....", 'h'},
                { "..", 'i'},
                {".---", 'j'},
                {"-.-", 'k'},
                {".-..", 'l'},
                {"--", 'm'},
                {"-.", 'n'},
                {"---", 'o'},
                {".--.", 'p'},
                {"--.-", 'q'},
                {".-.", 'r'},
                {"...", 's'},
                {"-", 't'},
                {"..-", 'u'},
                {"...-", 'v'},
                {".--", 'w'},
                {"-..-", 'x'},
                {"-.--", 'y'},
                {"--..", 'z'},
                {"-----", '0'},
                {".----", '1'},
                {"..---", '2'},
                {"...--", '3'},
                {"....-", '4'},
                {".....", '5'},
                {"-....", '6'},
                {"--...", '7'},
                {"---..", '8'},
                {"----.", '9'}
            };

            foreach (var item in dict)
            {
                if (item.Key == letter)
                {
                    return item.Value;
                }
            }

            return ' ';
        }
    }
}
