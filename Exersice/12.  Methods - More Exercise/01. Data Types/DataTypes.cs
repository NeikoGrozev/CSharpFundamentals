using System;

namespace DataTypes
{
    class DataTypes
    {
        static void Main()
        {
            string typeVariable = Console.ReadLine();

            switch (typeVariable)
            {
                case "int":
                    GetInt();
                    break;
                case "real":
                    GetRealNumber();
                    break;
                case "string":
                    GetString();
                    break;
            }
        }

        private static void GetInt()
        {
            int number = int.Parse(Console.ReadLine()) * 2;
            Console.WriteLine(number);
        }

        private static void GetRealNumber()
        {
            double realNumber = double.Parse(Console.ReadLine()) * 1.5;
            Console.WriteLine($"{realNumber:F2}");
        }

        private static void GetString()
        {
            string word = Console.ReadLine();
            Console.WriteLine($"${word}$");
        }
    }
}
