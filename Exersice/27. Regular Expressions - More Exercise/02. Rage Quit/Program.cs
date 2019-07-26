namespace RageQuit
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string pattern = $@"(?<word>[^\d]+)(?<digit>[0-9]+)";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            StringBuilder str = new StringBuilder();
            List<char> uniqueSymbol = new List<char>();

            foreach (Match match in matches)
            {
                string word = match.Groups["word"].Value.ToString().ToUpper();
                int digit = int.Parse(match.Groups["digit"].Value);

                if (digit != 0)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (!uniqueSymbol.Contains(word[i]))
                        {
                            uniqueSymbol.Add(word[i]);
                        }
                    }

                    for (int i = 0; i < digit; i++)
                    {
                        str.Append(word);
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbol.Count}");
            Console.WriteLine(string.Join("", str));
        }
    }
}

