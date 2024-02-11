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
    public partial class EmanetTablo : Form
    {
        public EmanetTablo()
        {
            InitializeComponent();
        }

        private void EmanetTablo_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'projeDataSet.Tbl_EmanetIslemleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_EmanetIslemleriTableAdapter.Fill(this.projeDataSet.Tbl_EmanetIslemleri);
            //datagridview ile çekilen emanet tablo.
        }
    }
}
