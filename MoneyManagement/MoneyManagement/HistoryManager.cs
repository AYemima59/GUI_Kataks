using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


public class Transaction
{
    public DateTime Date { get; set; }
    public string Description { get; set; } = "";
    public decimal Amount { get; set; }
    public string Type { get; set; } = "";
}

namespace MoneyManagement
{
    public class HistoryManager
    {
        private List<Transaction> transactions = new();
        private int maxEntries = 10;
        private string sortBy = "Date";
        private string filterType = "All";

        private Dictionary<string, Func<Transaction, string>> formatTable = new()
    {
        { "income", t => $"[+]{t.Date:yyyy-MM-dd} - {t.Description}: ${t.Amount}" },
        { "expense", t => $"[-]{t.Date:yyyy-MM-dd} - {t.Description}: ${t.Amount}" }
    };

        public void LoadConfig(IConfiguration config)
        {
            var settings = config.GetSection("HistorySettings");
            maxEntries = int.Parse(settings["MaxEntries"] ?? "10");
            sortBy = settings["SortBy"] ?? "Date";
            filterType = settings["FilterType"] ?? "All";
        }

        public void AddTransaction(Transaction t) => transactions.Add(t);

        public IReadOnlyList<Transaction> Transactions => transactions;

        public void DisplayHistory()
        {
            IEnumerable<Transaction> filtered = transactions;

            if (filterType.ToLower() != "all")
                filtered = filtered.Where(t => t.Type.ToLower() == filterType.ToLower());

            filtered = sortBy.ToLower() switch
            {
                "amount" => filtered.OrderByDescending(t => t.Amount),
                _ => filtered.OrderByDescending(t => t.Date)
            };

            foreach (var t in filtered.Take(maxEntries))
            {
                string output = formatTable.ContainsKey(t.Type.ToLower())
                    ? formatTable[t.Type.ToLower()](t)
                    : $"{t.Date} - {t.Description} - ${t.Amount}";
                Console.WriteLine(output);
            }
        }

    }
}
