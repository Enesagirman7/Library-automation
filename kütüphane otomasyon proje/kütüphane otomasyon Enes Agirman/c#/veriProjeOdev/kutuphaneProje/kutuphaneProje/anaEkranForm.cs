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

namespace kutuphaneProje
{
    public partial class anaEkranForm : Form
    {
        
        public anaEkranForm()
        {
            SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - BK0R1MS; Initial Catalog = proje; Integrated Security = True");
            //sql servis bağalantısı için gerekli kod.
            InitializeComponent();
        }


        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            kitapTablo kitapTablo = new kitapTablo();
            kitapTablo.ShowDialog();
            //kitap listele butonuna tıklandığı zaman kitap tablosunun kayıtlı olduğu forma aktarma gerçekleşiyor.
        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetTablo emanetTablo = new EmanetTablo();
            emanetTablo.ShowDialog();
            //emanet listele butonuna tıklandığı zaman emanet tablosunun kayıtlı olduğu forma aktarma gerçekleşiyor.
        }

        private void btnUyeListele_Click(object sender, EventArgs e)
        {
            uyeTablo uyeTablo = new uyeTablo();
            uyeTablo.ShowDialog();
            //üye listele butonuna tıklandığı zaman üye tablosunun kayıtlı olduğu forma aktarma gerçekleşiyor.
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            uyeBilgiForm uyeBilgiForm = new uyeBilgiForm();
            uyeBilgiForm.ShowDialog();
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            uyeBilgiForm uyeBilgiForm = new uyeBilgiForm();
            uyeBilgiForm.ShowDialog();
        }

        private void btnUyeDuzenle_Click(object sender, EventArgs e)
        {
            uyeBilgiForm uyeBilgiForm = new uyeBilgiForm();
            uyeBilgiForm.ShowDialog();
        }
        //üye ekleme,silme ve düzenleme işlemleri için açılan uyebilgiforma oto aktarım gerçekleşiyor.
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            kitapBilgiForm kitapBilgiForm = new kitapBilgiForm();
            kitapBilgiForm.ShowDialog();
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            kitapBilgiForm kitapBilgiForm = new kitapBilgiForm();
            kitapBilgiForm.ShowDialog();
        }
        //kitap ekleme ve silme işlemleri için açılan kitapbilgiforma oto aktarım gerçekleşiyor.

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            emanetBilgiForm emanetBilgiForm = new emanetBilgiForm();
            emanetBilgiForm.ShowDialog();
        }

        private void btnEmanetAl_Click(object sender, EventArgs e)
        {
            emanetBilgiForm emanetBilgiForm = new emanetBilgiForm();
            emanetBilgiForm.ShowDialog();
        }
        //emanet verme ve alma işlemleri için açılan emanetbilgiforma oto aktarım gerçekleşiyor.

    }
}
