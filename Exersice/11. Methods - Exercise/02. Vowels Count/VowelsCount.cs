using System;

namespace VowelsCount
{
    class VowelsCount
    {
        static void Main()
        {
            string str = Console.ReadLine();

            FindVolwels(str);
        }

        private static void FindVolwels(string str)
        {
            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                    case 'a':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'U':
                    case 'u':
                    case 'O':
                    case 'o':
                        counter++;
                        break;

                }
            }

            PrintResult(counter);
        }

        private static void PrintResult(int counter)
        {
            Console.WriteLine(counter);
        }
    }
}
