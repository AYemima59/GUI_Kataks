using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keuangan
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("User tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Setup DataGridView columns
                dataGridViewHistory.Columns.Clear();
                dataGridViewHistory.Columns.Add("No", "No");
                dataGridViewHistory.Columns.Add("Tanggal", "Tanggal");
                dataGridViewHistory.Columns.Add("Jenis", "Jenis");
                dataGridViewHistory.Columns.Add("Jumlah", "Jumlah");

                // Set column widths
                dataGridViewHistory.Columns["No"].Width = 40;
                dataGridViewHistory.Columns["Tanggal"].Width = 100;
                dataGridViewHistory.Columns["Jenis"].Width = 100;
                dataGridViewHistory.Columns["Jumlah"].Width = 120;

                // Set column alignment
                dataGridViewHistory.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewHistory.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Clear existing rows
                dataGridViewHistory.Rows.Clear();

                // Load transaction data
                var transaksiList = Session.CurrentUser.Transaksi.OrderByDescending(t => DateTime.Parse(t.Tanggal)).ToList();

                if (transaksiList.Count == 0)
                {
                    // Add empty row if no transactions
                    dataGridViewHistory.Rows.Add("", "Tidak ada transaksi", "", "");
                }
                else
                {
                    // Add transaction rows
                    for (int i = 0; i < transaksiList.Count; i++)
                    {
                        var transaksi = transaksiList[i];

                        // Format tanggal
                        string tanggalFormatted = DateTime.Parse(transaksi.Tanggal).ToString("dd/MM/yyyy");

                        // Format jumlah dengan currency
                        string jumlahFormatted = transaksi.Jumlah.ToString("C");

                        // Add row
                        int rowIndex = dataGridViewHistory.Rows.Add(
                            (i + 1).ToString(),
                            tanggalFormatted,
                            transaksi.Jenis,
                            jumlahFormatted
                        );

                        // Set row color based on transaction type
                        if (transaksi.Jenis == "Pemasukan")
                        {
                            dataGridViewHistory.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
                        }
                        else if (transaksi.Jenis == "Pengeluaran")
                        {
                            dataGridViewHistory.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                        }
                    }
                }

                // Update total saldo
                lblTotalSaldo.Text = $"Total Saldo: {Session.CurrentUser.Saldo:C}";

                // Update summary info
                var totalPemasukan = transaksiList.Where(t => t.Jenis == "Pemasukan").Sum(t => t.Jumlah);
                var totalPengeluaran = transaksiList.Where(t => t.Jenis == "Pengeluaran").Sum(t => t.Jumlah);

                lblTotalSaldo.Text = $"Saldo: {Session.CurrentUser.Saldo:C} ";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction history: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
