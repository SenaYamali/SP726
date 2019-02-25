using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru
{
    enum Bolumler : byte {Muhasebe,Yazılım_Birimi,IT_Birimi,IK,Satın_Alma,Hukuk,Satış }
    class Personel
    { public Bolumler BolumLER;
        public string AdSoyad;
        public int Yas;
        public Personel(Bolumler bolumler, string adsoyad, int yas)
        {
            BolumLER = bolumler;AdSoyad = adsoyad; Yas = yas;
        }
    }
    class Yonetici : Personel
    {
        public int AltPersonelSayisi;

            public Yonetici(Bolumler bolumler, string adsoyad, int yas) : base(bolumler, adsoyad, yas)
            {
            this.AdSoyad = adsoyad;
           
            this.Yas = yas;
            }
        }
    class Program
    {
        public static string SenaYamali { get; private set; }

        static void Main(string[] args)
        {
            Personel prsl = new Personel(Bolumler.Yazılım_Birimi,"SenaYamali",22);
            Console.ReadKey();
        }
    }
}
