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
    public partial class MüşteriForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");

        private void temizle()
        {
            
            txt_AdıSoyadı.Text = "";
            txt_MüşteriID.Text = "";
            txt_Telefon.Text = "";

        }
        public MüşteriForm()
        {
            InitializeComponent();
            
        }

        private void MüşteriForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet1.Tbl_Customer' table. You can move, or remove it, as needed.
            //this.tbl_CustomerTableAdapter.Fill(this.sYSdbDataSet1.Tbl_Customer);

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            this.tbl_CustomerTableAdapter.Fill(this.sYSdbDataSet1.Tbl_Customer);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Customer(Misim,Mtelefon) values(@k2,@k3)", baglanti);
            
            komutKaydet.Parameters.AddWithValue("@k2", txt_AdıSoyadı.Text);
            komutKaydet.Parameters.AddWithValue("@k3", txt_Telefon.Text);
            komutKaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydedildi..");
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutSil = new SqlCommand("delete from Tbl_Customer where MüşteriID=@s1 ", baglanti);
            komutSil.Parameters.AddWithValue("@s1", txt_MüşteriID.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Müşteri Silindi..");
        }

        private void btn_Düzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutDüzenle = new SqlCommand("update Tbl_Customer set Misim=@d1, Mtelefon=@d2 where MüşteriID=@d3", baglanti);
            komutDüzenle.Parameters.AddWithValue("@d1", txt_AdıSoyadı.Text);
            komutDüzenle.Parameters.AddWithValue("@d2", txt_Telefon.Text);
            komutDüzenle.Parameters.AddWithValue("@d3", txt_MüşteriID.Text);

            komutDüzenle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Güncellendi..");
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_MüşteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_AdıSoyadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_Telefon.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
