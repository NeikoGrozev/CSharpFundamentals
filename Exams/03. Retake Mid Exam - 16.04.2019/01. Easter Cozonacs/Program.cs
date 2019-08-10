using System;

namespace EasterCozonacs
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());

            double flour = double.Parse(Console.ReadLine());

            double eggs = flour * 0.75;
            double milk = (flour * 1.25) / 4;

            int colorEggs = 0;

            double cozonac = flour + eggs + milk;
            int cozonacCount = 0;

            while (budget > cozonac)
            {
                cozonacCount++;
                budget -= cozonac;
                colorEggs += 3;

                if (cozonacCount % 3 == 0)
                {
                    colorEggs -= cozonacCount - 2;
                }
            }

            Console.WriteLine($"You made {cozonacCount} cozonacs! Now you have {colorEggs} eggs and {budget:F2}BGN left.");
        }
    }
}
