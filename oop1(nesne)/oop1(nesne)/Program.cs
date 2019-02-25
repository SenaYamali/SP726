using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1_nesne_
{
    //class Dortgen
    //{
    //public int sayi; // public her yerden erişime açık demek başka class dan çağrılabilir.
    //public string metin;
    ////double kare;// erişim belirteci yoksa private olarak döner.
    ////private int cevre;  // private sadece class içerisinde çağırmak istersek kullanılır.

    //public void Merhaba()
    //{
    //    Console.WriteLine("Merhaba OOP");

    //}

    //private void Merhaba2()
    //{
    //    Console.WriteLine("Merhaba OOOOOOP");

    //}

    //public string merhaba3()
    //{
    //    return " Merhaba ooooooooooooooooops";

    //}


    // }
    //----------------------------------------------------------------------------------------------
    //class kurs
    //{
    //    public int sinif_no ;
    //    public string Ogretmen_adi ;
    //    public int Kursiyer_sayisi;

    //    private ArrayList Kursiyer_Bilgileri = new ArrayList();




    //    private void Kursiyer_Kayit()
    //    {
    //        for (int i = 0; i < Kursiyer_sayisi; i++)
    //        {
    //            Console.Write("Kursiyer Adını giriniz".PadRight(25) + ": ");
    //            string ad = Console.ReadLine();
    //            Kursiyer_Bilgileri.Add(ad);
    //        }


    //        Kursiyer_Listele();


    //    }
    //    private void Kursiyer_Listele()
    //    {
    //        foreach (var item in Kursiyer_Bilgileri)
    //        {
    //            Console.WriteLine("\nAdı ".PadRight(5) + ": " + item+"\n");
    //        }

    //    }
    //    public void Kurs_ac()
    //    {
    //        Console.Write("Sınıf Numarası Giriniz".PadRight(25) + ": ");
    //        sinif_no = Convert.ToInt32(Console.ReadLine());
    //        Console.Write("Öğretmen Adı Giriniz".PadRight(25) + ": ");
    //     Ogretmen_adi = Console.ReadLine();
    //        Console.Write("Kursiyer Sayisi".PadRight(25) + ": ");
    //       Kursiyer_sayisi= Convert.ToInt32(Console.ReadLine());

    //        Kursiyer_Kayit();
    //    }
    //} 
    //---------------------------------------------------------------------------------
    //class Araba
    //{

    //    public string Marka;
    //    public string Renk;
    //    private int ModelYili;

    //    public void ServisBilgisiYaz(string Renk)
    //    {
    //        Console.WriteLine(this.Renk); // this dersek class ait özelliğin olduğu belli olur
    //        Console.WriteLine(Renk);

    //    }

    //}

        //----------------------------------------------------------------------


    //    class Matematik
    //{
    //    public char islem;
    //    public double sayi1, sayi2;
    //    public double sonuc;
        
    //    public void İslemYap()
    //    {
            

    //        Console.WriteLine("Sayi Giriniz");
    //        sayi1 = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Sayi Giriniz");
    //        sayi2 = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine($"Yapmak İstediğiniz İşlemi Seçiniz"+"\nToplama ".PadRight(14) + ": " + "T" + " \nÇıkarma ".PadRight(15) + ": " + "C" + " \nÇarp ".PadRight(15) + ": " + "Ç" + " \nBölme ".PadRight(15) + ": " + "B" + " ");
    //        islem = Convert.ToChar(Console.ReadLine());

    //        if(islem=='T')
    //        {

    //            Topla();

    //        }
    //        else if(islem == 'C')
    //        {
               
                
    //            Cıkarma();

    //        }
    //        else if (islem == 'Ç')
    //        {

               
    //            Carp();

    //        }
    //        else if (islem == 'B')
    //        {

                
    //            Bolme();
    //        }
           
    //    }

    //    public void Topla()
    //    {
            
    //        sonuc = sayi1 + sayi2;
    //        Console.WriteLine("Toplama İşlemi : " + sonuc);

    //    }


    //    public void Cıkarma()
    //    {
    //        sonuc = sayi1 - sayi2;
    //        Console.WriteLine("Çıkarma İşlemi : "+sonuc);

    //    }
    //    public void Carp()
    //    {
    //        sonuc = sayi1 * sayi2;
    //        Console.WriteLine("Çarpma İşlemi : "+sonuc);

    //    }
    //    public void Bolme()

    //    {
    //        sonuc = sayi1 / sayi2;
    //        Console.WriteLine("Bölme İşlemi : "+sonuc);

    //    }

    //}
    //--------------------------------------------------------------------------------------------------------------------------------


        class Program
        {
            static void Main(string[] args)
            {


            //------------------------------------------------------------------------------------------------------------------------
            //Matematik mat1 = new Matematik();
            //mat1.İslemYap();
       
            //----------------------------------------------------------------------------------



            // nesne oluşturma
            /* Dortgen dortGen1 = new Dortgen();*/ // dortGen1 Dortgen sınıfından nesne olur 
                                                   //dortGen1.sayi = 7; //
                                                   //dortGen1.metin = "dortGen1 Nesnesi"; 
                                                   //Console.WriteLine($"{dortGen1.metin}{dortGen1.sayi}");

            //dortGen1.Merhaba();
            //Console.WriteLine(dortGen1.merhaba3());

            //---------------------------------------------------------------------------------------

            //    kurs kurs1 = new kurs();




            //kurs1.Kurs_ac();


            //--------------------------------------------------------------------------------------

            //Araba araba1 = new Araba();
            //araba1.Renk = "Siyah";
            //araba1.ServisBilgisiYaz("Beyaz");


            Console.ReadKey();
            }
        }
    }





        
    

