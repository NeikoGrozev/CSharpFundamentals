using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class CardsGame
    {
        static void Main()
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            while (true)
            {
                if (firstPlayer.Count <= 0 || secondPlayer.Count <= 0)
                {
                    break;
                }

                if (firstPlayer[0] > secondPlayer[0])
                {
                    int temp = firstPlayer[0];
                    firstPlayer.RemoveAt(0);
                    firstPlayer.Add(temp);
                    firstPlayer.Add(secondPlayer[0]);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    int temp = secondPlayer[0];
                    secondPlayer.RemoveAt(0);
                    secondPlayer.Add(temp);
                    secondPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }

            int sum = 0;
            if (firstPlayer.Count == 0)
            {
                sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
