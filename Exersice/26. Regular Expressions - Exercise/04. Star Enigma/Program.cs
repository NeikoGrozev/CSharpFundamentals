namespace StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string patternInput = $"[STARstar]";
            Regex regexInput = new Regex(patternInput);

            string patternDecrypt = $@"[^@\-,!:>]*@(?<planetName>[A-Z][a-z]+)[^@\-,!:>]*:(?<population>\d+)[^@\-,!:>]*!(?<attackType>[AD])[^@\-,!:>]*![^@\-,!:>]*->(?<SoldierCount>\d+)[^@\-,!:>]*";
            Regex regexDecrypt = new Regex(patternDecrypt);

            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                int numberMatchesChar = Regex.Matches(input, regexInput.ToString()).Count;

                string inputDecrypted = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    inputDecrypted += (char)(input[j] - numberMatchesChar);
                }

                Match match = regexDecrypt.Match(inputDecrypted);

                if (match.Success)
                {
                    char symbol = char.Parse(match.Groups["attackType"].Value);
                    string planet = match.Groups["planetName"].Value;

                    if (symbol == 'A')
                    {
                        attackedPlanet.Add(planet);
                    }
                    else if (symbol == 'D')
                    {
                        destroyedPlanet.Add(planet);
                    }
                }
            }

            int attackedPlanetCount = attackedPlanet.Count;
            int destroyedPlanetCount = destroyedPlanet.Count;

            Console.WriteLine($"Attacked planets: {attackedPlanetCount}");

            foreach (var item in attackedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanetCount}");

            foreach (var item in destroyedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
