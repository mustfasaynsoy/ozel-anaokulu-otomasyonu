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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }



        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.KULLANICI' table. You can move, or remove it, as needed.
            this.kULLANICITableAdapter.Fill(this.oZEL_ANAOKULUDataSet.KULLANICI);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kULLANICIBindingSource.Filter = "KULLANICI='" + textBox1.Text + "' AND PAROLA='" + textBox2.Text + "'";
            if (kULLANICIBindingSource.Count > 0)
            {
              frmAna KULLANICI = new frmAna();
                KULLANICI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("BU KULLANICI VEYA PAROLA HATALI!");
               textBox1.Focus();

            }
        }

       
    }
}
