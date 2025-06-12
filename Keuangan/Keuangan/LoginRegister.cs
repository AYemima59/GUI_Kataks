using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Keuangan
{
    public partial class LoginRegister : Form
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string pin = txtPin.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(pin))
            {
                lblStatus.Text = "Nama dan PIN harus diisi!";
                return;
            }

            string filePath = "data_pengguna.json";
            if (!File.Exists(filePath))
            {
                lblStatus.Text = "Data pengguna tidak ditemukan!";
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(filePath);
                var penggunaList = JsonSerializer.Deserialize<List<Pengguna>>(jsonData) ?? new List<Pengguna>();

                var user = penggunaList.FirstOrDefault(p =>
                    p.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase) && p.Pin == pin);

                if (user != null)
                {
                    Session.CurrentUser = user;
                    lblStatus.Text = "Login berhasil!";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    lblStatus.Text = "Nama atau PIN salah!";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string pin = txtPin.Text.Trim();

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(pin))
            {
                lblStatus.Text = "Nama dan PIN harus diisi!";
                return;
            }

            if (pin.Length < 4)
            {
                lblStatus.Text = "PIN minimal 4 digit!";
                return;
            }

            try
            {
                string filePath = "data_pengguna.json";
                List<Pengguna> penggunaList = new List<Pengguna>();

                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    penggunaList = JsonSerializer.Deserialize<List<Pengguna>>(jsonData) ?? new List<Pengguna>();
                }

                // Cek apakah nama sudah ada
                if (penggunaList.Any(p => p.Nama.Equals(nama, StringComparison.OrdinalIgnoreCase)))
                {
                    lblStatus.Text = "Nama pengguna sudah ada!";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                // Buat pengguna baru
                Pengguna penggunaBaru = new Pengguna
                {
                    Nama = nama,
                    Pin = pin,
                    Saldo = 0,
                    Transaksi = new List<Transaksi>()
                };

                penggunaList.Add(penggunaBaru);
                Session.CurrentUser = penggunaBaru;

                // Simpan ke file
                string jsonBaru = JsonSerializer.Serialize(penggunaList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonBaru);

                lblStatus.Text = "Registrasi berhasil!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
