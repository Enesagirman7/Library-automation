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
    public partial class kitapBilgiForm : Form
    {
        public kitapBilgiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-BK0R1MS;Initial Catalog=proje;Integrated Security=True"); //sql bağlantısı.
        private void btnFormKitapEkle_Click(object sender, EventArgs e)
        {
            baglantiKitap.Open(); //bağlantı açma.

            SqlCommand kitapEkle = new SqlCommand("insert into Tbl_Kitap(KitapAdı , Yazar , Sayfa , BasımYılı , YayınEvi , RafNo) values(@k1,@k2,@k3,@k4,@k5,@k6)", baglantiKitap);
            //sqldeki kitap tablomun sütun adları ve değişken tanımlamaları.
            kitapEkle.Parameters.AddWithValue("@k1", txtboxKitapEkleKitapAdi.Text);
            kitapEkle.Parameters.AddWithValue("@k2", txtboxKitapEkleYazar.Text);
            kitapEkle.Parameters.AddWithValue("@k3", txtboxKitapEkleSayfa.Text);
            kitapEkle.Parameters.AddWithValue("@k4", txtboxKitapEkleBasimYili.Text);
            kitapEkle.Parameters.AddWithValue("@k5", txtboxKitapEkleYayinEvi.Text);
            kitapEkle.Parameters.AddWithValue("@k6", txtboxKitapEkleRafNo.Text);
            kitapEkle.ExecuteNonQuery();
            //tanımlanan değişkenlere textbox üzerinden değer atama işlemleri.

            baglantiKitap.Close(); //bağlantı kapatma.
            MessageBox.Show("Kitap Eklendi."); //ekleme işlemi tamamlandığında ekrana çıkan mesaj.
        }

        private void btnFormKitapSil_Click(object sender, EventArgs e)
        {
            baglantiKitap.Open(); //bağlantı açma.

            SqlCommand kitapSil = new SqlCommand("delete from Tbl_Kitap where Barkod=@s1", baglantiKitap);
            //sqldeki kitap tablomun Barkod sütunu ve ona tanımlanan değişken.
            kitapSil.Parameters.AddWithValue("@s1", txtboxKitapSilBarkod.Text);
            kitapSil.ExecuteNonQuery();
            //tanımlanan değişkene textbox üzerinden değer girildiğinde Barkod doğru ise o kitap tamamen siliniyor.

            baglantiKitap.Close(); //bağlantı kapama.
            MessageBox.Show("Kayıt Silindi."); //silme işlemi tamamlandığında ekrana çıkan mesaj.
        }
    } ////BU 2 İŞLEM İÇİN TABPAGE KULLANDIĞIMDAN ÖTÜRÜ ÇALIŞTIRILAN PROGRAMDA EKLEME VE SİLME 2 BUTONA DA BASILDIĞINDA YUKARIDA SEKME OLARAK HEPSİ GÖSTERİLİYOR. ORADAN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİP İŞLEME DEVAM EDEBİLİRSİZ.
}
