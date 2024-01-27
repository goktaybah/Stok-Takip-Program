namespace StokYönetimSistemi
{
    partial class StokForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbl_KategoriTableAdapter = new StokYönetimSistemi.SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter();
            this.tblKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet2 = new StokYönetimSistemi.SYSdbDataSet2();
            this.tbl_UserTableAdapter = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet = new StokYönetimSistemi.SYSdbDataSet();
            this.sYSdbDataSet1 = new StokYönetimSistemi.SYSdbDataSet1();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CustomerTableAdapter = new StokYönetimSistemi.SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.tbl_UserTableAdapter1 = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sySdbDataSet3 = new StokYönetimSistemi.SYSdbDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ücret = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ÜrünID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ÜrünAçıklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ÜrünMiktarı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ÜrünAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStok = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Düzenle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Arama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblÜrünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet31 = new StokYönetimSistemi.SYSdbDataSet3();
            this.tbl_ÜrünTableAdapter = new StokYönetimSistemi.SYSdbDataSet3TableAdapters.Tbl_ÜrünTableAdapter();
            this.ürünIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünMiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünÜcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAçıklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sySdbDataSet3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStok)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet31)).BeginInit();
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
            // btn_Temizle
            // 
            this.btn_Temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Temizle.Location = new System.Drawing.Point(384, 9);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(86, 36);
            this.btn_Temizle.TabIndex = 4;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // tbl_UserTableAdapter1
            // 
            this.tbl_UserTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Tbl_User";
            this.bindingSource1.DataSource = this.sySdbDataSet3;
            // 
            // sySdbDataSet3
            // 
            this.sySdbDataSet3.DataSetName = "SYSdbDataSet";
            this.sySdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ürün Açıklama:";
            // 
            // txt_Ücret
            // 
            this.txt_Ücret.Location = new System.Drawing.Point(12, 229);
            this.txt_Ücret.Name = "txt_Ücret";
            this.txt_Ücret.Size = new System.Drawing.Size(182, 20);
            this.txt_Ücret.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.txt_ÜrünID);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmb_Kategori);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_ÜrünAçıklama);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_Ücret);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_ÜrünMiktarı);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_ÜrünAdı);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 390);
            this.panel3.TabIndex = 6;
            // 
            // txt_ÜrünID
            // 
            this.txt_ÜrünID.Location = new System.Drawing.Point(12, 52);
            this.txt_ÜrünID.Name = "txt_ÜrünID";
            this.txt_ÜrünID.Size = new System.Drawing.Size(182, 20);
            this.txt_ÜrünID.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ürün ID:";
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(12, 346);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(182, 21);
            this.cmb_Kategori.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Kategori:";
            // 
            // txt_ÜrünAçıklama
            // 
            this.txt_ÜrünAçıklama.Location = new System.Drawing.Point(12, 291);
            this.txt_ÜrünAçıklama.Name = "txt_ÜrünAçıklama";
            this.txt_ÜrünAçıklama.Size = new System.Drawing.Size(182, 20);
            this.txt_ÜrünAçıklama.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ücret:";
            // 
            // txt_ÜrünMiktarı
            // 
            this.txt_ÜrünMiktarı.Location = new System.Drawing.Point(12, 167);
            this.txt_ÜrünMiktarı.Name = "txt_ÜrünMiktarı";
            this.txt_ÜrünMiktarı.Size = new System.Drawing.Size(182, 20);
            this.txt_ÜrünMiktarı.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Miktarı:";
            // 
            // txt_ÜrünAdı
            // 
            this.txt_ÜrünAdı.Location = new System.Drawing.Point(12, 107);
            this.txt_ÜrünAdı.Name = "txt_ÜrünAdı";
            this.txt_ÜrünAdı.Size = new System.Drawing.Size(182, 20);
            this.txt_ÜrünAdı.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı:";
            // 
            // btnStok
            // 
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.Image = ((System.Drawing.Image)(resources.GetObject("btnStok.Image")));
            this.btnStok.Location = new System.Drawing.Point(16, 3);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(39, 40);
            this.btnStok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStok.TabIndex = 10;
            this.btnStok.TabStop = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "STOK YÖNETİMİ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnStok);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 43);
            this.panel2.TabIndex = 5;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.Location = new System.Drawing.Point(292, 9);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(86, 36);
            this.btn_Listele.TabIndex = 3;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Düzenle
            // 
            this.btn_Düzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Düzenle.Location = new System.Drawing.Point(200, 9);
            this.btn_Düzenle.Name = "btn_Düzenle";
            this.btn_Düzenle.Size = new System.Drawing.Size(86, 36);
            this.btn_Düzenle.TabIndex = 2;
            this.btn_Düzenle.Text = "Düzenle";
            this.btn_Düzenle.UseVisualStyleBackColor = true;
            this.btn_Düzenle.Click += new System.EventHandler(this.btn_Düzenle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(108, 9);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(86, 36);
            this.btn_Sil.TabIndex = 1;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kaydet.Location = new System.Drawing.Point(16, 9);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(86, 36);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_Arama);
            this.panel1.Controls.Add(this.btn_Temizle);
            this.panel1.Controls.Add(this.btn_Listele);
            this.panel1.Controls.Add(this.btn_Düzenle);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_Kaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(548, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "Arama:";
            // 
            // txt_Arama
            // 
            this.txt_Arama.Location = new System.Drawing.Point(623, 19);
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.Size = new System.Drawing.Size(317, 20);
            this.txt_Arama.TabIndex = 5;
            this.txt_Arama.TextChanged += new System.EventHandler(this.txt_Arama_TextChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ürünIDDataGridViewTextBoxColumn,
            this.ürünAdıDataGridViewTextBoxColumn,
            this.ürünMiktarıDataGridViewTextBoxColumn,
            this.ürünÜcretiDataGridViewTextBoxColumn,
            this.ürünAçıklamaDataGridViewTextBoxColumn,
            this.ürünKategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblÜrünBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(218, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 390);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // tblÜrünBindingSource
            // 
            this.tblÜrünBindingSource.DataMember = "Tbl_Ürün";
            this.tblÜrünBindingSource.DataSource = this.sYSdbDataSet31;
            // 
            // sYSdbDataSet31
            // 
            this.sYSdbDataSet31.DataSetName = "SYSdbDataSet3";
            this.sYSdbDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ÜrünTableAdapter
            // 
            this.tbl_ÜrünTableAdapter.ClearBeforeFill = true;
            // 
            // ürünIDDataGridViewTextBoxColumn
            // 
            this.ürünIDDataGridViewTextBoxColumn.DataPropertyName = "ÜrünID";
            this.ürünIDDataGridViewTextBoxColumn.HeaderText = "ÜrünID";
            this.ürünIDDataGridViewTextBoxColumn.Name = "ürünIDDataGridViewTextBoxColumn";
            this.ürünIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ürünAdıDataGridViewTextBoxColumn
            // 
            this.ürünAdıDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ürünAdıDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdı";
            this.ürünAdıDataGridViewTextBoxColumn.HeaderText = "ÜrünAdı";
            this.ürünAdıDataGridViewTextBoxColumn.Name = "ürünAdıDataGridViewTextBoxColumn";
            this.ürünAdıDataGridViewTextBoxColumn.Width = 70;
            // 
            // ürünMiktarıDataGridViewTextBoxColumn
            // 
            this.ürünMiktarıDataGridViewTextBoxColumn.DataPropertyName = "ÜrünMiktarı";
            this.ürünMiktarıDataGridViewTextBoxColumn.HeaderText = "ÜrünMiktarı";
            this.ürünMiktarıDataGridViewTextBoxColumn.Name = "ürünMiktarıDataGridViewTextBoxColumn";
            // 
            // ürünÜcretiDataGridViewTextBoxColumn
            // 
            this.ürünÜcretiDataGridViewTextBoxColumn.DataPropertyName = "ÜrünÜcreti";
            this.ürünÜcretiDataGridViewTextBoxColumn.HeaderText = "ÜrünÜcreti";
            this.ürünÜcretiDataGridViewTextBoxColumn.Name = "ürünÜcretiDataGridViewTextBoxColumn";
            // 
            // ürünAçıklamaDataGridViewTextBoxColumn
            // 
            this.ürünAçıklamaDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAçıklama";
            this.ürünAçıklamaDataGridViewTextBoxColumn.HeaderText = "ÜrünAçıklama";
            this.ürünAçıklamaDataGridViewTextBoxColumn.Name = "ürünAçıklamaDataGridViewTextBoxColumn";
            // 
            // ürünKategoriDataGridViewTextBoxColumn
            // 
            this.ürünKategoriDataGridViewTextBoxColumn.DataPropertyName = "ÜrünKategori";
            this.ürünKategoriDataGridViewTextBoxColumn.HeaderText = "ÜrünKategori";
            this.ürünKategoriDataGridViewTextBoxColumn.Name = "ürünKategoriDataGridViewTextBoxColumn";
            // 
            // StokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokForm";
            this.Text = "StokForm";
            this.Load += new System.EventHandler(this.StokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sySdbDataSet3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStok)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet31)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter tbl_KategoriTableAdapter;
        private System.Windows.Forms.BindingSource tblKategoriBindingSource;
        private SYSdbDataSet2 sYSdbDataSet2;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private SYSdbDataSet sYSdbDataSet;
        private SYSdbDataSet1 sYSdbDataSet1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.Button btn_Temizle;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SYSdbDataSet sySdbDataSet3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ücret;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_ÜrünAçıklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ÜrünMiktarı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ÜrünAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Düzenle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnStok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cmb_Kategori;
        private SYSdbDataSet3 sYSdbDataSet31;
        private System.Windows.Forms.BindingSource tblÜrünBindingSource;
        private SYSdbDataSet3TableAdapters.Tbl_ÜrünTableAdapter tbl_ÜrünTableAdapter;
        private System.Windows.Forms.TextBox txt_ÜrünID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Arama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünMiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünÜcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAçıklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünKategoriDataGridViewTextBoxColumn;
    }
}