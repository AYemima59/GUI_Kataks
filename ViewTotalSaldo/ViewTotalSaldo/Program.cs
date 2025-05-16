using System;
using System.IO;
using System.Text.Json;
using PenggunaLibrary;

namespace SaldoBankJson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Aplikasi Cek Saldo ===");

            string filePath = "data_pengguna.json";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File data pengguna tidak ditemukan!");
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(filePath);
                var penggunaList = JsonSerializer.Deserialize<Pengguna[]>(jsonData);

                Console.Write("Masukkan Nama Pengguna: ");
                string namaInput = Console.ReadLine();

                Console.Write("Masukkan PIN: ");
                string pinInput = Console.ReadLine();

                Pengguna pengguna = Array.Find(penggunaList, p =>
                    p.Nama.Equals(namaInput, StringComparison.OrdinalIgnoreCase) &&
                    p.Pin == pinInput);

                if (pengguna != null)
                {
                    Console.WriteLine($"\nData Pengguna:");
                    Console.WriteLine($"Nama: {pengguna.Nama}");
                    Console.WriteLine($"Saldo: {pengguna.Saldo:C}");
                }
                else
                {
                    Console.WriteLine("Pengguna tidak ditemukan atau PIN salah!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}
