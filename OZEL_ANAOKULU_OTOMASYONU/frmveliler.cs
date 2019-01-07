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
    public partial class frmveliler : Form
    {
        public frmveliler()
        {
            InitializeComponent();
        }

        private void vELILERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vELILERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void frmveliler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.VELILER' table. You can move, or remove it, as needed.
            this.vELILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.VELILER);

        }

        
    }
}
