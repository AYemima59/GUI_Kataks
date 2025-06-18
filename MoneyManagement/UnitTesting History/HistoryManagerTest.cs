using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManagement;

namespace MoneyManagement
{
    internal class HistoryManagerTest
    {
        public void AddTransaction_AddsOneTransaction()
        {
            // Arrange
            var manager = new HistoryManager();
            var transaction = new Transaction
            {
                Date = DateTime.Today,
                Description = "Test",
                Amount = 100,
                Type = "income"
            };

            // Act
            manager.AddTransaction(transaction);

            // Assert - You'll need to expose a method or property to verify this.
            // For now, just ensure no exceptions were thrown.
            Assert.AreEqual(1, manager.Transactions.Count);

        }
    }
}
