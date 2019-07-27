namespace AnimalSanctuary
{
    using System;    
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int weigth = 0;
            string pattern = "^n:(?<name>[^;]+);t:(?<kind>[^;]+);c--(?<country>[A-Za-z ]+)$";

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string matchName = match.Groups["name"].Value.ToString();
                    string matchKind = match.Groups["kind"].Value.ToString();
                    string name = string.Empty;
                    string kind = string.Empty;

                    for (int j = 0; j < matchName.Length; j++)
                    {
                        if (char.IsLetter(matchName[j]) || matchName[j] == ' ')
                        {
                            name += matchName[j];
                        }
                        else if (char.IsDigit(matchName[j]))
                        {
                            weigth += int.Parse(matchName[j].ToString());
                        }
                    }

                    for (int k = 0; k < matchKind.Length; k++)
                    {
                        if (char.IsLetter(matchKind[k]) || matchKind[k] == ' ')
                        {
                            kind += matchKind[k];
                        }
                        else if (char.IsDigit(matchKind[k]))
                        {
                            weigth += int.Parse(matchKind[k].ToString());
                        }
                    }

                    string country = match.Groups["country"].Value.ToString();

                    Console.WriteLine($"{name} is a {kind} from {country}");
                }
            }

            Console.WriteLine($"Total weight of animals: {weigth}KG");
        }
    }
}
