using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*        int i = 5 + 3;*/ //3ve 5 operand,+ ve = operatör
                                       // ////Aritmetiksel operatörler
                                       // //// +,-,*,/

            // int sayi1, sayi2, sayi3, sayi4;

            //int sayi =10;
            //sayi += 20;    // sayi =sayi+20
            //sayi -= 10;   //sayi =sayi-10
            //sayi *= 5;   // sayi= sayi*5
            //sayi /= 10; // sayi= sayi/10


            // sayi1 = 25 + 75;
            // sayi2 = 75 - 25;
            // sayi3 = 75 / 25;
            // sayi4 = 75 * 25;
            // Console.WriteLine(sayi1);
            // Console.WriteLine(sayi2);
            // Console.WriteLine(sayi3);
            // Console.WriteLine(sayi4);

            //double sayi5 = 10 * 4 - 10 / 3 + 15;
            // int sayi6 = 10 * 4 / 2 * 8;
            // int sayi7 = 10 * 4 /( 2*8);
            // Console.WriteLine(sayi5);
            // Console.WriteLine(sayi6);
            // Console.WriteLine(sayi7);
            // Console.ReadKey();

            //% mod alma ,++ ,--
            //int mod = 10 % 3;
            //Console.WriteLine(mod);
            //Console.ReadKey();


            //float sSayy,=45,5F;
            //sSayy++;
            //Console.WriteLine(sSayy);
            //++sSayy;


            //double = dsayi = 25.00;
            //dsayi--;
            //--dsayi;
            //Console.WriteLine(dsayi);


            //int sayi3 = 100;
            //int sayi4 = ++sayi3;
            //int sayi5 = sayi3++;
            //int sayi6 = sayi5++;
            //int sayi7 = --sayi3;
            //int sayi8 = sayi3--;



            // Console.WriteLine(sayi3,sayi4,sayi5,sayi6,sayi7);

            //Console.ReadKey();


            // Karşılaştırma operatörleri
            // < ,><,=<,=>,==,!=


            //bool kDeg1 = 34 > 24;  //True
            //bool kDeg2 = 34 < 24; //False
            //bool kDeg3 = 74.7F > 74.6F;
            //Console.WriteLine($"{kDeg1} {kDeg2} {kDeg3}");
            //bool kDeg4 =25 >= 45;
            //int sayi1 = 10;
            //int sayi2 = 20;
            //bool sayiKarsilastırm = sayi1 <= sayi2;
            //bool sayiKarsilastırm1 = sayi1 >= sayi2;
            //Console.WriteLine(sayiKarsilastırm);
            //Console.WriteLine(sayiKarsilastırm1);
            //Console.ReadKey();

            //bool bDeg5 = 5 == 6;

            //int i = 6;
            //int k = 58;
            //bool b = i == k;
            //bool b2= i != k;
            //Console.WriteLine(b);
            //Console.WriteLine(b2);
            //Console.ReadKey();


            // As ve is operatörleri


            //int test = 55;
            //bool bTest = test is double;   //test değişkeni double mı diye sorduk hayır dedi tipini sormak için 
            //bool bTest2 = test is int;
            //bool bTest3 = test is object;
            //Console.WriteLine(bTest);
            //Console.WriteLine(bTest2);
            //Console.WriteLine(bTest3);
            //Console.ReadKey();
            //string text = "Merhaba";
            //bool sText = text is object;
            //Console.WriteLine(sText);
            //object obje = (object)text;
            //string text2 = (string)text;
            //Console.WriteLine(text2);
            //Console.ReadKey();

            //object deg = "758";    // Kısıtlı tür dönüşümü yapar as null değeri alabilen tipler arasında kullanılır.String ve object
            //string str = deg as String;
            //Console.WriteLine(str);
            //Console.ReadKey();


            //Mantıksal Operatörler
            //   && ve      || veya 


            //bool deg1 = (8 < 9) && (5 == 5);  // İki şartında doğru olması gere3k true gelebilmesi için
            //bool deg2 = (8 > 9) && (5 == 5);
            //bool deg3 = (8 > 9) && (5 != 5);
            //bool deg4 =(8<9) &&( 5!=5);
            //Console.WriteLine($"{deg1} {deg2} {deg3} {deg4}");
            //Console.ReadKey();



            //bool deg1 = (8 < 9) ||  (5 == 5);  // En az bir şartın doğru olması gerek
            //bool deg2 = (8 > 9) || (5 == 5);
            //bool deg3 = (8 > 9) || (5 != 5);
            //bool deg4 = (8 < 9) || (5 != 5);
            //Console.WriteLine($"{deg1} {deg2} {deg3} {deg4}");
            //Console.ReadKey();

            //bool deg1 = (8 < 9) || (5 == 5);  
            //bool deg2 = (8 > 9) || (5 == 5);
            //bool deg3 = (8 > 9) || (5 != 5);
            //bool deg4 = (8 < 9) || (5 != 5);

            //bool deg5 = !((8 < 9) || (5 == 5));
            //bool deg6 = !((8 > 9) || (5 == 5)); // Tersleme işlemi yapıyor true sa false , false true ya çeviriyor
            //bool deg7 = !((8 > 9) || (5 != 5));
            //bool deg8 = !((8 < 9) || (5 != 5));
            //Console.WriteLine($"{deg1} {deg2} {deg3} {deg4}");
            //Console.WriteLine($"{deg5} {deg6} {deg7} {deg8}");
            //Console.ReadKey();


            //  & (BİTSEL VE) OPERATÖRÜ

            //byte a = 5;     // 0000 0101
            //byte b = 10;    // 0000 1010
            //int c = a & b;  // 0000 0000   iki işleminde eşit olması lazım bit bazında işlem yaoar


            //// |  (BİTSEL VEYA) OPERATÖRÜ


            //int d = a | b;  
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.ReadKey();


            //// ^ (BİTSEL ÖZEL VEYA) OPERATÖRÜ

            //byte a = 21;     // 0001 0101
            //byte b = 26;     // 0001 1010             // değerler aynıysa 0 farklı ise 1 getirir.
            //int c = a ^ b;  // 0000 1111

            //Console.WriteLine(c);
            //Console.ReadKey();


            //// >>  (BİTSEL SAĞA KAYDIRMA) OPERATÖRÜ

            //byte sayi  = 128;                // 1000 0000
            //byte sayi2 = (byte)(sayi >> 1);  // 0100 0000
            //Console.WriteLine(sayi2);
            //Console.ReadKey();

            ////sayı değişkenini bir bit sağa kaydır diyor.Silinen her bitin yerine 0 koycak.
            //// 2 üzeri sağ kaydıralan bite bölünür.



            // <<  (BİTSEL SOLA KAYDIRMA) OPERATÖRÜ
            
            //byte sayi = 8;                 // 0000 1000
            //byte sayi2 = (byte)(sayi << 1);  // 0001 0000
            //Console.WriteLine(sayi2);
            //Console.ReadKey();

            ////sayı değişkenini bir bit sola kaydır diyor.Silinen her bitin yerine 0 koycak.
            //// 2 üzeri sola kaydıralan bite bölünür.
            

      





















        }



    }
}
