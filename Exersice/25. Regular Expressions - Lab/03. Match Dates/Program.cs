namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"((?<day>[0-9]{2})([.\-/]))(?<mount>[A-Z][a-z]{2})\2(?<year>[0-9]{4})";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string mount = match.Groups["mount"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day:F2}, Month: {mount}, Year: {year}");
            }
        }
    }
}
