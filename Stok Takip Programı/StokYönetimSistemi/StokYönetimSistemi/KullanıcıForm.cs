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
    public partial class KullanıcıForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");

        void temizle()
        {
            txt_KullanıcıAdı.Text = "";
            txt_AdıSoyadı.Text = "";
            txt_Şifre.Text = "";
            txt_Telefon.Text = "";

        }
        public KullanıcıForm()
        {
            InitializeComponent();
        }

        private void KullanıcıForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet.Tbl_User' table. You can move, or remove it, as needed.
            //this.tbl_UserTableAdapter.Fill(this.sYSdbDataSet.Tbl_User);

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_UserTableAdapter.Fill(this.sYSdbDataSet.Tbl_User);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_User(KullanıcıAdı,AdıSoyadı,Şifre,Telefon) values(@k1,@k2,@k3,@k4)",baglanti);
            komutKaydet.Parameters.AddWithValue("@k1", txt_KullanıcıAdı.Text);
            komutKaydet.Parameters.AddWithValue("@k2", txt_AdıSoyadı.Text);
            komutKaydet.Parameters.AddWithValue("@k3", txt_Şifre.Text);
            komutKaydet.Parameters.AddWithValue("@k4", txt_Telefon.Text);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Kaydedildi..");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from Tbl_User where AdıSoyadı=@s1 ", baglanti);
            komutSil.Parameters.AddWithValue("@s1", txt_AdıSoyadı.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kullanıcı Silindi..");
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutDüzenle = new SqlCommand("update Tbl_User set KullanıcıAdı=@d1,Şifre=@d2,Telefon=@d3 where AdıSoyadı=@d4",baglanti);
            komutDüzenle.Parameters.AddWithValue("@d1",txt_KullanıcıAdı.Text);
            komutDüzenle.Parameters.AddWithValue("@d2", txt_Şifre.Text);
            komutDüzenle.Parameters.AddWithValue("@d3", txt_Telefon.Text);
            komutDüzenle.Parameters.AddWithValue("@d4", txt_AdıSoyadı.Text);
            komutDüzenle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kullanıcı Güncellendi..");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_KullanıcıAdı.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_AdıSoyadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Şifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Telefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Temizle_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void txt_KullanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            if (txt_KullanıcıAdı.Text.Length > 15)
            {
                MessageBox.Show("Hoop dur "); 
                txt_KullanıcıAdı.Text = txt_KullanıcıAdı.Text.Substring(0, 15);
                txt_KullanıcıAdı.Select(15, 0); // Son karakteri seçer (isteğe bağlı)
                
            }
        }
    }
}
