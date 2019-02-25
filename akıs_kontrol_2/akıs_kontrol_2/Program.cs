using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akıs_kontrol_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayi = 3;
            //switch(sayi)
            //{
            //    case 1:
            //    Console.WriteLine("sayı 1");
            //    break;

            //    case 2:
            //        Console.WriteLine("sayı 2");
            //    break;

            //    case 3:
            //        Console.WriteLine("sayı 3");
            //        break;

            //    default:
            //            Console.WriteLine("sayı 1, 2, 3 değildir");
            //        break;
            //    }

            //string str = "Kadıköy";
            //switch (str)
            //{
            //    case "Sarıyer":
            //        Console.WriteLine("istanbulun en güzel ilçesi saryerdir");
            //        break;
            //    case "karTal":
            //        Console.WriteLine("istanbulun en güzel ilçesi KARTAL");
            //        break;
            //        case "Kadıköy":
            //        Console.WriteLine("istanbulun en güzel ilçesi kadıköydür");
            //        break;
            //        default:
            //        Console.WriteLine("İlçe olmasa da en güzeli dolapderedir");
            //        break;

            //Console.WriteLine("Sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sayi giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Toplama için :T\nÇıkarma için :Ç\nBölme için :B\nÇarpma için :C");
            //string islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "T":
            //        Console.WriteLine($"Toplama işlemi : {sayi1+sayi2}");
            //        break;
            //    case "Ç":
            //        Console.WriteLine($"Çıkarma işlemi : {sayi1 - sayi2}");
            //        break;

            //    case "C":
            //        Console.WriteLine($"Çarpma işlemi : {sayi1 * sayi2}");
            //        break;
            //    case "B":
            //        switch (sayi2)
            //        {
            //            case 0:
            //                 Console.WriteLine($"Sıfır ile bölme işlmeni olmaz");
            //                break;
            //            default:
            //                Console.WriteLine($"Bölme  işlemi : {sayi1 / sayi2}");
            //                break;
            //        }

            //        break;

            //}

            //Console.WriteLine("Sayı giriniz:");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int islem;
            //if (sayi1 > 99)
            //{
            //    islem = sayi1 % 3;

            //    switch (islem)
            //    {
            //        case 1:
            //            Console.WriteLine($"3 ile bölümünden kalan {islem}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"3 ile bölümünden kalan {islem}");
            //            break;
            //        case 0:
            //            Console.WriteLine($"3 ile bölümünden kalan {islem}");
            //            break;
            //    }


            //}else if (sayi1 < 100)
            //{
            //    islem = sayi1 % 4;
            //    switch (islem)

            //    {

            //        case 1:
            //            Console.WriteLine($"4 ile bölümünden kalan {islem}");
            //            break;
            //        case 2:
            //            Console.WriteLine($"4 ile bölümünden kalan {islem}");
            //            break;
            //        case 3:
            //            Console.WriteLine($"4 ile bölümünden kalan {islem}");
            //            break;
            //        case 0:
            //            Console.WriteLine($"4 ile bölümünden kalan {islem}");
            //            break;

            //    }   
            //}


            //Console.WriteLine("Sayi giriniz :");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int d;
            //for (d = 0; d <= sayi1; d++) 
            //{
            //    int kalan = d % 2;
            //    if (kalan == 0)
            //    {
            //        Console.WriteLine($"{d} çiftir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{d} tektir.");
            //    }
            //}



            //Console.WriteLine("Sayi giriniz :");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //int d;
            //for (d = 0; d <= sayi1; d+=2)
            //{
            //    Console.WriteLine($"{d} çiftir.");
            //}




            // Console.WriteLine(" Ad Giriniz :");
            // string ad = Convert.ToString(Console.ReadLine());
            // Console.WriteLine(" Yaş Giriniz :");
            //int yas = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= yas; i++)
            // {
            //     Console.WriteLine($"İyi ki Doğdun {ad}--> {i}");

            // }



            //Console.WriteLine("İşçi sayısı giriniz :");
            //int isci = Convert.ToInt32(Console.ReadLine());
            //int cocuk;
            //for (int i = 1; i <= isci; i++)
            //{
            //    Console.WriteLine("Çocuk sayısı giriniz :");
            //     cocuk = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"{i}. işçinin {cocuk} çocuğu var");

            //int maas=3000;
            //   if (cocuk < 0)
            //    {
            //        Console.WriteLine($"Negatif girdiniz:{maas}");
            //    }
            //   else if (cocuk <= 2)
            //    {
            //        Console.WriteLine($"işcinin maaşı :{maas = maas + (cocuk * 100)}");
            //    }
            //    else if (cocuk > 2)
            //    {
            //        Console.WriteLine($"işcinin maaşı :{maas = maas + (cocuk * 75)}");
            //    }
            //    else if (cocuk == 0)
            //    {
            //        Console.WriteLine($"işcinin maaşı :{maas}");
            //    }

            //}
            //    Console.WriteLine("sayı giriniz :");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int basamak = 1;


            //    Console.WriteLine($"1 ler Basamağı : {sayi%10}");
            //    for (;sayi>10;)
            //    {

            //        sayi = sayi / 10;
            //        int rakam = sayi % 10;
            //        basamak *= 10;
            //        Console.WriteLine(basamak + " lar basamağı" + rakam);
            //}


            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("For Döngüsü");
            //}


            //for (int i = 100; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"Çift sayılar:{i}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"tek sayılar:{i}");
            //    }

            //}




            //int toplam = 0;
            //for (int i =1;i <= 100; i++)
            //{
            //    toplam = toplam+i * i;
            //    Console.WriteLine($"{i} karesi :  {i*i}");


            //}

            //Console.WriteLine($"toplamının karesi: {toplam}");



            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int k = 1; k <=10-i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine(" ");
            //}
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int km = 10; km >= 1+i ; km--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" *" );
            //    }
            //    Console.WriteLine(" ");
            //}



            //int calısan = 2;
            //int cocuk, tc, toplam=0;
            //for (int i = 1; i <= calısan; i++)
            //   {
            //    Console.WriteLine( $"{i}. çalışanın Çocuk sayısı giriniz");
            //    cocuk = Convert.ToInt32(Console.ReadLine());
            //    toplam =toplam + cocuk;
            //    for (int j = 1; j <= cocuk; j++)
            //    {
            //        Console.WriteLine($"{j}. cocğunTc kimlik numarası giriniz.");
            //         tc = Convert.ToInt32(Console.ReadLine());
            //    }


            //}


            //Console.WriteLine($"Toplam Çocuk sayısı{toplam}");



            //for (int i = 1; i <= 45; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i%3==0)

            //        {
            //            Console.Write("#");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }  Console.WriteLine("");
            //}


            //for (int i = 1; i <= 20; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % 9 == 0)

            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //    Console.WriteLine("");
            //}
            
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <=10 ; j++)
            //    {
            //        Console.WriteLine($"{i} X {j} = {i*j}");
            //    }
            //    Console.WriteLine("\n ******\n ");
            //}

          


            Console.ReadKey();
        }
    }


}