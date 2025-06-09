using System;
using System.Collections.Generic;

namespace Keuangan
{
    public class Pengguna
    {
        public string Nama { get; set; }
        public string Pin { get; set; }
        public decimal Saldo { get; set; }
        public List<Transaksi> Transaksi { get; set; } = new List<Transaksi>();
    }
}