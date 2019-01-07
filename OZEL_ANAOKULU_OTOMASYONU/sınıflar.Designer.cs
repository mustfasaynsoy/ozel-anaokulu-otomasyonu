namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class sınıflar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sınıflar));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sINIFLARIMIZBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.srgSINIFLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.srgSINIFLARTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.srgSINIFLARTableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.sINIFLARIMIZTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.SINIFLARIMIZTableAdapter();
            this.srgSINIFLARBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.srgSINIFLARBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.srgSINIFLARDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sINIFLARIMIZBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARBindingNavigator)).BeginInit();
            this.srgSINIFLARBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sINIFLARIMIZBindingSource;
            this.comboBox1.DisplayMember = "SINIF";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 111);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "SINIF_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sINIFLARIMIZBindingSource
            // 
            this.sINIFLARIMIZBindingSource.DataMember = "SINIFLARIMIZ";
            this.sINIFLARIMIZBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // srgSINIFLARBindingSource
            // 
            this.srgSINIFLARBindingSource.DataMember = "srgSINIFLAR";
            this.srgSINIFLARBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // srgSINIFLARTableAdapter
            // 
            this.srgSINIFLARTableAdapter.ClearBeforeFill = true;
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
            // sINIFLARIMIZTableAdapter
            // 
            this.sINIFLARIMIZTableAdapter.ClearBeforeFill = true;
            // 
            // srgSINIFLARBindingNavigator
            // 
            this.srgSINIFLARBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.srgSINIFLARBindingNavigator.BindingSource = this.srgSINIFLARBindingSource;
            this.srgSINIFLARBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.srgSINIFLARBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.srgSINIFLARBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.srgSINIFLARBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.srgSINIFLARBindingNavigatorSaveItem});
            this.srgSINIFLARBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.srgSINIFLARBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.srgSINIFLARBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.srgSINIFLARBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.srgSINIFLARBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.srgSINIFLARBindingNavigator.Name = "srgSINIFLARBindingNavigator";
            this.srgSINIFLARBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.srgSINIFLARBindingNavigator.Size = new System.Drawing.Size(1018, 27);
            this.srgSINIFLARBindingNavigator.TabIndex = 1;
            this.srgSINIFLARBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";

            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // srgSINIFLARBindingNavigatorSaveItem
            // 
            this.srgSINIFLARBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.srgSINIFLARBindingNavigatorSaveItem.Enabled = false;
            this.srgSINIFLARBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("srgSINIFLARBindingNavigatorSaveItem.Image")));
            this.srgSINIFLARBindingNavigatorSaveItem.Name = "srgSINIFLARBindingNavigatorSaveItem";
            this.srgSINIFLARBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.srgSINIFLARBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // srgSINIFLARDataGridView
            // 
            this.srgSINIFLARDataGridView.AutoGenerateColumns = false;
            this.srgSINIFLARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.srgSINIFLARDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.srgSINIFLARDataGridView.DataSource = this.srgSINIFLARBindingSource;
            this.srgSINIFLARDataGridView.Location = new System.Drawing.Point(62, 216);
            this.srgSINIFLARDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.srgSINIFLARDataGridView.Name = "srgSINIFLARDataGridView";
            this.srgSINIFLARDataGridView.Size = new System.Drawing.Size(840, 228);
            this.srgSINIFLARDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ADI";
            this.dataGridViewTextBoxColumn1.HeaderText = "ADI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SOYADI";
            this.dataGridViewTextBoxColumn2.HeaderText = "SOYADI";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CINSIYET";
            this.dataGridViewTextBoxColumn3.HeaderText = "CINSIYET";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "D_TARIHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "D_TARIHI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SINIF";
            this.dataGridViewTextBoxColumn5.HeaderText = "SINIF";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ADISOYADI";
            this.dataGridViewTextBoxColumn6.HeaderText = "ADISOYADI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ADRES";
            this.dataGridViewTextBoxColumn7.HeaderText = "ADRES";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CEP_TEL";
            this.dataGridViewTextBoxColumn8.HeaderText = "CEP_TEL";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Classes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sınıflar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.anaokulu2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srgSINIFLARDataGridView);
            this.Controls.Add(this.srgSINIFLARBindingNavigator);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sınıflar";
            this.Text = "sınıflar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINIFLARIMIZBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARBindingNavigator)).EndInit();
            this.srgSINIFLARBindingNavigator.ResumeLayout(false);
            this.srgSINIFLARBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srgSINIFLARDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource srgSINIFLARBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.srgSINIFLARTableAdapter srgSINIFLARTableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator srgSINIFLARBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton srgSINIFLARBindingNavigatorSaveItem;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.SINIFLARIMIZTableAdapter sINIFLARIMIZTableAdapter;
        private System.Windows.Forms.DataGridView srgSINIFLARDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource sINIFLARIMIZBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}