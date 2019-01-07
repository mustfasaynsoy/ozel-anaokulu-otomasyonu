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
    public partial class SINIFLARIMIZ : Form
    {
        public SINIFLARIMIZ()
        {
            InitializeComponent();
        }

        private void sINIFLARIMIZBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINIFLARIMIZBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void SINIFLARIMIZ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.SINIFLARIMIZ' table. You can move, or remove it, as needed.
            this.sINIFLARIMIZTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.SINIFLARIMIZ);

        }
    }
}
