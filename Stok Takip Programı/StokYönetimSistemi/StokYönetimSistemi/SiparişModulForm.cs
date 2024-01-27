using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYönetimSistemi
{
    public partial class SiparişModulForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adtr;
        DataTable ekran = new DataTable();
        public SiparişModulForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SiparişModulForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet5.Tbl_Ürün' table. You can move, or remove it, as needed.
            this.tbl_ÜrünTableAdapter.Fill(this.sYSdbDataSet5.Tbl_Ürün);
            // TODO: This line of code loads data into the 'sYSdbDataSet4.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.sYSdbDataSet4.Tbl_Customer);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_MüşteriID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_AdıSoyadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            
        }

        int Adet = 0;

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txt_ÜrünID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txt_ÜrünAdı.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txt_Ücret.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            Adet = Convert.ToInt32(dataGridView2.Rows[secilen].Cells[2].Value.ToString());

        }
        int stokDurumu=-1;
        private void nud_Adet_ValueChanged(object sender, EventArgs e) 
        {
            //----------------------Bu kisim bize stok yeterli mi degil mi --------------------------
            string connectionString = "Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;";

            // Kontrol etmek istediğiniz ürün ID'si
            string urunID =txt_ÜrünID.Text;  // Bu değeri, kontrol etmek istediğiniz ürün ID'sine göre değiştirin.

            // Kontrol etmek istediğiniz stok miktarı
            int stokYeterlilik = Convert.ToInt32(nud_Adet.Value);  // Bu değeri, kontrol etmek istediğiniz stok miktarına göre değiştirin.

          
            // SQL sorgusu ve bağlantı oluşturma
            string sql = "SELECT dbo.StokKontrol(@StokYeterlilik, @UrunID) AS StokDurumu";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Parametre ekleme
                    command.Parameters.AddWithValue("@StokYeterlilik", stokYeterlilik);
                    command.Parameters.AddWithValue("@UrunID", urunID);

                    // ExecuteScalar ile tek bir değeri almak
                     stokDurumu = (int)command.ExecuteScalar();

                    // Fonksiyonun döndürdüğü değere göre işlem yapma
                    switch (stokDurumu)
                    {
                        //yapilmasi istenen buraya  yazilacak iste durumlar arasi bi kontrol  edelim
                        case -1:
                            Console.WriteLine("Hata: Giriş değeri null.");
                            break;
                        case 0:
                            Console.WriteLine("Stok Yetersiz!");
                            break;
                        case 1:
                            Console.WriteLine("Stok Yeterli.");
                            break;
                    }
                }

            }



            //---------------------------------------------------------------------------



            if (Convert.ToInt32(nud_Adet.Value) > 0)
            {
                int toplam = Convert.ToInt32(txt_Ücret.Text) * Convert.ToInt32(nud_Adet.Value);
                txt_Toplam.Text = toplam.ToString();
            }
            
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (stokDurumu==1)
            {
                baglanti.Open();
                SqlCommand SiparişEkle = new SqlCommand("insert into Sipariş(SiparişTarih,ÜrünId,ÜrünAdı,MüşteriID,MüşteriAdı,Adet,Ücret,Toplam) values(@e2,@e3,@e4,@e5,@e6,@e7,@e8,@e9)", baglanti);
                //SiparişEkle.Parameters.AddWithValue("@k1", txt_KategoriAdı.Text);
                SiparişEkle.Parameters.AddWithValue("@e2", Tarih_buton.Value);
                SiparişEkle.Parameters.AddWithValue("@e3", Convert.ToInt32(txt_ÜrünID.Text));
                SiparişEkle.Parameters.AddWithValue("@e4", Convert.ToString(txt_ÜrünAdı.Text));
                SiparişEkle.Parameters.AddWithValue("@e5", Convert.ToInt32(txt_MüşteriID.Text));
                SiparişEkle.Parameters.AddWithValue("@e6", Convert.ToString(txt_AdıSoyadı.Text));
                SiparişEkle.Parameters.AddWithValue("@e7", Convert.ToInt32(nud_Adet.Value));
                SiparişEkle.Parameters.AddWithValue("@e8", Convert.ToInt32(txt_Ücret.Text));
                SiparişEkle.Parameters.AddWithValue("@e9", Convert.ToInt32(txt_Toplam.Text));

                SiparişEkle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Sipariş Eklendi..");


                ekran.Clear();
                cmd = new SqlCommand("sp_StokDüşürme", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ÜrünID", txt_ÜrünID.Text);
                cmd.Parameters.AddWithValue("ÜrünMiktarı", Convert.ToInt32(nud_Adet.Value));
                adtr = new SqlDataAdapter(cmd);
                adtr.Fill(ekran);

                temizle();
            }

            else
            {
                MessageBox.Show("Stok Yetersiz oldugundan eklenemedi");
            }
          
           
        }

        public void temizle()
        {
            txt_MüşteriID.Clear();
            txt_AdıSoyadı.Clear();

            txt_ÜrünID.Clear();
            txt_Ücret.Clear();
            txt_ÜrünAdı.Clear();

            txt_Ücret.Clear();
            nud_Adet.Value = 0;
            txt_Toplam.Clear();
            Tarih_buton.Value = DateTime.Now;


        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            ekran.Clear();
            cmd = new SqlCommand("sp_MüşteriAra", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Misim", txt_Arama.Text);
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran);
            dataGridView1.DataSource = ekran;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ekran.Clear();
            cmd = new SqlCommand("sp_ÜrünAra", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ÜrünAçıklama", textBox1.Text);
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran);
            dataGridView2.DataSource = ekran;
        }
    }
}
