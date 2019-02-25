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

namespace FORM_Soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Hesapla(double vize, double final)
        {
            return ((vize * 0.4d) + (final * 0.6d));
        }
        SqlConnection baglanti = new SqlConnection("Server=.;DataBase=Kayit_Sistemi;uid=sa;pwd=1234");
        private void hesapla_Click(object sender, EventArgs e)
        {
            string no = txt_no.Text;
            string dersAdi = txt_ders.Text;
            double vize = Convert.ToDouble (txt_vize.Text);
            double final = Convert.ToDouble(txt_final.Text);
            SqlCommand komut = new SqlCommand($@"INSERT INTO Kayit (OgrenciNo,DersAdi,Vize,Final)VALUES('{no}','{dersAdi}','{vize}','{final}')", baglanti);
            baglanti.Open();
            double ort = Hesapla(vize,final );

            if (ort <= 50)
            {
                MessageBox.Show($"Kaldınız F : {ort}");
            }
            else if (ort<=60 && ort>50)
            {
                MessageBox.Show($"Geçtiniz D : {ort}");
            }
            else if (ort <= 70 && ort > 60)
            {
                MessageBox.Show($"Geçtiniz C : {ort}");
            }
            else if (ort <= 80 && ort > 70)
            {
                MessageBox.Show($"GeçtinizB : {ort}");
            }
            else if (ort >80)
            {
                MessageBox.Show($"Geçtiniz A : {ort}");
            }


            int etkilenenSatirSayisi = komut.ExecuteNonQuery();
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
