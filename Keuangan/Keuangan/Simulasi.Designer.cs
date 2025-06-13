namespace GUIKATAK
{
    partial class Simulasi
    {
    
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
            grpPilihan = new GroupBox();
            rdoMingguan = new RadioButton();
            rdoBulanan = new RadioButton();
            rdoTahunan = new RadioButton();
            lblJumlah = new Label();
            txtJumlah = new TextBox();
            label1 = new Label();
            txtNominal = new TextBox();
            btnHitung = new Button();
            lblHasil = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            grpPilihan.SuspendLayout();
            SuspendLayout();
            // 
            // grpPilihan
            // 
            grpPilihan.Controls.Add(rdoMingguan);
            grpPilihan.Controls.Add(rdoBulanan);
            grpPilihan.Controls.Add(rdoTahunan);
            grpPilihan.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPilihan.Location = new Point(55, 146);
            grpPilihan.Margin = new Padding(3, 4, 3, 4);
            grpPilihan.Name = "grpPilihan";
            grpPilihan.Padding = new Padding(3, 4, 3, 4);
            grpPilihan.Size = new Size(397, 211);
            grpPilihan.TabIndex = 2;
            grpPilihan.TabStop = false;
            grpPilihan.Text = "Pilih Jangka Waktu Menabung:";
            grpPilihan.Enter += grpPilihan_Enter;
            // 
            // rdoMingguan
            // 
            rdoMingguan.AutoSize = true;
            rdoMingguan.Font = new Font("Century Gothic", 8F);
            rdoMingguan.Location = new Point(7, 155);
            rdoMingguan.Margin = new Padding(3, 4, 3, 4);
            rdoMingguan.Name = "rdoMingguan";
            rdoMingguan.Size = new Size(116, 25);
            rdoMingguan.TabIndex = 5;
            rdoMingguan.TabStop = true;
            rdoMingguan.Text = "Mingguan";
            rdoMingguan.UseVisualStyleBackColor = true;
            rdoMingguan.CheckedChanged += rdoMingguan_CheckedChanged;
            // 
            // rdoBulanan
            // 
            rdoBulanan.AutoSize = true;
            rdoBulanan.Font = new Font("Century Gothic", 8F);
            rdoBulanan.Location = new Point(7, 96);
            rdoBulanan.Margin = new Padding(3, 4, 3, 4);
            rdoBulanan.Name = "rdoBulanan";
            rdoBulanan.Size = new Size(99, 25);
            rdoBulanan.TabIndex = 4;
            rdoBulanan.TabStop = true;
            rdoBulanan.Text = "Bulanan";
            rdoBulanan.UseVisualStyleBackColor = true;
            rdoBulanan.CheckedChanged += rdoBulanan_CheckedChanged;
            // 
            // rdoTahunan
            // 
            rdoTahunan.AutoSize = true;
            rdoTahunan.Font = new Font("Century Gothic", 8F);
            rdoTahunan.Location = new Point(7, 44);
            rdoTahunan.Margin = new Padding(3, 4, 3, 4);
            rdoTahunan.Name = "rdoTahunan";
            rdoTahunan.Size = new Size(105, 25);
            rdoTahunan.TabIndex = 3;
            rdoTahunan.TabStop = true;
            rdoTahunan.Text = "Tahunan";
            rdoTahunan.UseVisualStyleBackColor = true;
            rdoTahunan.CheckedChanged += rdoTahunan_CheckedChanged;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            lblJumlah.Location = new Point(50, 404);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(178, 19);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "Jumlah Waktu (1-10) :";
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(54, 438);
            txtJumlah.Margin = new Padding(3, 4, 3, 4);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(398, 31);
            txtJumlah.TabIndex = 4;
            txtJumlah.TextChanged += txtJumlah_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            label1.Location = new Point(52, 506);
            label1.Name = "label1";
            label1.Size = new Size(132, 19);
            label1.TabIndex = 5;
            label1.Text = "Nominal Anda :";
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(56, 546);
            txtNominal.Margin = new Padding(3, 4, 3, 4);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(398, 31);
            txtNominal.TabIndex = 6;
            txtNominal.TextChanged += txtNominal_TextChanged;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.PaleGreen;
            btnHitung.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(54, 609);
            btnHitung.Margin = new Padding(3, 4, 3, 4);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(198, 36);
            btnHitung.TabIndex = 7;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHasil.Location = new Point(130, 673);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(0, 23);
            lblHasil.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(360, 40);
            label3.Name = "label3";
            label3.Size = new Size(96, 66);
            label3.TabIndex = 11;
            label3.Text = "💸";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(59, 78);
            label2.Name = "label2";
            label2.Size = new Size(229, 28);
            label2.TabIndex = 10;
            label2.Text = "Simulasi Tabungan";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(55, 40);
            label4.Name = "label4";
            label4.Size = new Size(199, 38);
            label4.TabIndex = 9;
            label4.Text = "BUDGET AID";
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(349, 609);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 36);
            button1.TabIndex = 12;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(56, 673);
            label5.Name = "label5";
            label5.Size = new Size(74, 23);
            label5.TabIndex = 13;
            label5.Text = "Hasil : ";
            // 
            // Simulasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 751);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblHasil);
            Controls.Add(btnHitung);
            Controls.Add(txtNominal);
            Controls.Add(label1);
            Controls.Add(txtJumlah);
            Controls.Add(lblJumlah);
            Controls.Add(grpPilihan);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Simulasi";
            Text = "Simulasi Tabungan";
            grpPilihan.ResumeLayout(false);
            grpPilihan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPilihan;
        private System.Windows.Forms.RadioButton rdoMingguan;
        private System.Windows.Forms.RadioButton rdoBulanan;
        private System.Windows.Forms.RadioButton rdoTahunan;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label lblHasil;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}

