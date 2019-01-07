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
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }


      
        

     

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongTimeString();
        }

      

        private void frmAna_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMOGR F = new FRMOGR();
            F.MdiParent = this;
            F.Show();
            F.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOGRHAKKINDA F = new frmOGRHAKKINDA();
            F.MdiParent = this;
            F.Show();
            F.WindowState = FormWindowState.Maximized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bütünform f = new bütünform();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void OGRENCIBILGILERI_Click(object sender, EventArgs e)
        {
            FRMOGR F = new FRMOGR();
            F.MdiParent = this;
            F.Show();
            F.WindowState = FormWindowState.Maximized;
        }

        private void OGRENCIEKLE_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void btnHAKKINDA_Click(object sender, EventArgs e)
        {
            frmOGRHAKKINDA F = new frmOGRHAKKINDA();
            F.MdiParent = this;
            F.Show();
            F.WindowState = FormWindowState.Maximized;
        }

        private void BÜTÜNFORM_Click(object sender, EventArgs e)
        {
            bütünform f = new bütünform();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oTURUMUKAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LOGIN f = new LOGIN();
            f.Show();
            this.Hide();
        }

      
    }
}
