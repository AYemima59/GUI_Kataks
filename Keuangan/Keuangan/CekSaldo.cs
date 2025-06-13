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
        private Label lblResult;

        public CekSaldo()
        {
            InitializeComponent();
        }

        private void CekSaldo_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                textBox1.Text = $"{Session.CurrentUser.Saldo:C}";
            }
            else
            {
                textBox1.Text = "Anda belum login!";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
