using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosyaSilme
{
    class Program
    {
        static void Main(string[] args)
        {
            string kaynakKlasor = @"C:\TEST";
            string hedefKlasor = @"C:\HEDEF";
            string[] kaynakDosyalar = Directory.GetFiles(kaynakKlasor);
            string logDosyası = @"C:\LOG\SilmeLoglari.txt";
            FileStream fs = new FileStream(logDosyası, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            foreach (var item in kaynakDosyalar)
            {
                // Console.WriteLine(item); Kontrol amaçlı
                DateTime dSYTarihi = File.GetLastWriteTime(item);
              // Console.WriteLine(dSYTarihi);
                //----------------------------------1. yöntem
                DateTime bugun = DateTime.Now;
                //Console.WriteLine(dSYTarihi);
                //Console.WriteLine(bugun);
                TimeSpan fark = bugun - dSYTarihi;
                //Console.WriteLine(fark.Days); // hangi dosya kaç günlük 


                if (fark.Days == 1)
                {
                    //kopyalama
                    string dosyaAdi = item.Substring(item.LastIndexOf('\\') + 1);
                    string hedefDosya = @"C:\HEDEF\" + dosyaAdi;
                    //Console.WriteLine(hedefDosya);
                    File.Copy(item, hedefDosya, true);
                    Console.WriteLine(item + " Kopyalandı");
                    sw.WriteLine($"{DateTime.Now} \t Kopyalandı \t {item}   ===>  {hedefDosya}");

                }
                else if (fark.Days > 5)
                { // silme
                    File.Delete(item);
                    Console.WriteLine(item + " Silindi");
                    sw.WriteLine($"{DateTime.Now} \t SİLİNDİ \t {item}");

                }
            }
            sw.Flush();
     
            sw.Close();
        
            
            Console.ReadKey();
        }
    }
}
