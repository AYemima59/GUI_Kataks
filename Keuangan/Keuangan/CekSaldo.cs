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
            lblResult = new Label();
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Location = new Point(25, 40);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(5);
            lblResult.Size = new Size(514, 80);
            lblResult.TabIndex = 1;

            ClientSize = new Size(590, 180);
            Controls.Add(lblResult);
            Name = "CekSaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CekSaldo_Load;
        }

        private void CekSaldo_Load(object sender, EventArgs e)
        {
            if (Session.CurrentUser != null)
            {
                lblResult.Text = $"Data Pengguna:\n" +
                                 $"Nama: {Session.CurrentUser.Nama}\n" +
                                 $"Saldo: {Session.CurrentUser.Saldo:C}";
            }
            else
            {
                lblResult.Text = "Anda belum login!";
            }
        }
    }
}
