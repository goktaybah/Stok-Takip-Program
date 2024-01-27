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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sYSdbDataSet8.Tbl_SiparişDurum' table. You can move, or remove it, as needed.
            this.tbl_SiparişDurumTableAdapter.Fill(this.sYSdbDataSet8.Tbl_SiparişDurum);

        }
    }
}
