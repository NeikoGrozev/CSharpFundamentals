namespace DistanceCalculator
{
    using System;

    class Program
    {
        static void Main()
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            double stepPerCentimeter = double.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());

            double sumSteps = 0;

            for (int i = 1; i <= numberOfSteps; i++)
            {
                double currentStepPerCentimeter = stepPerCentimeter;

                if (i % 5 == 0)
                {
                    currentStepPerCentimeter *= 0.70;
                }

                sumSteps += currentStepPerCentimeter;
            }

            double distanceTraveled = sumSteps / distance;

            Console.WriteLine($"You travelled {distanceTraveled:F2}% of the distance!");
        }
    }
}
