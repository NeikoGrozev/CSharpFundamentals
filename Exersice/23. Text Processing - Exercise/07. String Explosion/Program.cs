namespace StringExplosion
{
    using System;

    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '>')
                {
                    int bombNumber = (int)(str[i + 1]) - 48 + count;
                    int nextSymbol = str.IndexOf('>', i + 1);

                    if (nextSymbol != -1)
                    {
                        count = nextSymbol - i - 1;
                    }
                    else
                    {
                        count = bombNumber;
                    }

                    if (i + bombNumber < str.Length && count >= bombNumber)
                    {
                        str = str.Remove(i + 1, bombNumber);
                        count = 0;
                    }
                    else if (i + bombNumber < str.Length && count < bombNumber)
                    {
                        str = str.Remove(i + 1, count);
                        count = bombNumber - count;
                    }
                    else if (i + bombNumber >= str.Length && count < bombNumber)
                    {
                        str = str.Remove(i + 1, count);
                        count = bombNumber - count;
                    }
                    else
                    {
                        bombNumber = str.Length - (i + 1);
                        str = str.Remove(i + 1, bombNumber);
                    }
                }
            }

            Console.WriteLine(str);
        }
    }
}
