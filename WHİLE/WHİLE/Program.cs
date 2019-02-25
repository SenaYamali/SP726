using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHİLE
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;


            //}


            //string toplam = "";
            //Char a = ' ';
            //while (a != 'K')
            //{
            //    Console.WriteLine("Karakter Giriniz :");
            //    a = Convert.ToChar(Console.ReadLine());
            //    toplam = toplam + a.ToString();
            //    Console.Write(a);               
            //}
            //Console.WriteLine(toplam);




            // Do While döngüsü döngüye girmeden bir kere çalıştırıyor sonra koşulu gerçekleştiriyor


            //int i= 1;
            //do
            //{
            //    Console.WriteLine("Merhaba Dünya"+i);
            //    i++;
            //} while (i<16);
            //Console.WriteLine("Döngü Bitti");


            //int sayi =1;

            //do
            //{
            //    Console.WriteLine($"{sayi} Karesi :{sayi * sayi}");
            //    sayi++;
            //} while (sayi<=100);


            //Console.WriteLine("Döngü bitti");



            //int i = 1;
            //string ad ="smartpro";
            //string prl = "SmartKD";

            //do
            //{
            //    Console.WriteLine("Adınızı Giriniz");
            //    ad = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("Parola Giriniz");
            //    prl = Convert.ToString(Console.ReadLine());

            //    if (ad == "smartpro" && prl == "SmartKD")
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //    else if (i==5)
            //    { Console.WriteLine("Çok Fazla Hata Yaptınız");

            //    }
            //    i++;

            //}

            //while (i<=5);



            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i == 10)
            //        continue;   // 10 yazdırmadan devam eder.
            //    if (i == 20)
            //        break;

            //    Console.WriteLine("sayı"+i);
            //}





            //Console.WriteLine("Sayi Giriniz:");
            //int sayi = Convert.ToInt16(Console.ReadLine());
            //for (int i = 1; i < sayi; i++)
            //{
            //    Console.WriteLine("SMARTPRO");

            //    if (i == sayi / 2)
            //    {
            //        Console.WriteLine("SMART");
            //        continue;
            //    }
            //}


            //Random rast = new Random();

            //for(int i=1;i<=10;i++)
            //{
            //    int rastsayi = rast.Next(15,20);
            //    Console.WriteLine(rastsayi);

            //}




            //Random rast = new Random();
            //int thm, sayac=1;
            //int sayi = rast.Next(1,41);
            //do
            //{
            //    do
            //    {
            //        Console.WriteLine("Tahmin :");
            //        thm = Convert.ToInt16(Console.ReadLine());
            //    } while (thm > 40 || thm < 1);
            //    if (sayi == thm)
            //        {
            //            Console.WriteLine("Tebrikler Bİldiniz");
            //            break;
            //        }
            //        else if (sayi < thm)
            //        {
            //            Console.WriteLine("Büyük sayi girdiniz");
            //        }
            //        else if (sayi > thm)
            //        {
            //            Console.WriteLine("Küçük sayi girdiniz");
            //        }
            //    Console.WriteLine(sayac);
            //        sayac++;

            //} while (sayac <=10);





            //    Random rast = new Random();
            //    int sayi1 = rast.Next(1, 100);
            //int sayac = 0;
            //do
            //{
            //Console.WriteLine("Sayi Girniz :");
            //int sayi = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine(sayi1);

            //    if (sayi == sayi1)
            //    {
            //        Console.WriteLine("Doğru Bildiniz");
            //    }
            //    else if (sayi<sayi1){
            //        Console.WriteLine($"{sayac}.deneme Başarısız.Büyük Giriniz");
            //    }
            //    else if (sayi > sayi1)
            //    {
            //        Console.WriteLine($"{sayac}.deneme Başarısız.Küçük Giriniz");
            //    }

            //    sayac++;

            //}
            //while (sayac<=15);


            //Random rastgele = new Random();
            //int sayi1, ksayi=1, bsayi=101;

            //int sayi,deneme=0;
            //do
            //{
            //    Console.WriteLine("sayı gir:");
            //     sayi = Convert.ToInt16(Console.ReadLine());

            //} while (sayi<0 || sayi>=100);
            //do
            //{
            //    deneme++;
            //    sayi1 = rastgele.Next(ksayi, bsayi);
            //    Console.WriteLine($"tahmin :{sayi1}");
            //    if (sayi1 > sayi)
            //    {
            //        Console.WriteLine($"{deneme}. deneme başarısız.");
            //        bsayi = sayi1;
            //    }
            //    else if (sayi1 < sayi)
            //    {
            //        Console.WriteLine($"{deneme}. deneme başarısız.");
            //        ksayi = sayi1;

            //    }
            //    else {
            //        Console.WriteLine($"{deneme}. denemede doğru Bildi");
            //    }
            //    if (deneme > 14)
            //        break;
            //} while (sayi!=sayi1);


            ////GOTO
            //Console.WriteLine("1. ifade" );
            //goto ifade3;
            //Console.WriteLine( "2.ifade");
            //ifade3:
            //Console.WriteLine("3.ifade");
            // TODO: Hatırlatma görevini görüyor


            int sayi1=0;
            Random rast = new Random();
            
            for (;;) 
            {
                sayi1 = rast.Next(1, 21);
                Console.WriteLine(sayi1);
               
                if(sayi1==11)
                {
                    Console.WriteLine("döngü bitti");
                    break;

                }
                
            }
          


            Console.ReadKey();
        
        }
    }
}
