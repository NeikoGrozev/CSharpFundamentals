using System;
class BeerKegs
{
    static void Main()
    {
        int numberOfKegs = int.Parse(Console.ReadLine());

        string model = string.Empty;
        double volumeOfKegs = 0.0;
        double currentVolumeOfKeg = 0.0;
        string currentModel = string.Empty;
       
        for (int i = 1; i <= numberOfKegs; i++)
        {
            model = Console.ReadLine();
            float radius = float.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            volumeOfKegs = Math.PI * Math.Pow(radius, 2) * height;

            if (volumeOfKegs > currentVolumeOfKeg)
            {
                currentVolumeOfKeg = volumeOfKegs;
                currentModel = model;
            }
        }

        Console.WriteLine(currentModel);
        
    }
}

