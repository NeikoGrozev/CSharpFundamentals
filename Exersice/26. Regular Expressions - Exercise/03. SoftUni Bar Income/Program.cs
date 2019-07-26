namespace SoftUniBarIncome
{
    using System;    
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = $@"^\%(?<name>[A-Z][a-z]*)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[0-9]+\.*[0-9]*)\$";

            Regex regex = new Regex(pattern);

            double totalIncome = 0.0;           

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                Match match = regex.Match(input);                

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double sum = quantity * price;
                    totalIncome += sum;

                    Console.WriteLine($"{name}: {product} - {sum:F2}");                    
                }
            }     

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
