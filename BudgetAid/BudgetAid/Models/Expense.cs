using System;

namespace BudgetAid.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Deskripsi { get; set; }
        public decimal Jumlah { get; set; }
        public DateTime Tanggal { get; set; }
        public string Kategori { get; set; }

        public Expense(string deskripsi, decimal jumlah, DateTime tanggal, string kategori)
        {
            Id = Guid.NewGuid();
            Deskripsi = deskripsi;
            Jumlah = jumlah;
            Tanggal = tanggal;
            Kategori = kategori;
        }

        public override string ToString()
        {
            return $"{Tanggal.ToShortDateString()} | {Kategori,-15} | {Deskripsi,-30} | Rp {Jumlah:N0}";
        }
    }
}
