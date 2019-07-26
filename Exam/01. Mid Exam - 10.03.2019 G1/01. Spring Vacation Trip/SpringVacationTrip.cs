using System;

namespace SpringVacationTrip
{
    class Program
    {
        static void Main()
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int numberOfPeoples = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double feesForHumanFood = double.Parse(Console.ReadLine());
            double priceOfHotelRoomPerOnePeople = double.Parse(Console.ReadLine());


            double foodExpenses = daysOfTrip * numberOfPeoples * feesForHumanFood;
            double hotelExpenses = daysOfTrip * numberOfPeoples * priceOfHotelRoomPerOnePeople;
            

            if (numberOfPeoples > 10)
            {
                hotelExpenses = hotelExpenses * 0.75;
            }

            double totalExpenses = foodExpenses + hotelExpenses;

             

            for (int i = 1; i <= daysOfTrip; i++)
            {
                double travelDistance = double.Parse(Console.ReadLine());
                double priceForFuel = travelDistance * fuelPerKilometer;
                
                if (totalExpenses > budget)
                {
                    break;
                }

                totalExpenses += priceForFuel;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpenses += totalExpenses * 0.40;
                }

                if (i % 7 == 0)
                {
                    totalExpenses -= totalExpenses / numberOfPeoples;
                }

            }

            if (budget >= totalExpenses)
            {
                Console.WriteLine("You have reached the destination. You have {0:F2}$ budget left.", budget - totalExpenses);
            }
            else
            {
                Console.WriteLine("Not enough money to continue the trip. You need {0:F2}$ more.", totalExpenses - budget);
            }
        }
    }
}
