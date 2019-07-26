using System;
using System.Numerics;

class Snowballs
{
    static void Main()
    {
        int numberOfSnowballs = int.Parse(Console.ReadLine());

        BigInteger snowballValue = 0;
        BigInteger currentSnowballValue = 0;
        int currentSnowballSnow = 0;
        int currentSsnowballTime = 0;
        int currentSnowballQuality = 0;

        for (int i = 1; i <= numberOfSnowballs; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

            if (snowballValue > currentSnowballValue)
            {
                currentSnowballValue = snowballValue;
                currentSnowballSnow = snowballSnow;
                currentSsnowballTime = snowballTime;
                currentSnowballQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{currentSnowballSnow} : {currentSsnowballTime} = {currentSnowballValue} ({currentSnowballQuality})");
    }
}

