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
    public partial class kitapTablo : Form
    {
        public kitapTablo()
        {
            InitializeComponent();
        }

        private void kitapTablo_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.Tbl_Kitap' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_KitapTableAdapter.Fill(this.projeDataSet.Tbl_Kitap);
            //datagridview ile çekilen kitap tablosu.
        }

    }
}
