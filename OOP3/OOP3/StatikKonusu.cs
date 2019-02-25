using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class StatikKonusu
    {
        public string Ad;
        public string Unvan;
        public static int NesneSayisi;  // satatik sadece sınıfda kullanılıyor nesnede dekullanılmıyor

        public static void TumunuListele(ArrayList aList)
        {
            for (int i = 0; i < aList.Count; i=i+2)
            
            {
                Console.Write("Ad :"+aList[i]);
                Console.WriteLine("Unvan :"+aList[i+1]);
            }

        }
    }
}
