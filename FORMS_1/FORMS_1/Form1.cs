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

namespace FORMS_1
{
    public partial class Form_AnaEkran : Form
    {
        public Form_AnaEkran()
        {
            InitializeComponent();
        }

        private void Form_AnaEkran_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Server =.;DataBase=FORM_1;uid=sa;pwd=1234");
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text;
            string soyad = txt_Soyad.Text;
            string tc = txt_tc.Text;
            DateTime dogumTarihi = dateTimePicker_Dogum.Value;
            string strDogT = dogumTarihi.ToString("yyyy-MM-dd hh:mm:ss");
            SqlCommand komutEkle=new SqlCommand($@"INSERT INTO Kullanicilar (TC,Ad,Soyad,DogumTarihi)VALUES('{tc}','{ad}','{soyad}','{dogumTarihi}')",baglanti);
            baglanti.Open();
            int etkilenenSatirSayisi = komutEkle.ExecuteNonQuery();
            if (etkilenenSatirSayisi > 0)
            {
                MessageBox.Show("Kayıt İşlemi Tamamlandı");
            }

            else
            {
                MessageBox.Show("Bir Hata Oluştu !");
            }
            baglanti.Close();
        }
    }
}
