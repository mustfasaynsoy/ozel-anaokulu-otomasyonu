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
    public partial class FRMOGR : Form
    {
        public FRMOGR()
        {
            InitializeComponent();
        }

        private void oGRENCILERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oGRENCILERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void FRMOGR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.OGRENCILER' table. You can move, or remove it, as needed.
            this.oGRENCILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.OGRENCILER);

        }
    }
}
