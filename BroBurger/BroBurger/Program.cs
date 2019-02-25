using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroBurger
{
    interface ISahip
    {
        string Sahibi { get; set; }
        int VergiNumarasi { get; set; }
        void SahipKaydet(string dosyaYolu);
}
    interface IDukkanBilgiler
    {
        string Adi { get; set; }
        string ID { get; set; }
        string Ulke { get; set; }
        string Sehir { get; set; }
        string Ilce { get; set; }
        void DukkanKaydet(string dosyaYolu);
 }
    class BroBurger : ISahip, IDukkanBilgiler
    {
        string BSahibi;
        int BVergiNo;
        string BAdi;
        string BId;
        string BIlce;
        string BSehir;
        string BUlke;
        public string Sahibi { get { return BSahibi; } set { BSahibi = value; } }
        public int VergiNumarasi{ get { return BVergiNo; } set { BVergiNo = value; } }
        public string Adi{get{return BAdi; } set{BAdi = value;}}
        public string ID{get{return BId;}set{BId = value;}}
        public string Ilce{get{return BIlce; ;}set{BIlce = value;}}
        public string Sehir{get{return BSehir;}set{BSehir = value; }}
        public string Ulke{ get{return BUlke;}set{ BUlke = value; }}

        public void DukkanKaydet(string dosyaYolu)
        {
            FileStream flls = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter smr = new StreamWriter(flls, Encoding.Default);
            smr.WriteLine($"Adı : {Adi} ID : {ID} Ulke : {Ulke} Sehir : {Sehir} İlçe : {Ilce}");
            smr.Flush();
            smr.Close();
            flls.Close();

        }

        public void SahipKaydet(string dosyaYolu)
        {
            FileStream flls = new FileStream(dosyaYolu, FileMode.Append, FileAccess.Write);
            StreamWriter smr = new StreamWriter(flls, Encoding.Default);
            smr.Write($"Sahibi : {Sahibi} Vergi Numarası : {VergiNumarasi}");
            smr.Flush();
            smr.Close();
            flls.Close();
        }
        public static void BilgiYaz(string dosyaYolu)
        {
            FileStream flls = new FileStream(dosyaYolu, FileMode.Open, FileAccess.Read);
            StreamReader smr = new StreamReader(flls, Encoding.Default);
            string satir;
            while ((satir = smr.ReadLine()) != null)
            {
                Console.WriteLine(satir);
            }
           
            
            smr.Close();
            flls.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string dosyaYolu = "C:\\SahipDukkan\\Dosya.txt";
            BroBurger bbrgr = new BroBurger();
            bbrgr.Sahibi = "Sena";
            bbrgr.VergiNumarasi = 145248552;
            bbrgr.ID = "G245H895";
            bbrgr.Adi = "Sena Aş.";
            bbrgr.Ulke = "Türkiye";
            bbrgr.Sehir = "İstanbul";
            bbrgr.Ilce = "Avcılar";
            bbrgr.SahipKaydet(dosyaYolu);
            bbrgr.DukkanKaydet(dosyaYolu);
         BroBurger.BilgiYaz(dosyaYolu);

            Console.ReadKey();
        }
    }
}
