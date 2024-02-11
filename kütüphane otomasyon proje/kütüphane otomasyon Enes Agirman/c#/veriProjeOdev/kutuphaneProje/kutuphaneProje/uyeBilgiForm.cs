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
    public partial class uyeBilgiForm : Form
    {
        public uyeBilgiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK0R1MS;Initial Catalog=proje;Integrated Security=True"); //sql bağlantısı.

        private void btnFormUyeEkle_Click(object sender, EventArgs e)
        {
            
            baglanti.Open(); //bağlantı açma.

            SqlCommand uyeEkle = new SqlCommand("insert into Tbl_Uye(TC , Ad , Soyad , [Telefon No] , Mail , Adres) values(@e1,@e2,@e3,@e4,@e5,@e6)", baglanti); 
            //sqldeki üye tablomun sütun adları ve değişken tanımlamaları.
            uyeEkle.Parameters.AddWithValue("@e1", txtboxUyeEkleTc.Text);
            uyeEkle.Parameters.AddWithValue("@e2", txtboxUyeEkleAd.Text);
            uyeEkle.Parameters.AddWithValue("@e3", txtboxUyeEkleSoyad.Text);
            uyeEkle.Parameters.AddWithValue("@e4", txtboxUyeEkleTelNo.Text);
            uyeEkle.Parameters.AddWithValue("@e5", txtboxUyeEkleMail.Text);
            uyeEkle.Parameters.AddWithValue("@e6", txtboxUyeEkleAdres.Text);
            uyeEkle.ExecuteNonQuery();
            //tanımlanan değişkenlere textbox üzerinden değer atama işlemleri.

            baglanti.Close(); //bağlantı kapama.
            MessageBox.Show("Ogrenci Eklendi."); //ekleme işlemi tamamlandıktan sonra ekrana çıkan mesaj.

        }

        private void btnFormUyeSil_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //bağlantı açma.

            SqlCommand uyeSil = new SqlCommand("delete from Tbl_Uye where TC=@s1", baglanti);
            //sqldeki üye tablomun TC sütunu ve ona tanımlanan değişken.
            uyeSil.Parameters.AddWithValue("@s1", txtboxUyeSilTc.Text);
            uyeSil.ExecuteNonQuery();
            //tanımlanan değişkene textbox üzerinden değer girildiğinde TC doğru ise o üye kaydı tamamen siliniyor.
            baglanti.Close(); //bağlantı kapama.
            MessageBox.Show("Kayıt Silindi."); //silme işlemi tamamlandığında ekrana çıkan mesaj.
        }

        private void btnFormUyeDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //bağlantı açma.

            SqlCommand uyeDuzenle = new SqlCommand("update Tbl_Uye Set Ad=@d1,Soyad=@d2,[Telefon No]=@d3,Mail=@d4 , Adres=@d5 where TC=@d6", baglanti);
            //sqldeki üye tablomun sütun adları ve değişken tanımlamaları. Güncelleme yapacağımız için sql kodunun başında update bulunmakta.
            uyeDuzenle.Parameters.AddWithValue("@d1", txtboxUyeDuzenleAd.Text);
            uyeDuzenle.Parameters.AddWithValue("@d2", txtboxUyeDuzenleSoyad.Text);
            uyeDuzenle.Parameters.AddWithValue("@d3", txtboxUyeDuzenleTelNo.Text);
            uyeDuzenle.Parameters.AddWithValue("@d4", txtboxUyeDuzenleMail.Text);
            uyeDuzenle.Parameters.AddWithValue("@d5", txtboxUyeDuzenleAdres.Text);
            uyeDuzenle.Parameters.AddWithValue("@d6", txtboxUyeDuzenleTc.Text);
            uyeDuzenle.ExecuteNonQuery();
            //tanımlanan değişkenlere textbox üzerinden değer atama işlemleri.

            baglanti.Close(); //bağlantı kapama.
            MessageBox.Show("Kayıt Güncellendi."); //düzenleme işlemi tamamlandığında ekrana çıkan mesaj.
        }

        //BU 3 İŞLEM İÇİN TABPAGE KULLANDIĞIMDAN ÖTÜRÜ ÇALIŞTIRILAN PROGRAMDA EKLE,SİLME,DÜZENLEME 3 BUTONA DA BASILDIĞINDA YUKARIDA SEKME OLARAK HEPSİ GÖSTERİLİYOR. ORADAN YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİP İŞLEME DEVAM EDEBİLİRSİZ.
    }
}
