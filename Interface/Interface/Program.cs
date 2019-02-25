using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ISablon1 // nesne türetilmez sadece bir sınıfa miras alınırsa kullanır.
        // statik olamaz ve abstract gini zorunlu ancak onun gibi kendi
        //değişkenini alamaz.Yapıcı ve yıkıcı metotlar tanımlanamaz.
    {

        string Renk { get; set; }
        string Tat  { get; set; }
    }
    interface ISablon2
    {
        int Agırlık { get; set; }
        int Fiyat   { get; set; }
    }
    class Portakal : ISablon1,ISablon2
    {
       private string renk;
        public string Renk
        {
            get{return renk;} set{renk = value;}
        }
        private string tat;
        public string Tat
        {
            get { return tat;} set{tat = value;}
        }
        private int PAgırlık;
        private int PFiyat;
        public int Agırlık
        {
            get
            { return PAgırlık; } set{PAgırlık=value;}
        }

        public int Fiyat
        {
            get{ return PFiyat;} set{PFiyat = value;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Portakal pr1 = new Portakal();
            pr1.Renk = "Turuncu";
            pr1.Tat = "Bal Şeker";
            pr1.Agırlık = 5000;
            pr1.Fiyat = 300;
            Console.WriteLine( pr1.Tat+" "+pr1.Renk+" "+pr1.Agırlık+" "+pr1.Fiyat);
            Console.ReadKey();


        }
    }
}
