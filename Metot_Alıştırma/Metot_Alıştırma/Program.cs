using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Alıştırma
{
    class Program
    {
        static void a(string mtn)
        {
            string[] dizi = new string[mtn.Length];

            string[] metindizi = mtn.Split(' ');
            Console.WriteLine(metindizi.Length);
           
           
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Metinleri Giriniz");
            string mtn = Console.ReadLine();


            a(mtn);


            Console.ReadKey() ;
        }
    }
}
