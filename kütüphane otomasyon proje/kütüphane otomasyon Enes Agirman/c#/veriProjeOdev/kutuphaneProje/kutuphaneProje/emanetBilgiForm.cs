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
    public partial class emanetBilgiForm : Form
    {
        public emanetBilgiForm()
        {
            InitializeComponent();
        }
        SqlConnection baglantiEmanet = new SqlConnection("Data Source=DESKTOP-BK0R1MS;Initial Catalog=proje;Integrated Security=True"); //sql bağlantısı.
        private void btnFormEmanetVer_Click(object sender, EventArgs e)
        {
            baglantiEmanet.Open(); //bağlantı açma.

            SqlCommand EmanetVer = new SqlCommand("insert into Tbl_EmanetIslemleri(TC , Ad , Soyad , [Telefon No] , Mail , Adres , Barkod , KitapAdı , RafNo , VerilmeTarihi) values(@k1,@k2,@k3,@k4,@k5,@k6,@k7,@k8,@k9,@k10)", baglantiEmanet); //sqldeki emanetIslemleri tablomun sütun adları ve değişken tanımlamaları.
            EmanetVer.Parameters.AddWithValue("@k1", txtboxEmanetVerTc.Text);
            EmanetVer.Parameters.AddWithValue("@k2", txtboxEmanetVerAd.Text);
            EmanetVer.Parameters.AddWithValue("@k3", txtboxEmanetVerSoyad.Text);
            EmanetVer.Parameters.AddWithValue("@k4", txtboxEmanetVerTelNo.Text);
            EmanetVer.Parameters.AddWithValue("@k5", txtboxEmanetVerMail.Text);
            EmanetVer.Parameters.AddWithValue("@k6", txtboxEmanetVerAdres.Text);
            EmanetVer.Parameters.AddWithValue("@k7", txtboxEmanetVerBarkod.Text);
            EmanetVer.Parameters.AddWithValue("@k8", txtboxEmanetVerKitapAdi.Text);
            EmanetVer.Parameters.AddWithValue("@k9", txtboxEmanetVerRafNo.Text);
            EmanetVer.Parameters.AddWithValue("@k10", txtboxEmanetVerVerilişT.Text);
            EmanetVer.ExecuteNonQuery();
            //tanımlanan değişkenlere textbox üzerinden değer atama işlemleri.
            baglantiEmanet.Close(); //bağlantı kapama.
            MessageBox.Show("Emanet Kitap Verildi."); //emanet verme işlemi sonunda ekrana gelen mesaj.
        }

        private void btnFormEmanetAl_Click(object sender, EventArgs e)
        {
            baglantiEmanet.Open(); //bağlantı açma

            SqlCommand emanetAl = new SqlCommand("update Tbl_EmanetIslemleri Set Ad=@d1,Soyad=@d2,[Telefon No]=@d3 , Mail=@d4 , Adres=@d5 , Barkod=@d6 , KitapAdı=@d7 , RafNo=@d8 , VerilmeTarihi=@d9 , TeslimTarihi=@d10 where TC=@d11", baglantiEmanet); //sqldeki emanetIslemleri tablomun sütun adları ve değişken tanımlamaları.Güncellemeyi yapabilmek için TC nin doğru olması lazım.
            emanetAl.Parameters.AddWithValue("@d1", txtboxEmanetAlAd.Text);
            emanetAl.Parameters.AddWithValue("@d2", txtboxEmanetAlSoyad.Text);
            emanetAl.Parameters.AddWithValue("@d3", txtboxEmanetAlTelNo.Text);
            emanetAl.Parameters.AddWithValue("@d4", txtboxEmanetAlMail.Text);
            emanetAl.Parameters.AddWithValue("@d5", txtboxEmanetAlAdres.Text);
            emanetAl.Parameters.AddWithValue("@d6", txtboxEmanetAlBarkod.Text);
            emanetAl.Parameters.AddWithValue("@d7", txtboxEmanetAlKitapAdi.Text);
            emanetAl.Parameters.AddWithValue("@d8", txtboxEmanetAlRafNo.Text);
            emanetAl.Parameters.AddWithValue("@d9", txtboxEmanetAlVerilmeT.Text);
            emanetAl.Parameters.AddWithValue("@d10", txtboxEmanetAlTeslimT.Text);
            emanetAl.Parameters.AddWithValue("@d11", txtboxEmanetAlTc.Text);
            emanetAl.ExecuteNonQuery();
            //tanımlanan değişkenlere textbox üzerinden değer atama işlemleri.

            baglantiEmanet.Close(); //bağlantı kapama.
            MessageBox.Show("Emanet Kitap Geri Alındı.");//emaneti geri alma işlemi sonunda ekrana gelen mesaj.
        }

    }
}
