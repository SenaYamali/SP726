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

namespace Form_soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Server=.;DataBase=Kayit_Sistemi;uid=sa;pwd=1234;");
        private void button_grs_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text;
            string prl = txt_prl.Text;
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = @"
               SELECT * FROM  Kullanici WHERE KullaniciAdi=@ad AND KullaniciParola=@prl";
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@prl", prl);

            baglanti.Open();
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                
            }

            else
            {
                MessageBox.Show("Bir Hata Oluştu !");
            }

            baglanti.Close();
        }
    }
}
