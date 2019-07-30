namespace VaporWinterSale
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    class VaporWinterSaleProg
    {
        static void Main()
        {
            Dictionary<string, double> games = new Dictionary<string, double>();
            Dictionary<string, double> gamesWithDLC = new Dictionary<string, double>();

            string[] input = Console.ReadLine()
                .Split(", ");

            string patternGames = @"(?<name>[A-Za-z\d ]+)-(?<price>\d+(?:\.\d+)?)";
            string patternDLC = @"(?<name>[A-Za-z\d ]+):(?<DLC>.*)";

            Regex regexGames = new Regex(patternGames);
            Regex regexDLC = new Regex(patternDLC);

            foreach (var item in input)
            {
                Match matchGame = regexGames.Match(item);
                Match matchDLC = regexDLC.Match(item);

                if (matchGame.Success)
                {
                    string name = matchGame.Groups["name"].Value;
                    double price = double.Parse(matchGame.Groups["price"].Value);

                    if (!games.ContainsKey(name))
                    {
                        games[name] = price;
                    }
                }
                else if (matchDLC.Success)
                {
                    string name = matchDLC.Groups["name"].Value;
                    string DLC = matchDLC.Groups["DLC"].Value;

                    if (games.ContainsKey(name))
                    {
                        double value = games[name] * 1.2;
                        gamesWithDLC.Add($"{name} - {DLC}", value);

                        games.Remove(name);
                    }
                }
            }
            foreach (var item in gamesWithDLC.OrderBy(x => x.Value))
            {
                double value = item.Value * 0.5;
                Console.WriteLine($"{item.Key} - {value:F2}");
            }

            foreach (var item in games.OrderByDescending(x => x.Value))
            {
                double value = item.Value * 0.8;
                Console.WriteLine($"{item.Key} - {value:F2}");
            }
        }
    }
}
