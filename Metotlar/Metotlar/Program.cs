using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program

    {
        static void merhabaYaz(string sena)  // metot oluşturuldu
        {

            Console.Write("MERHABA "+sena);
        }
        //static int carpma(int a,int b)  // parametreli metot
        //{
        //    return a * b;
        //}
        static int carpmat(int x )  
        {
            return (x + 2) * (x + 2) - 12;
        }

        static int islem(int a, int b, char c)
        {
            if (c == 'Ç')
            {
                return a * b;
            }
            else if (c == 'B')
            {
                return a / b;

            }

            else if (c == 'T')
            {
                return a + b;
            }
            else if(c== 'R')
            {
                return a - b;
            }
            else
            {
                return 0;

            }


        }
        static void opsiyononelMetot(string musteriAdi, string otel = "Dedeman", int odaNumarasi = 105)
        {



            Console.WriteLine("Müşteri Adı : " +musteriAdi+" \n"+ "Otel :" +otel+" \n" +"Oda :" +odaNumarasi+" \n\n");
        }

        static void NamedMetot(string ad, int yas, string kanGrubu)
        {

            Console.WriteLine($"Ad: {ad} Yas:{yas} Kan Greubu {kanGrubu}");
        }

        static int faktoriyel(int sayi)
        {

            if (sayi == 0)
                return 1;
            return sayi * faktoriyel(sayi - 1);
                
        }
        static int fib(int sayi3)
        {

            if (sayi3 == 0 )
                return 0;
            else if (sayi3 == 1)
                return 1;
           
         
            return fib(sayi3 - 1) + fib(sayi3 - 2);

            Console.WriteLine(sayi3);
        }

        static void Main(string[] args)
        {
            // //Console.Write("HEY ");
            // //merhabaYaz(); // metot çağırıldı
            // //Console.Write(" DÜNYA ");
            // //merhabaYaz();

            //int sonuc= carpma(5, 7);
            // Console.WriteLine(sonuc);
            //// Console.WriteLine(carpma(7,9));


            //------------------------------------------------------------------------------

            //Console.WriteLine("İsim Giriniz ");
            //string ad = Convert.ToString(Console.ReadLine());
            //merhabaYaz(ad);


            //------------------------------------------------------------------------------

            //Console.WriteLine("Sayı gir :");
            //int sayi = Convert.ToUInt16(Console.ReadLine());

            //int sonuc = carpmat(sayi);
            //Console.WriteLine(sonuc);

            //------------------------------------------------------------

            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine("Sayı giriniz");
            //int sayi2 = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine("İşlem seçiniz\nÇarpma için  : Ç\nBölme için   : B\nToplama için : T\nÇıkarma için : R");
            //char c = Convert.ToChar(Console.ReadLine());


            //Console.WriteLine(islem(sayi,sayi2,c));


            /*
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * */



            //------------------------------------ Opsiyonel Parametreli Metodlar-------------


            //opsiyononelMetot("Sena Yamalı");
            //opsiyononelMetot("Sena Yamalı", "Çiçek Oteli", 54);




            //------------------------------parametrenin adıyla sırasız göndeliriliyorr sıralı çıkıyor------


            //NamedMetot(ad: "Sena", yas: 18, kanGrubu: "BRH-");
            //NamedMetot(ad: "Sena", kanGrubu: "BRH-", yas: 18);


            //----------------------------öz yinelemeli -----------

            // Console.WriteLine(faktoriyel(3));

        //    Console.WriteLine("Sayi Giriniz");
        //int  sayi3 = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i <=sayi3; i++)
        //    {
        //        Console.WriteLine($"{i}   {fib(i)}");
        //    }

         

            Console.ReadKey();

        }
    }



}
