using System;
using System.Collections.Generic;

namespace Pemasukan
{
    public class PengelolaPemasukan
    {
        private List<CatatanPemasukan<int>> daftarPemasukan = new List<CatatanPemasukan<int>>();

        public void TambahPemasukan()
        {
            Console.Write("Masukkan ID (angka): ");
            string? inputId = Console.ReadLine();
            bool validId = int.TryParse(inputId, out int id);
            if (!validId)
            {
                Console.WriteLine("ID harus berupa angka!");
                return;
            }

            Console.Write("Masukkan tanggal (yyyy-MM-dd): ");
            string? inputTanggal = Console.ReadLine();
            if (!DateTime.TryParse(inputTanggal, out DateTime tanggal))
            {
                Console.WriteLine("Format tanggal salah!");
                return;
            }

            Console.Write("Masukkan nominal: ");
            string? inputNominal = Console.ReadLine();
            if (!int.TryParse(inputNominal, out int nominal))
            {
                Console.WriteLine("Nominal harus berupa angka!");
                return;
            }

            Console.Write("Masukkan jenis pemasukan: ");
            string jenis = Console.ReadLine() ?? "Tidak Diketahui";

            daftarPemasukan.Add(new CatatanPemasukan<int>(id, tanggal, nominal, jenis));
            Console.WriteLine("Pemasukan berhasil ditambahkan!");
        }

   

        public int HitungTotalPemasukan()
        {
            int total = 0;
            foreach (var catatan in daftarPemasukan)
            {
                total += catatan.Nominal;
            }
            Console.WriteLine($"Total uang anda: {total}");
            return total;
        }
        public List<CatatanPemasukan<int>> GetDaftarPemasukan()
        {
            return daftarPemasukan;
        }
        public void Jalankan()
        {
            bool jalan = true;
            while (jalan)
            {
                Console.WriteLine("\n=== Menu Aplikasi Pemasukan ===");
                Console.WriteLine("1. Tambah Pemasukan");
                Console.WriteLine("2. Tampilkan Total Uang");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");
                string? pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        TambahPemasukan();
                        break;
                    case "2":
                        HitungTotalPemasukan();
                        break;
                    case "3":
                        Console.Write("Anda sudah keluar. Ingin kembali? (yes/no): ");
                        string? kembali = Console.ReadLine()?.ToLower();
                        if (kembali == "yes")
                        {
                            break; 
                        }
                        else
                        {
                            jalan = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        break;
                }
            }
        }
    }
}
