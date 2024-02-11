using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneProje
{
    public partial class uyeTablo : Form
    {
        public uyeTablo()
        {
            InitializeComponent();
        }

        private void uyeTablo_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.Tbl_Uye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UyeTableAdapter.Fill(this.projeDataSet.Tbl_Uye);
            //datagridview ile çekilen uye tablo.
        }


    }
}
