using System;
using System.Windows.Forms;

namespace GUIKATAK
{
    public enum AppState
    {
        Start,
        PilihWaktu,
        InputNominal,
        Hasil
    }

    public partial class Simulasi : Form
    {
        private AppState currentState = AppState.Start;

        public Simulasi()
        {
            InitializeComponent();
            TransisiState(AppState.Start);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (currentState != AppState.Hasil)
            {
                MessageBox.Show("Pastikan semua data telah diisi dengan benar!");
                return;
            }

            if (int.TryParse(txtJumlah.Text, out int jumlah) &&
                int.TryParse(txtNominal.Text, out int nominal))
            {
                lblHasil.Text = $"Total tabungan: {jumlah * nominal}";
            }
            else
            {
                MessageBox.Show("Input tidak valid.");
            }
        }

        private void TransisiState(AppState newState)
        {
            currentState = newState;

            switch (currentState)
            {
                case AppState.Start:
                    txtJumlah.Enabled = false;
                    txtNominal.Enabled = false;
                    btnHitung.Enabled = false;
                    lblHasil.Text = "";
                    break;

                case AppState.PilihWaktu:
                    txtJumlah.Enabled = true;
                    txtNominal.Enabled = false;
                    btnHitung.Enabled = false;
                    lblHasil.Text = "";
                    break;

                case AppState.InputNominal:
                    txtJumlah.Enabled = true;
                    txtNominal.Enabled = true;
                    btnHitung.Enabled = false;
                    lblHasil.Text = "";
                    break;

                case AppState.Hasil:
                    txtJumlah.Enabled = true;
                    txtNominal.Enabled = true;
                    btnHitung.Enabled = true;
                    break;
            }
        }

        private void rdoTahunan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTahunan.Checked)
            {
                TransisiState(AppState.PilihWaktu);
            }
        }

        private void rdoBulanan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBulanan.Checked)
            {
                TransisiState(AppState.PilihWaktu);
            }
        }

        private void rdoMingguan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMingguan.Checked)
            {
                TransisiState(AppState.PilihWaktu);
            }
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtJumlah.Text, out int jumlah) && jumlah > 0)
            {
                TransisiState(AppState.InputNominal);
            }
            else
            {
                txtNominal.Enabled = false;
                btnHitung.Enabled = false;
            }
        }

        private void txtNominal_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNominal.Text, out int nominal) && nominal > 0)
            {
                TransisiState(AppState.Hasil);
            }
            else
            {
                btnHitung.Enabled = false;
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void grpPilihan_Enter(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
