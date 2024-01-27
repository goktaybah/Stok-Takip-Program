using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYönetimSistemi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelAna.Controls.Add(childForm);
            panelAna.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            openChildForm(new KategoriForm());
        }

        private void btnKullanıcı_Click(object sender, EventArgs e)
        {
            openChildForm(new KullanıcıForm());
        }

        private void btnMüşteri_Click(object sender, EventArgs e)
        {
            openChildForm(new MüşteriForm());
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            openChildForm(new StokForm());
        }

        private void btnSipariş_Click(object sender, EventArgs e)
        {
            openChildForm(new SiparişForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildForm(new RaporForm());
        }
    }
}
