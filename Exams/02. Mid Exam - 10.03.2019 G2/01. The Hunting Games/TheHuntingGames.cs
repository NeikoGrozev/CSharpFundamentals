using System;

namespace TheHuntingGames
{
    class TheHuntingGames
    {
        static void Main()
        {
            int daysOfAdvengers = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double groupsEnergy = double.Parse(Console.ReadLine());
            double waterPerDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPerDayForOnePerson = double.Parse(Console.ReadLine());

            double groupsWater = daysOfAdvengers * players * waterPerDayForOnePerson;
            double groupsFood = daysOfAdvengers * players * foodPerDayForOnePerson;

            //bool energyLeft = true;

            for (int i = 1; i <= daysOfAdvengers; i++)
            {
                                     
                double energyLostForDay = double.Parse(Console.ReadLine());

                groupsEnergy -= energyLostForDay;

                if (groupsEnergy <= 0)
                {
                    
                    break;
                }

                if (i % 2 == 0)
                {
                    groupsWater *= 0.70;
                    groupsEnergy *= 1.05;
                }

                if (i % 3 == 0)
                {
                    groupsFood -= groupsFood / players;
                    groupsEnergy *= 1.10;
                }    
            }

            if (groupsEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {groupsFood:F2} food and {groupsWater:F2} water.");
            }
        }
    }
}
