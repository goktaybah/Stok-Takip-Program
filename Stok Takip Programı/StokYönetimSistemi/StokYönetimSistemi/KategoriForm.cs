using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokYönetimSistemi
{
    public partial class KategoriForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");

        void temizle()
        {
            txt_KategoriID.Text = "";
            txt_KategoriAdı.Text = "";

        }
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet2.Tbl_Kategori' table. You can move, or remove it, as needed.
            //this.tbl_KategoriTableAdapter.Fill(this.sYSdbDataSet2.Tbl_Kategori);

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_KategoriTableAdapter.Fill(this.sYSdbDataSet2.Tbl_Kategori);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Kategori(Kisim) values(@k1)", baglanti);
            komutKaydet.Parameters.AddWithValue("@k1", txt_KategoriAdı.Text);

            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Kaydedildi..");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from Tbl_Kategori where KategoriID=@s1 ", baglanti);
            komutSil.Parameters.AddWithValue("@s1", txt_KategoriID.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kategori Silindi..");
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutDüzenle = new SqlCommand("update Tbl_Kategori set Kisim=@d1 where KategoriID=@d2", baglanti);
            komutDüzenle.Parameters.AddWithValue("@d1", txt_KategoriAdı.Text);
            komutDüzenle.Parameters.AddWithValue("@d2", txt_KategoriID.Text);

            komutDüzenle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Güncellendi..");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_KategoriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_KategoriAdı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }
    }
}
