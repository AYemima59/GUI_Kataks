using NUnit.Framework;
using System;
using System.IO;

namespace TabunganTests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void HitungTotal_ShouldReturnCorrectResult()
        {
            int hasil = Program.HitungTotal(5, 1000);
            Assert.That(hasil, Is.EqualTo(5000));
        }

        [TestCase("1", "Tahun", 10)]
        [TestCase("2", "Bulan", 12)]
        [TestCase("3", "Minggu", 4)]
        [TestCase("9", "", 0)]
        public void DapatkanJenisTabungan_ShouldReturnCorrectValues(string input, string expectedTipe, int expectedBatas)
        {
            var (tipe, batas) = Program.DapatkanJenisTabungan(input);

            if (expectedTipe == "")
                Assert.IsNull(tipe);
            else
                Assert.AreEqual(expectedTipe, tipe);

            Assert.AreEqual(expectedBatas, batas);
        }

        [TestCase("1", "Tahun", 10)]
        [TestCase("2", "Bulan", 12)]
        [TestCase("3", "Minggu", 4)]
        [TestCase("9", "", 0)]
        public void PilihJangkaWaktu_ShouldSetCorrectValues(string input, string expectedTipe, int expectedBatas)
        {
            var reader = new StringReader(input);
            Console.SetIn(reader);

            string tipe = "init"; // supaya keliatan berubah
            int batasMaks = -1;
            Program.PilihJangkaWaktu(ref tipe, ref batasMaks);

            if (string.IsNullOrEmpty(expectedTipe))
            {
                Assert.IsNull(tipe);
            }
            else
            {
                Assert.AreEqual(expectedTipe, tipe);
            }
            Assert.AreEqual(expectedBatas, batasMaks);
        }


        [TestCase("5", 5)]
        [TestCase("abc", 0)]
        [TestCase("-1", 0)]
        public void InputWaktu_ShouldParseCorrectly(string input, int expected)
        {
            Console.SetIn(new StringReader(input));
            int result = Program.InputWaktu();
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("5000", 5000)]
        [TestCase("-500", 0)]
        [TestCase("abc", 0)]
        public void InputNominal_ShouldParseCorrectly(string input, int expected)
        {
            Console.SetIn(new StringReader(input));
            int result = Program.InputNominal();
            Assert.That(result, Is.EqualTo(expected));
        }

    }
}
