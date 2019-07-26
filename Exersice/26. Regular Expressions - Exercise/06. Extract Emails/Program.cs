namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = $@"(?<=\s)[A-Za-z0-9]+([.\-_][A-Za-z0-9]*)?@[a-z]+[-]?[a-z]+\.[a-z]+(\.[a-z]+)?\b";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine($"{match}");
            }
        }
    }
}
