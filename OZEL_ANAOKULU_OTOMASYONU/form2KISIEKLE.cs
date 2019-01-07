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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgOgrenciDetay' table. You can move, or remove it, as needed.
            this.srgOgrenciDetayTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.srgOgrenciDetay);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgOGRENCI' table. You can move, or remove it, as needed.
          // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgSINIFLAR' table. You can move, or remove it, as needed.
            this.srgSINIFLARTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.srgSINIFLAR);
        
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.SINIFLARIMIZ' table. You can move, or remove it, as needed.
            this.sINIFLARIMIZTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.SINIFLARIMIZ);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.VELILER' table. You can move, or remove it, as needed.
            this.vELILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.VELILER);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.OGRENCILER' table. You can move, or remove it, as needed.
            this.oGRENCILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.OGRENCILER);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.srgOGRENCI' table. You can move, or remove it, as needed.

        }

        private void srgOGRENCIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.oGRENCILERBindingSource.EndEdit();
            this.oGRENCILERTableAdapter.Update(this.oZEL_ANAOKULUDataSet.OGRENCILER);
        }

        private void oGRENCILERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.srgOgrenciDetayBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oZEL_ANAOKULUDataSet);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.RemoveCurrent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.AddNew();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.MoveLast();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.MoveNext();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.MovePrevious();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            srgOgrenciDetayBindingSource.MoveFirst();
        }

     
    }
    }

