using System;

class RageExpenses
{
    static void Main()
    {
        int gamesLost = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        int numberOfRemovedHeadphones = gamesLost / 2;
        int numberOfRemovedMouse = gamesLost / 3;
        int numberOfremovedKeyboard = gamesLost / (2 * 3);
        int numberOfRemovedDislay = gamesLost / (2 * 2 * 3);

        double totalSum = numberOfRemovedHeadphones * headsetPrice +
            numberOfRemovedMouse * mousePrice +
            numberOfremovedKeyboard * keyboardPrice +
            numberOfRemovedDislay * displayPrice;

        Console.WriteLine($"Rage expenses: {totalSum:F2} lv.");
    }
}

