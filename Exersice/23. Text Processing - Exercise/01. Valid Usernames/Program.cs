namespace ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string[] userName = Console.ReadLine()
                .Split(", ")
                .ToArray();

            StringBuilder validUserName = new StringBuilder();

            for (int i = 0; i < userName.Length; i++)
            {
                bool isLength = false;
                bool isCorectSymbol = true;

                if (userName[i].Length >= 3 && userName[i].Length <= 16)
                {
                    isLength = true;
                }
                else
                {
                    continue;
                }

                for (int j = 0; j < userName[i].Length; j++)
                {
                    if (Char.IsLetterOrDigit(userName[i][j]) || userName[i][j] == '-' || userName[i][j] == '_')
                    {
                        continue;
                    }
                    else
                    {
                        isCorectSymbol = false;
                        break;
                    }
                }

                if (isLength && isCorectSymbol)
                {
                    validUserName = validUserName.AppendLine(userName[i]);
                }
            }

            Console.WriteLine(string.Join("", validUserName));
        }
    }
}
