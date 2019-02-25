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

namespace form_soru2
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("SERVER=.;DATABASE=TEST;uid=sa;pwd=1234;");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void listele()
        {
            string sorgu = "SELECT * FROM Eleman";
            SqlDataAdapter tabloCek = new SqlDataAdapter(sorgu, baglanti);
            DataTable elemanTable = new DataTable();
            tabloCek.Fill(elemanTable);
            dataGridView1.DataSource = elemanTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            string ad= dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();
            string soyad= dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
            string sehir= dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
            txt_ad.Text = ad;
            txt_soyad.Text = soyad;
            comboBox1.Text = sehir;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElemanKaydet();

        }

        private void ElemanKaydet()
        {
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string sehir = comboBox1.Text;

            SqlCommand kaydetKomut = new SqlCommand("SP_Eleman_Kaydet", baglanti);
            kaydetKomut.CommandType = CommandType.StoredProcedure;
            kaydetKomut.Parameters.AddWithValue("@ad", ad);
            kaydetKomut.Parameters.AddWithValue("@soyad", soyad);
            kaydetKomut.Parameters.AddWithValue("@sehir", sehir);
            baglanti.Open();
            int etkilenenSatir = kaydetKomut.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Kayıt Başarılı");
                listele();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int seciliID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;
            string sehir = comboBox1.Text;
            SqlCommand komutGuncelle = new SqlCommand("SP_Eleman_Guncelle",baglanti);
            komutGuncelle.CommandType = CommandType.StoredProcedure;
            komutGuncelle.Parameters.AddWithValue("@id",seciliID);
            komutGuncelle.Parameters.AddWithValue("@ad",ad);
            komutGuncelle.Parameters.AddWithValue("@soyad",soyad);
            komutGuncelle.Parameters.AddWithValue("@sehir",sehir);
            baglanti.Open();
            int etkilenenSatir = komutGuncelle.ExecuteNonQuery();
            baglanti.Close();
            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Güncelleme Başarılı");
                listele();
            }
            else
            {
                MessageBox.Show("Hata Oluştu !");
            }
        }
    }
}
