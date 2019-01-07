namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class LOGIN
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
            System.Windows.Forms.Label kULLANICILabel;
            System.Windows.Forms.Label pAROLALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            this.button1 = new System.Windows.Forms.Button();
            this.kULLANICIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.kULLANICITableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.KULLANICITableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            kULLANICILabel = new System.Windows.Forms.Label();
            pAROLALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kULLANICILabel
            // 
            kULLANICILabel.AutoSize = true;
            kULLANICILabel.BackColor = System.Drawing.Color.White;
            kULLANICILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            kULLANICILabel.Location = new System.Drawing.Point(117, 96);
            kULLANICILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            kULLANICILabel.Name = "kULLANICILabel";
            kULLANICILabel.Size = new System.Drawing.Size(85, 29);
            kULLANICILabel.TabIndex = 1;
            kULLANICILabel.Text = "USER:";
            // 
            // pAROLALabel
            // 
            pAROLALabel.AutoSize = true;
            pAROLALabel.BackColor = System.Drawing.Color.White;
            pAROLALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            pAROLALabel.Location = new System.Drawing.Point(117, 136);
            pAROLALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pAROLALabel.Name = "pAROLALabel";
            pAROLALabel.Size = new System.Drawing.Size(157, 29);
            pAROLALabel.TabIndex = 3;
            pAROLALabel.Text = "PASSWORD:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(413, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kULLANICIBindingSource
            // 
            this.kULLANICIBindingSource.DataMember = "KULLANICI";
            this.kULLANICIBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.Namespace = "http://tempuri.org/OZEL_ANAOKULUDataSet.xsd";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kULLANICITableAdapter
            // 
            this.kULLANICITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANNEBABADURUMLARITableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KULLANICITableAdapter = this.kULLANICITableAdapter;
            this.tableAdapterManager.OGRENCILERTableAdapter = null;
            this.tableAdapterManager.SINIFLARIMIZTableAdapter = null;
            this.tableAdapterManager.TAKSIT_ODEMELERITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VELILERTableAdapter = null;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(296, 135);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 30);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1234";
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(298, 88);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "mustafasayınsoy";
            // 
            // LOGIN
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.anaokulu_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(636, 375);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(kULLANICILabel);
            this.Controls.Add(pAROLALabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kULLANICIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource kULLANICIBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.KULLANICITableAdapter kULLANICITableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}