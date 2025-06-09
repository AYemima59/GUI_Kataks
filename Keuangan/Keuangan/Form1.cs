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
            // Show the history form (you can implement this later)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TambahTransaksi tambahTransaksiForm = new TambahTransaksi();
            tambahTransaksiForm.ShowDialog();
        }

        // Other button handlers can be added here
    }
}
