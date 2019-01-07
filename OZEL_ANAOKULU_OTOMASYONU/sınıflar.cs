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
    public partial class sınıflar : Form
    {
        public sınıflar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.SINIFLARIMIZ' table. You can move, or remove it, as needed.
            this.sINIFLARIMIZTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.SINIFLARIMIZ);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgSINIFLAR' table. You can move, or remove it, as needed.
            this.srgSINIFLARTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.srgSINIFLAR);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            srgSINIFLARBindingSource.Filter = "SINIF_ID=" +Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            srgSINIFLARBindingSource.RemoveFilter();  
        }
    }
}
