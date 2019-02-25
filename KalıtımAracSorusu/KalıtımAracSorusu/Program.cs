using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimAracSorusu
{
   //Sabit Veri Tipleri

    enum Markalar : byte { Honda=1, Mazda, Ford, Mercedes, Renault, Toyota, Tofaş, Lamborghini, Ferrari, Scania, Volvo }
    enum Vitesler : byte { Manuel=1, Otomatik, Yarı_Otomatik }
    enum Renkler : byte { Kırmızı=1, Beyaz, Siyah, Turuncu, Yeşil, Mavi, Mor }
    class Arac
    {
        public Markalar Marka;  // enumdan Değişken Tanımlama
        public Vitesler Vites;
        public Renkler Renk;
        protected short MotorHacmi;
        public Arac(Markalar marka, Vitesler vites, Renkler renk, short motorHacmi)
        {
            Marka=marka;Vites=vites;Renk=renk;MotorHacmi=motorHacmi;
        }
    }
    class Otomobil : Arac
    {
        public byte KapiSayisi;
        public string Model;
        public bool Ceker4;
        public bool ParkSensoru;

        public Otomobil(byte kapisayisi,string model,bool ceker4,bool parksensoru,Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.KapiSayisi = kapisayisi;
            this.Model = model;
            this.Ceker4 = ceker4;
            this.ParkSensoru = parksensoru;

        }


        public void OtomobilBilgiYaz()
        {
            string sCeker4;
            if (Ceker4 == true)
            {sCeker4 = "Arac 4 Çeker";}
            else
            {sCeker4 = "Araç 2 çeker";}
      
            string sParkSensoru;
            if (ParkSensoru == true)
            {sParkSensoru = "Park Sensörü Var. ";}
            else
            {sParkSensoru = "Park Sensörü Yok. ";}
            Console.WriteLine($"Arac Markası : {Marka}\nModel : {Model} ");
            Console.WriteLine($"Araç Vites Tipi : {Vites}\nRenk : {Renk} " );
            Console.WriteLine($"Araç Motor Hacmi : {MotorHacmi}\nKapı Sayısı : {KapiSayisi}" );
            Console.WriteLine(sCeker4);
            Console.WriteLine($"ParkSensoru : {sParkSensoru}");
            
        }
    }
    class Ticari : Arac
    {
        public int TasimaKapasitesi;
        public bool Ceker4;
        public int YolcuKapasitesi;

        public Ticari(int tasimakapasitesi,bool ceker4,int yolcukapasitesi, Markalar marka, Vitesler vites, Renkler renk, short motorHacmi) : base(marka, vites, renk, motorHacmi)
        {
            this.TasimaKapasitesi = tasimakapasitesi;
            this.Ceker4 = ceker4;
            this.YolcuKapasitesi = yolcukapasitesi;
        }

        public void TicariBilgiYaz()
        {
            string sCeker4;
            if (Ceker4 == true)
            { sCeker4 = "Arac 4 Çeker"; }
            else
            { sCeker4 = "Araç 2 çeker"; }

          
            Console.WriteLine($"Arac Markası : {Marka}\nRenk : {Renk} ");
            Console.WriteLine($"Araç Vites Tipi : {Vites}\nYolcu Kapasitesi : {YolcuKapasitesi}");
            Console.WriteLine($"Araç Motor Hacmi : {MotorHacmi}\nTaşıma Kapasitesi : {TasimaKapasitesi}");
            Console.WriteLine(sCeker4);
 

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil(2,"Practica",false,false,Markalar.Mazda,Vitesler.Otomatik,Renkler.Yeşil,1500);
            oto.OtomobilBilgiYaz();
            Console.WriteLine("____¯¯¯___--------___¯¯¯¯¯_____------------____¯¯¯¯¯¯¯______----------");
            Ticari tcr = new Ticari(5000,true,4,Markalar.Volvo,Vitesler.Yarı_Otomatik,Renkler.Mor,1500);
            tcr.TicariBilgiYaz();

            Console.ReadKey();
        }
    }
}
