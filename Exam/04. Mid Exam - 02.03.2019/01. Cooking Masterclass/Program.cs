namespace CookingMasterclass
{
    using System;

    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfFlour = double.Parse(Console.ReadLine());
            double priceOfEgg = double.Parse(Console.ReadLine());
            double priceOfApron = double.Parse(Console.ReadLine());

            int numberFreePacketFlour = students / 5;
            int numberPacketFlour = students - numberFreePacketFlour;

            double priceForAllFlour = priceOfFlour * numberPacketFlour;
            double priceForAllEgg = priceOfEgg * 10 * students;
            double priceForAllApron =  priceOfApron * (students + Math.Ceiling(students * 0.20));

            double sum = priceForAllFlour + priceForAllEgg + priceForAllApron;

            double diff = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine($"Items purchased for {sum:F2}$.");
            }
            else
            {
                Console.WriteLine($"{diff:F2}$ more needed.");
            }
        }
    }
}
