namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class FRMANNEBABADURUMU
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
            System.Windows.Forms.Label dURUMLabel;
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.aNNEBABADURUMLARIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aNNEBABADURUMLARITableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.ANNEBABADURUMLARITableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aNNEBABADURUMLARIDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            dURUMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNNEBABADURUMLARIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNNEBABADURUMLARIDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dURUMLabel
            // 
            dURUMLabel.AutoSize = true;
            dURUMLabel.BackColor = System.Drawing.Color.White;
            dURUMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dURUMLabel.Location = new System.Drawing.Point(363, 196);
            dURUMLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dURUMLabel.Name = "dURUMLabel";
            dURUMLabel.Size = new System.Drawing.Size(100, 25);
            dURUMLabel.TabIndex = 3;
            dURUMLabel.Text = "STATUS:";
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.Namespace = "http://tempuri.org/OZEL_ANAOKULUDataSet.xsd";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aNNEBABADURUMLARIBindingSource
            // 
            this.aNNEBABADURUMLARIBindingSource.DataMember = "ANNEBABADURUMLARI";
            this.aNNEBABADURUMLARIBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // aNNEBABADURUMLARITableAdapter
            // 
            this.aNNEBABADURUMLARITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEBABADURUMLARITableAdapter = this.aNNEBABADURUMLARITableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KULLANICITableAdapter = null;
            this.tableAdapterManager.OGRENCILERTableAdapter = null;
            this.tableAdapterManager.SINIFLARIMIZTableAdapter = null;
            this.tableAdapterManager.TAKSIT_ODEMELERITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VELILERTableAdapter = null;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.aNNEBABADURUMLARIBindingSource;
            this.comboBox1.DisplayMember = "DURUM";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(471, 193);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 33);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "DURUM_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aNNEBABADURUMLARIDataGridView
            // 
            this.aNNEBABADURUMLARIDataGridView.AutoGenerateColumns = false;
            this.aNNEBABADURUMLARIDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aNNEBABADURUMLARIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aNNEBABADURUMLARIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.aNNEBABADURUMLARIDataGridView.DataSource = this.aNNEBABADURUMLARIBindingSource;
            this.aNNEBABADURUMLARIDataGridView.Location = new System.Drawing.Point(319, 300);
            this.aNNEBABADURUMLARIDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.aNNEBABADURUMLARIDataGridView.Name = "aNNEBABADURUMLARIDataGridView";
            this.aNNEBABADURUMLARIDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aNNEBABADURUMLARIDataGridView.Size = new System.Drawing.Size(433, 162);
            this.aNNEBABADURUMLARIDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DURUM_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "DURUM_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DURUM";
            this.dataGridViewTextBoxColumn2.HeaderText = "DURUM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 235);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMANNEBABADURUMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.aile_icon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(776, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aNNEBABADURUMLARIDataGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(dURUMLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMANNEBABADURUMU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMANNEBABADURUMU";
            this.Load += new System.EventHandler(this.FRMANNEBABADURUMU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNNEBABADURUMLARIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNNEBABADURUMLARIDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource aNNEBABADURUMLARIBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.ANNEBABADURUMLARITableAdapter aNNEBABADURUMLARITableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView aNNEBABADURUMLARIDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}