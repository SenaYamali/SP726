using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------yıkıcı metot--------------------------------------------
            //OOp3 object1 = new OOp3();
            //object1.Merhaba();

            //-------- statik konusu---------------------------------------
            //ArrayList aList = new ArrayList();
            //StatikKonusu s1 = new StatikKonusu();
            //s1.Ad = "SmartPro Akademi";
            //aList.Add(s1.Ad);
            //s1.Unvan = "Bilişim Kursu";
            //aList.Add(s1.Unvan);
            //StatikKonusu.NesneSayisi++;

            //StatikKonusu s2 = new StatikKonusu();
            //s2.Ad = "Selim Pehlivan";
            //aList.Add(s2.Ad);

            //s2.Unvan = "Aşçı";
            //aList.Add(s2.Unvan);
            //StatikKonusu.NesneSayisi++;


            //StatikKonusu.TumunuListele(aList);
            //Console.WriteLine(StatikKonusu.NesneSayisi);


            //-------------------------Soru--------------------------------------



            //ArrayList aList1 = new ArrayList();
            //Ogrenci.ToplamOgrenciSayisi = 2;
            //Ogrenci soru1= new Ogrenci();

            //soru1.KayitEkle(aList1);
            //Console.WriteLine("Toplam Ortalama : "+soru1.OkulOrtalamaHesaplama(aList1));


            //-----------------------------soru------------------------
            ArrayList aList2 = new ArrayList();
            Araba soru2 = new Araba();
            soru2.AracEkle(aList2);  
            Araba.AracListele(aList2);
           



            Console.ReadKey();

        }
    }
}
