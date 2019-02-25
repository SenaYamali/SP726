using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katılım_polimorfizm
{ // Çok biçimlilik polimorfizm metotu  baskın yapıp istediğimizi çalıştırma

    // class Hayvan
    // {

    //    virtual public void SesCıkar() //sanal metotoluyor.
    //     {
    //         Console.WriteLine("Hayvan Sesleri Çeşitlidir.");
    //     }
    // }
    // class Kedi : Hayvan // hayvan sınıfının bütün özeliklerini alabilir.
    // {
    //override public void SesCıkar() // Baskın oldu override ile 
    //     {
    //         Console.WriteLine("Miyav Miyav");
    //     }
    // }
    // class Tavuk:Hayvan
    // {
    //     override public void SesCıkar() // new koymamız gerek bilinçli yaptığımızı belirtmek için
    //     {
    //         Console.WriteLine("Gıt Gıt Gıdaaak");
    //     }
    // }
    //-------------------------------------------------------------------------

        enum EnerjiSiniflari : byte {A,B,C,D,E}
    enum FirinTipleri : byte {MiniFırın,NormalFirin }
        
    class BeyazEsya
    {
        public EnerjiSiniflari Enerjisiniflari;
        public string Marka;
        public int Fiyat;
        public string GarantiSuresi;
        public BeyazEsya(EnerjiSiniflari enerjisinifi,string marka,int fiyat,string garantisuresi)
        {
            Enerjisiniflari = enerjisinifi; Marka = marka;Fiyat = fiyat;GarantiSuresi = garantisuresi;

        }
        virtual public void IndirimliFiyatHesapla()
        {
            Console.WriteLine($"İndirim Yok !  Fiyat Bilgisi {Fiyat}");

        }
    }
    class BulasikMakinesi : BeyazEsya
    {
        public int ProgramSayisi;
        public string Model;
        public double IndirimOrani;

        public BulasikMakinesi(int programsayisi, string model, double indirimorani, EnerjiSiniflari enerjisinifi, string marka, int fiyat, string garantisuresi) : base(enerjisinifi, marka, fiyat, garantisuresi)
        {
            this.ProgramSayisi = programsayisi;
            this.Model = model;
            this.IndirimOrani = indirimorani;
        }

        public override void IndirimliFiyatHesapla()
        {
            Console.WriteLine($"İndirimli Fiyat : {(Fiyat - (Fiyat * (IndirimOrani / 100)))}");

        }
    }
    class Firin : BeyazEsya
    {
        public FirinTipleri FirinTip;
        public double IndirimOrani;
        public Firin(double indirimorani,FirinTipleri firintip,EnerjiSiniflari enerjisinifi, string marka, int fiyat, string garantisuresi) : base(enerjisinifi, marka, fiyat, garantisuresi)
        {
            this.FirinTip = firintip;
            this.IndirimOrani = indirimorani;
        }
        public override void IndirimliFiyatHesapla()
        {
            Console.WriteLine($"Fırın İndirimli Fiyat : {(Fiyat - (Fiyat * (IndirimOrani / 100)))}");

        }
    }
    class MiniFirin : Firin

    {
        public double IndirimOrani;
        public MiniFirin(double indirimorani, FirinTipleri firintip, EnerjiSiniflari enerjisinifi, string marka, int fiyat, string garantisuresi) : base(indirimorani, firintip, enerjisinifi, marka, fiyat, garantisuresi)
        {
            this.IndirimOrani = indirimorani;
        }

        public override void IndirimliFiyatHesapla()
        {
            Console.WriteLine($"Fırın İndirimli Fiyat : {(Fiyat - (Fiyat * (IndirimOrani / 100)))}");

        }
    }

    class Program
    {
        //static void SesCikar(Hayvan hyn)
        //{
        //    hyn.SesCıkar();

        //}
        //-------------------------------------------
        static void IndirimliFiyatHesapla(BeyazEsya byz)
        {
            byz.IndirimliFiyatHesapla();

        }

        static void Main(string[] args)
        {

            BulasikMakinesi blsk = new BulasikMakinesi(3,"Plus",30.0,EnerjiSiniflari.B,"Beko",1000,"2 Yıl");

            IndirimliFiyatHesapla(blsk);
            Firin frn = new Firin(20, FirinTipleri.MiniFırın, EnerjiSiniflari.E, "MiniFırın", 1500, "2 Yıl");
            IndirimliFiyatHesapla(frn);
            MiniFirin mnfrn = new MiniFirin(15,FirinTipleri.MiniFırın,EnerjiSiniflari.C,"Arçelik",2000,"3 yil");
            IndirimliFiyatHesapla(mnfrn);

            //-----------------------------------------------------------------------------

            //Hayvan hayvan1 = new Hayvan();
            //Kedi kedi1 = new Kedi();
            //Tavuk tavuk1 = new Tavuk();

            ////hayvan1.SesCıkar();
            ////kedi1.SesCıkar();
            ////tavuk1.SesCıkar();


            //SesCikar(hayvan1);
            //SesCikar(kedi1);
            //SesCikar(tavuk1);

            Console.ReadKey();
        }
    }
}
