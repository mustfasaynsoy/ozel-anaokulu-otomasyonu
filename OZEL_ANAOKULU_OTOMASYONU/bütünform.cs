﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OZEL_ANAOKULU_OTOMASYONU
{
    public partial class bütünform : Form
    {
        public bütünform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.OGRENCILER' table. You can move, or remove it, as needed.
            this.oGRENCILERTableAdapter.Fill(this.oZEL_ANAOKULUDataSet.OGRENCILER);
            // TODO: This line of code loads data into the 'oZEL_ANAOKULUDataSet.TAKSIT_ODEMELERI' table. You can move, or remove it, as needed.
            this.tAKSIT_ODEMELERITableAdapter.Fill(this.oZEL_ANAOKULUDataSet.TAKSIT_ODEMELERI);

        }

        private void BTNIlk_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.MoveFirst();
        }

        private void BTNIlerı_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.MoveNext();
        }

        private void btnGerı_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.MovePrevious();
        }

        private void btnson_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.MoveLast();
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.AddNew();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                oGRENCILERBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("kayıtların tümü silindi.");
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            oGRENCILERBindingSource.EndEdit();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void  BTNVELILER_Click(object sender, EventArgs e)
        {
            frmveliler veli = new frmveliler();
            veli.Show();
        }

        private void FRMOGR_Click(object sender, EventArgs e)
        {
            FRMOGR OGR = new FRMOGR();
            OGR.Show();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }




       
       

   

       
        private void BTNANNEBABADURUMU_Click(object sender, EventArgs e)
        {
            FRMANNEBABADURUMU ANNEBABA = new FRMANNEBABADURUMU();
            ANNEBABA.Show();
        }

        private void BTNADIARAMASOYADIFİLTRELEME_Click(object sender, EventArgs e)
        {
            ADI_ARAMA_SOYADI_FİLTRELEME F = new ADI_ARAMA_SOYADI_FİLTRELEME();
            F.Show();
        }

        private void BTNSINIFLAR_Click(object sender, EventArgs e)
        {
            sınıflar SNF = new sınıflar();
            SNF.Show();
        }

        private void BTNTAKSITLER_Click(object sender, EventArgs e)
        {

            frmTaksitOdemeleri taksıt = new frmTaksitOdemeleri();
            taksıt.Show();
        }


        

  
    






    }
}


  

        


      


