using System;

class PadawanEquipment
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double lightsabersPrice = double.Parse(Console.ReadLine());
        double robesPrice = double.Parse(Console.ReadLine());
        double beltsPrice = double.Parse(Console.ReadLine());

        double lightsabersSum = Math.Ceiling (students * 1.1) * lightsabersPrice;
        double robesSum = students * robesPrice;              
        double beltsSum = ((students - (students / 6)) * beltsPrice);

        double totalSum = lightsabersSum + robesSum + beltsSum;

        double diff = Math.Abs (money - totalSum);

        if (money >= totalSum)
        {
            Console.WriteLine("The money is enough - it would cost {0:F2}lv.", totalSum);
        }
        else
        {
            Console.WriteLine("Ivan Cho will need {0:F2}lv more.", diff);
        }
    }
}

