namespace MessageDecrypter
{
    using System;
    using System.Text.RegularExpressions;

    class MessageDecrypterProg
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string pattern = @"^([$%])(?<name>[A-Z][a-z]{3,})\1: \[(?<fitrsDidgit>\d+)\]\|\[(?<secondDigit>\d+)\]\|\[(?<thurdDigit>\d+)\]\|$";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < num; i++)
            {
                string str = Console.ReadLine();

                Match match = regex.Match(str);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    int fitrsDidgit = int.Parse(match.Groups["fitrsDidgit"].Value);
                    int secondDigit = int.Parse(match.Groups["secondDigit"].Value);
                    int thurdDigit = int.Parse(match.Groups["thurdDigit"].Value);

                    string decryptMessage = $"{(char)fitrsDidgit}{(char)secondDigit}{(char)thurdDigit}";

                    Console.WriteLine($"{name}: {decryptMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
