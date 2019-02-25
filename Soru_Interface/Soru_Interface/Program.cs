using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_Interface
{ interface IArac
    {
        string AracAdi { get; set; }
    }
    interface ITeker4
    {
        string AracTipi { get; set; }


        void TipYazdir();

    }
    class Audi : IArac, ITeker4
    {
        private string PAracAdi;
        private string PAracTipi;
        public string AracAdi
        {
            get { return PAracAdi; }
            set { PAracAdi = value; }
        }

        public string AracTipi
        {
            get { return PAracTipi; }
            set { PAracTipi = value; }
        }

        public void TipYazdir()
        {
            Console.WriteLine($"Arac Adı : {PAracAdi}\nArac Tipi : {PAracTipi} ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Audi au = new Audi();
            au.AracAdi = "Mazda";
            au.AracTipi = "Ticari";
            au.TipYazdir();
            Console.ReadKey();
        }
    }
}
