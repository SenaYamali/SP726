using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucg1 = new Ucgen();


            ucg1.KenarGir();
             ucg1.KenarYazdir();





            Console.ReadKey();

        }
    }

    //--------------------------------------------------------------------------------
    class Ucgen
    {

        private int Kenar1;
        private int Kenar2;
        private int Kenar3;
        private int Yukseklik;

        public int publicKenar1  //Kontrollü atama
        {
            get { return Kenar1; }
            set// private kenar1 e kontrollü atama
            {
                if((value<0))
                {
                    Kenar1=10;
                }
                else
                {
                    Kenar1 = value;
                }
            }
        }
        public int publicKenar2  //Kontrollü atama
        {
            get { return Kenar2; }
            set// private kenar1 e kontrollü atama
            {
                if ((value < 0))
                {
                    Kenar2 = 10;
                }
                else
                {
                    Kenar2 = value;
                }
            }
        }

        public int publicKenar3  //Kontrollü atama
        {
            get { return Kenar3; }
            set// private kenar1 e kontrollü atama
            {
                if (value < (Kenar1 + Kenar2) && value > (Kenar2 - Kenar1))
                {
                    Kenar3 = value;
                }

                else
                {
                    Console.WriteLine("3. Kenarı Giriniz : ");
                    publicKenar3 = Convert.ToInt32(Console.ReadLine());

                }
            }
         
        }

        public void KenarGir()
        {
            
            Console.WriteLine("1. Kenarı Giriniz : ");
            publicKenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Kenarı Giriniz : ");
           publicKenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Kenarı Giriniz : ");
      publicKenar3 = Convert.ToInt32(Console.ReadLine());



        }

        public int CevreHesaplama()
        {

            Console.WriteLine($"Çevre Hesaplaması: {(Kenar1 + Kenar2 + Kenar3) / 2}");
            return (Kenar1 + Kenar2 + Kenar3) / 2;

        }
        public void KenarYazdir()
        {
            Console.WriteLine($"Kenar1={Kenar1}\nKenar2={Kenar2}\nKenar3={Kenar3}");
            CevreHesaplama();
        }







        //----------------------------------------------------------------------------------------------------------

    }


}


