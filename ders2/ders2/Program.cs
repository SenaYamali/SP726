using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //bilinçsiz tür dönüşümleri

            //int sayi1 = 255;
            // float sayi2 = sayi1;
            // Console.ReadKey(); 


            //byte sayi1 = 254;
            //int sayi2 = sayi1;
            //Console.WriteLine(sayi2.GetType());
            //Console.ReadKey();

            //float sayi1 = 47.89f;
            //Double SAYİ2 = sayi1;
            //Console.WriteLine( $"Sayi1 tipi:{SAYİ2.GetType () }");
            //Console.ReadKey();

            //char deg1 = 'G';
            //decimal deg2 = deg1;
            //Console.WriteLine(deg2);
            //Console.ReadKey();



            //int sayi3 = 15;
            //byte sayi4 = 25;
            //short sayi5 = 45;
            //double toplam = sayi3 + sayi4 + sayi5;
            //Console.WriteLine(toplam);
            //Console.ReadKey();


            //Bilinçli Tür dönüşümleri

            //byte dg1 = 255;
            //int dg2 = (int)dg1;
            //Console.WriteLine(dg1.GetType());
            //Console.WriteLine(dg1);
            //Console.ReadKey();

            //degisken_tipi degisken_adi = (dönüştürülecek_tip)değer;



            //int kucukInt = 10;
            //byte kucukByte = (byte)kucukInt;
            //Console.WriteLine(kucukByte);
            //Console.ReadKey();

            //float sayi8 = 25.87F;
            //int sayi4 = (int)sayi8;
            //Console.WriteLine(sayi4);
            //Console.ReadKey();

            //checked   //veri döüşümü eğer veri kaybına yol açıyorsa hata vericek
            //{
            //    int kucukInt = 10;
            //    byte kucukByte = (byte)kucukInt;
            //    Console.WriteLine(kucukByte);
            //    Console.ReadKey();


            //    unchecked
            //    {
            //        int kucukInt1 = 256;
            //        byte kucukByte1 = (byte)kucukInt1;
            //        Console.WriteLine(kucukByte1);
            //        Console.ReadKey();

            //    }


            //}


            //int sayi6 = 789;
            //string stringSayi6 = sayi6.ToString();

            //string stringSayi7 ="456";
            //Console.WriteLine($"stringSayi6 ={stringSayi6} ");
            //Console.WriteLine($"stringSayi7 ={stringSayi7} ");

            //string strToplam = stringSayi6 + stringSayi7;
            //Console.WriteLine($"Toplam Değeri : {strToplam}");


            ////Console.ReadKey();
            //float sayi = 45.17F;
            //string ss = sayi.ToString();
            //Console.WriteLine(ss);
            //Console.ReadKey();


            //string sayi2 = "144886";
            //int intSayi = int.Parse(sayi2);
            //Console.WriteLine(intSayi.GetType());
            //Console.ReadKey();

            //int intSayi = 75;  
            //object obje8 = intSayi;  //Bilinçsiz Tür Dönüşüm
            //Console.WriteLine(obje8.GetType());
            //Console.ReadKey();

            //int intSayi9 = 75;
            //object obje9 = (object)intSayi9;  //Biliçli Tür DÖnüşümü 
            //Console.WriteLine(obje9.GetType());
            //Console.ReadKey();

            //int intSayi10 = (int)obje9;  //Unboxing Bilinçli

            // System.Convert

            //int sayi = 0;
            //string str = Convert.ToString(sayi);
            //double dbl = Convert.ToDouble(sayi);
            //bool bl = Convert.ToBoolean(sayi);

            //Console.WriteLine($"{str} {str.GetType()}");
            //Console.WriteLine($"{dbl} {dbl.GetType()}");
            //Console.WriteLine($"{bl} {bl.GetType()}");
            //Console.WriteLine("elveda");
            //Console.ReadKey();


          
        

        }
    }
}
