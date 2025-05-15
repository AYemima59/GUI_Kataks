using Microsoft.Extensions.Configuration;
using MoneyManagement;

namespace MoneyManagement
{
    class Program
    {
        static void Main()
        {
            var builder = new ConfigurationBuilder()
         .AddJsonFile("appsettings.json");

            var config = builder.Build();

            Console.WriteLine("Enter month :");
            string month = Console.ReadLine();

            var section = config.GetSection($"History:{month}");

            if (section.Exists())
            {
                var income = section["Income"];
                var spending = section["Spending"];

                Console.WriteLine($"Income: {income}");
                Console.WriteLine($"Spending: {spending}");
            }
            else
            {
                Console.WriteLine("Month data not found.");
            }
        }
    }
}

