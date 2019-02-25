using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Bir sayı giriniz :" );
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir Karakter giriniz :");
            int b = (Console.Read());
            Console.WriteLine($" {a}{b}");
            int toplam;
            toplam = a + b;
            double c = (double)(toplam);
            Console.WriteLine($" {c} :"+c.GetType());
            string e = "" + c;         // a=a.toString();
            Console.WriteLine($" {e} "+e.GetType());
            
            Console.ReadKey();

        }
    }
}
