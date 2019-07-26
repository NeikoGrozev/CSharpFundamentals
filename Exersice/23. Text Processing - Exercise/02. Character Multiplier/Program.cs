namespace CharacterMultiplier
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] str = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string strOne = str[0];
            string strTwo = str[1];
            int result = 0;

            if (strOne.Length == strTwo.Length)
            {
                result = Multiplier(strOne, strTwo, strOne.Length);
            }
            else if (strOne.Length > strTwo.Length)
            {
                result = Multiplier(strOne, strTwo, strTwo.Length);
                result += Add(strOne, strTwo.Length);
            }
            else
            {
                result = Multiplier(strOne, strTwo, strOne.Length);
                result += Add(strTwo, strOne.Length);
            }
            

            Console.WriteLine(result);
        }

        private static int Multiplier(string strOne, string strTwo, int length)
        {
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                result += strOne[i] * strTwo[i];
            }

            return result;
        }

        private static int Add(string str, int length)
        {
            int result = 0;

            for (int i = length; i < str.Length; i++)
            {
                result += str[i];
            }

            return result;
        }
    }
}
