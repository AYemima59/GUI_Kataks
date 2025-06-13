namespace Keuangan
{
    partial class TambahTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSaldo = new Label();
            cmbJenis = new ComboBox();
            txtJumlah = new TextBox();
            btnSubmit = new Button();
            lblStatus = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(41, 125);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(139, 22);
            lblSaldo.TabIndex = 0;
            lblSaldo.Text = "Sisa Saldo: Rp0";
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Items.AddRange(new object[] { "Pemasukan", "Pengeluaran" });
            cmbJenis.Location = new Point(41, 167);
            cmbJenis.Margin = new Padding(4, 4, 4, 4);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(372, 33);
            cmbJenis.TabIndex = 1;
            // 
            // txtJumlah
            // 
            txtJumlah.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtJumlah.Location = new Point(37, 224);
            txtJumlah.Margin = new Padding(4, 4, 4, 4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.PlaceholderText = "Jumlah";
            txtJumlah.Size = new Size(376, 30);
            txtJumlah.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.PaleGreen;
            btnSubmit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(234, 274);
            btnSubmit.Margin = new Padding(4, 4, 4, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(179, 36);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(37, 324);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(317, 41);
            label3.Name = "label3";
            label3.Size = new Size(96, 66);
            label3.TabIndex = 14;
            label3.Text = "💸";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(41, 79);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 13;
            label2.Text = "Simulasi Tabungan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(37, 41);
            label4.Name = "label4";
            label4.Size = new Size(199, 38);
            label4.TabIndex = 12;
            label4.Text = "BUDGET AID";
            // 
            // TambahTransaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 367);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblSaldo);
            Controls.Add(cmbJenis);
            Controls.Add(txtJumlah);
            Controls.Add(btnSubmit);
            Controls.Add(lblStatus);
            Margin = new Padding(4, 4, 4, 4);
            Name = "TambahTransaksi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Transaksi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Tambahkan deklarasi field di bawah region Windows Form Designer generated code
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cmbJenis;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblStatus;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}