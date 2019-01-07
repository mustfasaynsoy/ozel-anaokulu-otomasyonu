namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class frmTaksitOdemeleri
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
            System.Windows.Forms.Label oGRENCI_IDLabel;
            System.Windows.Forms.Label oDEME_TARIHILabel;
            System.Windows.Forms.Label oDEME_MIKTARILabel;
            System.Windows.Forms.Label oDEDIMILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaksitOdemeleri));
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.tAKSIT_ODEMELERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAKSIT_ODEMELERITableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TAKSIT_ODEMELERITableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.oGRENCILERTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.OGRENCILERTableAdapter();
            this.tAKSIT_ODEMELERIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.oDEME_TARIHIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oDEME_MIKTARITextBox = new System.Windows.Forms.TextBox();
            this.oDEDIMICheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.oGRENCILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            oGRENCI_IDLabel = new System.Windows.Forms.Label();
            oDEME_TARIHILabel = new System.Windows.Forms.Label();
            oDEME_MIKTARILabel = new System.Windows.Forms.Label();
            oDEDIMILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSIT_ODEMELERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSIT_ODEMELERIBindingNavigator)).BeginInit();
            this.tAKSIT_ODEMELERIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCILERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oGRENCI_IDLabel
            // 
            oGRENCI_IDLabel.AutoSize = true;
            oGRENCI_IDLabel.Location = new System.Drawing.Point(92, 117);
            oGRENCI_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oGRENCI_IDLabel.Name = "oGRENCI_IDLabel";
            oGRENCI_IDLabel.Size = new System.Drawing.Size(102, 17);
            oGRENCI_IDLabel.TabIndex = 3;
            oGRENCI_IDLabel.Text = "Student Name:";
            // 
            // oDEME_TARIHILabel
            // 
            oDEME_TARIHILabel.AutoSize = true;
            oDEME_TARIHILabel.Location = new System.Drawing.Point(92, 151);
            oDEME_TARIHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oDEME_TARIHILabel.Name = "oDEME_TARIHILabel";
            oDEME_TARIHILabel.Size = new System.Drawing.Size(101, 17);
            oDEME_TARIHILabel.TabIndex = 5;
            oDEME_TARIHILabel.Text = "Payment Date:";
            // 
            // oDEME_MIKTARILabel
            // 
            oDEME_MIKTARILabel.AutoSize = true;
            oDEME_MIKTARILabel.Location = new System.Drawing.Point(92, 181);
            oDEME_MIKTARILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oDEME_MIKTARILabel.Name = "oDEME_MIKTARILabel";
            oDEME_MIKTARILabel.Size = new System.Drawing.Size(119, 17);
            oDEME_MIKTARILabel.TabIndex = 7;
            oDEME_MIKTARILabel.Text = "Payment Amount:";
            // 
            // oDEDIMILabel
            // 
            oDEDIMILabel.AutoSize = true;
            oDEDIMILabel.Location = new System.Drawing.Point(114, 222);
            oDEDIMILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            oDEDIMILabel.Name = "oDEDIMILabel";
            oDEDIMILabel.Size = new System.Drawing.Size(97, 17);
            oDEDIMILabel.TabIndex = 9;
            oDEDIMILabel.Text = "Indebtedness:";
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.Namespace = "http://tempuri.org/OZEL_ANAOKULUDataSet.xsd";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAKSIT_ODEMELERIBindingSource
            // 
            this.tAKSIT_ODEMELERIBindingSource.DataMember = "TAKSIT_ODEMELERI";
            this.tAKSIT_ODEMELERIBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // tAKSIT_ODEMELERITableAdapter
            // 
            this.tAKSIT_ODEMELERITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEBABADURUMLARITableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KULLANICITableAdapter = null;
            this.tableAdapterManager.OGRENCILERTableAdapter = this.oGRENCILERTableAdapter;
            this.tableAdapterManager.SINIFLARIMIZTableAdapter = null;
            this.tableAdapterManager.TAKSIT_ODEMELERITableAdapter = this.tAKSIT_ODEMELERITableAdapter;
            this.tableAdapterManager.UpdateOrder = OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VELILERTableAdapter = null;
            // 
            // oGRENCILERTableAdapter
            // 
            this.oGRENCILERTableAdapter.ClearBeforeFill = true;
            // 
            // tAKSIT_ODEMELERIBindingNavigator
            // 
            this.tAKSIT_ODEMELERIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tAKSIT_ODEMELERIBindingNavigator.BindingSource = this.tAKSIT_ODEMELERIBindingSource;
            this.tAKSIT_ODEMELERIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tAKSIT_ODEMELERIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tAKSIT_ODEMELERIBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tAKSIT_ODEMELERIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem});
            this.tAKSIT_ODEMELERIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tAKSIT_ODEMELERIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tAKSIT_ODEMELERIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tAKSIT_ODEMELERIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tAKSIT_ODEMELERIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tAKSIT_ODEMELERIBindingNavigator.Name = "tAKSIT_ODEMELERIBindingNavigator";
            this.tAKSIT_ODEMELERIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tAKSIT_ODEMELERIBindingNavigator.Size = new System.Drawing.Size(659, 27);
            this.tAKSIT_ODEMELERIBindingNavigator.TabIndex = 0;
            this.tAKSIT_ODEMELERIBindingNavigator.Text = "bindingNavigator1";
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
            // tAKSIT_ODEMELERIBindingNavigatorSaveItem
            // 
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tAKSIT_ODEMELERIBindingNavigatorSaveItem.Image")));
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.Name = "tAKSIT_ODEMELERIBindingNavigatorSaveItem";
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.Text = "Save Data";
            this.tAKSIT_ODEMELERIBindingNavigatorSaveItem.Click += new System.EventHandler(this.tAKSIT_ODEMELERIBindingNavigatorSaveItem_Click);
            // 
            // oDEME_TARIHIDateTimePicker
            // 
            this.oDEME_TARIHIDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tAKSIT_ODEMELERIBindingSource, "ODEME_TARIHI", true));
            this.oDEME_TARIHIDateTimePicker.Location = new System.Drawing.Point(228, 146);
            this.oDEME_TARIHIDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.oDEME_TARIHIDateTimePicker.Name = "oDEME_TARIHIDateTimePicker";
            this.oDEME_TARIHIDateTimePicker.Size = new System.Drawing.Size(227, 22);
            this.oDEME_TARIHIDateTimePicker.TabIndex = 6;
            // 
            // oDEME_MIKTARITextBox
            // 
            this.oDEME_MIKTARITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tAKSIT_ODEMELERIBindingSource, "ODEME_MIKTARI", true));
            this.oDEME_MIKTARITextBox.Location = new System.Drawing.Point(228, 178);
            this.oDEME_MIKTARITextBox.Margin = new System.Windows.Forms.Padding(4);
            this.oDEME_MIKTARITextBox.Name = "oDEME_MIKTARITextBox";
            this.oDEME_MIKTARITextBox.Size = new System.Drawing.Size(180, 22);
            this.oDEME_MIKTARITextBox.TabIndex = 8;
            // 
            // oDEDIMICheckBox
            // 
            this.oDEDIMICheckBox.BackColor = System.Drawing.Color.White;
            this.oDEDIMICheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tAKSIT_ODEMELERIBindingSource, "ODEDIMI", true));
            this.oDEDIMICheckBox.ForeColor = System.Drawing.Color.White;
            this.oDEDIMICheckBox.Location = new System.Drawing.Point(228, 216);
            this.oDEDIMICheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.oDEDIMICheckBox.Name = "oDEDIMICheckBox";
            this.oDEDIMICheckBox.Size = new System.Drawing.Size(24, 30);
            this.oDEDIMICheckBox.TabIndex = 10;
            this.oDEDIMICheckBox.Text = "checkBox1";
            this.oDEDIMICheckBox.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tAKSIT_ODEMELERIBindingSource, "OGRENCI_ID", true));
            this.comboBox1.DataSource = this.oGRENCILERBindingSource;
            this.comboBox1.DisplayMember = "ADI";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(228, 108);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "OGR_ID";
            // 
            // oGRENCILERBindingSource
            // 
            this.oGRENCILERBindingSource.DataMember = "OGRENCILER";
            this.oGRENCILERBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.oGRENCILERBindingSource;
            this.comboBox2.DisplayMember = "SOYADI";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(397, 108);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // frmTaksitOdemeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.maas_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(659, 332);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(oGRENCI_IDLabel);
            this.Controls.Add(oDEME_TARIHILabel);
            this.Controls.Add(this.oDEME_TARIHIDateTimePicker);
            this.Controls.Add(oDEME_MIKTARILabel);
            this.Controls.Add(this.oDEME_MIKTARITextBox);
            this.Controls.Add(oDEDIMILabel);
            this.Controls.Add(this.oDEDIMICheckBox);
            this.Controls.Add(this.tAKSIT_ODEMELERIBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaksitOdemeleri";
            this.Text = "frmTaksitOdemeleri";
            this.Load += new System.EventHandler(this.frmTaksitOdemeleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSIT_ODEMELERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSIT_ODEMELERIBindingNavigator)).EndInit();
            this.tAKSIT_ODEMELERIBindingNavigator.ResumeLayout(false);
            this.tAKSIT_ODEMELERIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCILERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource tAKSIT_ODEMELERIBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TAKSIT_ODEMELERITableAdapter tAKSIT_ODEMELERITableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tAKSIT_ODEMELERIBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tAKSIT_ODEMELERIBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker oDEME_TARIHIDateTimePicker;
        private System.Windows.Forms.TextBox oDEME_MIKTARITextBox;
        private System.Windows.Forms.CheckBox oDEDIMICheckBox;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.OGRENCILERTableAdapter oGRENCILERTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource oGRENCILERBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}