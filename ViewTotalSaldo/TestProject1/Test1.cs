using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaldoBankJson;
using System;
using System.IO;
using System.Text.Json;

namespace TestProject1
{
    [TestClass]
    public class Test1
    {
        private string testFilePath = "data_pengguna.json";

        [TestInitialize]
        public void Setup()
        {
            // Create test data and save to JSON file
            var testData = new Program.Pengguna[]
            {
                new Program.Pengguna { Nama = "TestUser1", Pin = "1234", Saldo = 1000.0m },
                new Program.Pengguna { Nama = "TestUser2", Pin = "5678", Saldo = 2000.0m }
            };

            string jsonData = JsonSerializer.Serialize(testData);
            using (var stream = new FileStream(testFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                JsonSerializer.Serialize(stream, testData);
            }

        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFilePath))
            {
                try
                {
                    File.Delete(testFilePath);
                }
                catch (IOException)
                {
                    System.Threading.Thread.Sleep(100); // Tunggu sedikit lalu coba lagi
                    File.Delete(testFilePath);
                }
            }
        }


        [TestMethod]
        public void TestFindExistingPengguna()
        {
            // Arrange
            string jsonData = File.ReadAllText(testFilePath);
            var penggunaList = JsonSerializer.Deserialize<Program.Pengguna[]>(jsonData);

            // Act
            var result = Array.Find(penggunaList, p =>
                p.Nama.Equals("TestUser1", StringComparison.OrdinalIgnoreCase) &&
                p.Pin == "1234");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("TestUser1", result.Nama);
            Assert.AreEqual("1234", result.Pin);
            Assert.AreEqual(1000.0m, result.Saldo);
        }

        [TestMethod]
        public void TestFindPenggunaWithWrongPin()
        {
            // Arrange
            string jsonData = File.ReadAllText(testFilePath);
            var penggunaList = JsonSerializer.Deserialize<Program.Pengguna[]>(jsonData);

            // Act
            var result = Array.Find(penggunaList, p =>
                p.Nama.Equals("TestUser1", StringComparison.OrdinalIgnoreCase) &&
                p.Pin == "wrong");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestFindNonExistentPengguna()
        {
            // Arrange
            string jsonData = File.ReadAllText(testFilePath);
            var penggunaList = JsonSerializer.Deserialize<Program.Pengguna[]>(jsonData);

            // Act
            var result = Array.Find(penggunaList, p =>
                p.Nama.Equals("NonExistentUser", StringComparison.OrdinalIgnoreCase) &&
                p.Pin == "1234");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestFileNotFound()
        {
            // Arrange
            string nonExistentFilePath = "non_existent_file.json";

            // Act & Assert
            Assert.IsFalse(File.Exists(nonExistentFilePath));
        }
    }
}