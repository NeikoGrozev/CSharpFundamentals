namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string patternHealth = $@"[^0-9\+\-\*\/\.]";
            Regex regexHealth = new Regex(patternHealth);            

            string patternDamage = $@"[-]?\d+(\.\d+)?";
            Regex regexDamage = new Regex(patternDamage);

            string patternSymbol = $@"[\/*]";
            Regex regexSymbol = new Regex(patternSymbol);

            Dictionary<string, KeyValuePair<int, double>> dict = new Dictionary<string, KeyValuePair<int, double>>();

            for (int i = 0; i < input.Length; i++)
            {
                string name = input[i];
                int health = 0;

                MatchCollection matchesHealth = regexHealth.Matches(input[i]);

                foreach (Match match in matchesHealth)
                {
                    char asciiNum = char.Parse(match.Value);
                    health += asciiNum;
                }

                double damage = 0.00;

                MatchCollection matchesDamage = regexDamage.Matches(input[i]);

                foreach (Match match in matchesDamage)
                {
                    damage += double.Parse(match.ToString());
                }

                MatchCollection matchesSymbol = regexSymbol.Matches(input[i]);                

                foreach (Match match in matchesSymbol)
                {
                    char symbol = char.Parse(match.ToString());

                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                    else if (symbol == '*')
                    {
                        damage *= 2;
                    }
                }

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new KeyValuePair<int, double>(health, damage));
                }
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value.Key} health, {item.Value.Value:F2} damage ");
            }
        }
    }
}
