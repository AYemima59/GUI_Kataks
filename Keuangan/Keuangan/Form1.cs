using GUIKATAK;

namespace Keuangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CekSaldo cekSaldoForm = new CekSaldo();
            cekSaldoForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            History historyForm = new History();
            historyForm.ShowDialog();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Simulasi simulasi = new Simulasi();
            simulasi.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahTransaksiForm = new TambahTransaksi();
            tambahTransaksiForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Logout: hapus user aktif
            Session.CurrentUser = null;

            // Tampilkan kembali form login
            this.Hide();
            var loginForm = new LoginRegister();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Jika login berhasil, tampilkan Form1 lagi
                this.Show();
            }
            else
            {
                // Jika tidak login, tutup aplikasi
                this.Close();
            }
        }


        // Other button handlers can be added here
    }
}
