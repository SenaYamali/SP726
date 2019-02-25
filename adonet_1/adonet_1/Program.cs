using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection baglanti_OKUL_VT = new SqlConnection();
            baglanti_OKUL_VT.ConnectionString = @"Server=localhost;Database=OKUL_VT;User=sa;Password=1234";
            //SqlCommand komut1 = new SqlCommand();
            //komut1.CommandText = "SELECT *FROM Ogretmenler";
            //komut1.Connection = baglanti_OKUL_VT;
            //baglanti_OKUL_VT.Open();
            //SqlDataReader dataReaderOgretmenler = komut1.ExecuteReader();
            //while(dataReaderOgretmenler.Read())
            //{
            //    string ogretmenID = dataReaderOgretmenler[0].ToString();
            //    string ogretmenAdi = dataReaderOgretmenler[1].ToString();
            //    //string aktifCalısan = dataReaderOgretmenler[2].ToString();
            //    string aktifCalısan = dataReaderOgretmenler["AktifCalisan"].ToString(); // yukardakiyle aynı kod
            //    Console.WriteLine($"Öğretmen ID'si : {ogretmenID}  Öğretmen Adı : {aktifCalısan}  Çalışma Durumu : {aktifCalısan}");
            //}

            {
                string ogretmenAdi2 = "Kazım KOYUNCU";
                SqlCommand komutInsert = new SqlCommand();
                komutInsert.CommandText = $"INSERT INTO Ogretmenler VALUES ('{ogretmenAdi2}',1)";
                komutInsert.Connection = baglanti_OKUL_VT;
                baglanti_OKUL_VT.Open();

                komutInsert.ExecuteNonQuery(); // bir yere atamak zorunda değiliz bize gelen birşey yok update insert delete gibi
                baglanti_OKUL_VT.Close();
            }
           
            Console.ReadKey();
        }
    }
}
