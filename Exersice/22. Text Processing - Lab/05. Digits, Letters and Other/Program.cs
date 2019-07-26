namespace DigitsLettersAndOther
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var digit = new StringBuilder();
            var letter = new StringBuilder();
            var other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digit = digit.Append(input[i]);
                }
                else if (char.IsLetter(input[i]))
                {
                    letter = letter.Append(input[i]);
                }
                else
                {
                    other = other.Append(input[i]);
                }
            }

            Console.WriteLine(digit.ToString());
            Console.WriteLine(letter.ToString());
            Console.WriteLine(other.ToString());

        }
    }
}
