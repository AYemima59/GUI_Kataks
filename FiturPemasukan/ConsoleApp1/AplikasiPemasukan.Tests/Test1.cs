using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pemasukan;
using System;

namespace AplikasiPemasukan.Tests
{
    [TestClass]
    public class PengelolaPemasukanTests
    {
        [TestMethod]
        public void TambahPemasukan_ManualData_TotalTersimpanBenar()
        {
            var pengelola = new PengelolaPemasukan();
            pengelola.GetDaftarPemasukan().Add(new CatatanPemasukan<int>(1, DateTime.Now, 100000, "Hadiah"));

            int total = pengelola.HitungTotalPemasukan();
            Assert.AreEqual(100000, total);
        }
        [TestMethod]
        public void TampilkanTotalPemasukan_Benar()
        {
            var pengelola = new PengelolaPemasukan();
            pengelola.GetDaftarPemasukan().Add(new CatatanPemasukan<int>(1, DateTime.Now, 50000, "Gaji"));
            pengelola.GetDaftarPemasukan().Add(new CatatanPemasukan<int>(2, DateTime.Now, 75000, "Bonus"));

            int total = pengelola.HitungTotalPemasukan();
            Assert.AreEqual(125000, total);

            // Simulasi output ke konsol (hanya di test saja)
            Console.WriteLine($"Total Pemasukan: {total}");
        }
      

    }
}