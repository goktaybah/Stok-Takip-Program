namespace StokYönetimSistemi
{
    partial class SiparişForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_KategoriTableAdapter = new StokYönetimSistemi.SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter();
            this.tblKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet2 = new StokYönetimSistemi.SYSdbDataSet2();
            this.tbl_UserTableAdapter = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet = new StokYönetimSistemi.SYSdbDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSipariş = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sYSdbDataSet1 = new StokYönetimSistemi.SYSdbDataSet1();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CustomerTableAdapter = new StokYönetimSistemi.SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ÜrünID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SiparişID = new System.Windows.Forms.TextBox();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.sYSdbDataSet6 = new StokYönetimSistemi.SYSdbDataSet6();
            this.siparişBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparişTableAdapter = new StokYönetimSistemi.SYSdbDataSet6TableAdapters.SiparişTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siparişIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparişTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müşteriAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ücretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparişBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet7 = new StokYönetimSistemi.SYSdbDataSet7();
            this.siparişTableAdapter1 = new StokYönetimSistemi.SYSdbDataSet7TableAdapters.SiparişTableAdapter();
            this.btn_top = new System.Windows.Forms.Button();
            this.btn_Toplam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSipariş)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_KategoriTableAdapter
            // 
            this.tbl_KategoriTableAdapter.ClearBeforeFill = true;
            // 
            // tblKategoriBindingSource
            // 
            this.tblKategoriBindingSource.DataMember = "Tbl_Kategori";
            this.tblKategoriBindingSource.DataSource = this.sYSdbDataSet2;
            // 
            // sYSdbDataSet2
            // 
            this.sYSdbDataSet2.DataSetName = "SYSdbDataSet2";
            this.sYSdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "Tbl_User";
            this.tblUserBindingSource.DataSource = this.sYSdbDataSet;
            // 
            // sYSdbDataSet
            // 
            this.sYSdbDataSet.DataSetName = "SYSdbDataSet";
            this.sYSdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnSipariş);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 43);
            this.panel2.TabIndex = 13;
            // 
            // btnSipariş
            // 
            this.btnSipariş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSipariş.Image = ((System.Drawing.Image)(resources.GetObject("btnSipariş.Image")));
            this.btnSipariş.Location = new System.Drawing.Point(14, 1);
            this.btnSipariş.Name = "btnSipariş";
            this.btnSipariş.Size = new System.Drawing.Size(41, 40);
            this.btnSipariş.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSipariş.TabIndex = 14;
            this.btnSipariş.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "SİPARİŞ YÖNETİMİ";
            // 
            // sYSdbDataSet1
            // 
            this.sYSdbDataSet1.DataSetName = "SYSdbDataSet1";
            this.sYSdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.sYSdbDataSet1;
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_SiparişID);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_Kaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btn_Toplam);
            this.panel3.Controls.Add(this.btn_top);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_Arama);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_ÜrünID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(984, 60);
            this.panel3.TabIndex = 49;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(722, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Arama:";
            // 
            // txt_Arama
            // 
            this.txt_Arama.Location = new System.Drawing.Point(797, 21);
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.Size = new System.Drawing.Size(175, 20);
            this.txt_Arama.TabIndex = 51;
            this.txt_Arama.TextChanged += new System.EventHandler(this.txt_Arama_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(560, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "ÜRÜN ID:";
            // 
            // txt_ÜrünID
            // 
            this.txt_ÜrünID.Location = new System.Drawing.Point(646, 22);
            this.txt_ÜrünID.Name = "txt_ÜrünID";
            this.txt_ÜrünID.Size = new System.Drawing.Size(40, 20);
            this.txt_ÜrünID.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(404, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "SİPARİŞ ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(513, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 20);
            this.textBox1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(104, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 47;
            this.button1.Text = "Sipariş Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(14, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sipariş Gir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(298, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "SİPARİŞ ID:";
            // 
            // txt_SiparişID
            // 
            this.txt_SiparişID.Location = new System.Drawing.Point(409, 22);
            this.txt_SiparişID.Name = "txt_SiparişID";
            this.txt_SiparişID.Size = new System.Drawing.Size(100, 20);
            this.txt_SiparişID.TabIndex = 48;
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(115, 12);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(86, 36);
            this.btn_Sil.TabIndex = 47;
            this.btn_Sil.Text = "Sipariş Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(14, 12);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(86, 36);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "Sipariş Gir";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // sYSdbDataSet6
            // 
            this.sYSdbDataSet6.DataSetName = "SYSdbDataSet6";
            this.sYSdbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparişBindingSource
            // 
            this.siparişBindingSource.DataMember = "Sipariş";
            this.siparişBindingSource.DataSource = this.sYSdbDataSet6;
            // 
            // siparişTableAdapter
            // 
            this.siparişTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparişIdDataGridViewTextBoxColumn,
            this.siparişTarihDataGridViewTextBoxColumn,
            this.ürünIdDataGridViewTextBoxColumn,
            this.ürünAdıDataGridViewTextBoxColumn,
            this.müşteriIDDataGridViewTextBoxColumn,
            this.müşteriAdıDataGridViewTextBoxColumn,
            this.adetDataGridViewTextBoxColumn,
            this.ücretDataGridViewTextBoxColumn,
            this.toplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siparişBindingSource1;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(984, 390);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // siparişIdDataGridViewTextBoxColumn
            // 
            this.siparişIdDataGridViewTextBoxColumn.DataPropertyName = "SiparişId";
            this.siparişIdDataGridViewTextBoxColumn.HeaderText = "SiparişId";
            this.siparişIdDataGridViewTextBoxColumn.Name = "siparişIdDataGridViewTextBoxColumn";
            this.siparişIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparişTarihDataGridViewTextBoxColumn
            // 
            this.siparişTarihDataGridViewTextBoxColumn.DataPropertyName = "SiparişTarih";
            this.siparişTarihDataGridViewTextBoxColumn.HeaderText = "SiparişTarih";
            this.siparişTarihDataGridViewTextBoxColumn.Name = "siparişTarihDataGridViewTextBoxColumn";
            // 
            // ürünIdDataGridViewTextBoxColumn
            // 
            this.ürünIdDataGridViewTextBoxColumn.DataPropertyName = "ÜrünId";
            this.ürünIdDataGridViewTextBoxColumn.HeaderText = "ÜrünId";
            this.ürünIdDataGridViewTextBoxColumn.Name = "ürünIdDataGridViewTextBoxColumn";
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "ÜrünAdı";
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            this.ürünAdıDataGridViewTextBoxColumn.Width = 70;
            // 
            // müşteriIDDataGridViewTextBoxColumn
            // 
            this.müşteriIDDataGridViewTextBoxColumn.DataPropertyName = "MüşteriID";
            this.müşteriIDDataGridViewTextBoxColumn.HeaderText = "MüşteriID";
            this.müşteriIDDataGridViewTextBoxColumn.Name = "müşteriIDDataGridViewTextBoxColumn";
            // 
            // müşteriAdıDataGridViewTextBoxColumn
            // 
            this.müşteriAdıDataGridViewTextBoxColumn.DataPropertyName = "MüşteriAdı";
            this.müşteriAdıDataGridViewTextBoxColumn.HeaderText = "MüşteriAdı";
            this.müşteriAdıDataGridViewTextBoxColumn.Name = "müşteriAdıDataGridViewTextBoxColumn";
            // 
            // adetDataGridViewTextBoxColumn
            // 
            this.adetDataGridViewTextBoxColumn.DataPropertyName = "Adet";
            this.adetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.adetDataGridViewTextBoxColumn.Name = "adetDataGridViewTextBoxColumn";
            // 
            // ücretDataGridViewTextBoxColumn
            // 
            this.ücretDataGridViewTextBoxColumn.DataPropertyName = "Ücret";
            this.ücretDataGridViewTextBoxColumn.HeaderText = "Ücret";
            this.ücretDataGridViewTextBoxColumn.Name = "ücretDataGridViewTextBoxColumn";
            // 
            // toplamDataGridViewTextBoxColumn
            // 
            this.toplamDataGridViewTextBoxColumn.DataPropertyName = "Toplam";
            this.toplamDataGridViewTextBoxColumn.HeaderText = "Toplam";
            this.toplamDataGridViewTextBoxColumn.Name = "toplamDataGridViewTextBoxColumn";
            // 
            // siparişBindingSource1
            // 
            this.siparişBindingSource1.DataMember = "Sipariş";
            this.siparişBindingSource1.DataSource = this.sYSdbDataSet7;
            // 
            // sYSdbDataSet7
            // 
            this.sYSdbDataSet7.DataSetName = "SYSdbDataSet7";
            this.sYSdbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparişTableAdapter1
            // 
            this.siparişTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_top
            // 
            this.btn_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_top.Location = new System.Drawing.Point(196, 12);
            this.btn_top.Name = "btn_top";
            this.btn_top.Size = new System.Drawing.Size(96, 36);
            this.btn_top.TabIndex = 15;
            this.btn_top.Text = "TOP 3 ÜRÜN";
            this.btn_top.UseVisualStyleBackColor = true;
            this.btn_top.Click += new System.EventHandler(this.btn_top_Click);
            // 
            // btn_Toplam
            // 
            this.btn_Toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Toplam.Location = new System.Drawing.Point(298, 12);
            this.btn_Toplam.Name = "btn_Toplam";
            this.btn_Toplam.Size = new System.Drawing.Size(96, 36);
            this.btn_Toplam.TabIndex = 54;
            this.btn_Toplam.Text = "Toplam Gelir";
            this.btn_Toplam.UseVisualStyleBackColor = true;
            this.btn_Toplam.Click += new System.EventHandler(this.btn_Toplam_Click);
            // 
            // SiparişForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparişForm";
            this.Text = "SiparişForm";
            this.Load += new System.EventHandler(this.SiparişForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSipariş)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparişBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter tbl_KategoriTableAdapter;
        private System.Windows.Forms.BindingSource tblKategoriBindingSource;
        private SYSdbDataSet2 sYSdbDataSet2;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private SYSdbDataSet sYSdbDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private SYSdbDataSet1 sYSdbDataSet1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSipariş;
        private System.Windows.Forms.Button btn_Kaydet;
        private SYSdbDataSet6 sYSdbDataSet6;
        private System.Windows.Forms.BindingSource siparişBindingSource;
        private SYSdbDataSet6TableAdapters.SiparişTableAdapter siparişTableAdapter;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SiparişID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SYSdbDataSet7 sYSdbDataSet7;
        private System.Windows.Forms.BindingSource siparişBindingSource1;
        private SYSdbDataSet7TableAdapters.SiparişTableAdapter siparişTableAdapter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ÜrünID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparişIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparişTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müşteriAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ücretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_top;
        private System.Windows.Forms.Button btn_Toplam;
    }
}