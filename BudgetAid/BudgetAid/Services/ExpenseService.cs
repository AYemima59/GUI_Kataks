using System;
using System.Collections.Generic;
using BudgetAid.Models;

namespace BudgetAid.Services
{
    public class ExpenseService
    {
        private readonly List<Expense> _expenses = new();

        public Expense AddExpense(string deskripsi, decimal jumlah, DateTime tanggal, string kategori)
        {
            if (string.IsNullOrWhiteSpace(deskripsi)) throw new ArgumentException("Deskripsi Tidak Boleh Kosong");
            if (jumlah < 0) throw new ArgumentException("Jumlah Pengeluaran Tidak Boleh Minus !!");
            if (string.IsNullOrWhiteSpace(kategori)) throw new ArgumentException("Kategori juga Tidak Boleh Kosong");

            var expense = new Expense(deskripsi, jumlah, tanggal, kategori);
            _expenses.Add(expense);
            return expense;
        }

        public List<Expense> GetAllExpenses()
        {
            return _expenses;
        }

        public bool RemoveExpense(Guid id)
        {
            var expense = _expenses.Find(e => e.Id == id);
            if (expense != null)
            {
                _expenses.Remove(expense);
                return true;
            }
            return false;
        }
    }
}
