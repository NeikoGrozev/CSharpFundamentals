namespace Furniture
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = $@">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>[0-9]+)";
            Regex regex = new Regex(pattern);
            double totalSum = 0.0;                     

            Console.WriteLine("Bought furniture:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    
                    Console.WriteLine($"{name}");

                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalSum += price * quantity;
                }
            }
           
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
