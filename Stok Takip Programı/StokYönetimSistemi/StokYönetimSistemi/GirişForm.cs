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
    public partial class GirişForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-BJ6L27T;Initial Catalog=SYSdb;Integrated Security=True;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter adtr;

        public GirişForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxŞifre_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxŞifre.Checked==false)
                txt_Şifre.UseSystemPasswordChar = true;
            else
                txt_Şifre.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Uygulamadan Çıkmak İstediğine Emin misin?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            try 
            {
                cmd = new SqlCommand("sp_Giriş", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("KullanıcıAdı", txt_KullanıcıAdı.Text);
                cmd.Parameters.AddWithValue("Şifre", txt_Şifre.Text);
                adtr = new SqlDataAdapter(cmd);
                baglanti.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    MessageBox.Show("Hoşgeldiniz " + dr["AdıSoyadı"].ToString() + " | ", "Giriş Kontrol", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AnaForm main = new AnaForm();
                    this.Hide();
                    main.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre!","Giriş Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {



                MessageBox.Show(ex.Message);


            }
        }
    }
}
