namespace Deciphering
{
using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            string[] secondInput = Console.ReadLine()
                .Split(" ");

            string pattern = @"^[d-z{}\|#]+$";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(firstInput);

            StringBuilder decryptedWord = new StringBuilder();

            if (match.Success)
            {
                for (int i = 0; i < firstInput.Length; i++)
                {
                    decryptedWord.Append((char)(firstInput[i] - 3));
                }

                decryptedWord.Replace(secondInput[0], secondInput[1]);

                Console.WriteLine(string.Join("", decryptedWord));
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }
    }
}
