using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_soru2
{
    interface ISesGorubtuSistemleri
    {
        string Marka { get; set; }
        int Fiyat { get; set; }
        int Puan { get; set; }
        int PuanToplami { get; set; }
        int PuanciToplamı { get; set; }

        void PuanVer(byte puan);
        void PuanGöster();
    }
    interface ITelevizyon : ISesGorubtuSistemleri
    {
        string Cözünürlükk { get; set; }

        byte EkranBoyutu { get; set; }
        bool UyduAlicisi { get; set; }
        void OzellikYazdir();


    }

    class Toshiba : ITelevizyon
    {
        string cznrlk;
        public string Cözünürlükk
        {
            get { return cznrlk; }
            set { cznrlk = value; }
        }
        byte PEkran;
        public byte EkranBoyutu
        {
            get { return PEkran; }

            set { PEkran = value; }
        }
        int PFiyat;
        public int Fiyat
        {
            get { return PFiyat; }
            set { PFiyat = value; }
        }
        string PMarka;
        public string Marka { get { return PMarka; } set { PMarka = value; } }
        int PPUan;
        public int Puan { get { return PPUan; } set { PPUan = value; } }

        public int PuanciToplamı { get; set; }

        public int PuanToplami { get; set; }

        public bool UyduAlicisi { get; set; }


        public void PuanVer(byte puan)
        {
            PuanToplami += puan;
            PuanciToplamı++;
        }
        public void PuanGöster()
        {
            Console.WriteLine("Ortalama puan : " + PuanToplami / PuanciToplamı);

        }

        public void OzellikYazdir()
        {
            string strUyduAl = UyduAlicisi ? "Var" : "Yok";
       
            Console.WriteLine($"Marka : {Marka}\nÇözünürlük : {Cözünürlükk}\nEkran Boyutu : {EkranBoyutu}\nUydu Alıcısı : {strUyduAl}\nFiyat : {Fiyat}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Toshiba tshb = new Toshiba();
            tshb.Marka = "Toshiba";
            tshb.Fiyat = 520145;
            tshb.Cözünürlükk = "1025X1258";
            tshb.EkranBoyutu = 74;
            tshb.UyduAlicisi = false;
            tshb.OzellikYazdir();
            tshb.PuanVer(5);
            tshb.PuanVer(2);
            tshb.PuanVer(3);
            tshb.PuanGöster();


            
            Console.ReadKey();



        }
    }
}
