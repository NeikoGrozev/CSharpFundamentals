using System;

class Theatre_Promotion
{
    static void Main()
    {
        string typeOfDay = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        int price = 0;

        if (!(age >= 0 && age <= 122))
        {
            Console.WriteLine("Error!");
            return;
        }

        if (typeOfDay == "Weekday")
        {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122)
            {
                price = 12;
            }
            else 
            {
                price = 18;
            }
        }
        else if (typeOfDay == "Weekend")
        {
            if (age >= 0 && age <= 18 || age > 64 && age <= 122)
            {
                price = 15;
            }
            else
            {
                price = 20;
            }
        }
        else if (typeOfDay == "Holiday")
        {
            if (age >= 0 && age <= 18)
            {
                price = 5;
            }
            else if (age > 18 && age <= 64)
            {
                price = 12;
            }
            else
            {
                price = 10;
            }
        }

        Console.WriteLine($"{price}$");
    }
}

