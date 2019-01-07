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
    public partial class taksitödemeleri : Form
    {
        public taksitödemeleri()
        {
            InitializeComponent();
        }

        private void tAKSIT_ODEMELERIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAKSIT_ODEMELERIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void taksitödemeleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.VELILER' table. You can move, or remove it, as needed.
            this.vELILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.VELILER);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.OGRENCILER' table. You can move, or remove it, as needed.
            this.oGRENCILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.OGRENCILER);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgTAKSITODEMESI' table. You can move, or remove it, as needed.
            this.srgTAKSITODEMESITableAdapter.Fill(this.oZEL_ANAOKULUDataSet.srgTAKSITODEMESI);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.TAKSIT_ODEMELERI' table. You can move, or remove it, as needed.
            this.tAKSIT_ODEMELERITableAdapter.Fill(this.oZEL_ANAOKULUDataSet.TAKSIT_ODEMELERI);

        }

      
    }
}
