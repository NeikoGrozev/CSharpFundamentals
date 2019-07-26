using System;
class Orders
{
    static void Main()
    {
        string product = Console.ReadLine();
        int numberOfProducts = int.Parse(Console.ReadLine());

        double result = Price(product, numberOfProducts);

        Console.WriteLine($"{result:F2}");
    }

    private static double Price(string product, int numberOfProducts)
    {
        double sum = 0.0;

        switch (product)
        {
            case "coffee":
                sum = numberOfProducts * 1.50;
                break;
            case "water":
                sum = numberOfProducts * 1.00;
                break;
            case "coke":
                sum = numberOfProducts * 1.40;
                break;
            case "snacks":
                sum = numberOfProducts * 2.00;
                break;
        }

        return sum;

    }
}

