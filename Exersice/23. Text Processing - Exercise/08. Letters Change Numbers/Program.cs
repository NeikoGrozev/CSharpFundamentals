namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> collecton = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<double> digit = new List<double>();

            for (int i = 0; i < collecton.Count; i++)
            {
                string word = collecton[i];
                char firstLetter = word[0];
                char finishLetter = word[word.Length - 1];

                word = word.Remove(0, 1);
                word = word.Remove(word.Length - 1, 1);

                double number = double.Parse(word);

                int firstLetterDigit = 0;
                int finishLetterDigit = 0;

                if (char.IsUpper(firstLetter))
                {
                    firstLetterDigit = firstLetter - 64;

                    number /= firstLetterDigit;
                }
                else if (char.IsLower(firstLetter))
                {
                    firstLetterDigit = firstLetter - 96;

                    number *= firstLetterDigit;
                }

                if (char.IsUpper(finishLetter))
                {
                    finishLetterDigit = finishLetter - 64;

                    number -= finishLetterDigit;
                }
                else if (char.IsLower(finishLetter))
                {
                    finishLetterDigit = finishLetter - 96;

                    number += finishLetterDigit;
                }

                digit.Add(number);
            }

            double sum = digit.Sum();

            Console.WriteLine($"{sum:F2}");
        }
    }
}
