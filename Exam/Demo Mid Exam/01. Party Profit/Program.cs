using System;

namespace PartyProfit
{
    class Program
    {
        static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                coins += 50;

                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                if (i % 3 == 0)
                {
                    coins -= partySize * 3;
                }

                if (i % 5 == 0)
                {
                    coins += partySize * 20;

                    if (i % 3 == 0)
                    {
                        coins -= partySize * 2;
                    }
                }

                coins -= partySize * 2;
            }

            int coinsPerCompanion = coins / partySize;

            Console.WriteLine($"{partySize} companions received {coinsPerCompanion} coins each.");
        }
    }
}
