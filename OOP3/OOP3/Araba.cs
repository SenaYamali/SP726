using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Araba
    {
        public int Fiyat;
        public int MotorHacmi;
        public string plaka;
        public double OTV;

    

        public double OTVhHesapla(int fiyat,int motorhacmi )
        {

            if (MotorHacmi < 1600 && Fiyat < 70000)
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat * 0.30);
                OTV = Fiyat * 0.30;
            }
            else if (MotorHacmi < 1600 && Fiyat < 120000)
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat * 0.35);
                OTV = Fiyat * 0.35;
            }
            else if (MotorHacmi < 1600 && Fiyat > 120000)
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat * 0.60);
                OTV = Fiyat * 0.60;
            }
            else if (MotorHacmi < 2000 && Fiyat < 170000)
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat *1);
                OTV = Fiyat * 1;
            }
            else if (MotorHacmi < 2000 && Fiyat > 170000)
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat * 1.10);
                OTV = Fiyat * 1.10;
            }
            else if (MotorHacmi > 2000 )
            {
                Console.WriteLine("ÖTV Oranı : " + Fiyat * 1.60);
                OTV = Fiyat * 1.60;
            }


            return OTV;
        }


        public void AracEkle(ArrayList aList2)
        {
            Console.WriteLine("Arabanın Fiyatını Giriniz : ");
            Fiyat = Convert.ToInt32(Console.ReadLine());
            aList2.Add(Fiyat);
            Console.WriteLine("Arabanın Motor Hacmini Giriniz : ");
            MotorHacmi = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Arabanın Plakasın Giriniz : ");
            plaka = Console.ReadLine();
            aList2.Add(plaka);
            OTV = OTVhHesapla(Fiyat, MotorHacmi);
            aList2.Add(OTV);
        }

        static public void AracListele(ArrayList aList2)
        {
            for (int i = 0; i < aList2.Count; i = i + 3)

            {
                Console.WriteLine("Fiyat :" + aList2[i]);
                Console.Write("Plaka :" + aList2[i+1]);
               
                Console.WriteLine("ÖTV Tutarı :" + aList2[i + 2]);

            }



        }


    }
}
