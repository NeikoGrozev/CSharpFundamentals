namespace EmojiSumator
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"(?<=\s):(?<emoji>[a-z]{4,}):(?=[ \,\.\!\?])";

            Regex regex = new Regex(pattern);

            string str = Console.ReadLine();

            int[] word = Console.ReadLine()
                .Split(":")
                .Select(int.Parse)
                .ToArray();

            string emoji = string.Empty;

            for (int i = 0; i < word.Length; i++)
            {
                emoji += (char)word[i];
            }

            MatchCollection matches = regex.Matches(str);
            int emojiPower = 0;

            foreach (Match match in matches.OrderBy(x => x.Value))
            {
                string currentMatch = match.Groups["emoji"].Value;

                for (int i = 0; i < currentMatch.Length; i++)
                {
                    emojiPower += (int)currentMatch[i];
                }
            }

            foreach (Match match in matches)
            {
                string currentMatch = match.ToString();
                currentMatch = currentMatch.Remove(0, 1);
                currentMatch = currentMatch.Remove(currentMatch.Length - 1, 1);

                if (currentMatch == emoji)
                {
                    emojiPower *= 2;
                    break;
                }
            }

            if (matches.Count > 0)
            {
                Console.WriteLine($"Emojis found: {string.Join(", ", matches)}");
            }

            Console.WriteLine($"Total Emoji Power: {emojiPower}");
        }
    }
}
