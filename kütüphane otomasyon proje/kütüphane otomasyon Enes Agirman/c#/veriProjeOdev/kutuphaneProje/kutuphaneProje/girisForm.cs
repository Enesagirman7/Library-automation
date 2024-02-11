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
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, parola;
            kullaniciAdi = txtboxKullaniciAdi.Text; 
            parola = txtboxParola.Text;
            //kullanıcı adı ve parola bilgilerini textboxtan çekiyoruz.
            if (kullaniciAdi == "admin" && parola == "1234")
            {
                anaEkranForm form2 = new anaEkranForm();
                form2.ShowDialog();
                //admin girişi için geçerli ad ve şifre.
                //doğru giriş yapıldığında otomatik olarak form2 ye aktarılıyor.
            }
            else if (kullaniciAdi == "gorevliMemur" && parola == "kütüphane1234")
            {
                anaEkranForm form2 = new anaEkranForm();
                form2.ShowDialog();
                //gorevli memur için geçerli ad ve şifre.
                //doğru giriş yapıldığında otomatik olarak form2 ye aktarılıyor.
            }
            else
                MessageBox.Show("Kullanıcı adı veya parola yanlış!");
            //ad veya şifre yanlış ise verilen uyarı mesajı.

        }
    }
}
