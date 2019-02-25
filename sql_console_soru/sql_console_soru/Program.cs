using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sql_console_soru
{
    class Personel
    {
        int PersonelID;
        string PersonelAdi;
        string PersonelSoyadi;
        DateTime PersonelIBT= DateTime.Today;
        bool AktifMi;
        private object komutInsert;
        private SqlConnection baglanti_OKUL_VT;

        public void PersonelEkle()
         {
            Console.WriteLine("Adınızı Giriniz");
            PersonelAdi = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            PersonelSoyadi = Console.ReadLine();
            //Console.WriteLine("İşe Başlama Tarihinizi Giriniz");
            string strPersonelIBT = PersonelIBT.ToString("yyyy-MM-dd");

            SqlConnection baglanti_OKUL_VT = new SqlConnection();
            baglanti_OKUL_VT.ConnectionString = @"Server=localhost;Database=OKUL_VT;User=sa;Password=1234";
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = $"INSERT INTO Personel VALUES ('{PersonelAdi}','{PersonelSoyadi}','{strPersonelIBT}',1)";
            komut1.Connection = baglanti_OKUL_VT;
            baglanti_OKUL_VT.Open();
            komut1.ExecuteNonQuery();
            baglanti_OKUL_VT.Close();
        }
        public void PersonelSil()
        {

            SqlConnection baglanti_OKUL_VT = new SqlConnection();
            baglanti_OKUL_VT.ConnectionString = @"Server=localhost;Database=OKUL_VT;User=sa;Password=1234";
            Console.WriteLine("Personel ID giriniz");
            PersonelID=Convert.ToInt16(Console.ReadLine());
            SqlCommand komutInsert = new SqlCommand();
            komutInsert.CommandText = $"UPDATE Personel SET AktifMi=0 WHERE PersonelID ={PersonelID}";
            komutInsert.Connection = baglanti_OKUL_VT;
            baglanti_OKUL_VT.Open();
            komutInsert.ExecuteNonQuery();
            baglanti_OKUL_VT.Close();

        }
        public void PersonelListele()
        {
            SqlConnection baglanti_OKUL_VT = new SqlConnection();
            baglanti_OKUL_VT.ConnectionString = @"Server=localhost;Database=OKUL_VT;User=sa;Password=1234";
            SqlCommand komut1 = new SqlCommand();
            komut1.CommandText = "SELECT *FROM Personel";


            komut1.Connection = baglanti_OKUL_VT;
            baglanti_OKUL_VT.Open();
            komut1.ExecuteNonQuery();
            SqlDataReader dataReaderPersonel = komut1.ExecuteReader();
            while (dataReaderPersonel.Read())
            {
                if ((bool)dataReaderPersonel[4]==true) {
                    string PersonelID = dataReaderPersonel[0].ToString();
                    string PersonelAdi = dataReaderPersonel[1].ToString();
                    string PersonelSoyadi = dataReaderPersonel[2].ToString();

                    Console.WriteLine($"Personel ID'si : {PersonelID}  Personel Adı : {PersonelAdi}  Personel Soyadı : {PersonelSoyadi}");
                }
            }
            baglanti_OKUL_VT.Close();
        }
        


    }


    class Program
    {
        static void Main(string[] args)
        {
            Personel prsl = new Personel();
            //prsl.PersonelEkle();
            prsl.PersonelSil();
            prsl.PersonelListele();

            //SqlConnection baglanti_OKUL_VT = new SqlConnection();
            //baglanti_OKUL_VT.ConnectionString = @"Server=localhost;Database=OKUL_VT;User=sa;Password=1234";
            //SqlCommand komut1 = new SqlCommand();
            //komut1.CommandText = "SELECT *FROM Personeller";
            //komut1.Connection = baglanti_OKUL_VT;
            //baglanti_OKUL_VT.Open();
            //SqlDataReader dataReaderOgretmenler = komut1.ExecuteReader();
            ////while(dataReaderOgretmenler.Read())
            ////{
            ////    string ogretmenID = dataReaderOgretmenler[0].ToString();
            ////    string ogretmenAdi = dataReaderOgretmenler[1].ToString();
            ////    //string aktifCalısan = dataReaderOgretmenler[2].ToString();
            ////    string aktifCalısan = dataReaderOgretmenler["AktifCalisan"].ToString(); // yukardakiyle aynı kod
            ////    Console.WriteLine($"Öğretmen ID'si : {ogretmenID}  Öğretmen Adı : {aktifCalısan}  Çalışma Durumu : {aktifCalısan}");
            ////}

            //{
            //    string ogretmenAdi2 = "Kazım KOYUNCU";
            //    SqlCommand komutInsert = new SqlCommand();
            //    komutInsert.CommandText = $"INSERT INTO Ogretmenler VALUES ('{ogretmenAdi2}',1)";
            //    komutInsert.Connection = baglanti_OKUL_VT;
            //    baglanti_OKUL_VT.Open();

            //    komutInsert.ExecuteNonQuery(); // bir yere atamak zorunda değiliz bize gelen birşey yok update insert delete gibi
            //    baglanti_OKUL_VT.Close();
            //}

            Console.ReadKey();
        }
    }
}
