using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICatatanPemasukan
{
    public partial class Form1: Form
    {
        private List<string>    CatatanPemasukan = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tanggal = dateTimePicker1.Value.ToString("dddd, dd MMMM yyyy");
            string nominal = textBox1.Text.Trim();
            string keterangan = textBox2.Text.Trim();

            // Validasi input
            if (!decimal.TryParse(nominal, out _) || string.IsNullOrEmpty(keterangan))
            {
                MessageBox.Show("Masukkan nominal dalam angka dan lengkapi keterangan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simpan data
            string data = $"Tanggal: {tanggal}" +
                $" Nominal: {nominal} " +
                $" Keterangan: {keterangan}";
            CatatanPemasukan.Add(data);

            // Tampilkan pesan sukses
            MessageBox.Show("Catatan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Bersihkan dulu isi ListBox

            if (CatatanPemasukan.Count == 0)
            {
                MessageBox.Show("Belum ada data pemasukan yang diinput.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tampilkan seluruh data ke ListBox
            foreach (string data in CatatanPemasukan)
            {
                listBox1.Items.Add(data);
            }

            // Langsung tampilkan juga detail data di MessageBox
            //string semuaData = string.Join(Environment.NewLine + Environment.NewLine, CatatanPemasukan);
            //MessageBox.Show("Daftar Catatan Pemasukan:\n\n" + semuaData, "Detail Pemasukan", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
