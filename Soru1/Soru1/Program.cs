using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Bilgisayar
    {
        public string Marka;
        public string CPU;
        public string RAM;

        public Bilgisayar(string marka,string cpu,string ram)
        {
            Marka = marka;CPU = cpu;RAM = ram;

        }
        public virtual void OzellikGoster()
        {
            Console.WriteLine("Marka"+Marka+"\nİşlemci"+CPU+"\nRAM Bilgisi"+RAM);
        }

    }
    class DizustuBilgisayar : Bilgisayar
{
        bool Bluetooth;
        bool Wifi;
        public DizustuBilgisayar(bool bluetooth,bool wifi,string marka, string cpu, string ram) : base(marka, cpu, ram)
        {
            this.Bluetooth = bluetooth;
            this.Wifi = wifi;
        }

        override public void OzellikGoster()
        {
            Console.WriteLine("Marka : " + Marka + "\nİşlemci :" + CPU + "\nRAM Bilgisi : " + RAM+"\nBluetooth :"+Bluetooth+"\nWifi : "+Wifi);
        }
    }
    class Program
       
    {
        static public void OzelikGöster(Bilgisayar blg)
        {
            blg.OzellikGoster();

        }
        static void Main(string[] args)
        {
            DizustuBilgisayar db = new DizustuBilgisayar(true,false,"Casper","Intel","5gb");
            OzelikGöster(db);
            Console.ReadKey();

        }
       
    }
}
