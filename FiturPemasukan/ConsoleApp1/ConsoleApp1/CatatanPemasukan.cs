namespace Pemasukan
{
    public class CatatanPemasukan<T>
    {
        public T ID { get; set; }
        public DateTime Tanggal { get; set; }
        public int Nominal { get; set; }
        public string Jenis { get; set; } = string.Empty;

        public CatatanPemasukan(T id, DateTime tanggal, int nominal, string jenis)
        {
            ID = id;
            Tanggal = tanggal;
            Nominal = nominal;
            Jenis = jenis;
        }
    }
}