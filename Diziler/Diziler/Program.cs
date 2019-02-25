using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] diziAdi = new int[6];
            //int[] dizi1 = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(dizi1[0]);
            //dizi1[0] = 25;
            //Console.WriteLine(dizi1[0]);

            //-------------------------------------------------------------------------------------------

            //int[] diziAdi = new int[6];
            //int[] dizi1 = { 1, 2, 3, 4, 5, 6 }; // dizinin boyutunu gösterir.
            //Console.WriteLine(dizi1.Length);
            //Console.WriteLine("Döngü İle");

            //for (int i = 0; i <= 5; i++)
            //// for (int i = 0; i <dizi1.Length; i++)
            //{
            //    Console.WriteLine(dizi1[i]);
            //}


            //------------------------------------------------------------------------------------------

            //    string[] sdizi = { "Mert", "Sena", "Rümeysa", "Ufuk", "Eray","Emre" };

            //    for(int i=0;i<sdizi.Length;i++)
            //    { 

            //    Console.WriteLine(sdizi[i]);
            //}
            //    sdizi[0] = "Murat";
            //    Console.WriteLine(sdizi[0]);

            //--------------------------------------------------------------------------------------------

            //int[] diziAdi = new int[6];

            // int[] dizi2 = { 1, 2, 3, 4, 5, 6 };
            // foreach (int a in dizi2) // Dizi elemanlarının her biri için işelm yap
            // {
            //     Console.WriteLine(a);
            // }

            // char[] cDizi = { 'a', 'f', 'e', 'd' };



            //---------------------------------------------------------------------------------------

            //Random a = new Random();
            //int[] dizi1 = new int[10];


            //    for (int i = 0; i < dizi1.Length; i++)
            //    {
            //        dizi1[i] = a.Next(1, 100);

            //        Console.WriteLine(dizi1[i]);
            //    }



            //---------------------------------------------------------------------------------------------




            //int[] dizi1 = new int[5];

            //for (int i = 0; i < dizi1.Length; i++)

            //{
            //    Console.WriteLine("Sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    dizi1[i] = sayi;
            //}
            //    foreach (int item in dizi1)
            //    {

            //        if (item % 2 == 0)
            //        {
            //            Console.WriteLine($"Çift sayılar {item}");

            //        }


            //}


            //-------------------------KOMUTLAR---------------------------------------------------------------




            //char[] cdizi = { 'a', 'f', 'e', 'z', 'h', 'A' };
            //foreach (var item in cdizi)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine("Sıralamadaan sonra :");
            //Array.Sort(cdizi);  // Sıralama Yapar.
            //foreach (var item in cdizi)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("Tersine Sıralamadan sonra :");
            //Array.Reverse(cdizi); // Tersine Sıralama Yapar.
            //foreach (var item in cdizi)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Clear Sonrası :");
            //Array.Clear(cdizi, 3, 2);  // 3. indis den sonra 2 karakter sil 
            //foreach (var item in cdizi)
            //{
            //    Console.WriteLine(item);
            //}



            //----------------------------------------------------------------------------------------------------



            //string[] dizi2 = new string[5];

            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine("İsim Giriniz :");
            //     dizi2[i] = Console.ReadLine();
            // }

            // Console.WriteLine(  );
            //     Array.Sort(dizi2);

            //     foreach (string item in dizi2)
            //     {

            //         Console.WriteLine(item);
            //     }

            // Console.WriteLine();
            // if (dizi2.Length % 2 != 0)
            // {
            //     Array.Clear(dizi2, dizi2.Length / 2, 1);

            // }
            // foreach (var item in dizi2)
            // {
            //     Console.WriteLine(item);
            // }




            //-------------------------------------------------------------------------------------------



            //int[] dizi1 = { 5, 66, 898, 12, 34, 55, 90 };
            //int[] dizi2 = new int[14];
            //int[] dizi3 = new int[8];

            //dizi1.CopyTo(dizi2,4);
            //foreach (var item in dizi2)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Copy(dizi1, dizi3, 3);
            //Console.WriteLine("-------------------");
            //foreach (var item in dizi3)
            //{
            //    Console.WriteLine(item);
            //}


            //-----------------------------------------------------------------------------



            //    int[] dizi1 = { 5, 66, 898, 12, 34, 55, 90 };
            //    int index = Array.BinarySearch(dizi1, 34); // dizide 34 varmı diye ve hangi indiste diye bakar
            //    if(index>0)

            //    Console.WriteLine("34 Bulunan indis :"+index);

            //else
            //        Console.WriteLine("Dizi Yok.");


            //-----------------------------------------------------------------------------


            //int[] dizi1 = new int[20];
            //int[] tek = new int[20];

            //int sayi;

            //for (int i = 0; i <20; i++)

            //{
            //    Console.WriteLine("Tam sayı giriniz:");
            //   sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 2 == 0)
            //    {

            //        dizi1[i] = sayi;


            //    }
            //    else
            //    {
            //        tek[i]= sayi;

            //    }

            //}

            //foreach (var item in dizi1)
            //{
            //    if (item !=0)
            //    {
            //        Console.WriteLine($"Çift Sayı : {item}");
            //    }

            //}

            //foreach (var item in tek)
            //{
            //    if (item != 0)
            //    {
            //        Console.WriteLine($"Tek Sayı : {item}");
            //    }
            //}




            //----------------------------------------------------------------------------------------------------



            //int[] dizi5 = new int[10];
            //int[] kucuk = new int[10];
            //int tktoplam = 0, cfttoplam = 0;
            //for (int i = 0; i < 10; i++)
            //{


            //    Console.WriteLine("Sayı Giriniz :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());



            //    if (sayi >= 50)
            //    {
            //        dizi5[i] = sayi;
            //        cfttoplam += dizi5[i];

            //    }

            //    else if (sayi < 50)
            //    {
            //        kucuk[i] = sayi;
            //        tktoplam += kucuk[i];


            //    }

            // }
            //Console.WriteLine($"Büyükler Toplamı :{cfttoplam}\nKüçükler Toplamı :{tktoplam}");



            //---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---_---



            //int[] dizi1 = { 5, 66, 898, 12, 34, 55, 90,34 };
            //int n = Array.IndexOf(dizi1, 34);
            //Console.WriteLine(n);   // İndex değerini gösteriyor.
            //Console.WriteLine(dizi1[n]);


            //__________________--------------------______________________-----------------_____________________





            // string[] no = { "101", "102", "103", "104", "105" };
            // string[] ad = { "ahmet", "recep", "mustafa", "kenan", "ayşe" };
            // string[] tel = { "5252252", "785215", "54741245", "7785152", "55214522" };
            // string[] email = { "vfcklkbmcv@kfmbh", "fkfdkj@nçbgjf", "cxmkçdjflk@flkghf", "kfgjklfdxjl@glkşnçhkl", "hjxzfkxd@kflgf" };

            // Console.WriteLine("Oda Numarası Giriniz :");
            //string sayi = Convert.ToString(Console.ReadLine());

            // int n = Array.IndexOf(no,sayi);
            // Console.WriteLine(ad[n]+" "+tel[n]+" "+email[n]+" "+no[n]);




            //-------------------------------> 2 BOYUTLU DİZİLER <-----------------------------------


            //int[] dizi11 = { 2, 3, 5, 6 };
            //int[] dizi12 = new int[4];
            //int[,] diziIB = new int[4,3];// 4 satır 3 sutun sayısı
            //Random rastgele = new Random();
            //for (int i = 0; i <4; i++)
            //{

            //    for (int k = 0; k < 3; k++)
            //    {
            //        int rsayi = rastgele.Next(101);
            //        diziIB[i, k] = rsayi;
            //        Console.WriteLine(diziIB[i,k]);
            //    }
            //}
            //Console.WriteLine(diziIB[1, 1]);


            //----------------------------------------------------------------------------------------------------


            //int[,] dizi7 = new int[3, 2];
            //Random rastgele = new Random();
            //int toplam = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        int rsayi = rastgele.Next(10, 29);
            //        dizi7[i, j] = rsayi;
            //        Console.Write(dizi7[i,j] +" ");


            //        if (i == 1)
            //        {
            //            toplam = toplam + dizi7[i, j];
            //        } 
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine($"Toplamları: {toplam} ");



            //----------------------------------------------------------------------------




            //  Random rastgele = new Random();
            //  int toplam = 0;
            //  Console.WriteLine("Sayı giriniz :");
            // int x = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Sayı giriniz :");
            //int y = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine("Sayı giriniz :");
            //  int z = Convert.ToInt32(Console.ReadLine());
            //  int[,,] dizi4 = new int[x, y, z];


            //  for (int i = 0; i < x; i++)
            //  {
            //      Console.Write("(");
            //      for (int k = 0; k < y; k++)
            //      {
            //          Console.Write("[");
            //          for (int j = 0; j < z; j++)
            //          {
            //              int rsayi = rastgele.Next(10,91);
            //              dizi4[i, k, j] = rsayi;
            //              Console.Write(dizi4[i,k ,j] + " ");
            //              if (k==0 && j==0)
            //              {
            //                  toplam = toplam + dizi4[i, k, j];

            //              }


            //          }
            //          Console.Write("]");
            //      }

            //      Console.WriteLine(")");
            //  }
            //  Console.WriteLine($"Toplam :{toplam}");




            //----------------------------------------------------------------------------------------



            //object[,] diziObje = new object[2,2];
            //diziObje[0, 0] = 5;
            //diziObje[0, 1] = "SMARTPRO";
            //diziObje[1, 0] = 'F';
            //diziObje[1, 1] = 14F;
            //foreach (var item in diziObje)
            //{
            //    Console.WriteLine(item);
            //}



            //-----------------________________________-------------------_______________________-----------------


           
            Console.Write("Sınıf Mevcudunu Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
           
           
            object[,] dizi1 = new object[sayi,3];
            for (int i = 0; i < sayi; i++)
            {
               
                Console.Write("Öğrenci Adını Giriniz :");
             string ad = (Console.ReadLine());
                dizi1[i, 0] = ad;
                Console.Write("Öğrenci Notunu Giriniz :");
               int not = Convert.ToInt32(Console.ReadLine());

                dizi1[i, 1] = not;
                if (not >= 0 && not <= 29)

                {
                   
                  
                    dizi1[i, 2] = "Çok Zayıf";
                }

                else if (not >= 30 && not <= 54)
                {
                   
                    dizi1[i, 2] = "Zayıf";
                }
                else if (not >= 55 && not <= 69)
                {
                    
                    dizi1[i, 2] = "Orta";
                }
                else if (not >= 70 && not <= 84)
                {
                    
                    dizi1[i, 2] = "İyi";
                }
                else if (not >= 85 && not <= 100)
                {
                    
                    dizi1[i, 2] = "Pekİyi";
                }
                Console.WriteLine($" Adı :{dizi1[i,0]}\n Notu : {dizi1[i,1]}\n Not Karşılığı :{dizi1[i,2]}");

            }
            Console.ReadKey();
        }
    }
}
