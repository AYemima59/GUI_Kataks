using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json");

var config = builder.Build();
Console.WriteLine("welcome to money management app history");
Console.WriteLine("Enter month:");
string month = Console.ReadLine();

var income = config[$"History:{month}:Income"];
var spending = config[$"History:{month}:Spending"];

Console.WriteLine($"Income: {income}");
Console.WriteLine($"Spending: {spending}");
