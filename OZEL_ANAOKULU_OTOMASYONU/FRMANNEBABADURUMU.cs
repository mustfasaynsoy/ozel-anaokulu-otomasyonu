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
    public partial class FRMANNEBABADURUMU : Form
    {
        public FRMANNEBABADURUMU()
        {
            InitializeComponent();
        }

        private void aNNEBABADURUMLARIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aNNEBABADURUMLARIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void FRMANNEBABADURUMU_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.ANNEBABADURUMLARI' table. You can move, or remove it, as needed.
            this.aNNEBABADURUMLARITableAdapter.Fill(this.oZEL_ANAOKULUDataSet.ANNEBABADURUMLARI);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aNNEBABADURUMLARIBindingSource.Filter = "DURUM_ID=" + Convert.ToInt32(comboBox1.SelectedValue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            aNNEBABADURUMLARIBindingSource.RemoveFilter();
        }
    }
}
