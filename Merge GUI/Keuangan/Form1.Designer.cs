namespace Keuangan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(215, 132);
            button1.Name = "button1";
            button1.Size = new Size(176, 143);
            button1.TabIndex = 0;
            button1.Text = "Cek Saldo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(31, 280);
            button2.Name = "button2";
            button2.Size = new Size(176, 143);
            button2.TabIndex = 1;
            button2.Text = "Histori Transaksi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveCaption;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(34, 132);
            button4.Name = "button4";
            button4.Size = new Size(176, 143);
            button4.TabIndex = 3;
            button4.Text = "Tambah Transaksi";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveCaption;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(215, 280);
            button5.Name = "button5";
            button5.Size = new Size(176, 143);
            button5.TabIndex = 4;
            button5.Text = "Simulasi";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 5;
            label1.Text = "BUDGET AID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(34, 83);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 6;
            label2.Text = "Menu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(305, 48);
            label3.Name = "label3";
            label3.Size = new Size(72, 54);
            label3.TabIndex = 7;
            label3.Text = "💸";
            //label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.ForeColor = Color.Linen;
            button3.Location = new Point(297, 433);
            button3.Name = "button3";
            button3.Size = new Size(94, 38);
            button3.TabIndex = 8;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 483);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Sistem Keuangan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
    }
}
