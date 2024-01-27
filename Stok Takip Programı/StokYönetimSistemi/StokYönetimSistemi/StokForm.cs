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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokYönetimSistemi
{
    public partial class StokForm : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adtr;
        DataTable ekran = new DataTable();

        public StokForm()
        {
            InitializeComponent();
            LoadKategori();
           
        }

        void temizle()
        {
            txt_ÜrünID.Text = "";
            txt_ÜrünAdı.Text = "";
            txt_ÜrünMiktarı.Text = "";
            txt_Ücret.Text = "";
            txt_ÜrünAçıklama.Text = "";

        }

        public void LoadKategori()
        {
            cmb_Kategori.Items.Clear();
            cmd = new SqlCommand("select Kisim from Tbl_Kategori",baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read() ) 
            {
                cmb_Kategori.Items.Add(dr[0].ToString());            
            }
            dr.Close();
            baglanti.Close();
        }


        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_ÜrünTableAdapter.Fill(this.sYSdbDataSet31.Tbl_Ürün);
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet31.Tbl_Ürün' table. You can move, or remove it, as needed.
            //this.tbl_ÜrünTableAdapter.Fill(this.sYSdbDataSet31.Tbl_Ürün);

        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Ürün(ÜrünAdı,ÜrünMiktarı,ÜrünÜcreti,ÜrünAçıklama,ÜrünKategori) values(@k2,@k3,@k4,@k5,@k6)", baglanti);
            
            komutKaydet.Parameters.AddWithValue("@k2", txt_ÜrünAdı.Text);
            komutKaydet.Parameters.AddWithValue("@k3", txt_ÜrünMiktarı.Text);
            komutKaydet.Parameters.AddWithValue("@k4", txt_Ücret.Text);
            komutKaydet.Parameters.AddWithValue("@k5", txt_ÜrünAçıklama.Text);
            komutKaydet.Parameters.AddWithValue("@k6", cmb_Kategori.Text);

            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Kaydedildi..");
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from Tbl_Ürün where ÜrünID=@s1 ", baglanti);
            komutSil.Parameters.AddWithValue("@s1", txt_ÜrünID.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kategori Silindi..");
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutDüzenle = new SqlCommand("update Tbl_Ürün set ÜrünAdı=@d1,ÜrünMiktarı=@d2,ÜrünÜcreti=@d3,ÜrünAçıklama=@d4,ÜrünKategori=@d5 where ÜrünID=@d6", baglanti);
            komutDüzenle.Parameters.AddWithValue("@d1", txt_ÜrünAdı.Text);
            komutDüzenle.Parameters.AddWithValue("@d2", txt_ÜrünMiktarı.Text);
            komutDüzenle.Parameters.AddWithValue("@d3", txt_Ücret.Text);
            komutDüzenle.Parameters.AddWithValue("@d4", txt_ÜrünAçıklama.Text);
            komutDüzenle.Parameters.AddWithValue("@d5", cmb_Kategori.Text);
            komutDüzenle.Parameters.AddWithValue("@d6", txt_ÜrünID.Text);

            komutDüzenle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Güncellendi..");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ÜrünID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ÜrünAdı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_ÜrünMiktarı.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Ücret.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_ÜrünAçıklama.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cmb_Kategori.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {

        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            ekran.Clear();
            cmd = new SqlCommand("sp_ÜrünAra", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ÜrünAçıklama", txt_Arama.Text);
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran);
            dataGridView1.DataSource = ekran;
        }
    }
}
