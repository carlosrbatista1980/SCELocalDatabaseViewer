namespace SCELocalDatabaseViewer
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nFCeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFCeLocalDBDataSet = new SCELocalDatabaseViewer.NFCeLocalDBDataSet();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nFCeTableAdapter = new SCELocalDatabaseViewer.NFCeLocalDBDataSetTableAdapters.NFCeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contigencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataHoraContingencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotivoContigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCEVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XmlProcNFePadrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersaoLeiaute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltNumeroNFCe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMLDataTableConfig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMLDataTableEmitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltNumeroNFSe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XmlProcNFSePadrao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersaoLeiauteNFSe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMD5_NFCeValid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsMD5_NFSeValid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MD5_NFCe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5_NFSe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMLDataTableItemServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloquearContingencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BloquearContHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloquearContForaPrazo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nFCeConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nFCeConfigTableAdapter = new SCELocalDatabaseViewer.NFCeLocalDBDataSetTableAdapters.NFCeConfigTableAdapter();
            this.nFCeLocalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contigenciaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataHoraContingenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoContigenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCEVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlProcNFePadraoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versaoLeiauteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultNumeroNFCeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMLDataTableConfigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMLDataTableEmitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultNumeroNFSeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlProcNFSePadraoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versaoLeiauteNFSeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isMD5NFCeValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isMD5NFSeValidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mD5NFCeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mD5NFSeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMLDataTableItemServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloquearContingenciaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bloquearContHorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloquearContForaPrazoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlProcNFeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versaoLeiauteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataHoraAutorizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataHoraCanceladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoCanceladoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chaveNFEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeLocalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeLocalDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serieDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.xmlProcNFeDataGridViewTextBoxColumn,
            this.iDVENDADataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.versaoLeiauteDataGridViewTextBoxColumn,
            this.autorizadoDataGridViewCheckBoxColumn,
            this.dataHoraAutorizadoDataGridViewTextBoxColumn,
            this.canceladoDataGridViewCheckBoxColumn,
            this.dataHoraCanceladoDataGridViewTextBoxColumn,
            this.motivoCanceladoDataGridViewTextBoxColumn,
            this.importadoDataGridViewCheckBoxColumn,
            this.chaveNFEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nFCeBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.OldLace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 407);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarVisual);
            // 
            // nFCeBindingSource
            // 
            this.nFCeBindingSource.DataMember = "NFCe";
            this.nFCeBindingSource.DataSource = this.nFCeLocalDBDataSet;
            // 
            // nFCeLocalDBDataSet
            // 
            this.nFCeLocalDBDataSet.DataSetName = "NFCeLocalDBDataSet";
            this.nFCeLocalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(104, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(623, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Carregar SDF";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "SALVAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(203, 39);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(141, 27);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arquivo SDF:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SCELocalDatabaseViewer.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(904, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 70);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 426);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela NFCe";
            // 
            // nFCeTableAdapter
            // 
            this.nFCeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 110);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabela NFCeConfig";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Serie,
            this.Contigencia,
            this.DataHoraContingencia,
            this.MotivoContigencia,
            this.SCEVersion,
            this.CNPJ,
            this.XmlProcNFePadrao,
            this.VersaoLeiaute,
            this.UltNumeroNFCe,
            this.XMLDataTableConfig,
            this.XMLDataTableEmitente,
            this.UltNumeroNFSe,
            this.XmlProcNFSePadrao,
            this.VersaoLeiauteNFSe,
            this.IsMD5_NFCeValid,
            this.IsMD5_NFSeValid,
            this.MD5_NFCe,
            this.MD5_NFSe,
            this.XMLDataTableItemServico,
            this.BloquearContingencia,
            this.BloquearContHoras,
            this.BloquearContForaPrazo,
            this.idDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn1,
            this.contigenciaDataGridViewCheckBoxColumn,
            this.dataHoraContingenciaDataGridViewTextBoxColumn,
            this.motivoContigenciaDataGridViewTextBoxColumn,
            this.sCEVersionDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn1,
            this.xmlProcNFePadraoDataGridViewTextBoxColumn,
            this.versaoLeiauteDataGridViewTextBoxColumn1,
            this.ultNumeroNFCeDataGridViewTextBoxColumn,
            this.xMLDataTableConfigDataGridViewTextBoxColumn,
            this.xMLDataTableEmitenteDataGridViewTextBoxColumn,
            this.ultNumeroNFSeDataGridViewTextBoxColumn,
            this.xmlProcNFSePadraoDataGridViewTextBoxColumn,
            this.versaoLeiauteNFSeDataGridViewTextBoxColumn,
            this.isMD5NFCeValidDataGridViewCheckBoxColumn,
            this.isMD5NFSeValidDataGridViewCheckBoxColumn,
            this.mD5NFCeDataGridViewTextBoxColumn,
            this.mD5NFSeDataGridViewTextBoxColumn,
            this.xMLDataTableItemServicoDataGridViewTextBoxColumn,
            this.bloquearContingenciaDataGridViewCheckBoxColumn,
            this.bloquearContHorasDataGridViewTextBoxColumn,
            this.bloquearContForaPrazoDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.nFCeConfigBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1151, 90);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditarVisual2);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            // 
            // Contigencia
            // 
            this.Contigencia.DataPropertyName = "Contigencia";
            this.Contigencia.HeaderText = "Contigencia";
            this.Contigencia.Name = "Contigencia";
            // 
            // DataHoraContingencia
            // 
            this.DataHoraContingencia.DataPropertyName = "DataHoraContingencia";
            this.DataHoraContingencia.HeaderText = "DataHoraContingencia";
            this.DataHoraContingencia.Name = "DataHoraContingencia";
            // 
            // MotivoContigencia
            // 
            this.MotivoContigencia.DataPropertyName = "MotivoContigencia";
            this.MotivoContigencia.HeaderText = "MotivoContigencia";
            this.MotivoContigencia.Name = "MotivoContigencia";
            // 
            // SCEVersion
            // 
            this.SCEVersion.DataPropertyName = "SCEVersion";
            this.SCEVersion.HeaderText = "SCEVersion";
            this.SCEVersion.Name = "SCEVersion";
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // XmlProcNFePadrao
            // 
            this.XmlProcNFePadrao.DataPropertyName = "XmlProcNFePadrao";
            this.XmlProcNFePadrao.HeaderText = "XmlProcNFePadrao";
            this.XmlProcNFePadrao.Name = "XmlProcNFePadrao";
            // 
            // VersaoLeiaute
            // 
            this.VersaoLeiaute.DataPropertyName = "VersaoLeiaute";
            this.VersaoLeiaute.HeaderText = "VersaoLeiaute";
            this.VersaoLeiaute.Name = "VersaoLeiaute";
            // 
            // UltNumeroNFCe
            // 
            this.UltNumeroNFCe.DataPropertyName = "UltNumeroNFCe";
            this.UltNumeroNFCe.HeaderText = "UltNumeroNFCe";
            this.UltNumeroNFCe.Name = "UltNumeroNFCe";
            // 
            // XMLDataTableConfig
            // 
            this.XMLDataTableConfig.DataPropertyName = "XMLDataTableConfig";
            this.XMLDataTableConfig.HeaderText = "XMLDataTableConfig";
            this.XMLDataTableConfig.Name = "XMLDataTableConfig";
            // 
            // XMLDataTableEmitente
            // 
            this.XMLDataTableEmitente.DataPropertyName = "XMLDataTableEmitente";
            this.XMLDataTableEmitente.HeaderText = "XMLDataTableEmitente";
            this.XMLDataTableEmitente.Name = "XMLDataTableEmitente";
            // 
            // UltNumeroNFSe
            // 
            this.UltNumeroNFSe.DataPropertyName = "UltNumeroNFSe";
            this.UltNumeroNFSe.HeaderText = "UltNumeroNFSe";
            this.UltNumeroNFSe.Name = "UltNumeroNFSe";
            // 
            // XmlProcNFSePadrao
            // 
            this.XmlProcNFSePadrao.DataPropertyName = "XmlProcNFSePadrao";
            this.XmlProcNFSePadrao.HeaderText = "XmlProcNFSePadrao";
            this.XmlProcNFSePadrao.Name = "XmlProcNFSePadrao";
            // 
            // VersaoLeiauteNFSe
            // 
            this.VersaoLeiauteNFSe.DataPropertyName = "VersaoLeiauteNFSe";
            this.VersaoLeiauteNFSe.HeaderText = "VersaoLeiauteNFSe";
            this.VersaoLeiauteNFSe.Name = "VersaoLeiauteNFSe";
            // 
            // IsMD5_NFCeValid
            // 
            this.IsMD5_NFCeValid.DataPropertyName = "IsMD5_NFCeValid";
            this.IsMD5_NFCeValid.HeaderText = "IsMD5_NFCeValid";
            this.IsMD5_NFCeValid.Name = "IsMD5_NFCeValid";
            // 
            // IsMD5_NFSeValid
            // 
            this.IsMD5_NFSeValid.DataPropertyName = "IsMD5_NFSeValid";
            this.IsMD5_NFSeValid.HeaderText = "IsMD5_NFSeValid";
            this.IsMD5_NFSeValid.Name = "IsMD5_NFSeValid";
            // 
            // MD5_NFCe
            // 
            this.MD5_NFCe.DataPropertyName = "MD5_NFCe";
            this.MD5_NFCe.HeaderText = "MD5_NFCe";
            this.MD5_NFCe.Name = "MD5_NFCe";
            // 
            // MD5_NFSe
            // 
            this.MD5_NFSe.DataPropertyName = "MD5_NFSe";
            this.MD5_NFSe.HeaderText = "MD5_NFSe";
            this.MD5_NFSe.Name = "MD5_NFSe";
            // 
            // XMLDataTableItemServico
            // 
            this.XMLDataTableItemServico.DataPropertyName = "XMLDataTableItemServico";
            this.XMLDataTableItemServico.HeaderText = "XMLDataTableItemServico";
            this.XMLDataTableItemServico.Name = "XMLDataTableItemServico";
            // 
            // BloquearContingencia
            // 
            this.BloquearContingencia.DataPropertyName = "BloquearContingencia";
            this.BloquearContingencia.HeaderText = "BloquearContingencia";
            this.BloquearContingencia.Name = "BloquearContingencia";
            // 
            // BloquearContHoras
            // 
            this.BloquearContHoras.DataPropertyName = "BloquearContHoras";
            this.BloquearContHoras.HeaderText = "BloquearContHoras";
            this.BloquearContHoras.Name = "BloquearContHoras";
            // 
            // BloquearContForaPrazo
            // 
            this.BloquearContForaPrazo.DataPropertyName = "BloquearContForaPrazo";
            this.BloquearContForaPrazo.HeaderText = "BloquearContForaPrazo";
            this.BloquearContForaPrazo.Name = "BloquearContForaPrazo";
            // 
            // nFCeConfigBindingSource
            // 
            this.nFCeConfigBindingSource.DataMember = "NFCeConfig";
            this.nFCeConfigBindingSource.DataSource = this.nFCeLocalDBDataSet;
            // 
            // nFCeConfigTableAdapter
            // 
            this.nFCeConfigTableAdapter.ClearBeforeFill = true;
            // 
            // nFCeLocalDBDataSetBindingSource
            // 
            this.nFCeLocalDBDataSetBindingSource.DataSource = this.nFCeLocalDBDataSet;
            this.nFCeLocalDBDataSetBindingSource.Position = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn1
            // 
            this.serieDataGridViewTextBoxColumn1.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn1.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn1.Name = "serieDataGridViewTextBoxColumn1";
            // 
            // contigenciaDataGridViewCheckBoxColumn
            // 
            this.contigenciaDataGridViewCheckBoxColumn.DataPropertyName = "Contigencia";
            this.contigenciaDataGridViewCheckBoxColumn.HeaderText = "Contigencia";
            this.contigenciaDataGridViewCheckBoxColumn.Name = "contigenciaDataGridViewCheckBoxColumn";
            // 
            // dataHoraContingenciaDataGridViewTextBoxColumn
            // 
            this.dataHoraContingenciaDataGridViewTextBoxColumn.DataPropertyName = "DataHoraContingencia";
            this.dataHoraContingenciaDataGridViewTextBoxColumn.HeaderText = "DataHoraContingencia";
            this.dataHoraContingenciaDataGridViewTextBoxColumn.Name = "dataHoraContingenciaDataGridViewTextBoxColumn";
            // 
            // motivoContigenciaDataGridViewTextBoxColumn
            // 
            this.motivoContigenciaDataGridViewTextBoxColumn.DataPropertyName = "MotivoContigencia";
            this.motivoContigenciaDataGridViewTextBoxColumn.HeaderText = "MotivoContigencia";
            this.motivoContigenciaDataGridViewTextBoxColumn.Name = "motivoContigenciaDataGridViewTextBoxColumn";
            // 
            // sCEVersionDataGridViewTextBoxColumn
            // 
            this.sCEVersionDataGridViewTextBoxColumn.DataPropertyName = "SCEVersion";
            this.sCEVersionDataGridViewTextBoxColumn.HeaderText = "SCEVersion";
            this.sCEVersionDataGridViewTextBoxColumn.Name = "sCEVersionDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn1
            // 
            this.cNPJDataGridViewTextBoxColumn1.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn1.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn1.Name = "cNPJDataGridViewTextBoxColumn1";
            // 
            // xmlProcNFePadraoDataGridViewTextBoxColumn
            // 
            this.xmlProcNFePadraoDataGridViewTextBoxColumn.DataPropertyName = "XmlProcNFePadrao";
            this.xmlProcNFePadraoDataGridViewTextBoxColumn.HeaderText = "XmlProcNFePadrao";
            this.xmlProcNFePadraoDataGridViewTextBoxColumn.Name = "xmlProcNFePadraoDataGridViewTextBoxColumn";
            // 
            // versaoLeiauteDataGridViewTextBoxColumn1
            // 
            this.versaoLeiauteDataGridViewTextBoxColumn1.DataPropertyName = "VersaoLeiaute";
            this.versaoLeiauteDataGridViewTextBoxColumn1.HeaderText = "VersaoLeiaute";
            this.versaoLeiauteDataGridViewTextBoxColumn1.Name = "versaoLeiauteDataGridViewTextBoxColumn1";
            // 
            // ultNumeroNFCeDataGridViewTextBoxColumn
            // 
            this.ultNumeroNFCeDataGridViewTextBoxColumn.DataPropertyName = "UltNumeroNFCe";
            this.ultNumeroNFCeDataGridViewTextBoxColumn.HeaderText = "UltNumeroNFCe";
            this.ultNumeroNFCeDataGridViewTextBoxColumn.Name = "ultNumeroNFCeDataGridViewTextBoxColumn";
            // 
            // xMLDataTableConfigDataGridViewTextBoxColumn
            // 
            this.xMLDataTableConfigDataGridViewTextBoxColumn.DataPropertyName = "XMLDataTableConfig";
            this.xMLDataTableConfigDataGridViewTextBoxColumn.HeaderText = "XMLDataTableConfig";
            this.xMLDataTableConfigDataGridViewTextBoxColumn.Name = "xMLDataTableConfigDataGridViewTextBoxColumn";
            // 
            // xMLDataTableEmitenteDataGridViewTextBoxColumn
            // 
            this.xMLDataTableEmitenteDataGridViewTextBoxColumn.DataPropertyName = "XMLDataTableEmitente";
            this.xMLDataTableEmitenteDataGridViewTextBoxColumn.HeaderText = "XMLDataTableEmitente";
            this.xMLDataTableEmitenteDataGridViewTextBoxColumn.Name = "xMLDataTableEmitenteDataGridViewTextBoxColumn";
            // 
            // ultNumeroNFSeDataGridViewTextBoxColumn
            // 
            this.ultNumeroNFSeDataGridViewTextBoxColumn.DataPropertyName = "UltNumeroNFSe";
            this.ultNumeroNFSeDataGridViewTextBoxColumn.HeaderText = "UltNumeroNFSe";
            this.ultNumeroNFSeDataGridViewTextBoxColumn.Name = "ultNumeroNFSeDataGridViewTextBoxColumn";
            // 
            // xmlProcNFSePadraoDataGridViewTextBoxColumn
            // 
            this.xmlProcNFSePadraoDataGridViewTextBoxColumn.DataPropertyName = "XmlProcNFSePadrao";
            this.xmlProcNFSePadraoDataGridViewTextBoxColumn.HeaderText = "XmlProcNFSePadrao";
            this.xmlProcNFSePadraoDataGridViewTextBoxColumn.Name = "xmlProcNFSePadraoDataGridViewTextBoxColumn";
            // 
            // versaoLeiauteNFSeDataGridViewTextBoxColumn
            // 
            this.versaoLeiauteNFSeDataGridViewTextBoxColumn.DataPropertyName = "VersaoLeiauteNFSe";
            this.versaoLeiauteNFSeDataGridViewTextBoxColumn.HeaderText = "VersaoLeiauteNFSe";
            this.versaoLeiauteNFSeDataGridViewTextBoxColumn.Name = "versaoLeiauteNFSeDataGridViewTextBoxColumn";
            // 
            // isMD5NFCeValidDataGridViewCheckBoxColumn
            // 
            this.isMD5NFCeValidDataGridViewCheckBoxColumn.DataPropertyName = "IsMD5_NFCeValid";
            this.isMD5NFCeValidDataGridViewCheckBoxColumn.HeaderText = "IsMD5_NFCeValid";
            this.isMD5NFCeValidDataGridViewCheckBoxColumn.Name = "isMD5NFCeValidDataGridViewCheckBoxColumn";
            // 
            // isMD5NFSeValidDataGridViewCheckBoxColumn
            // 
            this.isMD5NFSeValidDataGridViewCheckBoxColumn.DataPropertyName = "IsMD5_NFSeValid";
            this.isMD5NFSeValidDataGridViewCheckBoxColumn.HeaderText = "IsMD5_NFSeValid";
            this.isMD5NFSeValidDataGridViewCheckBoxColumn.Name = "isMD5NFSeValidDataGridViewCheckBoxColumn";
            // 
            // mD5NFCeDataGridViewTextBoxColumn
            // 
            this.mD5NFCeDataGridViewTextBoxColumn.DataPropertyName = "MD5_NFCe";
            this.mD5NFCeDataGridViewTextBoxColumn.HeaderText = "MD5_NFCe";
            this.mD5NFCeDataGridViewTextBoxColumn.Name = "mD5NFCeDataGridViewTextBoxColumn";
            // 
            // mD5NFSeDataGridViewTextBoxColumn
            // 
            this.mD5NFSeDataGridViewTextBoxColumn.DataPropertyName = "MD5_NFSe";
            this.mD5NFSeDataGridViewTextBoxColumn.HeaderText = "MD5_NFSe";
            this.mD5NFSeDataGridViewTextBoxColumn.Name = "mD5NFSeDataGridViewTextBoxColumn";
            // 
            // xMLDataTableItemServicoDataGridViewTextBoxColumn
            // 
            this.xMLDataTableItemServicoDataGridViewTextBoxColumn.DataPropertyName = "XMLDataTableItemServico";
            this.xMLDataTableItemServicoDataGridViewTextBoxColumn.HeaderText = "XMLDataTableItemServico";
            this.xMLDataTableItemServicoDataGridViewTextBoxColumn.Name = "xMLDataTableItemServicoDataGridViewTextBoxColumn";
            // 
            // bloquearContingenciaDataGridViewCheckBoxColumn
            // 
            this.bloquearContingenciaDataGridViewCheckBoxColumn.DataPropertyName = "BloquearContingencia";
            this.bloquearContingenciaDataGridViewCheckBoxColumn.HeaderText = "BloquearContingencia";
            this.bloquearContingenciaDataGridViewCheckBoxColumn.Name = "bloquearContingenciaDataGridViewCheckBoxColumn";
            // 
            // bloquearContHorasDataGridViewTextBoxColumn
            // 
            this.bloquearContHorasDataGridViewTextBoxColumn.DataPropertyName = "BloquearContHoras";
            this.bloquearContHorasDataGridViewTextBoxColumn.HeaderText = "BloquearContHoras";
            this.bloquearContHorasDataGridViewTextBoxColumn.Name = "bloquearContHorasDataGridViewTextBoxColumn";
            // 
            // bloquearContForaPrazoDataGridViewCheckBoxColumn
            // 
            this.bloquearContForaPrazoDataGridViewCheckBoxColumn.DataPropertyName = "BloquearContForaPrazo";
            this.bloquearContForaPrazoDataGridViewCheckBoxColumn.HeaderText = "BloquearContForaPrazo";
            this.bloquearContForaPrazoDataGridViewCheckBoxColumn.Name = "bloquearContForaPrazoDataGridViewCheckBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.serieDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.serieDataGridViewTextBoxColumn.FillWeight = 35F;
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.Width = 56;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.numeroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.numeroDataGridViewTextBoxColumn.FillWeight = 35F;
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.Width = 69;
            // 
            // xmlProcNFeDataGridViewTextBoxColumn
            // 
            this.xmlProcNFeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.xmlProcNFeDataGridViewTextBoxColumn.DataPropertyName = "XmlProcNFe";
            this.xmlProcNFeDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.xmlProcNFeDataGridViewTextBoxColumn.HeaderText = "XmlProcNFe";
            this.xmlProcNFeDataGridViewTextBoxColumn.Name = "xmlProcNFeDataGridViewTextBoxColumn";
            this.xmlProcNFeDataGridViewTextBoxColumn.Width = 91;
            // 
            // iDVENDADataGridViewTextBoxColumn
            // 
            this.iDVENDADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDVENDADataGridViewTextBoxColumn.DataPropertyName = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.FillWeight = 90F;
            this.iDVENDADataGridViewTextBoxColumn.HeaderText = "ID_VENDA";
            this.iDVENDADataGridViewTextBoxColumn.Name = "iDVENDADataGridViewTextBoxColumn";
            this.iDVENDADataGridViewTextBoxColumn.Width = 86;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            this.cNPJDataGridViewTextBoxColumn.Width = 59;
            // 
            // versaoLeiauteDataGridViewTextBoxColumn
            // 
            this.versaoLeiauteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.versaoLeiauteDataGridViewTextBoxColumn.DataPropertyName = "VersaoLeiaute";
            this.versaoLeiauteDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.versaoLeiauteDataGridViewTextBoxColumn.HeaderText = "VersaoLeiaute";
            this.versaoLeiauteDataGridViewTextBoxColumn.Name = "versaoLeiauteDataGridViewTextBoxColumn";
            // 
            // autorizadoDataGridViewCheckBoxColumn
            // 
            this.autorizadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.autorizadoDataGridViewCheckBoxColumn.DataPropertyName = "Autorizado";
            this.autorizadoDataGridViewCheckBoxColumn.FillWeight = 80.83756F;
            this.autorizadoDataGridViewCheckBoxColumn.HeaderText = "Autorizado";
            this.autorizadoDataGridViewCheckBoxColumn.Name = "autorizadoDataGridViewCheckBoxColumn";
            this.autorizadoDataGridViewCheckBoxColumn.Width = 63;
            // 
            // dataHoraAutorizadoDataGridViewTextBoxColumn
            // 
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.DataPropertyName = "DataHoraAutorizado";
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.HeaderText = "DataHoraAutorizado";
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.Name = "dataHoraAutorizadoDataGridViewTextBoxColumn";
            this.dataHoraAutorizadoDataGridViewTextBoxColumn.Width = 128;
            // 
            // canceladoDataGridViewCheckBoxColumn
            // 
            this.canceladoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.canceladoDataGridViewCheckBoxColumn.DataPropertyName = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.FillWeight = 80.83756F;
            this.canceladoDataGridViewCheckBoxColumn.HeaderText = "Cancelado";
            this.canceladoDataGridViewCheckBoxColumn.Name = "canceladoDataGridViewCheckBoxColumn";
            this.canceladoDataGridViewCheckBoxColumn.Width = 64;
            // 
            // dataHoraCanceladoDataGridViewTextBoxColumn
            // 
            this.dataHoraCanceladoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataHoraCanceladoDataGridViewTextBoxColumn.DataPropertyName = "DataHoraCancelado";
            this.dataHoraCanceladoDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.dataHoraCanceladoDataGridViewTextBoxColumn.HeaderText = "DataHoraCancelado";
            this.dataHoraCanceladoDataGridViewTextBoxColumn.Name = "dataHoraCanceladoDataGridViewTextBoxColumn";
            this.dataHoraCanceladoDataGridViewTextBoxColumn.Width = 129;
            // 
            // motivoCanceladoDataGridViewTextBoxColumn
            // 
            this.motivoCanceladoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.motivoCanceladoDataGridViewTextBoxColumn.DataPropertyName = "MotivoCancelado";
            this.motivoCanceladoDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.motivoCanceladoDataGridViewTextBoxColumn.HeaderText = "MotivoCancelado";
            this.motivoCanceladoDataGridViewTextBoxColumn.Name = "motivoCanceladoDataGridViewTextBoxColumn";
            this.motivoCanceladoDataGridViewTextBoxColumn.Width = 115;
            // 
            // importadoDataGridViewCheckBoxColumn
            // 
            this.importadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.importadoDataGridViewCheckBoxColumn.DataPropertyName = "Importado";
            this.importadoDataGridViewCheckBoxColumn.FillWeight = 80.83756F;
            this.importadoDataGridViewCheckBoxColumn.HeaderText = "Importado";
            this.importadoDataGridViewCheckBoxColumn.Name = "importadoDataGridViewCheckBoxColumn";
            this.importadoDataGridViewCheckBoxColumn.Width = 60;
            // 
            // chaveNFEDataGridViewTextBoxColumn
            // 
            this.chaveNFEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chaveNFEDataGridViewTextBoxColumn.DataPropertyName = "ChaveNFE";
            this.chaveNFEDataGridViewTextBoxColumn.FillWeight = 80.83756F;
            this.chaveNFEDataGridViewTextBoxColumn.HeaderText = "ChaveNFE";
            this.chaveNFEDataGridViewTextBoxColumn.Name = "chaveNFEDataGridViewTextBoxColumn";
            this.chaveNFEDataGridViewTextBoxColumn.Width = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1157, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Editar NFCeLocalDB.sdf";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalvarAoSair);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeLocalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFCeLocalDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NFCeLocalDBDataSet nFCeLocalDBDataSet;
        private System.Windows.Forms.BindingSource nFCeBindingSource;
        private NFCeLocalDBDataSetTableAdapters.NFCeTableAdapter nFCeTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource nFCeConfigBindingSource;
        private NFCeLocalDBDataSetTableAdapters.NFCeConfigTableAdapter nFCeConfigTableAdapter;
        private System.Windows.Forms.BindingSource nFCeLocalDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Contigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraContingencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotivoContigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCEVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn XmlProcNFePadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersaoLeiaute;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltNumeroNFCe;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMLDataTableConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMLDataTableEmitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltNumeroNFSe;
        private System.Windows.Forms.DataGridViewTextBoxColumn XmlProcNFSePadrao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersaoLeiauteNFSe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMD5_NFCeValid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMD5_NFSeValid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5_NFCe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5_NFSe;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMLDataTableItemServico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BloquearContingencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloquearContHoras;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BloquearContForaPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contigenciaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraContingenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoContigenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCEVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlProcNFePadraoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versaoLeiauteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultNumeroNFCeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMLDataTableConfigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMLDataTableEmitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultNumeroNFSeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlProcNFSePadraoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versaoLeiauteNFSeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMD5NFCeValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isMD5NFSeValidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mD5NFCeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mD5NFSeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMLDataTableItemServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloquearContingenciaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloquearContHorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bloquearContForaPrazoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlProcNFeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versaoLeiauteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorizadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraAutorizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canceladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraCanceladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoCanceladoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn importadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chaveNFEDataGridViewTextBoxColumn;
    }
}

