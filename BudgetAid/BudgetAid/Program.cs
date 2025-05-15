using System;
using BudgetAid.Models;
using BudgetAid.Services;

namespace BudgetAid
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("  Selamat Datang di BudgetAid");
            Console.WriteLine("=======================================");

            var service = new ExpenseService();

            while (true)
            {
                Console.WriteLine("\n======= Menu =======");
                Console.WriteLine("1) Tambah Pengeluaran");
                Console.WriteLine("2) Hapus Pengeluaran");
                Console.WriteLine("3) Tampilkan Pengeluaran");
                Console.WriteLine("4) Keluar");
                Console.Write("Pilih opsi (1-4): ");

                string? input = Console.ReadLine()?.Trim();
                Console.WriteLine();

                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.Write("Masukan Deskripsi: ");
                            var deskripsi = Console.ReadLine()?.Trim();

                            Console.Write("Masukan Jumlah : ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal jumlah))
                            {
                                Console.WriteLine("❌ Format jumlah salah.");
                                break;
                            }

                            Console.Write("Masukan Tanggal (yyyy-MM-dd): ");
                            if (!DateTime.TryParse(Console.ReadLine(), out DateTime tanggal))
                            {
                                Console.WriteLine("Format tanggal salah.");
                                break;
                            }

                            Console.Write("Masukan Kategori (Makanan, Transportasi, Hiburan): ");
                            var kategori = Console.ReadLine()?.Trim();

                            if (string.IsNullOrWhiteSpace(deskripsi) || string.IsNullOrWhiteSpace(kategori))
                            {
                                Console.WriteLine("Deskripsi dan kategori tidak boleh kosong.");
                                break;
                            }

                            var added = service.AddExpense(deskripsi, jumlah, tanggal, kategori);
                            Console.WriteLine($"Berhasil ditambahkan: {added}");
                            break;

                        case "2":
                            var allExpenses = service.GetAllExpenses();
                            if (allExpenses.Count == 0)
                            {
                                Console.WriteLine("Tidak ada pengeluaran untuk dihapus.");
                                break;
                            }

                            Console.WriteLine("================ Daftar Pengeluaran ================");
                            for (int i = 0; i < allExpenses.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {allExpenses[i]}");
                            }

                            Console.Write("Pilih nomor yang ingin dihapus: ");
                            if (!int.TryParse(Console.ReadLine(), out int index) || index < 1 || index > allExpenses.Count)
                            {
                                Console.WriteLine(" Nomor tidak valid.");
                                break;
                            }

                            var toRemove = allExpenses[index - 1];
                            service.RemoveExpense(toRemove.Id);
                            Console.WriteLine(" Pengeluaran berhasil dihapus.");
                            break;

                        case "3":
                            var expenses = service.GetAllExpenses();
                            if (expenses.Count == 0)
                            {
                                Console.WriteLine("Belum ada pengeluaran yang dicatat.");
                            }
                            else
                            {
                                Console.WriteLine("================ Daftar Pengeluaran ================");
                                foreach (var expense in expenses)
                                {
                                    Console.WriteLine(expense);
                                }
                            }
                            break;

                        case "4":
                            Console.WriteLine("Terima kasih telah menggunakan BudgetAid. Sampai jumpa!");
                            return;

                        default:
                            Console.WriteLine("Opsi tidak valid. Pilih antara 1 - 4.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Terjadi error: {ex.Message}");
                }
            }
        }
    }
}
