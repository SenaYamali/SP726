using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{

    //ENUM: Sabit farklı ifadelerin sayısal tiplerde liste gibi tutulmasına yarar.

    
        enum Aylar :byte{Ocak=1,Şubat,Mart,Nisan,Mayıs,Haziran,Temmuz,Ağustos,Eylül,Ekim,Kasım,Aralık }



    //----------------------------------------------------------------------------------------------------



        // enum Gunler : byte{Pazartesi,Salı,Çarşamba,Perşembe,Cuma,Cumartesi,Pazar }
    //class OOPDevam
    //{
    //    public const string Metin = "Sena";// değişmeyen özellik tanımlamak için kullanılır const
    //    public readonly int Sayi = 55;
    //    public readonly int Sayi2;  // kendisine bir değişken atandıktan sonra değiştirilemez sadece yapıcı metotda değiştirilir.

        
    //    public OOPDevam()
    //    {
    //        Console.WriteLine("Normal Yapıcı Çalıştı");
           

    //    }

    //    static OOPDevam() // Sadece bir kere çalışıyor bir daha çağırınca gelmiyor.Biraz nazlı sınıfla alakalı ilk değer ataması yapmak için 
    //    {

            
    //        Console.WriteLine("Static Yapıcı Çalıştı");
    //    }

    //}
    class Program
    {


        static void Main(string[] args)
        {

            //OOPDevam o1 = new OOPDevam();
            //OOPDevam o2 = new OOPDevam();
            //OOPDevam o3 = new OOPDevam();

            //string bugun = Gunler.Pazartesi.ToString();
            //Console.WriteLine(bugun);
            //string[] sDizi=Enum.GetNames(typeof(Gunler));
            //Console.WriteLine();
            //foreach (var item in sDizi)
            //{
            //    Console.WriteLine(item);
            //}

            //byte bugun1 = (byte)Gunler.Cuma; // index numarasını veriyor
            //Console.WriteLine(bugun1);

            //bool varMi = Enum.IsDefined(typeof(Gunler),"Pazar"); // var mı diye bakıyor
            //Console.WriteLine(varMi);

            //----------------------soru----------------------------------



            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Ay Giriniz :");
            //    string ay = Console.ReadLine();

            //    if (Enum.IsDefined(typeof(Aylar), ay))
            //    {
            //        Console.WriteLine("Var");
            //        break;

            //    }
            //    i++;

            //} while (i < 4);

            //------------------------------------------------------------------





            Console.ReadKey();

        }
    }
}
