namespace SantasSecretHelper
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            int numForDecrypt = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();
            string pattern = $"@(?<name>[A-Za-z]+)[^-@!:>]*!(?<behaviour>[G])!";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string decryptInput = string.Empty;

                for (int i = 0; i < input.Length; i++)
                {
                    decryptInput += (char)(input[i] - numForDecrypt);
                }

                Match match = regex.Match(decryptInput);

                if (match.Success)
                {
                    char symbol = char.Parse(match.Groups["behaviour"].Value);

                    if (symbol == 'G')
                    {
                        string name = match.Groups["name"].Value;
                        names.Add(name);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
