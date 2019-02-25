using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{  //Kapsulleme (Encapsulation) Gelen veriyi direkt atamak yerine ilk kontrol edilir.Sonra atılır.
    enum Markalar : byte {Honda,Mazda,Toyota,Porshce,Audi}
    class Arac
    {
        private string Marka;
        public string GetMarka()
        {
            return Marka;
        }
        public void SetMarka(string marka)
        {
            if(Enum.IsDefined(typeof(Markalar),marka))
            {
                this.Marka = marka;
            }
            else
            {
                this.Marka = "Markasız";

            }

           
        }



        private int MororHacmi;
        public int PublicMotorHacmi
        {
            get { return PublicMotorHacmi; }
            set {
                if (value>=0&& value <=100)
                {
                    PublicMotorHacmi = value;

                }


            }



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Arac arac1 = new Arac();
            arac1.PublicMotorHacmi = 1500;
            Console.WriteLine(arac1.PublicMotorHacmi);






            arac1.SetMarka("Honda");
            Console.WriteLine(arac1.GetMarka());
            arac1.SetMarka("Hondaaaaa");
            Console.WriteLine(arac1.GetMarka());


            Console.ReadKey();
        }
    }
}
