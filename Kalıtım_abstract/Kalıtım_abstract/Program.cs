using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım_abstract
{
    //abstract class Birey // abstract tanımlanırken class da abstract tanımlanır.
    //    // abstract dediğimin zaman aslında virtiul demiş gibi olur ama metot tanımlanmaz ve get setle kullanılır.
    //    // ön tanımlama yapar kednisinden nesne tanımlama yapamaz .
    //{
    //    abstract public string Ad { get; set; }
    //    abstract public void AdYaz();
    //    public int Yas;

    //}

    //class Calisan : Birey
    //{
    //    private string AD;
    //    public override string Ad
    //    {
    //        get
    //        {
    //            return AD;
    //        }

    //        set
    //        {
    //            AD = value;
    //        }
    //    }

    //    public override void AdYaz()
    //    {
    //        Console.WriteLine("Birey Adı : "+AD);
    //        Console.WriteLine("Birey Yas : "+Yas);
    //    }
    //}

    //-------------------------------------------------------------------------

    abstract class Kus
    {
        abstract public string Renk { get; set; }
        abstract public int Kanat_Uzunlugu { get; set; }
        abstract public string  Cins { get; set; }
        public string KusTurAdi = "Tavuk";
        abstract public void SeyahatHesapla(int hi, int mesafe);
    }
        class Karga : Kus
        {
        public new string KusTurAdi = "Karga";
        private string cins;
            public override string Cins
            {
                
                get
                {
                    return cins;
                }

                set
                {
                    cins = value;
                }
            }
            private int kanat_uzunlugu;
            public override int Kanat_Uzunlugu
            {
                get
                {
                    return kanat_uzunlugu;
                }

                set
                {
                    kanat_uzunlugu = value;
                }
            }
            private string renk;
            public override string Renk
            {
                get
                {
                    return renk;
                }

                set
                {
                    renk = value;
                }
            }

        public override void SeyahatHesapla(int hiz, int mesafe)
            {
                Console.WriteLine("Karganın Rengi : "+Renk);
                Console.WriteLine("Karganın Kanat Uzunluğu : "+Kanat_Uzunlugu);
                Console.WriteLine("Karganın Cinsi : "+Cins);
            int toplam = mesafe / hiz;
            Console.WriteLine($"{Renk} {KusTurAdi} {mesafe} km mesafeyi {toplam} saatte yol alır.");
            }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Karga krg = new Karga();
            krg.Renk = "Mor ";
            krg.Kanat_Uzunlugu = 5 ;
            krg.Cins = "Sivas Kargası ";

            krg.SeyahatHesapla(5,10);
            //---------------------------------------------------------------
            //Calisan cls1 = new Calisan();
            //cls1.Ad = "Sena";
            //cls1.Yas = 70;
            //// cls1.AdYaz();
            ////Birey br1 = new Birey();// bu şekilde tanımlama yapılmıyor.
            //Birey br2 = cls1;



            Console.ReadLine();


        }
    }
}
