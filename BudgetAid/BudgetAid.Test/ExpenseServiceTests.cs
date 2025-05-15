using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BudgetAid.Models;
using BudgetAid.Services;
using System.Linq;

namespace BudgetAid.Tests
{
    [TestClass]
    public class ExpenseServiceTests
    {
        private ExpenseService service;

        [TestInitialize]
        public void Setup()
        {
            service = new ExpenseService();
        }

        [TestMethod]
        public void AddExpense_ShouldAddExpenseCorrectly()
        {
            // Arrange
            string deskripsi = "Nasi Goreng";
            decimal jumlah = 25000m;
            DateTime tanggal = new DateTime(2025, 5, 16);
            string kategori = "Makanan";

            // Act
            var result = service.AddExpense(deskripsi, jumlah, tanggal, kategori);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(deskripsi, result.Deskripsi);
            Assert.AreEqual(jumlah, result.Jumlah);
            Assert.AreEqual(tanggal, result.Tanggal);
            Assert.AreEqual(kategori, result.Kategori);

            // Pastikan pengeluaran benar-benar tersimpan di list
            var allExpenses = service.GetAllExpenses();
            Assert.IsTrue(allExpenses.Any(e => e.Id == result.Id));
        }

        [TestMethod]
        public void RemoveExpense_ShouldRemoveExistingExpense()
        {
            // Arrange
            var expense = service.AddExpense("Beli Kopi", 15000m, DateTime.Now, "Minuman");
            var id = expense.Id;

            // Act
            service.RemoveExpense(id);

            // Assert
            var allExpenses = service.GetAllExpenses();
            Assert.IsFalse(allExpenses.Any(e => e.Id == id));
        }

        [TestMethod]
        public void GetAllExpenses_ShouldReturnAllAddedExpenses()
        {
            // Arrange
            service.AddExpense("Makan Siang", 30000m, DateTime.Today, "Makanan");
            service.AddExpense("Naik Bus", 5000m, DateTime.Today, "Transportasi");

            // Act
            var allExpenses = service.GetAllExpenses();

            // Assert
            Assert.AreEqual(2, allExpenses.Count);
            Assert.IsTrue(allExpenses.Any(e => e.Deskripsi == "Makan Siang"));
            Assert.IsTrue(allExpenses.Any(e => e.Deskripsi == "Naik Bus"));
        }
    }
}
