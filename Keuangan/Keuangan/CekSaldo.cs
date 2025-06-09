using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Keuangan
{
    public partial class CekSaldo : Form
    {
        private TextBox txtNama;
        private TextBox txtPin;
        private Button btnCekSaldo;
        private Label lblResult;
        private Label lblNama;
        private Label lblPin;
        private Panel panel1;

        //()
        //{
        //    InitializeComponent();
        //}

        public CekSaldo()
        {
            txtNama = new TextBox();
            txtPin = new TextBox();
            btnCekSaldo = new Button();
            lblResult = new Label();
            lblNama = new Label();
            lblPin = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(173, 22);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(366, 30);
            txtNama.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(173, 52);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(366, 30);
            txtPin.TabIndex = 4;
            // 
            // btnCekSaldo
            // 
            btnCekSaldo.Location = new Point(419, 88);
            btnCekSaldo.Name = "btnCekSaldo";
            btnCekSaldo.Size = new Size(120, 30);
            btnCekSaldo.TabIndex = 5;
            btnCekSaldo.Text = "Cek Saldo";
            btnCekSaldo.UseVisualStyleBackColor = true;
            btnCekSaldo.Click += btnCekSaldo_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(25, 140);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(5);
            lblResult.Size = new Size(514, 80);
            lblResult.TabIndex = 6;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(25, 25);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(142, 23);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Pengguna:";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(25, 55);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(42, 23);
            lblPin.TabIndex = 3;
            lblPin.Text = "PIN:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNama);
            panel1.Controls.Add(txtNama);
            panel1.Controls.Add(lblPin);
            panel1.Controls.Add(txtPin);
            panel1.Controls.Add(btnCekSaldo);
            panel1.Controls.Add(lblResult);
            panel1.Location = new Point(25, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 260);
            panel1.TabIndex = 7;
            // 
            // SaldoForm
            // 
            ClientSize = new Size(590, 320);
            Controls.Add(panel1);
            Name = "CekSaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CekSaldo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btnCekSaldo_Click(object sender, EventArgs e)
        {
            string filePath = "data_pengguna.json";

            if (!File.Exists(filePath))
            {
                lblResult.Text = "File data pengguna tidak ditemukan!";
                return;
            }

            try
            {
                string jsonData = File.ReadAllText(filePath);
                var penggunaList = JsonSerializer.Deserialize<Pengguna[]>(jsonData);

                string namaInput = txtNama.Text;
                string pinInput = txtPin.Text;

                Pengguna pengguna = Array.Find(penggunaList, p =>
                    p.Nama.Equals(namaInput, StringComparison.OrdinalIgnoreCase) &&
                    p.Pin == pinInput);

                if (pengguna != null)
                {
                    lblResult.Text = $"Data Pengguna:\n" +
                                   $"Nama: {pengguna.Nama}\n" +
                                   $"Saldo: {pengguna.Saldo:C}";
                }
                else
                {
                    lblResult.Text = "Pengguna tidak ditemukan atau PIN salah!";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private void CekSaldo_Load(object sender, EventArgs e)
        {

        }
    }
}
