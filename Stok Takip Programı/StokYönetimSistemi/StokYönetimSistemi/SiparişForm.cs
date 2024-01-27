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
    public partial class SiparişForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adtr;
        DataTable ekran = new DataTable();

        public SiparişForm()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            SiparişModulForm siparisForm = new SiparişModulForm();
            siparisForm.ShowDialog();
        }

        private void SiparişForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet7.Sipariş' table. You can move, or remove it, as needed.
            this.siparişTableAdapter1.Fill(this.sYSdbDataSet7.Sipariş);
            // TODO: This line of code loads data into the 'sYSdbDataSet6.Sipariş' table. You can move, or remove it, as needed.
            this.siparişTableAdapter.Fill(this.sYSdbDataSet6.Sipariş);

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand SiparişSil = new SqlCommand("delete from Sipariş where SiparişId=@s1 and ÜrünId=@s2 ", baglanti);
            SiparişSil.Parameters.AddWithValue("@s1", txt_SiparişID.Text);
            SiparişSil.Parameters.AddWithValue("@s2", txt_ÜrünID.Text);
            SiparişSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Sipariş Silindi..");

            
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            
            ekran.Clear();
            cmd = new SqlCommand("sp_StokEkleme", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ÜrünID", txt_ÜrünID.Text);
            cmd.Parameters.AddWithValue("ÜrünMiktarı", Convert.ToInt32(dataGridView1.Rows[secilen].Cells[6].Value.ToString()));
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_SiparişID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txt_ÜrünID.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiparişModulForm siparisForm = new SiparişModulForm();
            siparisForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand SiparişSil = new SqlCommand("delete from Sipariş where SiparişId=@s1 and ÜrünId=@s2 ", baglanti);
            SiparişSil.Parameters.AddWithValue("@s1", textBox1.Text);
            SiparişSil.Parameters.AddWithValue("@s2", txt_ÜrünID.Text);
            SiparişSil.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Sipariş Silindi..");


            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            ekran.Clear();
            cmd = new SqlCommand("sp_StokEkleme", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("ÜrünID", txt_ÜrünID.Text);
            cmd.Parameters.AddWithValue("ÜrünMiktarı", Convert.ToInt32(dataGridView1.Rows[secilen].Cells[6].Value.ToString()));
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran);
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            ekran.Clear();
            cmd = new SqlCommand("sp_SiparişAra", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Misim", txt_Arama.Text);
            adtr = new SqlDataAdapter(cmd);
            adtr.Fill(ekran); 
            dataGridView1.DataSource = ekran;
        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;";
            string functionName = "EnCokSatilanUrun"; // Çağrılacak fonksiyonun adı
            StringBuilder resultMessage = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}()", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Okunan verileri kullanabilirsiniz
                            int urunId = reader.GetInt32(0);
                            string urunAdi = reader.GetString(1);
                            int adetSatilan = reader.GetInt32(2);

                            // Örneğin, bu değerleri bir MessageBox'ta gösterelim
                            resultMessage.AppendLine($"Ürün ID: {urunId}, Ürün Adı: {urunAdi}, Adet Satılan: {adetSatilan}");
                        }
                    }
                }
            }
            MessageBox.Show(resultMessage.ToString());
        }

        private void btn_Toplam_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;";
            decimal toplamGelir = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.ToplamGelir()", connection))
                {
                    // Scalar değeri al
                    object result = command.ExecuteScalar();

                    // Sonucu decimal'e çevir
                    if (result != null && result != DBNull.Value)
                    {
                        toplamGelir = Convert.ToDecimal(result);
                    }
                }
                MessageBox.Show($"Toplam Gelir: {toplamGelir:C}", "Toplam Gelir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
