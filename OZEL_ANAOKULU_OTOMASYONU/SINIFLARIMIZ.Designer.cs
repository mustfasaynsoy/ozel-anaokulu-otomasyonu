namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class SINIFLARIMIZ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sINIFLabel;
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.sINIFLARIMIZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sINIFLARIMIZTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.SINIFLARIMIZTableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            sINIFLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINIFLARIMIZBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sINIFLabel
            // 
            sINIFLabel.AutoSize = true;
            sINIFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sINIFLabel.Location = new System.Drawing.Point(31, 92);
            sINIFLabel.Name = "sINIFLabel";
            sINIFLabel.Size = new System.Drawing.Size(55, 20);
            sINIFLabel.TabIndex = 3;
            sINIFLabel.Text = "SINIF:";
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sINIFLARIMIZBindingSource
            // 
            this.sINIFLARIMIZBindingSource.DataMember = "SINIFLARIMIZ";
            this.sINIFLARIMIZBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // sINIFLARIMIZTableAdapter
            // 
            this.sINIFLARIMIZTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEBABADURUMLARITableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KULLANICITableAdapter = null;
            this.tableAdapterManager.OGRENCILERTableAdapter = null;
            this.tableAdapterManager.SINIFLARIMIZTableAdapter = this.sINIFLARIMIZTableAdapter;
            this.tableAdapterManager.TAKSIT_ODEMELERITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VELILERTableAdapter = null;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sINIFLARIMIZBindingSource;
            this.comboBox2.DisplayMember = "SINIF";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 28);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.ValueMember = "SINIF_ID";
            // 
            // SINIFLARIMIZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 193);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(sINIFLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "SINIFLARIMIZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SINIFLARIMIZ";
            this.Load += new System.EventHandler(this.SINIFLARIMIZ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINIFLARIMIZBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource sINIFLARIMIZBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.SINIFLARIMIZTableAdapter sINIFLARIMIZTableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}