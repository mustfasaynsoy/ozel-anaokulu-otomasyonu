using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OZEL_ANAOKULU_OTOMASYONU
{
    public partial class frmOGRHAKKINDA : Form
    {
        public frmOGRHAKKINDA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmSORUN1 F = new frmSORUN1();
            F.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmSORUN2 F = new frmSORUN2();
            F.ShowDialog();
        }
    }
}
