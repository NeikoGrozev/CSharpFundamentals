namespace PostOffice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            List<string> collection = Console.ReadLine()
                .Split("|")
                .ToList();

            string firstPart = collection[0];
            string secondPart = collection[1];
            string thirdPard = collection[2];

            string patternFirstPart = @"([#$%*&])(?<upperLetter>[A-Z]+)\1";
            Regex regexFirstPart = new Regex(patternFirstPart);
            Match matchFirstPart = regexFirstPart.Match(firstPart);
            
            string upperLetters = matchFirstPart.Groups["upperLetter"].Value;

            for (int i = 0; i < upperLetters.Length; i++)
            {
                string startLetter = ((int)upperLetters[i]).ToString();
                string patternSecondPart = $@"{startLetter}:(?<length>[0-9][0-9])";
                Regex regexSecondPart = new Regex(patternSecondPart);
                Match matchSecondPart = regexSecondPart.Match(secondPart);

                string lengthstr = matchSecondPart.Groups["length"].Value;
                string length = (int.Parse(lengthstr)).ToString();

                string pattern = $@"(?<=\s|^)[{upperLetters[i]}][^\s]{{{length}}}(?=\s|$)";
                Regex regexWord = new Regex(pattern);
                Match matcheWord = regexWord.Match(thirdPard);

                if (matcheWord.Success)
                {
                    Console.WriteLine(matcheWord.ToString());                    
                }
            }
        }
    }
}
