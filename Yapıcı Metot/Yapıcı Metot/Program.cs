using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapıcı_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Sirket sirket1 = new Sirket();
            Sirket sirket2 = new Sirket("Sena Şirketi", "Avcılar/İSTANBUL", "00015", "Şahıs");
            Console.WriteLine(sirket1.SirketAdi);
            Console.WriteLine(sirket2.SirketAdi);
            Console.WriteLine(sirket2.VergiDairesi);
            Console.WriteLine(sirket2.VergiNumarası);
            Console.WriteLine(sirket1.SirketTurleri[sirket1.SirketTuru]);



            Console.ReadKey();
        }
    }

    class Sirket
    {
        public string SirketAdi;
        public string VergiDairesi;
        public string VergiNumarası;
        public byte SirketTuru;
         public ArrayList SirketTurleri = new ArrayList() { "Anonim", "Limited", "Şahıs" };
        public Sirket()
        {
            SirketAdi = "Bilgi Eksik";
            VergiDairesi = "Bilgi Eksik";
            VergiNumarası = "Bilgi Eksik";
            SirketTuru = 2;
        }
   
        public Sirket (string sirketAdi,string vergidairesi,string verginumarası,string sirketturu)
        {

            SirketAdi = sirketAdi;
            VergiDairesi = vergidairesi;
            VergiNumarası = verginumarası;
            SirketTuru = (byte)SirketTurleri.IndexOf(sirketturu);
        }

       
    }


}
