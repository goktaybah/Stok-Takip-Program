namespace StokYönetimSistemi
{
    partial class GeçmişForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeçmişForm));
            this.sYSdbDataSet31 = new StokYönetimSistemi.SYSdbDataSet3();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblÜrünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ÜrünTableAdapter = new StokYönetimSistemi.SYSdbDataSet3TableAdapters.Tbl_ÜrünTableAdapter();
            this.tbl_KategoriTableAdapter = new StokYönetimSistemi.SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter();
            this.tblKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet2 = new StokYönetimSistemi.SYSdbDataSet2();
            this.tbl_UserTableAdapter = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sYSdbDataSet = new StokYönetimSistemi.SYSdbDataSet();
            this.sYSdbDataSet1 = new StokYönetimSistemi.SYSdbDataSet1();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CustomerTableAdapter = new StokYönetimSistemi.SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sySdbDataSet3 = new StokYönetimSistemi.SYSdbDataSet();
            this.tbl_UserTableAdapter1 = new StokYönetimSistemi.SYSdbDataSetTableAdapters.Tbl_UserTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet31)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sySdbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sYSdbDataSet31
            // 
            this.sYSdbDataSet31.DataSetName = "SYSdbDataSet3";
            this.sYSdbDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "GEÇMİŞ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 43);
            this.panel2.TabIndex = 9;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(16, 12);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(86, 36);
            this.btn_Listele.TabIndex = 3;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_Listele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 60);
            this.panel1.TabIndex = 8;
            // 
            // tblÜrünBindingSource
            // 
            this.tblÜrünBindingSource.DataMember = "Tbl_Ürün";
            this.tblÜrünBindingSource.DataSource = this.sYSdbDataSet31;
            // 
            // tbl_ÜrünTableAdapter
            // 
            this.tbl_ÜrünTableAdapter.ClearBeforeFill = true;
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
            // tbl_UserTableAdapter1
            // 
            this.tbl_UserTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 390);
            this.dataGridView1.TabIndex = 10;
            // 
            // GeçmişForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeçmişForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "GeçmişForm";
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet31)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sySdbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SYSdbDataSet3 sYSdbDataSet31;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tblÜrünBindingSource;
        private SYSdbDataSet3TableAdapters.Tbl_ÜrünTableAdapter tbl_ÜrünTableAdapter;
        private SYSdbDataSet2TableAdapters.Tbl_KategoriTableAdapter tbl_KategoriTableAdapter;
        private System.Windows.Forms.BindingSource tblKategoriBindingSource;
        private SYSdbDataSet2 sYSdbDataSet2;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private SYSdbDataSet sYSdbDataSet;
        private SYSdbDataSet1 sYSdbDataSet1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private SYSdbDataSet1TableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private SYSdbDataSet sySdbDataSet3;
        private SYSdbDataSetTableAdapters.Tbl_UserTableAdapter tbl_UserTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}