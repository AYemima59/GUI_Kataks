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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Arial", 10F);
            txtNama.Location = new Point(108, 28);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 30);
            txtNama.TabIndex = 1;
            // 
            // txtPin
            // 
            txtPin.Font = new Font("Arial", 10F);
            txtPin.Location = new Point(108, 72);
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(250, 30);
            txtPin.TabIndex = 3;
            txtPin.TextChanged += txtPin_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightBlue;
            btnLogin.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(269, 123);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 35);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightGreen;
            btnRegister.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            btnRegister.Location = new Point(108, 123);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(155, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(25, 31);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(77, 23);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama:";
            lblNama.Click += lblNama_Click;
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPin.Location = new Point(55, 72);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(47, 23);
            lblPin.TabIndex = 2;
            lblPin.Text = "PIN:";
            lblPin.Click += lblPin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.CornflowerBlue;
            lblTitle.Location = new Point(33, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(199, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BUDGET AID";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial", 9F);
            lblStatus.ForeColor = Color.Red;
            lblStatus.Location = new Point(50, 331);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
            lblStatus.TabIndex = 2;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.AliceBlue;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblNama);
            panelMain.Controls.Add(txtNama);
            panelMain.Controls.Add(lblPin);
            panelMain.Controls.Add(txtPin);
            panelMain.Controls.Add(btnLogin);
            panelMain.Controls.Add(btnRegister);
            panelMain.Location = new Point(33, 161);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(391, 191);
            panelMain.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome To!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(328, 32);
            label2.Name = "label2";
            label2.Size = new Size(96, 66);
            label2.TabIndex = 4;
            label2.Text = "💸";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateGray;
            label3.Location = new Point(33, 129);
            label3.Name = "label3";
            label3.Size = new Size(288, 19);
            label3.TabIndex = 5;
            label3.Text = "Silahkan Melakukan Login / Register";
            // 
            // LoginRegister
            // 
            ClientSize = new Size(464, 388);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(panelMain);
            Controls.Add(lblStatus);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BudgetAid";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
    }
}