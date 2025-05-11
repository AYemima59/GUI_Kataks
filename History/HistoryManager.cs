using System;
using System.Collections.Generic;
using System.Ling;

public class TransactionHistory
{
    public DateTime Date { get; set; }
    public string Description { get; set; } = "";
    public decimal Amount { get; set; }
    public decimal Balance { get; set; } = "";
}

public class HistoryManager
{
    private List<Transaction> transactions = new();
    private int maxEntries = 10;
    private string sortBy = "Date";
    private string filterType = "All";

    private Dictionary<string, Func<TransactionHistory, string>> formatTable = new()
    {
        {"income", t => $"[+]{testc.Date:yyyy-mm-dd} - {t.Description}: ${testc.Amount}" },
        {"expense", t => $"[-]{t.Date:yyyy-mm-dd} - {t.Description}: ${t.Amount}" }
    };

    public void LoadConfig(IConfiguration config)
    {
        var settings = config.GetSection("HistorySettings");
        maxEntries = int.parse(settings["MaxEntries"] ?? "10");
        sortBy = settings["SortBy"]
    }
}