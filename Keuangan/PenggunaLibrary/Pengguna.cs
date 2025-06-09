using System;
using System.Collections.Generic;

namespace PenggunaLibrary
{
    public class Pengguna
    {
        public string Nama { get; set; }
        public string Pin { get; set; }
        public decimal Saldo { get; set; }
        public List<Transaksi> Transaksi { get; set; }
    }

    public class Transaksi
    {
        // Define properties for Transaksi class here
    }
}