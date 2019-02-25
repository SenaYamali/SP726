using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_ve__string_metotları
{
    class Program


    {
        static void methot(ref int[] dizi)
        {

            for (int i = 0; i <5; i++)
            {
                dizi[i] =Convert.ToInt32( Math.Pow(dizi[i], 2) * 2 + 5);
            }


        }


        static int Topla( int [] dizi2)
        {
            int toplam = 0;

            foreach (var item in dizi2)
            {
                toplam += item;

               
            }
            return toplam;
           
        }
        static int Topla(int a, int b, int c = 4)
        {

           return a+b+c;
           

        }
        static void metin(string str)
        {
            int bosluk=0; int yazi=0;
            for (int i = 0; i < str.Length; i++)
            {
               

                if (str.Substring(i, 1) == " ")
                {
                    bosluk++;
                }
                else
                {

                    yazi++;
                }
            }

            Console.WriteLine($"Boşluk: {bosluk}\nYazı:{yazi}");
        }
        static void metinsel(string clm)
        {
           
            for (int i = 0; i < clm.Length; i++)
            {
                if (clm.Substring(i, 1) == " ")
                {
                    
                   clm=clm.Remove(i, 1);i--;
                }
           
            }

            Console.WriteLine($"{clm}");
 

        }

        static char[] CharDiziYap(string[] a)
        {
            char[] diziChar = new char[a.Length];
            for (int i = 0; i <a.Length; i++)
            {

                diziChar[i] =Convert.ToChar(a[i]);
            }
            return diziChar;
        }

        static void Main(string[] args)
        {


            // Math Metotlar ön tanımlı işlemleri yapar----------



            //double pi = Math.PI;
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.E);
            //Console.WriteLine("Mutlak Değer : "+Math.Abs(-8));// Mutlak değer
            //Console.WriteLine("Cos : "+Math.Cos(45));
            //Console.WriteLine("Sin : "+Math.Sin(45));
            //Console.WriteLine("Tan : "+Math.Tan(45));
            //Console.WriteLine("Yuvarlama : "+Math.Round(10.6));
            //Console.WriteLine("---------------__________________---------------____________  ");
            //Console.WriteLine("max : "+Math.Max(4,5));
            //Console.WriteLine("Min : "+Math.Min(4,5));
            //Console.WriteLine("Üs Alma : "+Math.Pow(2,5));
            //Console.WriteLine("---------------__________________---------------____________  ");
            //Console.WriteLine("Karekökü : " + Math.Sqrt(25));
            //Console.WriteLine("Virgül Silme : " + Math.Truncate(12.6));



            //--------------------------------------------------------------------------------------



            //int[] dizi = new int[5];
            //int sayi;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayi Giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    dizi[i] = sayi;



            //}

            //methot(ref dizi);   // metothu burda çadırdım ref kullandığım için dolu şekilde girdi ve dolu şekilde çıktı

            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}


            //---------------------------------------------------------------------------------------------

            //int sayi;

            //Random rast = new Random();
            //Console.WriteLine("Sayı Giriniz");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //int[] dizi2 = new int[sayi];

            //for (int i = 0; i < sayi; i++)
            //{
            //    dizi2[i] = rast.Next(75, 126);
            //    Console.WriteLine(dizi2[i]);

            //}

            //Console.WriteLine(Topla(dizi2));

            //Console.WriteLine(Topla(dizi2[0], dizi2[1], dizi2[1]));
            //Console.WriteLine(Topla(dizi2[0], dizi2[1]));


            //-------------------------------------string metotları-----------------




            //string str1 = "Smart";
            //string str2 = "Pro";
            //string str3 = string.Concat(str1, str2); // concat birleştir demek
            ////Console.WriteLine(str3);
            //Console.WriteLine(String.Compare(str1,str2));  // sıralamaları ilki önce gelirse 1 ikincisi önce gelirse -1 döndürür

            //Console.WriteLine(str1.IndexOf("r"));// karakterin ilk görüldüğü yer için
            //Console.WriteLine(str1.LastIndexOf("r")); // son görüldüğü yer için


            //Console.WriteLine(str1.StartsWith("S"));// string s ile mi başlıyor diye soruyor
            //Console.WriteLine(str1.StartsWith("P"));
            //Console.WriteLine(str1.EndsWith("o"));// o ile mi bitiyor


            //--------------------------------------------------------------

            //string str4 = "   SmartPro      " ;
            //string str5 = "SmartPro";
            //Console.WriteLine(str4);
            //Console.WriteLine(str4.Trim());// baştaki ve sondaki boşlukları siler

            //---------------------------------------------------------------------------

            //char[] cDizi = { 'o', 'P', 'r' };
            //Console.WriteLine(str5.Trim(cDizi)); // dizide ki belirttiğimiz karekterleri silc

            //--------------------------------------------

            //string str6 = "PRO";
            //Console.WriteLine(str6.PadLeft(5));//karakter 3 harfli olduğu için sol tarafa boşluk koyuyor
            //Console.WriteLine(str6.PadLeft(5,'F')); // boşluk yerine FF koyuyor
            //Console.WriteLine(str6.PadRight(5,'F'));// sağına boşluk koyuyor

            //------------------------------------------------
            //string str7 = "merhaba ayşe aysel sevgi serdar sezgin mustafa";
            //Console.WriteLine(str7);
            //string[] strdizi = str7.Split(' ');// parçalara ayrıyor ayraça göre sonra diziye atıyor
            //foreach (var item in strdizi)
            //{
            //    Console.WriteLine(item);
            //}


            ////------------------------------------------------------------------------


            //string strJoined = string.Join("#", strdizi);
            //Console.WriteLine(strJoined);

            //---------------------------------------------------------------


            //Console.WriteLine("Cümle Giriniz");
            //string cml = (Console.ReadLine());
            //string[] dizi = cml.Split(' ');
            //foreach (var item in dizi)
            //    {
            //       Console.WriteLine(item);
            //    }

            //    Console.WriteLine(cml.Trim());
            //string strJoined = string.Join(",", dizi);
            //Console.WriteLine(strJoined);

            //-----------------------------------------------------------------------------

            //string kucuk = "smartpro";
            //string buyuk = "SMARTPRO";
            //Console.WriteLine(kucuk.ToUpper());  // metini büyük yapar
            //Console.WriteLine(buyuk.ToLower()); // metini kuçuk yapar


            //Console.WriteLine(buyuk.Remove(0,5)); // 0 indis ten beşinçi indise kadar siler
            //Console.WriteLine(buyuk.Insert(8,"_BRO"));  // 8 . indistren sonra metine ekle 

            //Console.WriteLine(buyuk.Replace('P','B'));  // p ile b yi yer değiştiirir.

            //------------------______________________------------------____________________---------------


            //string str = "Merhaba 404";
            //Console.WriteLine(str.Substring(8));  // 8. indisten itibaren kesip ikinci indisi alıyor
            //Console.WriteLine(str.Substring(0,7));
            //Console.WriteLine(str.Substring(0,1)); // başlangıç değeri verip kullanabiliriz.

            //Console.WriteLine(str.Contains("aba")); // içinde aba metni var mı diye kontrol eder.


            //Console.WriteLine(str[8]);  // BU şekilde eleman çağırılıyor.



            //-------------------------------------------------------------------------------------


            //Console.WriteLine("Metin giriniz.");
            //string mtn = (Console.ReadLine());

            //metin(mtn);

            //Console.ReadKey();



            //--------------------------------------------------------------------------------




            //Console.WriteLine("Metin giriniz.");
            //string cml = (Console.ReadLine());

            //metinsel(cml);


            //----------------------------------------------------------------------------

         
            Console.WriteLine("metin giriniz.");
            string cml1 = (Console.ReadLine());
            string[] dizi = new string[cml1.Length];
            Char[] dizist = new char[cml1.Length];
            for (int i = 0; i < cml1.Length; i++)
            { //Merhaba
             dizi[i] = cml1.Substring(i,1);
            }

           dizist = CharDiziYap(dizi);


            foreach (var item in dizist)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
        static void x()
        {

        }
    }


  


}
