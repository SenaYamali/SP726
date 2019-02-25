using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akıs_kontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // ifade (a+b)  deyim:  Console.WritLine(a+b);
            //int cs = 3;
            //if (cs == 0)
            //Console.WriteLine("Çocuk sayısı : 0");
            //else
            //Console.WriteLine("Çoçuk sayısı : 0 değil");
            //Console.ReadKey();


            //Console.WriteLine("1. sayıyı giriniz :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. sayıyı sayı giriniz :");
            //int b = Convert.ToInt32(Console.ReadLine());
            //if (a > b)
            //{
            //    Console.WriteLine($"1. sayı büyüktür : {a}");
            //}
            //else if (a < b)
            //{

            //    Console.WriteLine($"2. sayı büyüktür : {b}");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine($"\nİki sayıda eşittir : 1. sayı:{a}\n2.sayı :{b}");
            //}

            //Console.ReadKey();





            //Console.WriteLine("1. sayıyı giriniz :");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. sayıyı sayı giriniz :");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3. sayıyı sayı giriniz :");
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a == b ||  b == a || b == c || c == a )
            //{
            //    Console.WriteLine($"Sayılarda Bir eşitlik mevcut :\n1. sayı:{a}\n2.sayı :{b}\n3.sayı :{c}");
            //}

            //else if (a > b && a > c)
            //{
            //    Console.WriteLine($"1. sayı büyüktür : {a}");
            //}

            //else if (b > c && b > a)
            //{

            //    Console.WriteLine($". sayı büyüktür : {b}");
            //}
            //else if (c > b && c > a)
            //{

            //    Console.WriteLine($"3. sayı büyüktür : {c}");
            //}




            //Console.ReadKey();




            //Console.WriteLine("Vize Notunu Girniz :");
            //int v = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Final Notunu Girniz :");
            //int f = Convert.ToInt32(Console.ReadLine());
            //double toplam =0;
            //if (f >= 55) {
            //     toplam=(f*0.6)+(v*0.4);
            //    if (toplam >= 50 && toplam <= 59) 
            //    {
            //        Console.WriteLine( "Harf Notu  :E" );

            //    }
            //     else if (toplam >= 60 && toplam <= 69)
            //    {
            //        Console.WriteLine("Harf Notu :D");

            //    }
            //    else if (toplam >= 70 && toplam <= 79)
            //    {
            //        Console.WriteLine("Harf Notu :C");

            //    }
            //    else if (toplam >= 80 && toplam <= 89)
            //    {
            //        Console.WriteLine("Harf Notu :B");

            //    }
            //    else if (toplam >= 90 && toplam <= 100)
            //    {
            //        Console.WriteLine("Harf Notu :A");

            //    }
            //    else if(toplam<50)
            //    {
            //        Console.WriteLine("Ortalamadan Kaldı");
            //    }




            //}
            //else 
            //    {

            //    Console.WriteLine("Finalden Kaldı:");
            //}


            //Console.ReadKey();



            Console.WriteLine("Sayı Girniz :");
            float v = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Sayı Girniz :");
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Toplama için :T\nÇıkarma için :Ç\nBölme için :B\nÇarpma için :C");
            string islem = Console.ReadLine();

            float sonuc = v * f;
            if (islem == "T"||islem=="t")
               
            {
                Console.WriteLine($"Toplam:{v + f}");
            }
            else if (islem == "Ç"|| islem=="ç")
            {
                Console.WriteLine($"Çıkarma:{v-f}");
            }
            else if (islem == "B"|| islem=="b")
            {
                if (f == 0)
                {
                    Console.WriteLine($"{f} sayısı 0 ile 'bölmede bölen 0 olamaz'");

                }
                else {
                    Console.WriteLine($"Bölme:{v / f}");
                }
                
            }
            else if (islem == "C"|| islem=="c")
            {
                Console.WriteLine($"{v} ve {f} sayılarının Çarpımı :{sonuc}");
            }

            Console.ReadLine();

        }
    }
}
