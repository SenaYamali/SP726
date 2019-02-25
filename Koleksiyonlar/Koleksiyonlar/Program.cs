using System;
using System.Collections.Generic;
using System.Collections; // koleksiyonlarda bu tanımlanır.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection sınıfından türetilir.Arraylist koleksiyonların içinde , diziler gibi farklı formatta alabilr.
            //
            // -------------------------ARRAYLİST-----------------------

            //ArrayList aList1 = new ArrayList();
            //Console.WriteLine(aList1.Capacity);// Eleman Kapasitesini belirtir.

            //aList1.Add("SmartPro");
            //aList1.Add(67);
            //aList1.Add("Elma");
            //aList1.Add(false);
            //aList1.Add('F');
            //aList1.Add(34.5F);
            //aList1.Add(23.1D);
            ////İlk alınan değer 4 olarak gözüküyor.Değer almadan çalışıyor.
            ////2 Katına çıkıyor.3 elaman girince 4 çıkıyor.ama 5 elamn girince 8 oluyor.
            //Console.WriteLine("       ");
            //Console.WriteLine("Kapasitesi :" + aList1.Capacity);
            //Console.WriteLine("Eleman sayısı :" + aList1.Count);// Eleman sayısı 
            //Console.WriteLine("       ");
            //Console.WriteLine("Silmeden Önce :");
            //foreach (object item in aList1)
            //{
            //    Console.WriteLine(item);
            //}

            //aList1.Remove('F');
            //Console.WriteLine("       ");
            //Console.WriteLine("Sildikten Sonra :");
            //foreach (object item in aList1)
            //{
            //    Console.WriteLine(item);
            //}
            //aList1.TrimToSize();//Boş kapasiteyi siliyor
            //Console.WriteLine("       ");
            //aList1.Add(8);
            //Console.WriteLine("Kapasitesi :" + aList1.Capacity);
            //Console.WriteLine("Eleman sayısı :" + aList1.Count);

            //Console.WriteLine(aList1[0]);
            //Console.WriteLine(aList1[1]);
            //Console.WriteLine(aList1[2]);

            //aList1.Insert(2, "Çilek");

            //Console.WriteLine(aList1[0]);
            //Console.WriteLine(aList1[1]);
            //Console.WriteLine(aList1[2]);
            //Console.WriteLine(aList1[3]);

            //Console.WriteLine("    \n\n");

            //aList1.Clear();// Tüm elemanları siler


            //aList1.Add(54);// int tipinde değer ekledik
            //aList1.Add(41);
            //aList1.Add(17);
            //aList1.Sort(); // dizi elemanlarını sıraladık küçükten büyüğe 

            //Console.WriteLine();
            //foreach (var item in aList1)
            //{
            //    Console.WriteLine(item);
            //}
            //aList1.Reverse();
            //Console.WriteLine("-------------------------Reverse Sonrası----------------------------");
            //foreach (var item in aList1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(aList1.Contains(55)); // var mı yok mu
            //Console.WriteLine(aList1.GetType()); // listin tipini alır
            //Console.WriteLine(aList1.IndexOf(17)); // indis verir.
            //aList1.RemoveAt(2); // 2. indisteki elemanı siler
            //foreach (var item in aList1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //object[] oDizi = aList1.ToArray();
            ////object[] oDizi = new object[aList1.Count]; //DİZİ TANIMLADIK ELAMAN SAYISI ARRAYLİSTİMİXİN ELEMAN SAYISI KADAR OLSUN DEDİK
            ////aList1.CopyTo(oDizi);
            //Console.WriteLine(oDizi.Count());
            //foreach (var item in aList1)
            //{
            //    Console.WriteLine(item);
            //}


            //--------------------------------------------------------------------------------------

            //int sayi=1, toplam = 0;
            //ArrayList list = new ArrayList();
            //for (int i = 0; i < sayi;)
            //{
            //    Console.WriteLine("Sayi Giriniz.");
            //    sayi = Convert.ToInt32(Console.ReadLine());



            //    if (sayi == 0)
            //    {


            //        break;

            //    }
            //    else {

            //        list.Add(sayi);
            //        toplam += sayi;
            //    }

            //}

            //     list.Sort();
            //Console.WriteLine("Küçükten Büyüğe sıralama");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"\nAritmetik Ortalama:{toplam / list.Count}\nOrtanca:{list[list.Count/2] }");


            //------------------------------------------------------------------------------------------



            //   ArrayList list1 = new ArrayList();
            //string ad;
            //int yas;
            //int sayac=1;
            //for (int i = 0; i < 2; i++)
            //{
            //    int dyili;

            //    Console.Write("Ad Giriniz: ");
            //     ad = Console.ReadLine();
            //    Console.Write("Doğum Yılı Giriniz: ");
            //    yas = Convert.ToInt32(Console.ReadLine());
            //    dyili = 2019 - yas;

            //    list1.Add(ad);
            //    list1.Add(dyili);

            //}

            //foreach (var item in list1)
            //{
            //    if (sayac % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    else
            //    {
            //        Console.Write(item.ToString().PadRight(10)+" ");
            //    }

            //    sayac++;
            //}
            // ------------------------------ List--------------------------------
            //List<int> listem = new List<int>(); // tip belirtelerek tanımlama mantığı bu 
            //listem.Add(88);
            //listem.Add(87);
            //listem.Add(86);
            //listem.Add(85);

            // Array List sınıfının metotları kullanılır.


            // ---------------------------hashtable------------------------------
            // 2 boyutlu ,keyi bilmezsen çağıramazsın indis key gibi oluyor

            Hashtable ht = new Hashtable();
            ht.Add("aaaa", "Bir");
            ht.Add("bbbb", "İki");
            ht.Add("cccc", "Üç");
            Console.WriteLine(ht["bbbb"]);
            ht.Remove("bbbb");
            foreach (int item in ht.Keys) //ilk sütün,anahtar değerler.
            {
                Console.WriteLine(item+" => "+ht[item]);// anahtar ile çağırılır.
            }

            Console.ReadKey();
        }
    }
}
