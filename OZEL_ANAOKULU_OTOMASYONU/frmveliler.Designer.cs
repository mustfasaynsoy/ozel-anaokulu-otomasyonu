namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class frmveliler
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
            System.Windows.Forms.Label aDISOYADILabel;
            System.Windows.Forms.Label aDRESLabel;
            System.Windows.Forms.Label cEP_TELLabel;
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.vELILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vELILERTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.VELILERTableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            aDISOYADILabel = new System.Windows.Forms.Label();
            aDRESLabel = new System.Windows.Forms.Label();
            cEP_TELLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vELILERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDISOYADILabel
            // 
            aDISOYADILabel.AutoSize = true;
            aDISOYADILabel.BackColor = System.Drawing.Color.Black;
            aDISOYADILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aDISOYADILabel.ForeColor = System.Drawing.Color.White;
            aDISOYADILabel.Location = new System.Drawing.Point(301, 127);
            aDISOYADILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aDISOYADILabel.Name = "aDISOYADILabel";
            aDISOYADILabel.Size = new System.Drawing.Size(187, 29);
            aDISOYADILabel.TabIndex = 3;
            aDISOYADILabel.Text = "Name Surname:";
            // 
            // aDRESLabel
            // 
            aDRESLabel.AutoSize = true;
            aDRESLabel.BackColor = System.Drawing.Color.Black;
            aDRESLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aDRESLabel.ForeColor = System.Drawing.Color.White;
            aDRESLabel.Location = new System.Drawing.Point(302, 169);
            aDRESLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aDRESLabel.Name = "aDRESLabel";
            aDRESLabel.Size = new System.Drawing.Size(108, 29);
            aDRESLabel.TabIndex = 5;
            aDRESLabel.Text = "Address:";
            // 
            // cEP_TELLabel
            // 
            cEP_TELLabel.AutoSize = true;
            cEP_TELLabel.BackColor = System.Drawing.Color.Black;
            cEP_TELLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cEP_TELLabel.ForeColor = System.Drawing.Color.White;
            cEP_TELLabel.Location = new System.Drawing.Point(302, 212);
            cEP_TELLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cEP_TELLabel.Name = "cEP_TELLabel";
            cEP_TELLabel.Size = new System.Drawing.Size(186, 29);
            cEP_TELLabel.TabIndex = 7;
            cEP_TELLabel.Text = "Mobile Number:";
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vELILERBindingSource
            // 
            this.vELILERBindingSource.DataMember = "VELILER";
            this.vELILERBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // vELILERTableAdapter
            // 
            this.vELILERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEBABADURUMLARITableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KULLANICITableAdapter = null;
            this.tableAdapterManager.OGRENCILERTableAdapter = null;
            this.tableAdapterManager.SINIFLARIMIZTableAdapter = null;
            this.tableAdapterManager.TAKSIT_ODEMELERITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VELILERTableAdapter = this.vELILERTableAdapter;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.vELILERBindingSource;
            this.comboBox2.DisplayMember = "ADISOYADI";
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.ForeColor = System.Drawing.Color.Black;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(507, 127);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(296, 33);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "VELI_ID";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.vELILERBindingSource;
            this.comboBox3.DisplayMember = "ADRES";
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(507, 169);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(296, 33);
            this.comboBox3.TabIndex = 10;
            this.comboBox3.ValueMember = "VELI_ID";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.vELILERBindingSource;
            this.comboBox4.DisplayMember = "CEP_TEL";
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(507, 212);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(296, 33);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.ValueMember = "VELI_ID";
            // 
            // frmveliler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.aile_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(838, 378);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(aDISOYADILabel);
            this.Controls.Add(aDRESLabel);
            this.Controls.Add(cEP_TELLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmveliler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmveliler";
            this.Load += new System.EventHandler(this.frmveliler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vELILERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource vELILERBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.VELILERTableAdapter vELILERTableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}