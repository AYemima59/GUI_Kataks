using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;
using PenggunaLibrary;

// Jika Transaksi belum ada di PenggunaLibrary, tambahkan definisi berikut:
public class Transaksi
{
    public string Tanggal { get; set; }
    public string Jenis { get; set; }
    public double Jumlah { get; set; }
}

namespace Keuangan
{
    public partial class TambahTransaksi : Form
    {
        // Hapus atau komentari field yang tidak diperlukan
        // private TextBox txtNama;
        // private TextBox txtPin;
        // private TextBox txtSaldoAwal;
        private NumericUpDown numJumlahTransaksi;
        private Button btnTambahTransaksi;
        private Button btnSimpan;
        private Label lblNama;
        // private Label lblPin;
        // private Label lblSaldoAwal;
        private Label lblJumlahTransaksi;
        private Panel panelTransaksi;
        private Panel panelUtama;
        private Label lblStatus;
        private List<Panel> transaksiPanels = new List<Panel>();
        private Label lblSaldoInfo;

        public TambahTransaksi()
        {
            InitializeComponent();
            SetupUI();

            // Tampilkan info user yang login
            if (Session.CurrentUser != null)
            {
                lblNama.Text = $"Nama: {Session.CurrentUser.Nama}";
                lblSaldoInfo.Visible = true;
                lblSaldoInfo.Text = $"Saldo saat ini: {Session.CurrentUser.Saldo:C}";
            }
            else
            {
                lblNama.Text = "User belum login!";
                lblStatus.Text = "Error: Silakan login terlebih dahulu!";
            }
        }

        private void InitializeComponent()
        {
            // Hapus inisialisasi komponen yang tidak diperlukan
            // this.txtNama = new TextBox();
            // this.txtPin = new TextBox();
            // this.txtSaldoAwal = new TextBox();
            this.numJumlahTransaksi = new NumericUpDown();
            this.btnTambahTransaksi = new Button();
            this.btnSimpan = new Button();
            this.lblNama = new Label();
            // this.lblPin = new Label();
            // this.lblSaldoAwal = new Label();
            this.lblJumlahTransaksi = new Label();
            this.panelTransaksi = new Panel();
            this.panelUtama = new Panel();
            this.lblStatus = new Label();
            this.lblSaldoInfo = new Label();

            ((ISupportInitialize)this.numJumlahTransaksi).BeginInit();
            this.SuspendLayout();

            // Form properties
            this.ClientSize = new Size(800, 600);
            this.Text = "Tambah Transaksi";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Main Panel - ukuran lebih kecil karena tidak ada input nama/PIN
            this.panelUtama = new Panel();
            this.panelUtama.Location = new Point(20, 20);
            this.panelUtama.Size = new Size(760, 120); // Lebih kecil
            this.panelUtama.BorderStyle = BorderStyle.FixedSingle;
            this.panelUtama.Padding = new Padding(10);
            this.Controls.Add(this.panelUtama);

            // Label nama (hanya untuk menampilkan, bukan input)
            this.lblNama = new Label();
            this.lblNama.Text = "Nama: ";
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new Font("Arial", 10F, FontStyle.Bold);
            this.lblNama.Location = new Point(20, 20);
            this.panelUtama.Controls.Add(this.lblNama);

            // Saldo info label - selalu tampil
            this.lblSaldoInfo = new Label();
            this.lblSaldoInfo.AutoSize = false;
            this.lblSaldoInfo.Size = new Size(300, 30);
            this.lblSaldoInfo.BorderStyle = BorderStyle.FixedSingle;
            this.lblSaldoInfo.TextAlign = ContentAlignment.MiddleLeft;
            this.lblSaldoInfo.Location = new Point(20, 50);
            this.lblSaldoInfo.Font = new Font("Arial", 10F);
            this.panelUtama.Controls.Add(this.lblSaldoInfo);

            // Jumlah transaksi
            this.lblJumlahTransaksi = new Label();
            this.lblJumlahTransaksi.Text = "Jumlah Transaksi:";
            this.lblJumlahTransaksi.AutoSize = true;
            this.lblJumlahTransaksi.Location = new Point(400, 20);
            this.panelUtama.Controls.Add(this.lblJumlahTransaksi);

            this.numJumlahTransaksi = new NumericUpDown();
            this.numJumlahTransaksi.Location = new Point(520, 20);
            this.numJumlahTransaksi.Size = new Size(80, 30);
            this.numJumlahTransaksi.Minimum = 1;
            this.numJumlahTransaksi.Maximum = 10;
            this.numJumlahTransaksi.Value = 1;
            this.panelUtama.Controls.Add(this.numJumlahTransaksi);

            this.btnTambahTransaksi = new Button();
            this.btnTambahTransaksi.Text = "Buat Form";
            this.btnTambahTransaksi.Location = new Point(610, 20);
            this.btnTambahTransaksi.Size = new Size(100, 30);
            this.btnTambahTransaksi.Click += btnTambahTransaksi_Click;
            this.panelUtama.Controls.Add(this.btnTambahTransaksi);

            // Panel for transactions - posisi disesuaikan
            this.panelTransaksi = new Panel();
            this.panelTransaksi.AutoScroll = true;
            this.panelTransaksi.Location = new Point(20, 160); // Disesuaikan
            this.panelTransaksi.Size = new Size(760, 320);
            this.panelTransaksi.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(this.panelTransaksi);

            // Save button
            this.btnSimpan = new Button();
            this.btnSimpan.Text = "Simpan Transaksi";
            this.btnSimpan.Location = new Point(650, 490);
            this.btnSimpan.Size = new Size(130, 40);
            this.btnSimpan.Click += btnSimpan_Click;
            this.Controls.Add(this.btnSimpan);

            // Status label
            this.lblStatus = new Label();
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new Point(20, 500);
            this.Controls.Add(this.lblStatus);

            ((ISupportInitialize)this.numJumlahTransaksi).EndInit();
            this.ResumeLayout(false);
        }

        private void SetupUI()
        {
            // Set up default UI state
            CreateTransactionPanels(); // Create initial transaction panel
        }

        // Hapus method btnVerify_Click karena tidak diperlukan lagi

        private void CreateTransactionPanels()
        {
            int count = (int)numJumlahTransaksi.Value;
            panelTransaksi.Controls.Clear();
            transaksiPanels.Clear();

            // Calculate the width of the transaction panel
            int panelWidth = panelTransaksi.Width - 30; // Accounting for padding and scrollbar

            for (int i = 0; i < count; i++)
            {
                // Create a panel for each transaction
                Panel transPanel = new Panel();
                transPanel.BorderStyle = BorderStyle.FixedSingle;
                transPanel.Size = new Size(panelWidth, 120);
                transPanel.Location = new Point(10, 10 + i * 130);
                transPanel.Tag = i; // Store the index

                // Label for transaction number
                Label lblTransNo = new Label();
                lblTransNo.Text = $"Transaksi #{i + 1}";
                lblTransNo.Font = new Font(lblTransNo.Font, FontStyle.Bold);
                lblTransNo.AutoSize = true;
                lblTransNo.Location = new Point(10, 10);
                transPanel.Controls.Add(lblTransNo);

                // Tanggal label and text box
                Label lblTanggal = new Label();
                lblTanggal.Text = "Tanggal (yyyy-mm-dd):";
                lblTanggal.AutoSize = true;
                lblTanggal.Location = new Point(10, 40);
                transPanel.Controls.Add(lblTanggal);

                TextBox txtTanggal = new TextBox();
                txtTanggal.Location = new Point(160, 40);
                txtTanggal.Size = new Size(200, 30);
                txtTanggal.Name = $"txtTanggal_{i}";
                txtTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
                transPanel.Controls.Add(txtTanggal);

                // Jenis label and combo box
                Label lblJenis = new Label();
                lblJenis.Text = "Jenis:";
                lblJenis.AutoSize = true;
                lblJenis.Location = new Point(10, 70);
                transPanel.Controls.Add(lblJenis);

                ComboBox cboJenis = new ComboBox();
                cboJenis.Location = new Point(160, 70);
                cboJenis.Size = new Size(200, 30);
                cboJenis.Name = $"cboJenis_{i}";
                cboJenis.DropDownStyle = ComboBoxStyle.DropDownList;
                cboJenis.Items.AddRange(new object[] { "Pemasukan", "Pengeluaran" });
                cboJenis.SelectedIndex = 0; // Default to "Pemasukan"
                transPanel.Controls.Add(cboJenis);

                // Jumlah label and text box
                Label lblJumlah = new Label();
                lblJumlah.Text = "Jumlah:";
                lblJumlah.AutoSize = true;
                lblJumlah.Location = new Point(380, 40);
                transPanel.Controls.Add(lblJumlah);

                TextBox txtJumlah = new TextBox();
                txtJumlah.Location = new Point(450, 40);
                txtJumlah.Size = new Size(200, 30);
                txtJumlah.Name = $"txtJumlah_{i}";
                transPanel.Controls.Add(txtJumlah);

                // Add to the panel and the list
                panelTransaksi.Controls.Add(transPanel);
                transaksiPanels.Add(transPanel);
            }
        }

        private void btnTambahTransaksi_Click(object sender, EventArgs e)
        {
            CreateTransactionPanels();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session.CurrentUser == null)
                {
                    lblStatus.Text = "Error: Anda belum login!";
                    return;
                }

                string filePath = "data_pengguna.json";
                List<Pengguna> penggunaList = new List<Pengguna>();

                if (File.Exists(filePath))
                {
                    string jsonData = File.ReadAllText(filePath);
                    penggunaList = JsonSerializer.Deserialize<List<Pengguna>>(jsonData) ?? new List<Pengguna>();
                }

                // Create transactions list
                List<Transaksi> transaksiList = new List<Transaksi>();
                decimal totalPemasukan = 0;
                decimal totalPengeluaran = 0;

                foreach (Panel panel in transaksiPanels)
                {
                    TextBox txtTanggal = (TextBox)panel.Controls.Find($"txtTanggal_{panel.Tag}", true)[0];
                    ComboBox cboJenis = (ComboBox)panel.Controls.Find($"cboJenis_{panel.Tag}", true)[0];
                    TextBox txtJumlah = (TextBox)panel.Controls.Find($"txtJumlah_{panel.Tag}", true)[0];

                    if (string.IsNullOrWhiteSpace(txtJumlah.Text))
                    {
                        lblStatus.Text = $"Error: Jumlah pada Transaksi #{(int)panel.Tag + 1} harus diisi!";
                        return;
                    }

                    if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah))
                    {
                        lblStatus.Text = $"Error: Jumlah pada Transaksi #{(int)panel.Tag + 1} harus berupa angka!";
                        return;
                    }

                    // Track totals based on transaction type
                    if (cboJenis.Text == "Pemasukan")
                        totalPemasukan += jumlah;
                    else if (cboJenis.Text == "Pengeluaran")
                        totalPengeluaran += jumlah;

                    transaksiList.Add(new Transaksi
                    {
                        Tanggal = txtTanggal.Text,
                        Jenis = cboJenis.Text,
                        Jumlah = jumlah
                    });
                }

                // Update existing user (dari session)
                int index = penggunaList.FindIndex(p =>
                    p.Nama.Equals(Session.CurrentUser.Nama, StringComparison.OrdinalIgnoreCase) &&
                    p.Pin == Session.CurrentUser.Pin);

                if (index >= 0)
                {
                    // Update saldo
                    penggunaList[index].Saldo += totalPemasukan - totalPengeluaran;

                    // Add new transactions
                    if (penggunaList[index].Transaksi == null)
                        penggunaList[index].Transaksi = new List<Transaksi>();

                    penggunaList[index].Transaksi.AddRange(transaksiList);

                    // Update session user juga
                    Session.CurrentUser.Saldo = penggunaList[index].Saldo;
                    Session.CurrentUser.Transaksi = penggunaList[index].Transaksi;

                    lblStatus.Text = $"✓ {transaksiList.Count} transaksi telah ditambahkan! Saldo terbaru: {penggunaList[index].Saldo:C}";
                    lblSaldoInfo.Text = $"Saldo saat ini: {penggunaList[index].Saldo:C}";
                }

                // Save back to file
                string jsonBaru = JsonSerializer.Serialize(penggunaList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonBaru);

                // Reset transaction panels for adding more
                numJumlahTransaksi.Value = 1;
                CreateTransactionPanels();
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }
    }
}