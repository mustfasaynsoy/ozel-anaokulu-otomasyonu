namespace OZEL_ANAOKULU_OTOMASYONU
{
    partial class bütünform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNIlk = new System.Windows.Forms.Button();
            this.BTNIleri = new System.Windows.Forms.Button();
            this.btnGerı = new System.Windows.Forms.Button();
            this.btnson = new System.Windows.Forms.Button();
            this.btnyeni = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOYADIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINSIYETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOTOGRAFIDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dTARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kACGUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kAYITTARIHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sINIFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOPLAMBORCUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bORCBITTIMIDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sAGLIKDURUMUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNNEBABADURUMUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vELIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oGRENCILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oZEL_ANAOKULUDataSet = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tAKSITODEMELERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAKSIT_ODEMELERITableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TAKSIT_ODEMELERITableAdapter();
            this.oGRENCILERTableAdapter = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.OGRENCILERTableAdapter();
            this.tableAdapterManager = new OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNADIARAMASOYADIFİLTRELEME = new System.Windows.Forms.Button();
            this.BTNVELILER = new System.Windows.Forms.Button();
            this.BTNSINIFLAR = new System.Windows.Forms.Button();
            this.BTNTAKSITLER = new System.Windows.Forms.Button();
            this.BTNANNEBABADURUMU = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSITODEMELERIBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BTNIlk);
            this.panel1.Controls.Add(this.BTNIleri);
            this.panel1.Controls.Add(this.btnGerı);
            this.panel1.Controls.Add(this.btnson);
            this.panel1.Controls.Add(this.btnyeni);
            this.panel1.Controls.Add(this.btnsil);
            this.panel1.Controls.Add(this.btnkaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 89);
            this.panel1.TabIndex = 6;
            // 
            // BTNIlk
            // 
            this.BTNIlk.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIlk.Location = new System.Drawing.Point(-3, -1);
            this.BTNIlk.Margin = new System.Windows.Forms.Padding(4);
            this.BTNIlk.Name = "BTNIlk";
            this.BTNIlk.Size = new System.Drawing.Size(118, 89);
            this.BTNIlk.TabIndex = 7;
            this.BTNIlk.Text = "[<";
            this.BTNIlk.UseVisualStyleBackColor = true;
            this.BTNIlk.Click += new System.EventHandler(this.BTNIlk_Click);
            // 
            // BTNIleri
            // 
            this.BTNIleri.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.sinavekle;
            this.BTNIleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNIleri.Location = new System.Drawing.Point(254, -3);
            this.BTNIleri.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNIleri.Name = "BTNIleri";
            this.BTNIleri.Size = new System.Drawing.Size(113, 95);
            this.BTNIleri.TabIndex = 8;
            this.BTNIleri.UseVisualStyleBackColor = true;
            this.BTNIleri.Click += new System.EventHandler(this.BTNIlerı_Click);
            // 
            // btnGerı
            // 
            this.btnGerı.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.ters;
            this.btnGerı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerı.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGerı.Location = new System.Drawing.Point(510, -1);
            this.btnGerı.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnGerı.Name = "btnGerı";
            this.btnGerı.Size = new System.Drawing.Size(104, 89);
            this.btnGerı.TabIndex = 9;
            this.btnGerı.UseVisualStyleBackColor = true;
            this.btnGerı.Click += new System.EventHandler(this.btnGerı_Click);
            // 
            // btnson
            // 
            this.btnson.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnson.Location = new System.Drawing.Point(711, -1);
            this.btnson.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnson.Name = "btnson";
            this.btnson.Size = new System.Drawing.Size(104, 89);
            this.btnson.TabIndex = 10;
            this.btnson.Text = ">]";
            this.btnson.UseVisualStyleBackColor = true;
            this.btnson.Click += new System.EventHandler(this.btnson_Click);
            // 
            // btnyeni
            // 
            this.btnyeni.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.yeni;
            this.btnyeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnyeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyeni.Location = new System.Drawing.Point(934, -1);
            this.btnyeni.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnyeni.Name = "btnyeni";
            this.btnyeni.Size = new System.Drawing.Size(96, 89);
            this.btnyeni.TabIndex = 11;
            this.btnyeni.UseVisualStyleBackColor = true;
            this.btnyeni.Click += new System.EventHandler(this.btnyeni_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.hepsim;
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(1127, -2);
            this.btnsil.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(93, 89);
            this.btnsil.TabIndex = 12;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.disket_48;
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(1328, -3);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(89, 90);
            this.btnkaydet.TabIndex = 13;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aDIDataGridViewTextBoxColumn,
            this.sOYADIDataGridViewTextBoxColumn,
            this.cINSIYETDataGridViewTextBoxColumn,
            this.fOTOGRAFIDataGridViewImageColumn,
            this.dTARIHIDataGridViewTextBoxColumn,
            this.kACGUNDataGridViewTextBoxColumn,
            this.kAYITTARIHIDataGridViewTextBoxColumn,
            this.sINIFIDDataGridViewTextBoxColumn,
            this.tOPLAMBORCUDataGridViewTextBoxColumn,
            this.bORCBITTIMIDataGridViewCheckBoxColumn,
            this.sAGLIKDURUMUDataGridViewTextBoxColumn,
            this.aNNEBABADURUMUDataGridViewTextBoxColumn,
            this.vELIIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oGRENCILERBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 361);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1419, 176);
            this.dataGridView1.TabIndex = 7;
            // 
            // aDIDataGridViewTextBoxColumn
            // 
            this.aDIDataGridViewTextBoxColumn.DataPropertyName = "ADI";
            this.aDIDataGridViewTextBoxColumn.HeaderText = "ADI";
            this.aDIDataGridViewTextBoxColumn.Name = "aDIDataGridViewTextBoxColumn";
            // 
            // sOYADIDataGridViewTextBoxColumn
            // 
            this.sOYADIDataGridViewTextBoxColumn.DataPropertyName = "SOYADI";
            this.sOYADIDataGridViewTextBoxColumn.HeaderText = "SOYADI";
            this.sOYADIDataGridViewTextBoxColumn.Name = "sOYADIDataGridViewTextBoxColumn";
            // 
            // cINSIYETDataGridViewTextBoxColumn
            // 
            this.cINSIYETDataGridViewTextBoxColumn.DataPropertyName = "CINSIYET";
            this.cINSIYETDataGridViewTextBoxColumn.HeaderText = "CINSIYET";
            this.cINSIYETDataGridViewTextBoxColumn.Name = "cINSIYETDataGridViewTextBoxColumn";
            // 
            // fOTOGRAFIDataGridViewImageColumn
            // 
            this.fOTOGRAFIDataGridViewImageColumn.DataPropertyName = "FOTOGRAFI";
            this.fOTOGRAFIDataGridViewImageColumn.HeaderText = "FOTOGRAFI";
            this.fOTOGRAFIDataGridViewImageColumn.Name = "fOTOGRAFIDataGridViewImageColumn";
            // 
            // dTARIHIDataGridViewTextBoxColumn
            // 
            this.dTARIHIDataGridViewTextBoxColumn.DataPropertyName = "D_TARIHI";
            this.dTARIHIDataGridViewTextBoxColumn.HeaderText = "D_TARIHI";
            this.dTARIHIDataGridViewTextBoxColumn.Name = "dTARIHIDataGridViewTextBoxColumn";
            // 
            // kACGUNDataGridViewTextBoxColumn
            // 
            this.kACGUNDataGridViewTextBoxColumn.DataPropertyName = "KACGUN";
            this.kACGUNDataGridViewTextBoxColumn.HeaderText = "KACGUN";
            this.kACGUNDataGridViewTextBoxColumn.Name = "kACGUNDataGridViewTextBoxColumn";
            // 
            // kAYITTARIHIDataGridViewTextBoxColumn
            // 
            this.kAYITTARIHIDataGridViewTextBoxColumn.DataPropertyName = "KAYIT_TARIHI";
            this.kAYITTARIHIDataGridViewTextBoxColumn.HeaderText = "KAYIT_TARIHI";
            this.kAYITTARIHIDataGridViewTextBoxColumn.Name = "kAYITTARIHIDataGridViewTextBoxColumn";
            // 
            // sINIFIDDataGridViewTextBoxColumn
            // 
            this.sINIFIDDataGridViewTextBoxColumn.DataPropertyName = "SINIF_ID";
            this.sINIFIDDataGridViewTextBoxColumn.HeaderText = "SINIF_ID";
            this.sINIFIDDataGridViewTextBoxColumn.Name = "sINIFIDDataGridViewTextBoxColumn";
            // 
            // tOPLAMBORCUDataGridViewTextBoxColumn
            // 
            this.tOPLAMBORCUDataGridViewTextBoxColumn.DataPropertyName = "TOPLAMBORCU";
            this.tOPLAMBORCUDataGridViewTextBoxColumn.HeaderText = "TOPLAMBORCU";
            this.tOPLAMBORCUDataGridViewTextBoxColumn.Name = "tOPLAMBORCUDataGridViewTextBoxColumn";
            // 
            // bORCBITTIMIDataGridViewCheckBoxColumn
            // 
            this.bORCBITTIMIDataGridViewCheckBoxColumn.DataPropertyName = "BORCBITTIMI";
            this.bORCBITTIMIDataGridViewCheckBoxColumn.HeaderText = "BORCBITTIMI";
            this.bORCBITTIMIDataGridViewCheckBoxColumn.Name = "bORCBITTIMIDataGridViewCheckBoxColumn";
            // 
            // sAGLIKDURUMUDataGridViewTextBoxColumn
            // 
            this.sAGLIKDURUMUDataGridViewTextBoxColumn.DataPropertyName = "SAGLIK_DURUMU";
            this.sAGLIKDURUMUDataGridViewTextBoxColumn.HeaderText = "SAGLIK_DURUMU";
            this.sAGLIKDURUMUDataGridViewTextBoxColumn.Name = "sAGLIKDURUMUDataGridViewTextBoxColumn";
            // 
            // aNNEBABADURUMUDataGridViewTextBoxColumn
            // 
            this.aNNEBABADURUMUDataGridViewTextBoxColumn.DataPropertyName = "ANNEBABADURUMU";
            this.aNNEBABADURUMUDataGridViewTextBoxColumn.HeaderText = "ANNEBABADURUMU";
            this.aNNEBABADURUMUDataGridViewTextBoxColumn.Name = "aNNEBABADURUMUDataGridViewTextBoxColumn";
            // 
            // vELIIDDataGridViewTextBoxColumn
            // 
            this.vELIIDDataGridViewTextBoxColumn.DataPropertyName = "VELI_ID";
            this.vELIIDDataGridViewTextBoxColumn.HeaderText = "VELI_ID";
            this.vELIIDDataGridViewTextBoxColumn.Name = "vELIIDDataGridViewTextBoxColumn";
            // 
            // oGRENCILERBindingSource
            // 
            this.oGRENCILERBindingSource.DataMember = "OGRENCILER";
            this.oGRENCILERBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // oZEL_ANAOKULUDataSet
            // 
            this.oZEL_ANAOKULUDataSet.DataSetName = "OZEL_ANAOKULUDataSet";
            this.oZEL_ANAOKULUDataSet.Namespace = "http://tempuri.org/OZEL_ANAOKULUDataSet.xsd";
            this.oZEL_ANAOKULUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // tAKSITODEMELERIBindingSource
            // 
            this.tAKSITODEMELERIBindingSource.DataMember = "TAKSIT_ODEMELERI";
            this.tAKSITODEMELERIBindingSource.DataSource = this.oZEL_ANAOKULUDataSet;
            // 
            // tAKSIT_ODEMELERITableAdapter
            // 
            this.tAKSIT_ODEMELERITableAdapter.ClearBeforeFill = true;
            // 
            // oGRENCILERTableAdapter
            // 
            this.oGRENCILERTableAdapter.ClearBeforeFill = true;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.BTNADIARAMASOYADIFİLTRELEME);
            this.panel2.Controls.Add(this.BTNVELILER);
            this.panel2.Controls.Add(this.BTNSINIFLAR);
            this.panel2.Controls.Add(this.BTNTAKSITLER);
            this.panel2.Controls.Add(this.BTNANNEBABADURUMU);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1419, 93);
            this.panel2.TabIndex = 14;
            // 
            // BTNADIARAMASOYADIFİLTRELEME
            // 
            this.BTNADIARAMASOYADIFİLTRELEME.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.analiz;
            this.BTNADIARAMASOYADIFİLTRELEME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNADIARAMASOYADIFİLTRELEME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNADIARAMASOYADIFİLTRELEME.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNADIARAMASOYADIFİLTRELEME.Location = new System.Drawing.Point(1229, -2);
            this.BTNADIARAMASOYADIFİLTRELEME.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNADIARAMASOYADIFİLTRELEME.Name = "BTNADIARAMASOYADIFİLTRELEME";
            this.BTNADIARAMASOYADIFİLTRELEME.Size = new System.Drawing.Size(188, 96);
            this.BTNADIARAMASOYADIFİLTRELEME.TabIndex = 14;
            this.BTNADIARAMASOYADIFİLTRELEME.Text = "Name Search Surname Filtering";
            this.BTNADIARAMASOYADIFİLTRELEME.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNADIARAMASOYADIFİLTRELEME.UseVisualStyleBackColor = true;
            this.BTNADIARAMASOYADIFİLTRELEME.Click += new System.EventHandler(this.BTNADIARAMASOYADIFİLTRELEME_Click);
            // 
            // BTNVELILER
            // 
            this.BTNVELILER.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.accessibilitycpl_dll_I0146_0409;
            this.BTNVELILER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNVELILER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNVELILER.ForeColor = System.Drawing.Color.Black;
            this.BTNVELILER.Location = new System.Drawing.Point(39, -2);
            this.BTNVELILER.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNVELILER.Name = "BTNVELILER";
            this.BTNVELILER.Size = new System.Drawing.Size(144, 94);
            this.BTNVELILER.TabIndex = 8;
            this.BTNVELILER.Text = "Parents";
            this.BTNVELILER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNVELILER.UseVisualStyleBackColor = true;
            this.BTNVELILER.Click += new System.EventHandler(this.BTNVELILER_Click);
            // 
            // BTNSINIFLAR
            // 
            this.BTNSINIFLAR.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.ders1;
            this.BTNSINIFLAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNSINIFLAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNSINIFLAR.ForeColor = System.Drawing.Color.Black;
            this.BTNSINIFLAR.Location = new System.Drawing.Point(978, -3);
            this.BTNSINIFLAR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNSINIFLAR.Name = "BTNSINIFLAR";
            this.BTNSINIFLAR.Size = new System.Drawing.Size(139, 94);
            this.BTNSINIFLAR.TabIndex = 10;
            this.BTNSINIFLAR.Text = "Our class";
            this.BTNSINIFLAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNSINIFLAR.UseVisualStyleBackColor = true;
            this.BTNSINIFLAR.Click += new System.EventHandler(this.BTNSINIFLAR_Click);
            // 
            // BTNTAKSITLER
            // 
            this.BTNTAKSITLER.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.g_sozu;
            this.BTNTAKSITLER.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNTAKSITLER.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNTAKSITLER.ForeColor = System.Drawing.Color.Black;
            this.BTNTAKSITLER.Location = new System.Drawing.Point(711, -3);
            this.BTNTAKSITLER.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNTAKSITLER.Name = "BTNTAKSITLER";
            this.BTNTAKSITLER.Size = new System.Drawing.Size(139, 96);
            this.BTNTAKSITLER.TabIndex = 12;
            this.BTNTAKSITLER.Text = "Installments";
            this.BTNTAKSITLER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNTAKSITLER.UseVisualStyleBackColor = true;
            this.BTNTAKSITLER.Click += new System.EventHandler(this.BTNTAKSITLER_Click);
            // 
            // BTNANNEBABADURUMU
            // 
            this.BTNANNEBABADURUMU.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.musteri;
            this.BTNANNEBABADURUMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNANNEBABADURUMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNANNEBABADURUMU.ForeColor = System.Drawing.Color.Black;
            this.BTNANNEBABADURUMU.Location = new System.Drawing.Point(377, 0);
            this.BTNANNEBABADURUMU.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.BTNANNEBABADURUMU.Name = "BTNANNEBABADURUMU";
            this.BTNANNEBABADURUMU.Size = new System.Drawing.Size(173, 94);
            this.BTNANNEBABADURUMU.TabIndex = 11;
            this.BTNANNEBABADURUMU.Text = "Parents Situations";
            this.BTNANNEBABADURUMU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNANNEBABADURUMU.UseVisualStyleBackColor = true;
            this.BTNANNEBABADURUMU.Click += new System.EventHandler(this.BTNANNEBABADURUMU_Click);
            // 
            // bütünform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OZEL_ANAOKULU_OTOMASYONU.Properties.Resources.resim11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1419, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "bütünform";
            this.Text = "bütünform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oGRENCILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oZEL_ANAOKULUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAKSITODEMELERIBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNIlk;
        private System.Windows.Forms.Button BTNIleri;
        private System.Windows.Forms.Button btnGerı;
        private System.Windows.Forms.Button btnson;
        private System.Windows.Forms.Button btnyeni;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OZEL_ANAOKULUDataSet oZEL_ANAOKULUDataSet;
        private System.Windows.Forms.BindingSource tAKSITODEMELERIBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TAKSIT_ODEMELERITableAdapter tAKSIT_ODEMELERITableAdapter;
        private System.Windows.Forms.BindingSource oGRENCILERBindingSource;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.OGRENCILERTableAdapter oGRENCILERTableAdapter;
        private OZEL_ANAOKULU_OTOMASYONU.OZEL_ANAOKULUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOYADIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINSIYETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fOTOGRAFIDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kACGUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAYITTARIHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sINIFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOPLAMBORCUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bORCBITTIMIDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAGLIKDURUMUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNNEBABADURUMUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vELIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNADIARAMASOYADIFİLTRELEME;
        private System.Windows.Forms.Button BTNVELILER;
        private System.Windows.Forms.Button BTNSINIFLAR;
        private System.Windows.Forms.Button BTNTAKSITLER;
        private System.Windows.Forms.Button BTNANNEBABADURUMU;
    }
}

