namespace ArrivingInKathmandu
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"^(?<name>[A-Za-z\d!@#$?]+)=(?<length>\d+)<<(?<geohashcode>.*)$";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Last note")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (!match.Success)
                {
                    PrintNotingFound(); 
                    continue;
                }

                string namestr = match.Groups["name"].Value;
                string name = string.Empty;

                int length = int.Parse(match.Groups["length"].Value);
                string geohashcode = match.Groups["geohashcode"].Value;

                if (length != geohashcode.Length)
                {
                    PrintNotingFound();
                    continue;
                }

                for (int i = 0; i < namestr.Length; i++)
                {
                    if (char.IsLetterOrDigit(namestr[i]))
                    {
                        name += namestr[i];
                    }
                }

                Console.WriteLine($"Coordinates found! {name} -> {geohashcode}");
            }
        }

        private static void PrintNotingFound()
        {
            Console.WriteLine("Nothing found!");
        }
    }
}
