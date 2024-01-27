namespace StokYönetimSistemi
{
    partial class KullanıcıForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Düzenle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnKullanıcı = new System.Windows.Forms.PictureBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Şifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AdıSoyadı = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanıcıAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adıSoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.şifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet = new StokYönetimSistemi.SYSdbDataSet();
            this.tbl_UserTableAdapter = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullanıcı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_Temizle);
            this.panel1.Controls.Add(this.btn_Listele);
            this.panel1.Controls.Add(this.btn_Düzenle);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_Kaydet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 0;
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
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click_1);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 43);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "KULLANICI YÖNETİMİ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btnKullanıcı);
            this.panel3.Controls.Add(this.txt_Telefon);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_Şifre);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_AdıSoyadı);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_KullanıcıAdı);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 390);
            this.panel3.TabIndex = 2;
            // 
            // btnKullanıcı
            // 
            this.btnKullanıcı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullanıcı.Image = ((System.Drawing.Image)(resources.GetObject("btnKullanıcı.Image")));
            this.btnKullanıcı.Location = new System.Drawing.Point(79, 20);
            this.btnKullanıcı.Name = "btnKullanıcı";
            this.btnKullanıcı.Size = new System.Drawing.Size(58, 60);
            this.btnKullanıcı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnKullanıcı.TabIndex = 13;
            this.btnKullanıcı.TabStop = false;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(12, 335);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(182, 20);
            this.txt_Telefon.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon:";
            // 
            // txt_Şifre
            // 
            this.txt_Şifre.Location = new System.Drawing.Point(12, 273);
            this.txt_Şifre.Name = "txt_Şifre";
            this.txt_Şifre.Size = new System.Drawing.Size(182, 20);
            this.txt_Şifre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şifre:";
            // 
            // txt_AdıSoyadı
            // 
            this.txt_AdıSoyadı.Location = new System.Drawing.Point(12, 211);
            this.txt_AdıSoyadı.Name = "txt_AdıSoyadı";
            this.txt_AdıSoyadı.Size = new System.Drawing.Size(182, 20);
            this.txt_AdıSoyadı.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adı-Soyadı:";
            // 
            // txt_KullanıcıAdı
            // 
            this.txt_KullanıcıAdı.Location = new System.Drawing.Point(12, 151);
            this.txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            this.txt_KullanıcıAdı.Size = new System.Drawing.Size(182, 20);
            this.txt_KullanıcıAdı.TabIndex = 11;
            this.txt_KullanıcıAdı.TextChanged += new System.EventHandler(this.txt_KullanıcıAdı_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı:";
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
            this.kullanıcıAdıDataGridViewTextBoxColumn,
            this.adıSoyadıDataGridViewTextBoxColumn,
            this.şifreDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUserBindingSource;
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
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // kullanıcıAdıDataGridViewTextBoxColumn
            // 
            this.kullanıcıAdıDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.HeaderText = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.Name = "kullanıcıAdıDataGridViewTextBoxColumn";
            // 
            // adıSoyadıDataGridViewTextBoxColumn
            // 
            this.adıSoyadıDataGridViewTextBoxColumn.DataPropertyName = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.HeaderText = "AdıSoyadı";
            this.adıSoyadıDataGridViewTextBoxColumn.Name = "adıSoyadıDataGridViewTextBoxColumn";
            // 
            // şifreDataGridViewTextBoxColumn
            // 
            this.şifreDataGridViewTextBoxColumn.DataPropertyName = "Şifre";
            this.şifreDataGridViewTextBoxColumn.HeaderText = "Şifre";
            this.şifreDataGridViewTextBoxColumn.Name = "şifreDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
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
            // tbl_UserTableAdapter
            // 
            this.tbl_UserTableAdapter.ClearBeforeFill = true;
            // 
            // KullanıcıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullanıcıForm";
            this.Text = "KullanıcıForm";
            this.Load += new System.EventHandler(this.KullanıcıForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnKullanıcı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Düzenle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Şifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AdıSoyadı;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KullanıcıAdı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SYSdbDataSet sYSdbDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adıSoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn şifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.PictureBox btnKullanıcı;
    }
}