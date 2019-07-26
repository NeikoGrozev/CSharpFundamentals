using System;

namespace MiddleCharacters
{
    class MiddleCharacters
    {
        static void Main()
        {
            string str = Console.ReadLine();

            FindMiddleCharacter(str);
        }

        private static void FindMiddleCharacter(string str)
        {
            int middle = str.Length / 2;

            if (str.Length % 2 == 0)
            {
                Console.WriteLine($"{str[middle - 1]}{str[middle]}");
            }
            else
            {
                Console.WriteLine(str[middle]);
            }
        }
    }
}
