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
    public partial class ADI_ARAMA_SOYADI_FİLTRELEME : Form
    {
        public ADI_ARAMA_SOYADI_FİLTRELEME()
        {
            InitializeComponent();
        }

        private void oGRENCILERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oGRENCILERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);

        }

        private void ADI_ARAMA_SOYADI_FİLTRELEME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.OGRENCILER' table. You can move, or remove it, as needed.
            this.oGRENCILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.OGRENCILER);

        }

        private void txtadi_TextChanged(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.Position = oGRENCILERBindingSource.Find("ADI", txtadi.Text);
        }

        private void txtsoyadi_TextChanged(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.Filter = "SOYADI LIKE '" + txtsoyadi.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.RemoveFilter();
        }

     
    }
}
