namespace TreasureFinder
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int[] key = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string cryptedWord = Console.ReadLine();

                if (cryptedWord == "find")
                {
                    break;
                }

                StringBuilder decryptedWord = new StringBuilder();
                int count = 0;

                for (int i = 0; i < cryptedWord.Length; i++)
                {
                    char letter = (char)(cryptedWord[i] - key[count]);

                    decryptedWord.Append(letter);
                    count++;

                    if (count == key.Length)
                    {
                        count = 0;
                    }
                }

                string word = decryptedWord.ToString();

                int startIndexType = word.IndexOf('&') + 1;
                int finishIndexType = word.IndexOf('&', startIndexType + 1);
                
                int startIndexCoordinate = word.IndexOf('<') + 1;
                int finishIndexCoordinate = word.IndexOf('>');

                string type = word.Substring(startIndexType, finishIndexType - startIndexType);
                string coordinate = word.Substring(startIndexCoordinate, finishIndexCoordinate - startIndexCoordinate);

                Console.WriteLine($"Found {type} at {coordinate}");
            }
        }
    }
}
