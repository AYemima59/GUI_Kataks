using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            TulisTengah("=== Selamat Datang di Simulasi Tabungan BudgetAid ===\n");
            TulisTengah("Aplikasi ini membantu Anda menghitung total tabungan berdasarkan waktu dan nominal yang Anda pilih.");
            TulisTengah("Anda bisa memilih menabung mingguan, bulanan, atau tahunan sesuai dengan tujuan finansial Anda.\n");

            TulisTengah("Ketik 'Y' untuk melanjutkan atau tombol lain untuk keluar: ");
            string lanjut = Console.ReadLine();

            if (string.Equals(lanjut, "Y", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                break;
            }
            else
            {
                TulisTengah("Yakin ingin keluar? (Y/N): ");
                string konfirmasi = Console.ReadLine();

                if (string.Equals(konfirmasi, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    TulisTengah("\nTerima kasih. Sampai jumpa!");
                    return;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }

        Console.WriteLine("Pilih Jangka waktu Menabung:");
        Console.WriteLine("1. Tahunan");
        Console.WriteLine("2. Bulanan");
        Console.WriteLine("3. Mingguan");
        Console.Write("Pilih (1-3): ");
        string pilihan = Console.ReadLine();

        (string tipe, int batasMaks) = DapatkanJenisTabungan(pilihan);
        if (tipe == null)
        {
            Console.WriteLine("Pilihan tidak valid.");
            return;
        }

        Console.WriteLine($"\nAnda mau menabung berapa {tipe}?");
        Console.Write($"Pilih 1 - {batasMaks}: ");
        if (!int.TryParse(Console.ReadLine(), out int jumlahWaktu) || jumlahWaktu < 1 || jumlahWaktu > batasMaks)
        {
            Console.WriteLine("Input waktu tidak valid.");
            return;
        }

        Console.WriteLine("\nMasukkan Nominal Anda");
        Console.Write("Contoh 5000\nNominal : ");
        if (!int.TryParse(Console.ReadLine(), out int nominal) || nominal <= 0)
        {
            Console.WriteLine("Nominal harus berupa angka positif.");
            return;
        }

        int total = HitungTotal(jumlahWaktu, nominal);

        Console.WriteLine("\n=== Output ===");
        Console.WriteLine($"Jika anda Menabung {jumlahWaktu} {tipe} Dengan Nominal {nominal:N0}");
        Console.WriteLine($"Maka Tabungan anda {total:N0}");

        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }

    public static void TulisTengah(string teks)
    {
        int lebar = Console.WindowWidth;
        int spasi = (lebar - teks.Length) / 2;
        Console.WriteLine(new string(' ', Math.Max(spasi, 0)) + teks);
    }


    public static int HitungTotal(int jumlah, int nominal)
    {
        //pre
        if (jumlah <= 0) throw new ArgumentException("Jumlah waktu harus lebih dari 0");
        if (nominal <= 0) throw new ArgumentException("Nominal harus lebih dari 0");

        int total = jumlah * nominal;

        //post
        if (total < 0) throw new InvalidOperationException("Total tabungan tidak boleh negatif");

        return total;
    }

    public static (string tipe, int batasMaks) DapatkanJenisTabungan(string pilihan)
    {
        (string tipe, int batasMaks) result = pilihan switch
        {
            "1" => ("Tahun", 10),
            "2" => ("Bulan", 12),
            "3" => ("Minggu", 4),
            _ => (null, 0)
        };

        if (result.tipe == null && result.batasMaks != 0)
            throw new InvalidOperationException("Jika tipe null, batas maksimal harus 0");

        return result;
    }

    public static void PilihJangkaWaktu(ref string tipe, ref int batasMaks)
    {
        string pilihan = Console.ReadLine();

        switch (pilihan)
        {
            case "1":
                tipe = "Tahun";
                batasMaks = 10;
                break;
            case "2":
                tipe = "Bulan";
                batasMaks = 12;
                break;
            case "3":
                tipe = "Minggu";
                batasMaks = 4;
                break;
            default:
                tipe = null;
                batasMaks = 0;
                break;
        }
    }

    public static int InputWaktu()
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int jumlahWaktu) && jumlahWaktu > 0)
        {
            return jumlahWaktu;
        }
        return 0;
    }

    public static int InputNominal()
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int nominal) && nominal > 0)
        {
            return nominal;
        }
        return 0;
    }
}
