using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Ogrenci
    {
       private string OgrenciAdi;
       private int OgrenciNumarasi;
        private int Not1;
       private int Not2;
        public static int ToplamOgrenciSayisi;
        

    public void KayitEkle(ArrayList aList1)
        {
           
         
            for (int i = 0; i < ToplamOgrenciSayisi; i++)
            {

            Console.WriteLine("Öğrenci Adını Giriniz : ");
            OgrenciAdi = Console.ReadLine();
            aList1.Add(OgrenciAdi);
            Console.WriteLine("Öğrenci Numarasını Giriniz : "); 
            OgrenciNumarasi = Convert.ToInt32(Console.ReadLine());
            aList1.Add(OgrenciNumarasi);
            Console.WriteLine("Öğrencinin 1. Notunu Giriniz : ");
            Not1 = Convert.ToInt32(Console.ReadLine());
            aList1.Add(Not1);
            Console.WriteLine("Öğrencinin 2. Notunu Giriniz : ");
            Not2 = Convert.ToInt32(Console.ReadLine());
            aList1.Add(Not2);
              

        }
        }

        public double OkulOrtalamaHesaplama(ArrayList aList1)
        {
           double toplam = 0;
            for (int i = 0; i <aList1.Count; i=i+4)
            {

                toplam += (int)aList1[i+2] + (int)aList1[i+3] ;

            }

               
            return toplam/(ToplamOgrenciSayisi*2);
        }



    }
}
