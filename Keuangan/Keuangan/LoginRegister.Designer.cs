namespace Keuangan
{
    partial class LoginRegister
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNama = new TextBox();
            txtPin = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblNama = new Label();
            lblPin = new Label();
            lblTitle = new Label();
            lblStatus = new Label();
            panelMain = new Panel();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Arial", 10F);
            txtNama.Location = new Point(80, 27);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 27);
            txtNama.TabIndex = 1;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Arial", 10F);
            txtPin.Location = new Point(80, 67);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(250, 27);
            txtPin.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(80, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightGreen;
            btnRegister.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(190, 110);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Arial", 10F);
            lblNama.Location = new Point(20, 30);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(56, 19);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama:";
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Arial", 10F);
            lblPin.Location = new Point(20, 70);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(41, 19);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(140, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(280, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "SISTEM KEUANGAN";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(50, 250);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            lblStatus.TabIndex = 2;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblNama);
            panelMain.Controls.Add(txtNama);
            panelMain.Controls.Add(lblPin);
            panelMain.Controls.Add(txtPin);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(btnRegister);
            panelMain.Location = new Point(50, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(350, 180);
            panelMain.TabIndex = 1;
            // 
            // LoginRegister
            // 
            ClientSize = new Size(450, 300);
            Controls.Add(lblTitle);
            Controls.Add(panelMain);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login / Register";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}