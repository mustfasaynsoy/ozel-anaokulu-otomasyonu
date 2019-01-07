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
    public partial class frmSORUN1 : Form
    {
        public frmSORUN1()
        {
            InitializeComponent();
        }

        private void frmSORUN1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Parents are kindly requested to pay the price as soon as possible.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "The parents are given 1 month additional time and are requested to pay the price until this time.";
        }

      
    }
}
